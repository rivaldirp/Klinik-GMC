Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Module Module1
    Public con As New MySqlConnection
    Public sql As String
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public daData As MySqlDataAdapter
    Public dsData As DataSet

    Public Sub connection()
        Try
            con = New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=db_klinikgmc")
            con.Open()
        Catch ex As Exception
            MsgBox("Please Configure Database", MsgBoxStyle.Information, "Database")
        End Try
    End Sub

End Module

Module Module2
    Public allSet As Boolean
    Function IsEmpty(ByVal portion As Control) As Boolean
        Dim ctrl As New Control
        'Focus TextBox
        Dim tex As New TextBox
        For Each ctrl In portion.Controls.OfType(Of TextBox)()
            tex = TryCast(ctrl, TextBox)
            If tex.Text = "" Then
                tex.Focus()
                tex.BackColor = Color.Yellow
                allSet = True
            Else
                tex.BackColor = Color.White
                allSet = False
            End If
        Next
        For Each ctrl In portion.Controls.OfType(Of ComboBox)()
            'Focus Combobox
            Dim combo As New ComboBox
            combo = TryCast(ctrl, ComboBox)
            If combo.Text = "-Select-" Or combo.Text = "" Then
                combo.Focus()
                combo.BackColor = Color.Yellow
                allSet = True
                combo.Text = "-Select-"
            Else
                combo.BackColor = Color.White
                allSet = False
            End If

        Next
        Return allSet
    End Function
End Module

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    ' **NEW** ApplyApplicationDefaults: Raised when the application queries default values to be set for the application.

    ' Example:
    ' Private Sub MyApplication_ApplyApplicationDefaults(sender As Object, e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults
    '
    '   ' Setting the application-wide default Font:
    '   e.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)
    '
    '   ' Setting the HighDpiMode for the Application:
    '   e.HighDpiMode = HighDpiMode.PerMonitorV2
    '
    '   ' If a splash dialog is used, this sets the minimum display time:
    '   e.MinimumSplashScreenDisplayTime = 4000
    ' End Sub

    Partial Friend Class MyApplication

    End Class
End Namespace
