using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace NSGVisitorManagement.Classes
{
	class Validation
	{
		#region Constants
		//Vivek Verma, 24-FEB-2012, Validate EmailID format.
		private const string EMAIL_PATTERN = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@" + 
				@"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\." + 
				@"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|" + 
				@"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

		#endregion
		

		public static void ValidateTextIsNumeric(TextBox tbox, KeyPressEventArgs e, bool allowDecimal = false)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' || !allowDecimal))
			{
				e.Handled = true;
			}
			// only allow one decimal point
			if (allowDecimal)
			{
				if (e.KeyChar == '.' && (tbox).Text.IndexOf('.') > -1)
				{
					e.Handled = true;
				}
			}
		}

		public static void ValidateQuoteCharacter(TextBox tbox, KeyPressEventArgs e)
		{
			Byte[] keycode = Encoding.ASCII.GetBytes(e.KeyChar.ToString());
			if (keycode[0] == 39)
			{
				e.Handled = true;
			}
		}

		public static bool ValidateTextIsNumeric(TextBox tbox)
		{
			if (tbox.Text.Trim() == string.Empty)
			{
				tbox.Text = string.Empty;
				return true;
			}
			long outValue = 0;

			if (long.TryParse(tbox.Text, out outValue))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		//Varun,19-12-2011,Validate Characters is Alphabet Only
		public static void ValidateCharacterIsAlphabet(TextBox tbox, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		//Varun, 19-12-2011,Validate that string values contain only Alphabet
		public static bool ValidateStringForAlphabets(string valueString)
		{
			bool isValueOk = true;

			for (int i = 0; i < valueString.Length; i++)
			{
				if (!char.IsLetter(valueString[i]) && !char.IsWhiteSpace(valueString[i]))
				{
					isValueOk = false;
					break;
				}
			}

			return isValueOk;
		}
		//Varun, 19-12-2011,Validate alpha numeric string values contain only Alphabet
		public static bool ValidateAlphaNumericString(string valueString, char[] specialChars = null)
		{
			bool isValueValid = true;
			bool isChar;
			bool isNum;
			bool isValidSpec;

			for (int i = 0; i < valueString.Length; i++)
			{
				isChar = false;
				isNum = false;
				isValidSpec = false;

				if (char.IsLetter(valueString[i]))
				{
					isChar = true;
				}

				if (char.IsDigit(valueString[i]))
				{
					isNum = true;
				}

				if (specialChars != null)
				{
					for (int j = 0; j < specialChars.Length; j++)
					{
						if (valueString[i] == specialChars[j])
						{
							isValidSpec = true;
							break;
						}
					}
				}
				else
				{
					isValidSpec = true;
				}

				if (!isChar && !isNum && (!isValidSpec || specialChars == null))
				{
					isValueValid = false;
					break;
				}
			}

			return isValueValid;
		}
		//Varun, 05-01-2012,Validate Characters is space not allow
		public static bool ValidateCharacterIsSpace(TextBox tbox, KeyPressEventArgs e, bool allowspace = false)
		{
			bool isvalue = true;
			if (char.IsWhiteSpace(e.KeyChar))
			{
				e.Handled = true;
				isvalue = false;
			}
			return isvalue;
		}

		//Vivek Verma, 19-JAN-2012, Validate FROM Date and TO Date Selection. 
		public static string ValidateDateSelection(DateTimePicker FromDate, DateTimePicker ToDate)
		{
			string Message = string.Empty;
			if (FromDate.Value.Date > ToDate.Value.Date)
			{
				Message = "'From Date' should be less than or Equal to 'To Date'.";
				return Message;
			}
			else
				return Message;
		}

		//Vivek Verma, 24-FEB-2012, Validate EmailID format.        
		public static bool IsValidEmail(string emailID, bool isRequired)
		{
			if (!string.IsNullOrEmpty(emailID))
			{
				return Regex.IsMatch(emailID, EMAIL_PATTERN);
			}
			else if (isRequired)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
