using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CRMBO_CSharp;

namespace CRMWin_CSharp
{
	/// <summary>
	/// Form for user login.
	/// </summary>
	public class LoginWin : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Button cmdCancel;
		internal System.Windows.Forms.Button cmdLogin;
		internal System.Windows.Forms.TextBox txtPassword;
		internal System.Windows.Forms.TextBox txtUserName;
		internal System.Windows.Forms.Label lblPassword;
		internal System.Windows.Forms.Label lblUserName;
		internal System.Windows.Forms.ErrorProvider epValidation;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Constructor to initialize the Login form
		/// </summary>
		public LoginWin()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdLogin = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUserName = new System.Windows.Forms.Label();
			this.epValidation = new System.Windows.Forms.ErrorProvider();
			this.SuspendLayout();
			// 
			// cmdCancel
			// 
			this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdCancel.Location = new System.Drawing.Point(220, 80);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(88, 32);
			this.cmdCancel.TabIndex = 21;
			this.cmdCancel.Text = "E&xit";
			// 
			// cmdLogin
			// 
			this.cmdLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdLogin.Location = new System.Drawing.Point(116, 80);
			this.cmdLogin.Name = "cmdLogin";
			this.cmdLogin.Size = new System.Drawing.Size(88, 32);
			this.cmdLogin.TabIndex = 20;
			this.cmdLogin.Text = "&Login";
			this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(116, 40);
			this.txtPassword.MaxLength = 32;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(200, 21);
			this.txtPassword.TabIndex = 19;
			this.txtPassword.Text = "password";
			// 
			// txtUserName
			// 
			this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUserName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtUserName.Location = new System.Drawing.Point(116, 8);
			this.txtUserName.MaxLength = 32;
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(200, 21);
			this.txtUserName.TabIndex = 17;
			this.txtUserName.Text = "DeborahK";
			this.txtUserName.Leave += new System.EventHandler(this.txt_Leave);
			this.txtUserName.Enter += new System.EventHandler(this.txt_Enter);
			// 
			// lblPassword
			// 
			this.lblPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblPassword.ForeColor = System.Drawing.Color.DarkBlue;
			this.lblPassword.Location = new System.Drawing.Point(28, 42);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(92, 16);
			this.lblPassword.TabIndex = 18;
			this.lblPassword.Text = "Password";
			this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblUserName
			// 
			this.lblUserName.BackColor = System.Drawing.Color.Transparent;
			this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblUserName.ForeColor = System.Drawing.Color.DarkBlue;
			this.lblUserName.Location = new System.Drawing.Point(28, 8);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(88, 21);
			this.lblUserName.TabIndex = 16;
			this.lblUserName.Text = "Username";
			this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// epValidation
			// 
			this.epValidation.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.epValidation.ContainerControl = this;
			// 
			// LoginWin
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(322, 123);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUserName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "LoginWin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Please log in";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginWin_Paint);
			this.ResumeLayout(false);

		}
		#endregion

#region Form Events
		/// <summary>
		/// Handles the Paint event to draw a line on the form
		/// </summary>
		/// <param name="sender">form</param>
		/// <param name="e">PaintEventArgs</param>
		private void LoginWin_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			// Draw a line on the form for a visual effect
			Graphics g = e.Graphics;
			Pen penLine = new Pen(Color.CornflowerBlue, 12);
			g.DrawLine(penLine, 15, 0, 15, this.Height);
			penLine.Dispose();
		}
#endregion

#region Control Events
		/// <summary>
		/// Processes the login when the Login button is clicked
		/// </summary>
		/// <param name="sender">Login button</param>
		/// <param name="e">EventArgs</param>
		private void cmdLogin_Click(object sender, System.EventArgs e)
		{

			try
			{
				bool bValid = false;
				User oUser = new User();

				bValid = oUser.ValidateLogin(txtUserName.Text, txtPassword.Text);
				if (bValid == true)
				{
					this.DialogResult = DialogResult.OK;
				}
			}

			catch (UsernameNotFoundException ex)
			{
				MessageBox.Show(ex.Message);
				txtUserName.Focus();
			}

			catch (PasswordInvalidException ex)
			{
				MessageBox.Show(ex.Message);
				txtPassword.Focus();
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void txt_Enter(object sender, System.EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			tb.BackColor = Color.BlanchedAlmond;
		}

		private void txt_Leave(object sender, System.EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			tb.BackColor = Color.FromKnownColor(KnownColor.Window);
		}
#endregion

	}
}
