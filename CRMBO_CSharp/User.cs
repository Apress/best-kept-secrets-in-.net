using System;
using System.Data;
using GeneralUtility_CSharp;

namespace CRMBO_CSharp
{
	/// <summary>
	/// Provides validation of user login.
	/// </summary>
	public class User: IDisposable
	{
	#region  Public Constants
		// Constants for field names
		private const string TN_USER = "UserTable";
		private const string FN_USER_NAME= "UserName";
		private const string FN_PASSWORD_ENCODED = "Password";
		private const string FN_PASSWORD_SALT = "PasswordSalt";
		private const string FN_STATUS = "Status";

		private const string STATUS_ACTIVE = "A";
	#endregion

		#region Constructors
		public User()
		{
		}
		#endregion

		#region Destructors

		public void Dispose()
		{
		}
		#endregion

		#region Public Methods

		#region ValidateLogin
		/// <summary>
		/// Validates the user-entered username and password.
		/// </summary>
		/// <param name="sUserName">User-entered username</param>
		/// <param name="sPassword">User-entered password</param>
		/// <returns>True if username and password are valid.</returns>
		/// <exception cref="UsernameNotFoundException">Username is not valid</exception>
		/// <exception cref="PasswordInvalidException">Password is not valid</exception>
		public bool ValidateLogin(string sUserName, string sPassword)
		{
			DataSet dsUser;

			if (sUserName.Length == 0 || sPassword.Length == 0)
			{
				throw new ArgumentOutOfRangeException("Username and password are required.");
			}

			// Retrieve the dataset
			dsUser = this.Retrieve(sUserName, sPassword);

			// If the user does not exist, throw an exception
			if (dsUser == null || dsUser.Tables[TN_USER] == null || dsUser.Tables[TN_USER].Rows.Count == 0) 
			{
				//TODO: Add the log audit feature
				throw new UsernameNotFoundException("Invalid username");
			}

			// If the user does exist, verify the password
			// A hash value is generated using a salt and the user-entered password
			DataRow dr =  dsUser.Tables[TN_USER].Rows[0];
			string sPasswordEncoded  = dr[FN_PASSWORD_ENCODED].ToString();
			string sPasswordSalt = dr[FN_PASSWORD_SALT].ToString();
			string sPasswordHash = SecurityUtility.ComputeHash(sPasswordSalt + sPassword);

			// does the computed hash match the database hash?
			if (String.Compare(sPasswordEncoded, sPasswordHash) != 0)
			{
				//TODO: Add the log audit feature
				throw new PasswordInvalidException("Invalid password");
			}

            // Then verify the status
            if (dr[FN_STATUS].ToString() != STATUS_ACTIVE)
			{
				throw new UsernameNotFoundException("User is inactive");
			}

			return true;
		}
		#endregion

		#region Retrieve
		// Retrieves the user record
		private DataSet Retrieve(string sUserName, string sPassword)
		{
			DataSet	dsUser = new DataSet();
			DataTable dtUser = new DataTable();
			DataRow drUser;
			string sPasswordSalt;

			// Since the Northwind database does not have a user table, just generate the dataset

			// Add the columns to the table
			dtUser.Columns.Add(FN_USER_NAME);
			dtUser.Columns.Add(FN_PASSWORD_ENCODED);
			dtUser.Columns.Add(FN_PASSWORD_SALT);
			dtUser.Columns.Add(FN_STATUS);

			// Add the data to the row
			drUser = dtUser.NewRow();
			drUser[FN_USER_NAME] = "DeborahK";
			sPasswordSalt = SecurityUtility.ComputeSalt();
			drUser[FN_PASSWORD_ENCODED] = SecurityUtility.ComputeHash(sPasswordSalt + sPassword);
			drUser[FN_PASSWORD_SALT] = sPasswordSalt;
			drUser[FN_STATUS] = STATUS_ACTIVE;

			//Add the row to the table
			dtUser.Rows.Add(drUser);

			// Add the table to the dataset
			dsUser.Tables.Add(dtUser);

			// Set the table name
			dsUser.Tables[0].TableName = TN_USER;

			return dsUser;
		}

		#endregion

		#endregion

	}

	#region Exception Classes
	/// <summary>
	/// Exception for user name not found
	/// </summary>
	public class UsernameNotFoundException : Exception
	{
		public UsernameNotFoundException()
			: base()
		{
		}
		public UsernameNotFoundException(string message)
			: base(message)
		{
		}
		public UsernameNotFoundException(string message, Exception innerEx)
			: base(message, innerEx)
		{
		}
	}

	/// <summary>
	/// Exception for invalid password
	/// </summary>
	public class PasswordInvalidException : Exception
	{
		public PasswordInvalidException()
			: base()
		{
		}
		public PasswordInvalidException(string message)
			: base(message)
		{
		}
		public PasswordInvalidException(string message, Exception innerEx)
			: base(message, innerEx)
		{
		}
	}
#endregion

}
