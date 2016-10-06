using System;
using System.Data;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace GeneralUtility_CSharp
{
	/// <summary>
	/// Provides utility function to support validation of end-user entries.
	/// </summary>
	public class ValidationUtility
	{
		public ValidationUtility()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		#region Public Constants
		// Constants for extended properties
		public const string EP_VAL_REQUIRED = "ValidateRequired";
		public const string EP_CONV_PROPER = "ConvertToProperCase";
		public const string EP_REG_EX_PATTERN = "RegExPattern";
		#endregion

		/// <summary>
		/// Validates a text value based on values defined in a table column.
		/// </summary>
		/// <param name="sTextToValidate">Text to be validated</param>
		/// <param name="dcCol">Column containing the validation parameters</param>
		/// <returns>Validation error string - empty if no validation errors</returns>
		public static string ValidateColumn(ref string sTextToValidate, DataColumn dcCol)
		{
			string sErrorText = "";
			if (Convert.ToBoolean(dcCol.ExtendedProperties[EP_CONV_PROPER])== true)
			{
				// NOTE: This uses the VB Strings class to perform the conversion.
				// This could be replaced with general C# code if you did not wish
				// to import the VB namespace.
				sTextToValidate = Strings.StrConv(sTextToValidate, VbStrConv.ProperCase,0);
			}

			if (Convert.ToBoolean(dcCol.ExtendedProperties[EP_VAL_REQUIRED]) 
				== true && sTextToValidate.Length == 0)
			{
				sErrorText = "You must provide a response.";
			}

			if (Convert.ToString(dcCol.ExtendedProperties[EP_REG_EX_PATTERN]).Length > 0) 
			{
				string sRegExPattern = Convert.ToString(dcCol.ExtendedProperties[EP_REG_EX_PATTERN]);

            //TODO: This currently supports only numeric postal codes and needs to be updated to support
            //       non-numeric postal codes
				if (!Regex.IsMatch(sTextToValidate,sRegExPattern))
				{
					sErrorText = "The postal code must be numeric.";
				}
			}

			return sErrorText;
		}

	}
}
