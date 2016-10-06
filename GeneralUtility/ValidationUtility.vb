Option Strict On

Imports System.Text.RegularExpressions

''' <summary>
''' Provides utility function to support validation of end-user entries.
''' </summary>
Public Class ValidationUtility

#Region " Public Constants"
    ' Constants for extended properties
    Public Shared EP_VAL_REQUIRED As String = "ValidateRequired"
    Public Shared EP_CONV_PROPER As String = "ConvertToProperCase"
    Public Shared EP_REG_EX_PATTERN As String = "RegExPattern"
#End Region

    ''' <summary>
    ''' Validates a text value based on values defined in a table column.
    ''' </summary>
    ''' <param name="sTextToValidate">Text to be validated</param>
    ''' <param name="dcCol">Column containing the validation parameters</param>
    ''' <returns>Validation error string - empty if no validation errors</returns>
    Public Shared Function ValidateColumn(ByRef sTextToValidate As String, ByVal dcCol As DataColumn) As String
        Dim sErrorText As String = ""
        If CType(dcCol.ExtendedProperties(EP_CONV_PROPER), Boolean) = True Then
            sTextToValidate = StrConv(sTextToValidate, VbStrConv.ProperCase)
        End If

        If CType(dcCol.ExtendedProperties(EP_VAL_REQUIRED), Boolean) = True _
            AndAlso sTextToValidate.Length = 0 Then
            sErrorText = "You must provide a response."
        End If

        If CType(dcCol.ExtendedProperties(EP_REG_EX_PATTERN), String).Length > 0 Then
            Dim sRegExPattern As String = CType(dcCol.ExtendedProperties(EP_REG_EX_PATTERN), String)

            'TODO: This currently supports only numeric postal codes and needs to be updated to support
            '       non-numeric postal codes
            If Not Regex.IsMatch(sTextToValidate, sRegExPattern) Then
                sErrorText = "The postal code must be numeric."
            End If

        End If

        Return sErrorText
    End Function
End Class
