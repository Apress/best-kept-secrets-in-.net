Option Strict On

Imports GeneralUtility

#Region " Comment Header"
' Name:         	User  
'
' Purpose:      	The purpose of this class is to provide
'               	the following functions:
'              	 	- Validate login information
'
' Developer:    	Deborah Kurata
'		            InStep Technologies, Inc.
'               	www.insteptech.com
'
' Copyright:    	2003 InStep Technologies
'
' Date:         	6/08/04
'
' Modifications:
'   Date        	Developer   	Description
'   6/08/04     	DJK        		Created this class
'
#End Region

Public Class User
    Implements IDisposable

#Region " Public Constants"
    ' Constants for field names
    Private Const TN_USER As String = "UserTable"
    Private Const FN_USER_NAME As String = "UserName"
    Private Const FN_PASSWORD_ENCODED As String = "Password"
    Private Const FN_PASSWORD_SALT As String = "PasswordSalt"
    Private Const FN_STATUS As String = "Status"

    Private Const STATUS_ACTIVE As String = "A"
#End Region

#Region " Constructors"
    ' Standard constructor
    Public Sub New()
    End Sub
#End Region

#Region " Destructors"
    Public Sub Dispose() Implements System.IDisposable.Dispose
    End Sub
#End Region

#Region " Public Methods"

#Region " ValidateLogin"
    ''' <summary>
    ''' Validates the user-entered username and password.
    ''' </summary>
    ''' <param name="sUserName">User-entered username</param>
    ''' <param name="sPassword">User-entered password</param>
    ''' <returns>True if username and password are valid.</returns>
    ''' <exception cref="UsernameNotFoundException">Username is not valid</exception>
    ''' <exception cref="PasswordInvalidException">Password is not valid</exception>
    Public Function ValidateLogin(ByVal sUserName As String, _
        ByVal sPassword As String) As Boolean
        Dim dsUser As New DataSet

        If sUserName.Length = 0 OrElse sPassword.Length = 0 Then
            Throw New ArgumentOutOfRangeException("Username and password are required.")
        End If

        ' Retrieve the dataset
        dsUser = Me.Retrieve(sUserName, sPassword)

        ' If the user does not exist, throw an exception
        If dsUser Is Nothing _
            OrElse dsUser.Tables(TN_USER) Is Nothing _
            OrElse dsUser.Tables(TN_USER).Rows.Count = 0 Then
            'TODO: Add the log audit feature
            Throw New UsernameNotFoundException("Invalid username")
        End If

        With dsUser.Tables(TN_USER).Rows(0)
            ' If the user does exist, verify the password
            ' A hash value is generated using a salt and the user-entered password
            Dim sPasswordEncoded As String = CType(.Item(FN_PASSWORD_ENCODED), String)
            Dim sPasswordSalt As String = CType(.Item(FN_PASSWORD_SALT), String)
            Dim sPasswordHash As String = SecurityUtility.ComputeHash(sPasswordSalt & sPassword)

            ' does the computed hash match the database hash?
            If String.Compare(sPasswordEncoded, sPasswordHash) <> 0 Then
                'TODO: Add the log audit feature
                Throw New PasswordInvalidException("Invalid password")
            End If

            ' Then verify the status
            If CType(.Item(FN_STATUS), String) <> STATUS_ACTIVE Then
                Throw New UsernameNotFoundException("User is inactive")
            End If
        End With

        Return True
    End Function
#End Region

#Region " Retrieve"
    ' Retrieves the user record
    Private Function Retrieve(ByVal sUserName As String, _
            ByVal sPassword As String) As DataSet
        Dim dsUser As New DataSet
        Dim dtUser As New DataTable
        Dim drUser As DataRow
        Dim sPasswordSalt As String

        ' Since the Northwind database does not have a user table, just generate the dataset

        ' Add the columns to the table
        dtUser.Columns.Add(Me.FN_USER_NAME)
        dtUser.Columns.Add(Me.FN_PASSWORD_ENCODED)
        dtUser.Columns.Add(Me.FN_PASSWORD_SALT)
        dtUser.Columns.Add(Me.FN_STATUS)

        ' Add the data to the row
        drUser = dtUser.NewRow
        drUser(Me.FN_USER_NAME) = "DeborahK"
        sPasswordSalt = SecurityUtility.ComputeSalt()
        drUser(Me.FN_PASSWORD_ENCODED) = SecurityUtility.ComputeHash(sPasswordSalt & sPassword)
        drUser(Me.FN_PASSWORD_SALT) = sPasswordSalt
        drUser(Me.FN_STATUS) = Me.STATUS_ACTIVE

        ' Add the row to the table
        dtUser.Rows.Add(drUser)

        ' Add the table to the dataset
        dsUser.Tables.Add(dtUser)

        ' Set the table name
        dsUser.Tables(0).TableName = TN_USER

        Return dsUser

    End Function
#End Region

 #End Region

End Class

#Region " Exception Classes"
''' <summary>
''' Exception for user name not found
''' </summary>
Public Class UsernameNotFoundException : Inherits Exception
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub
    Public Sub New(ByVal message As String, ByVal innerEx As Exception)
        MyBase.New(message, innerEx)
    End Sub
End Class

''' <summary>
''' Exception for invalid password
''' </summary>
Public Class PasswordInvalidException : Inherits Exception
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub
    Public Sub New(ByVal message As String, ByVal innerEx As Exception)
        MyBase.New(message, innerEx)
    End Sub
End Class
#End Region
