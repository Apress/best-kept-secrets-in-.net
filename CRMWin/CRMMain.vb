Option Strict On

''' <summary>
''' Startup code for the application.
''' </summary>
Public Class eOrderOnlineMain

    ' To start the application with this Sub Main, it must be shared
    Public Shared Sub Main()
        Try
            Dim frmLogin As New LoginWin
            Dim frmCustomer As New CustomerWin

            ' Implement a global exception handler
            ' Creates an instance of the class that will handle the exception.
            Dim gEx As New GlobalExceptionHandler

            ' Add the event handler to to the event.
            AddHandler Application.ThreadException, _
               New System.Threading.ThreadExceptionEventHandler(AddressOf gEx.OnThreadException)

            frmLogin.ShowDialog()

            ' Use the built-in dialog result variable
            ' To check the status of the button that was pressed
            If frmLogin.DialogResult = DialogResult.OK Then
                frmLogin = Nothing

                ' Correct way to start up your application
                Application.Run(frmCustomer)
            End If

        Catch ex As Exception
            MessageBox.Show("The application has generated an error: " & ex.Message)
            Debug.WriteLine(ex.ToString)

        End Try

    End Sub

    ''' <summary>
    ''' Handles any unhandled exceptions
    ''' </summary>
    Private Class GlobalExceptionHandler

        ''' <summary>
        ''' Handles the OnThreadException event
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="t">Thread exception arguments</param>
        Public Sub OnThreadException(ByVal sender As Object, _
        ByVal t As System.Threading.ThreadExceptionEventArgs)
            Dim result As DialogResult = DialogResult.Cancel
            Try
                result = MessageBox.Show("Unhandled exception in application", _
                            "Application Error", _
                            MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop)
            Catch
                Try
                    MessageBox.Show("Fatal Error", "Fatal Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Finally
                    Application.Exit()
                End Try
            End Try

            ' Exits the program when the user clicks Abort.
            If result = DialogResult.Abort Then
                Application.Exit()
            End If
        End Sub
    End Class
End Class


