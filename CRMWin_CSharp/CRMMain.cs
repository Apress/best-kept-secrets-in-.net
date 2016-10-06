using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CRMWin_CSharp
{
	/// <summary>
	/// Startup code for the application.
	/// </summary>
	public class CRMMain
	{
		/// <summary>
		/// Main starting point for the C# application.
		/// </summary>
		public static void Main()
		{
			try
			{
				// Implement a global expection handler
				// Creates an instance of the class that will handle the exception.
				GlobalExceptionHandler gEx = new GlobalExceptionHandler();
 
				// Add the event handler to to the event.
				Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(gEx.OnThreadException);

				using (LoginWin frmLogin = new LoginWin())
				{
					frmLogin.ShowDialog();

					// Use the built-in dialog result variable
					// To check the status of the button that was pressed
					if (frmLogin.DialogResult == DialogResult.OK)
					{
						frmLogin.Dispose();

						// Correct way to start up your application
						Application.Run(new CustomerWin());
					}
					
				}
			}

			catch (Exception ex)
			{
					  MessageBox.Show("The application has generated an error: " + ex.Message);
					  Debug.WriteLine(ex.ToString());
			}

		}
	}

	/// <summary>
	/// Handles any unhandled exceptions
	/// </summary>
	internal class GlobalExceptionHandler 
	{
 
		/// <summary>
		/// Handles the OnThreadException event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="t">Thread exception arguments</param>
		public void OnThreadException(object sender, System.Threading.ThreadExceptionEventArgs t) 
		{
			DialogResult result = DialogResult.Cancel;
			try
			{
				result = MessageBox.Show("Unhandled exception in application", "Application Error", 
								MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
			}
			catch
			{
				try
				{
					MessageBox.Show("Fatal Error", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
				finally
				{
					Application.Exit();
				}
			}

			// Exits the program when the user clicks Abort.
			if (result == DialogResult.Abort) 
				Application.Exit();
		}
	}
}
