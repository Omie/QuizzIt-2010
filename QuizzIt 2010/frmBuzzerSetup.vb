Imports UsbLibrary
Public Class frmBuzzerSetup
    Dim WithEvents port As New UsbHidPort
    Dim WithEvents device As UsbLibrary.SpecifiedDevice
    Dim polling As Boolean = False

    Private Sub frmBuzzerSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadSettings()
        Try
            If device IsNot Nothing Then
                device.Dispose()
            End If
            device = New SpecifiedDevice
            port.VendorId = Int32.Parse(My.Settings.venId, Globalization.NumberStyles.AllowHexSpecifier)
            port.ProductId = Int32.Parse(My.Settings.hdId, Globalization.NumberStyles.AllowHexSpecifier)
            Control.CheckForIllegalCrossThreadCalls = False
            device = SpecifiedDevice.FindSpecifiedDevice(port.VendorId, port.ProductId)
        Catch ex As Exception
            lblStatus.Text &= " Already Registered to "
        End Try
        If device IsNot Nothing Then
            lblStatus.Text &= " Device Found"
        Else
            lblStatus.Text &= " No Device Found"
        End If
    End Sub

    Private Sub loadSettings()
        With My.Settings
            txtHardwareId.Text = .hdId
            txtVendorId.Text = .venId
            txtDataIndex.Text = .dataIndex.ToString
            txtTeamA.Text = .TeamA
            txtTeamB.Text = .TeamB
            txtTeamC.Text = .TeamC
            txtTeamD.Text = .TeamD
        End With
    End Sub
    'Start Polling
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        polling = True
        lblPollingStatus.Text = "Polling is On"
    End Sub

    'Stop Polling
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        polling = False
        lblPollingStatus.Text = "Polling is Off"
    End Sub

    'Find Device
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            port.VendorId = Int32.Parse(txtVendorId.Text, Globalization.NumberStyles.AllowHexSpecifier)
            port.ProductId = Int32.Parse(txtHardwareId.Text, Globalization.NumberStyles.AllowHexSpecifier)
            device = SpecifiedDevice.FindSpecifiedDevice(port.VendorId, port.ProductId)
            If device IsNot Nothing Then
                lblStatus.Text = "Device Found"
            Else
                lblStatus.Text = "No Device Found"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub device_DataRecieved(ByVal sender As Object, ByVal args As UsbLibrary.DataRecievedEventArgs) Handles device.DataRecieved
        If polling Then
            Try
                txtReceivedValue.Text = args.data(CShort(txtDataIndex.Text))
            Catch ex As Exception
                txtReceivedValue.Text = "Max Index: " & (args.data.Length - 1).ToString
                polling = False
                lblPollingStatus.Text = "Polling Off"
            End Try
        End If
    End Sub
    Private Sub device_Removed(ByVal sender As Object, ByVal e As EventArgs) Handles device.OnDeviceRemoved
        device = Nothing
        lblStatus.Text = "Device Removed"
    End Sub
    'Save settings
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        With My.Settings
            .TeamA = CLng(txtTeamA.Text)
            .TeamB = CLng(txtTeamB.Text)
            .TeamC = CLng(txtTeamC.Text)
            .TeamD = CLng(txtTeamD.Text)
            .hdId = txtHardwareId.Text
            .venId = txtVendorId.Text
            .dataIndex = CShort(txtDataIndex.Text)
            .Save()
        End With
    End Sub
End Class