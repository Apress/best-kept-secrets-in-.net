Option Explicit On 

Imports CRMBO
Imports NUnit.Framework

<TestFixture()> _
Public Class UserTester

#Region " Private Constants"

#End Region

#Region " Private Member Variables"

#End Region

#Region " Constructors"
    Public Sub New()
        MyBase.New()
    End Sub
#End Region

#Region " Test Set Up"
    <SetUp()> _
    Public Sub InitTest()
        ' Set up the application

    End Sub
#End Region

#Region " Test Tear Down"
    <TearDown()> _
    Public Sub TermTest()
        ' Perform any cleanup
    End Sub
#End Region

#Region " ValidateLoginTester"
    <Test()> _
    Public Sub ValidateLoginTester()
        Dim oUser As New User

        Dim bIsValid As Boolean = False

        ' This one should be correct
        bIsValid = oUser.ValidateLogin("DeborahK", "password")
        Assertion.AssertEquals(True, bIsValid)

        ' This one should generate a username not found exception
        Try
            bIsValid = oUser.ValidateLogin("Deborah", "password")
            Assertion.Assert("This should have generated an exception and it did not", False)

        Catch ex As Exception ' UsernameNotFoundException

        End Try

        ' This one should generate a password not valid exception
        Try
            bIsValid = oUser.ValidateLogin("DeborahK", "aaa")
            Assertion.Assert("This should have generated an exception and it did not", False)

        Catch ex As Exception 'PasswordInvalidException

        End Try

        oUser.Dispose()
    End Sub

#End Region

End Class
