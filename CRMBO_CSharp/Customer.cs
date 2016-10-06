using System;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using GeneralUtility_CSharp;
using Microsoft.ApplicationBlocks.Data;

namespace CRMBO_CSharp
{
	/// <summary>
	/// Provides for review and update of customer information.
	/// </summary>
	public class Customer : IDisposable
	{
		#region Public Constants
		// Constants for the table names
		public const String TN_CUSTOMER = "Customer";

		// Constants for field names
		public const String FN_CUSTOMER_ID = "CustomerID";
		public const String FN_CUSTOMER_NAME  = "CompanyName";
		public const String FN_COUNTRY = "Country";
		public const String FN_POSTALCODE  = "PostalCode";

		#endregion

		#region  Constructors
		public Customer()
		{
			Console.WriteLine("I'm a new Customer");
		}
		#endregion

		#region Destructors
		public void Dispose()
		{
			Console.WriteLine("I'm a dead Customer");
		}
		#endregion

		#region Public Methods

		#region Retrieve
		/// <summary>
		/// Retrieves all customer data.
		/// </summary>
		/// <returns>DataSet containing all customer data in one table.</returns>
		public DataSet Retrieve()
		{
			string sConn=null;
			DataSet dsCustomer=null;

			try
			{
				sConn = ConfigurationSettings.AppSettings["CONNECTION"].ToString();

				//TODO: Convert this SQL into a stored procedure
				dsCustomer = SqlHelper.ExecuteDataset(sConn,
					CommandType.Text,
					"Select CustomerID, CompanyName from Customers Order by CompanyName");

				// Set the table name
				dsCustomer.Tables[0].TableName = TN_CUSTOMER;

				return dsCustomer;
			}

			catch (Exception ex)
			{
				if (sConn == null)
				{
					throw new ApplicationException("The Configuration File is missing or invalid");
				}
				
				if (dsCustomer == null)
				{
					throw new ApplicationException("The data could not be retrieved");
				}

				throw ex;
			}

		}

		/// <summary>
		/// Retrieves all data for one customer.
		/// </summary>
		/// <param name="sCustomerID">Primary key ID of the desired customer record.</param>
		/// <returns>DataSet containing all data for the defined customer in one table.</returns>
		public DataSet Retrieve(String sCustomerID)
		{
			String sConn = ConfigurationSettings.AppSettings["CONNECTION"].ToString();

			//TODO: Convert this SQL into a stored procedure
			DataSet dsCustomer = SqlHelper.ExecuteDataset(sConn,
						  CommandType.Text,
						  "Select CustomerID, CompanyName, Country, PostalCode FROM Customers WHERE CustomerID = '" 
						  + sCustomerID + "'");

			// Set the table name
			dsCustomer.Tables[0].TableName = TN_CUSTOMER;

			// Set the extended properties
			DataTable tb = dsCustomer.Tables[TN_CUSTOMER];
            tb.Columns[FN_CUSTOMER_NAME].ExtendedProperties.Add(ValidationUtility.EP_VAL_REQUIRED, true);
            tb.Columns[FN_CUSTOMER_NAME].ExtendedProperties.Add(ValidationUtility.EP_CONV_PROPER, true);
            tb.Columns[FN_POSTALCODE].ExtendedProperties.Add(ValidationUtility.EP_VAL_REQUIRED, true);

            //TODO: This regular expression is only for numeric postal codes - need to globalize it
            tb.Columns[FN_POSTALCODE].ExtendedProperties.Add(ValidationUtility.EP_REG_EX_PATTERN, @"^\d+$");

			Debug.WriteLine(dsCustomer.GetXml());
			Debug.WriteLine(dsCustomer.GetXmlSchema());

			return dsCustomer;
		}

		[ObsoleteAttribute("This method is obsolete. Please use Retrieve(sID) instead", false)]
		public DataSet Retrieve(int iID)
		{
			// The ID must be greater than 0 to be valid
			if (iID <= 0)
			{	
				throw new ArgumentOutOfRangeException("iID must be > 0. iID is" + iID);
			}

			String sConn = ConfigurationSettings.AppSettings["CONNECTION"].ToString();

			DataSet dsCustomer = SqlHelper.ExecuteDataset(sConn,
							CommandType.StoredProcedure,
							"CustomerRetrieveByID_sp",
							new System.Data.SqlClient.SqlParameter("@ID", iID));

			// Set the table name
			dsCustomer.Tables[0].TableName = TN_CUSTOMER;

			return dsCustomer;
		}

#endregion

#endregion
	}
}
