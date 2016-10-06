using System;
using System.Security.Cryptography;

namespace GeneralUtility_CSharp
{

	/// <summary>
	/// Utility functions to manage application security.
	/// </summary>
	public class SecurityUtility
	{
		public SecurityUtility()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		/// <summary>
		/// Generates a unique hash of an input string.
		/// </summary>
		/// <param name="textToHash">Text to be hashed</param>
		/// <returns></returns>
		public static String ComputeHash(string textToHash)
		{
			SHA1CryptoServiceProvider SHA1 = new SHA1CryptoServiceProvider();
			byte[] byteValue = System.Text.Encoding.UTF8.GetBytes(textToHash);
			byte[] byteHash = SHA1.ComputeHash(byteValue);
			SHA1.Clear();

			return Convert.ToBase64String(byteHash);
		}

		/// <summary>
		/// Compute a salt value using a GUID
		/// </summary>
		/// <returns>Salt value</returns>
		public static String ComputeSalt()
		{
			System.Guid GuidValue = System.Guid.NewGuid();
			return GuidValue.ToString();

		}

	}
}
