using System;
namespace VS_21_February.Task8.exception
{
	public class AuthorizationForm
	{
		/// <summary>
		/// Return exception if login, password or confirm password is incorrect in Authorization Form
		/// </summary>
		/// <param name="login - should be more 3 and less 20 characters and no spaces"></param>
		/// <param name="password - should be more 3 and less 20 characters, no spaces and at least one number"></param>
		/// <param name="confirmPassword - should equal password"></param>
		/// <returns></returns>
		public static string CheckException(string login, string password, string confirmPassword)
		{
			try
			{
				int indexSpace_login = login.IndexOf(" ");
				int indexSpace_password = password.IndexOf(" ");
				int hashCode_password = password.GetHashCode();
				int hashCode_confirmPassword = confirmPassword.GetHashCode();

				if (login.Length < 3 || login.Length >= 20 || indexSpace_login > 0)
				{
					throw new WrongLoginException("Incorrect Login! Login must be: \n1)more than 3 characters and less than 20 characters, 2)must not contain spaces.");
				}
				else if (password.Length < 4 || password.Length >= 20 || indexSpace_password > 0 || !password.Any(char.IsDigit))
				{
					throw new WrongPasswordException("Incorrect Password! Password must be \n1)more than 4 characters and less than 20 characters,\n2) must not contain spaces, \n3)must contain at least one number.");
				}
				else if (hashCode_password != hashCode_confirmPassword)
				{
					throw new WrongPasswordException("Error! \nPassword and Confirmation password do not match.");
				}
			}
			catch (WrongLoginException ex)
			{
				Console.WriteLine(ex.Message);
				return "false";
			}
			catch (WrongPasswordException ex)
			{
				Console.WriteLine(ex.Message);
				return "false";
			}

			return "true";
		}
	}
}

