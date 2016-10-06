Option Strict On

Imports GeneralUtility
Imports Microsoft.ApplicationBlocks.Data

#Region " Comment Header"
' Name:         	Customer  
'
' Purpose:      	The purpose of this class is to provide
'               	the following functions:
'              	 	- Review customer information
'                   - Update customer information
'
' Developer:    	Deborah Kurata
'		            InStep Technologies, Inc.
'               	www.insteptech.com
'
' Copyright:    	2004 InStep Technologies
'
' Date:         	4/7/04
'
' Modifications:
'   Date        	Developer   	Description
'   4/7/04     	DJK        		Created this class
#End Region

Public Class Customer
    Implements IDisposable

#Region " Public Constants"
    ' Constants for the table names
    Public Const TN_CUSTOMER As String = "Customer"

    ' Constants for field names
    Public Const FN_CUSTOMER_ID As String = "CustomerID"
    Public Const FN_CUSTOMER_NAME As String = "CompanyName"
    Public Const FN_COUNTRY As String = "Country"
    Public Const FN_POSTALCODE As String = "PostalCode"
#End Region

#Region " Constructors"
    Public Sub New()
        Console.WriteLine("I'm a new Customer")
    End Sub
#End Region

#Region " Destructors"
    Public Sub Dispose() Implements System.IDisposable.Dispose
        Console.WriteLine("I'm a dead Customer")
    End Sub
#End Region

#Region " Public Methods"

#Region " Retrieve"
    ''' <summary>
    ''' Retrieves all customer data.
    ''' </summary>
    ''' <returns>DataSet containing all customer data in one table.</returns>
    Public Function Retrieve() As DataSet
        Dim sConn As String
        Dim dsCustomer As DataSet

        Try
            sConn = Configuration.ConfigurationSettings.AppSettings("CONNECTION").ToString()

            'TODO: Convert this SQL into a stored procedure
            dsCustomer = SqlHelper.ExecuteDataset(sConn, _
                        CommandType.Text, _
                        "Select CustomerID, CompanyName from Customers Order by CompanyName")

            ' Set the table name
            dsCustomer.Tables(0).TableName = Me.TN_CUSTOMER

            Return dsCustomer

        Catch ex As Exception
            If sConn Is Nothing Then
                Throw New ApplicationException("The Configuration File is missing or invalid")
            End If

            If dsCustomer Is Nothing Then
                Throw New ApplicationException("The data could not be retrieved")
            End If

            Throw ex
        End Try

    End Function

    ''' <summary>
    ''' Retrieves all data for one customer.
    ''' </summary>
    ''' <param name="sCustomerID">Primary key ID of the desired customer record.</param>
    ''' <returns>DataSet containing all data for the defined customer in one table.</returns>
    Public Function Retrieve(ByVal sCustomerID As String) As DataSet
        Dim sConn As String
        Dim dsCustomer As DataSet

        sConn = Configuration.ConfigurationSettings.AppSettings("CONNECTION").ToString()

        'TODO: Convert this SQL into a stored procedure
        dsCustomer = SqlHelper.ExecuteDataset(sConn, _
                    CommandType.Text, _
                    "Select CustomerID, CompanyName, Country, PostalCode FROM Customers WHERE CustomerID = '" & sCustomerID & "'")

        ' Set the table name
        dsCustomer.Tables(0).TableName = Me.TN_CUSTOMER

        ' Set the extended properties
        With dsCustomer.Tables(TN_CUSTOMER)
            .Columns(FN_CUSTOMER_NAME).ExtendedProperties.Add(ValidationUtility.EP_VAL_REQUIRED, True)
            .Columns(FN_CUSTOMER_NAME).ExtendedProperties.Add(ValidationUtility.EP_CONV_PROPER, True)
            .Columns(FN_POSTALCODE).ExtendedProperties.Add(ValidationUtility.EP_VAL_REQUIRED, True)

            'TODO: This regular expression is only for numeric postal codes - need to globalize it
            .Columns(FN_POSTALCODE).ExtendedProperties.Add(ValidationUtility.EP_REG_EX_PATTERN, "^\d+$")
        End With

        Debug.WriteLine(dsCustomer.GetXml())
        Debug.WriteLine(dsCustomer.GetXmlSchema())

        Return dsCustomer
    End Function

    <ObsoleteAttribute("This method is obsolete. Please use Retrieve(sID) instead", False)> _
    Public Function Retrieve(ByVal iID As Int32) As DataSet
        Dim sConn As String
        Dim dsCustomer As DataSet

        ' The ID must be greater than 0 to be valid
        If iID <= 0 Then
            Throw New ArgumentOutOfRangeException("iID must be > 0. iID is" & iID)
        End If

        sConn = Configuration.ConfigurationSettings.AppSettings("CONNECTION").ToString()

        dsCustomer = SqlHelper.ExecuteDataset(sConn, _
                    CommandType.StoredProcedure, _
                    "CustomerRetrieveByID_sp", _
                    New SqlClient.SqlParameter("@ID", iID))

        ' Set the table name
        dsCustomer.Tables(0).TableName = Me.TN_CUSTOMER

        Return dsCustomer
    End Function

#End Region

#End Region

End Class
