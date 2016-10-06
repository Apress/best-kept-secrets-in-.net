Option Explicit On 

''' <summary>
''' Provides general utilities used to manage exceptions.
''' Specifically, manages the logging of exceptions.
''' </summary>
Public Class ExceptionUtility

    ''' <summary>
    ''' Adds an entry to the event log.
    ''' </summary>
    ''' <param name="sText">Text to add to the event log entry</param>
    ''' <param name="eEntryType">Type of event log entry</param>
    Private Shared Sub AddEventLogEntry(ByVal sText As String, _
                ByVal eEntryType As EventLogEntryType)

        ' Get the current executing Assembly 
        Dim asm As System.Reflection.Assembly
        asm = System.Reflection.Assembly.GetExecutingAssembly

        ' Get the Title Attribute 
        Dim AppName As String
        AppName = DirectCast(asm.GetCustomAttributes(GetType(System.Reflection.AssemblyTitleAttribute), False)(0), _
                        System.Reflection.AssemblyTitleAttribute).Title

        ' Ensure application is registered in event log
        If Not EventLog.SourceExists(AppName) Then
            EventLog.CreateEventSource(AppName, "Application")
        End If

        '   Add entry
        EventLog.WriteEntry(AppName, sText, eEntryType)

    End Sub
End Class
