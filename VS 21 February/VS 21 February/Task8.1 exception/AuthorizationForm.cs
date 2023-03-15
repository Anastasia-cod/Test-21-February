﻿using System;
namespace VS_21_February.Task8.exception
{
	public class AuthorizationForm
	{
		//public static string login;
		//public static string password;
		//public static string confirmPassword;

		////public AuthorizationForm()
		////{
		////}

		/// <summary>
		/// Authorization Form, check exception if login, password or confirm password is incorrect
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

				if(login.Length < 3 || login.Length >= 20 || indexSpace_login > 0)
				{
					throw new WrongLoginException("Incorrect Login!\nLogin must be more than 3 characters and less than 20 characters and must not contain spaces");
				}
			}
			catch(WrongLoginException ex)
			{
				Console.WriteLine(ex.Message);
				return "false";
			}

			try
			{
				int indexSpace_password = password.IndexOf(" ");

				if (password.Length < 4 || password.Length >= 20 || indexSpace_password > 0)
				{
					throw new WrongPasswordException("Incorrect Password!\nPassword must be more than 4 characters and less than 20 characters, must not contain spaces and contain at least one number");
				}
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

