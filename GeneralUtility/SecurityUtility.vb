Option Strict On

Imports System.Security.Cryptography

''' <summary>
''' Utility functions to manage application security.
''' </summary>
	public class SecurityUtility

    ''' <summary>
    ''' Generates a unique hash of an input string.
    ''' </summary>
    ''' <param name="textToHash">Text to be hashed</param>
    ''' <returns></returns>
    Public Shared Function ComputeHash(ByVal textToHash As String) As String
        Dim byteValue As Byte()
        Dim byteHash As Byte()

        Dim SHA1 As New SHA1CryptoServiceProvider
        byteValue = System.Text.Encoding.UTF8.GetBytes(textToHash)
        byteHash = SHA1.ComputeHash(byteValue)
        SHA1.Clear()

        Return Convert.ToBase64String(byteHash)
    End Function

    ''' <summary>
    ''' Compute a salt value using a GUID
    ''' </summary>
    ''' <returns>Salt value</returns>
    Public Shared Function ComputeSalt() As String
        Dim GuidValue As System.Guid = System.Guid.NewGuid()
        Return GuidValue.ToString()
    End Function
End Class
