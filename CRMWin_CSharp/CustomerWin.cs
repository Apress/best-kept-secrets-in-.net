using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using CRMBO_CSharp;
using GeneralUtility_CSharp;

namespace CRMWin_CSharp
{
	/// <summary>
	/// Provides the UI for adding and editing a customer.
	/// </summary>
	/// <developer>
	///		Deborah Kurata
	///		InStep Technologies, Inc.
	///		www.insteptech.com
	/// </developer>
	/// <copyright>Copyright:  © 2004, InStep Technologies, Inc.  All rights reserved.</copyright>
	/// <date>8/9/2003</date>
	/// <edithistory date="8/9/03" developer="DJK">
	///		Developed the first draft of this form
	/// </edithistory>
	public class CustomerWin : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ToolBarButton tbSeparator1;
		internal System.Windows.Forms.ToolBarButton tbBtnCancel;
		internal System.Windows.Forms.ToolBarButton tbBtnNew;
		internal System.Windows.Forms.ToolBarButton tbSeparator3;
		internal System.Windows.Forms.Panel pnlInformation;
		internal System.Windows.Forms.TextBox txtCountry;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtPostalCode;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtName;
		internal System.Windows.Forms.ImageList ImListToolbar;
		internal System.Windows.Forms.ToolBarButton tbBtnSave;
		internal System.Windows.Forms.Panel pnlSelection;
		internal System.Windows.Forms.ComboBox cboSelectDescription;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.ToolBar tbCustomer;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.ToolBarButton tbSeparator2;
		internal System.Windows.Forms.ErrorProvider epValidation;
		private System.ComponentModel.IContainer components;

		/// <summary>
		/// Constructor initializes the form
		/// </summary>
		public CustomerWin()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Create an instance of the class
			m_oCustomer = new Customer();

			// Set up the event handler
			AddEventHandlers(this);
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

				if (m_oCustomer != null)
				{
					m_oCustomer.Dispose();
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CustomerWin));
			this.tbSeparator1 = new System.Windows.Forms.ToolBarButton();
			this.tbBtnCancel = new System.Windows.Forms.ToolBarButton();
			this.tbBtnNew = new System.Windows.Forms.ToolBarButton();
			this.tbSeparator3 = new System.Windows.Forms.ToolBarButton();
			this.pnlInformation = new System.Windows.Forms.Panel();
			this.txtCountry = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtPostalCode = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.ImListToolbar = new System.Windows.Forms.ImageList(this.components);
			this.tbBtnSave = new System.Windows.Forms.ToolBarButton();
			this.pnlSelection = new System.Windows.Forms.Panel();
			this.cboSelectDescription = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.tbCustomer = new System.Windows.Forms.ToolBar();
			this.tbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.Label9 = new System.Windows.Forms.Label();
			this.epValidation = new System.Windows.Forms.ErrorProvider();
			this.pnlInformation.SuspendLayout();
			this.pnlSelection.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbSeparator1
			// 
			this.tbSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbBtnCancel
			// 
			this.tbBtnCancel.ImageIndex = 6;
			this.tbBtnCancel.Text = "Cancel";
			this.tbBtnCancel.ToolTipText = "Discard changes";
			// 
			// tbBtnNew
			// 
			this.tbBtnNew.ImageIndex = 5;
			this.tbBtnNew.Text = "New";
			this.tbBtnNew.ToolTipText = "Create a new Customer";
			// 
			// tbSeparator3
			// 
			this.tbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// pnlInformation
			// 
			this.pnlInformation.BackColor = System.Drawing.Color.Gainsboro;
			this.pnlInformation.Controls.Add(this.txtCountry);
			this.pnlInformation.Controls.Add(this.Label15);
			this.pnlInformation.Controls.Add(this.Label10);
			this.pnlInformation.Controls.Add(this.Label5);
			this.pnlInformation.Controls.Add(this.txtPostalCode);
			this.pnlInformation.Controls.Add(this.Label3);
			this.pnlInformation.Controls.Add(this.txtName);
			this.pnlInformation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlInformation.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnlInformation.ForeColor = System.Drawing.Color.DarkBlue;
			this.pnlInformation.Location = new System.Drawing.Point(0, 88);
			this.pnlInformation.Name = "pnlInformation";
			this.pnlInformation.Size = new System.Drawing.Size(432, 154);
			this.pnlInformation.TabIndex = 3;
			// 
			// txtCountry
			// 
			this.txtCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCountry.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtCountry.Location = new System.Drawing.Point(136, 64);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Size = new System.Drawing.Size(272, 21);
			this.txtCountry.TabIndex = 4;
			this.txtCountry.Text = "";
			// 
			// Label15
			// 
			this.Label15.BackColor = System.Drawing.Color.Gainsboro;
			this.Label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label15.ForeColor = System.Drawing.Color.DarkBlue;
			this.Label15.Location = new System.Drawing.Point(12, 64);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(120, 16);
			this.Label15.TabIndex = 3;
			this.Label15.Text = "Country";
			this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label10
			// 
			this.Label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label10.ForeColor = System.Drawing.Color.DarkBlue;
			this.Label10.Location = new System.Drawing.Point(8, 8);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(272, 20);
			this.Label10.TabIndex = 0;
			this.Label10.Text = "Customer Information";
			// 
			// Label5
			// 
			this.Label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label5.Location = new System.Drawing.Point(12, 96);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(112, 16);
			this.Label5.TabIndex = 5;
			this.Label5.Text = "Postal Code";
			// 
			// txtPostalCode
			// 
			this.txtPostalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPostalCode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPostalCode.Location = new System.Drawing.Point(136, 96);
			this.txtPostalCode.Name = "txtPostalCode";
			this.txtPostalCode.TabIndex = 6;
			this.txtPostalCode.Text = "";
			this.txtPostalCode.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
			// 
			// Label3
			// 
			this.Label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label3.Location = new System.Drawing.Point(12, 32);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(112, 16);
			this.Label3.TabIndex = 1;
			this.Label3.Text = "Company Name";
			// 
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtName.Location = new System.Drawing.Point(136, 28);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(272, 21);
			this.txtName.TabIndex = 2;
			this.txtName.Text = "";
			this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
			// 
			// ImListToolbar
			// 
			this.ImListToolbar.ImageSize = new System.Drawing.Size(16, 16);
			this.ImListToolbar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImListToolbar.ImageStream")));
			this.ImListToolbar.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// tbBtnSave
			// 
			this.tbBtnSave.ImageIndex = 3;
			this.tbBtnSave.Text = "Save";
			this.tbBtnSave.ToolTipText = "Save this Customer";
			// 
			// pnlSelection
			// 
			this.pnlSelection.BackColor = System.Drawing.Color.Silver;
			this.pnlSelection.Controls.Add(this.cboSelectDescription);
			this.pnlSelection.Controls.Add(this.Label4);
			this.pnlSelection.Controls.Add(this.tbCustomer);
			this.pnlSelection.Controls.Add(this.Label9);
			this.pnlSelection.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSelection.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnlSelection.ForeColor = System.Drawing.Color.DarkBlue;
			this.pnlSelection.Location = new System.Drawing.Point(0, 0);
			this.pnlSelection.Name = "pnlSelection";
			this.pnlSelection.Size = new System.Drawing.Size(432, 88);
			this.pnlSelection.TabIndex = 2;
			// 
			// cboSelectDescription
			// 
			this.cboSelectDescription.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cboSelectDescription.Location = new System.Drawing.Point(140, 56);
			this.cboSelectDescription.Name = "cboSelectDescription";
			this.cboSelectDescription.Size = new System.Drawing.Size(273, 21);
			this.cboSelectDescription.TabIndex = 2;
			this.cboSelectDescription.DropDown += new System.EventHandler(this.cboSelectDescription_DropDown);
			this.cboSelectDescription.SelectionChangeCommitted += new System.EventHandler(this.cboSelectDecription_SelectionChangeCommitted);
			// 
			// Label4
			// 
			this.Label4.BackColor = System.Drawing.Color.Silver;
			this.Label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label4.ForeColor = System.Drawing.Color.DarkBlue;
			this.Label4.Location = new System.Drawing.Point(8, 56);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(120, 16);
			this.Label4.TabIndex = 1;
			this.Label4.Text = "Company Name";
			// 
			// tbCustomer
			// 
			this.tbCustomer.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.tbCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbCustomer.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						  this.tbBtnNew,
																						  this.tbSeparator1,
																						  this.tbBtnSave,
																						  this.tbSeparator2,
																						  this.tbBtnCancel,
																						  this.tbSeparator3});
			this.tbCustomer.ButtonSize = new System.Drawing.Size(16, 16);
			this.tbCustomer.DropDownArrows = true;
			this.tbCustomer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbCustomer.ImageList = this.ImListToolbar;
			this.tbCustomer.Location = new System.Drawing.Point(0, 0);
			this.tbCustomer.Name = "tbCustomer";
			this.tbCustomer.ShowToolTips = true;
			this.tbCustomer.Size = new System.Drawing.Size(432, 29);
			this.tbCustomer.TabIndex = 0;
			this.tbCustomer.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.tbCustomer.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbCustomer_ButtonClick);
			// 
			// tbSeparator2
			// 
			this.tbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// Label9
			// 
			this.Label9.BackColor = System.Drawing.Color.Silver;
			this.Label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label9.ForeColor = System.Drawing.Color.DarkBlue;
			this.Label9.Location = new System.Drawing.Point(8, 36);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(272, 20);
			this.Label9.TabIndex = 0;
			this.Label9.Text = "Select Customer";
			// 
			// epValidation
			// 
			this.epValidation.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.epValidation.ContainerControl = this;
			// 
			// CustomerWin
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(432, 242);
			this.Controls.Add(this.pnlInformation);
			this.Controls.Add(this.pnlSelection);
			this.Name = "CustomerWin";
			this.Text = "CustomerWin";
			this.pnlInformation.ResumeLayout(false);
			this.pnlSelection.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Private Member Variables
		internal Customer m_oCustomer;
		internal DataSet m_dsCustomer;
		#endregion

		#region  Toolbar Events
		private void tbCustomer_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			// The toolbar does not seem to perform validation
			this.Validate();

			// There should be a better way to do this
			// The order of the buttons in the UI could change - causing this code to break
			switch(tbCustomer.Buttons.IndexOf(e.Button))
			{
				case 0:		// New
					MessageBox.Show("This would perform a new operation");
					throw new ApplicationException("This is a test of the global exception");

				case 2:		// Save
					MessageBox.Show("This would perform a save");
					break;

				case 4:		// Cancel
					this.Close();
					break;

				default:	// Invalid choice
					MessageBox.Show("Invalid button selection");
					break;
			}
		}
		#endregion

		#region Control Events
		private void cboSelectDescription_DropDown(Object sender, System.EventArgs e)
		{
			// Retrieve all customers
			System.Data.DataSet dsAllCustomers = m_oCustomer.Retrieve();

			// Bind to the combo box
			cboSelectDescription.DisplayMember = Customer.FN_CUSTOMER_NAME;
			cboSelectDescription.DataSource = dsAllCustomers.Tables[0];
			cboSelectDescription.ValueMember = Customer.FN_CUSTOMER_ID;
			cboSelectDescription.SelectedIndex = -1;

			dsAllCustomers.Dispose();
			dsAllCustomers = null;
		}

		private void cboSelectDecription_SelectionChangeCommitted(Object sender, System.EventArgs e)
		{
			// Convert the selected value to the appropriate data type
			string	sID = (string)cboSelectDescription.SelectedValue;

			// Retrieve the defined Customer
			m_dsCustomer = m_oCustomer.Retrieve(sID);

			// Attempt to call an obsolete method
			//m_dsCustomer = m_oCustomer.Retrieve(0);

			// Fill the form
			FillForm();
		}

		private void txt_Validating(Object sender,System.ComponentModel.CancelEventArgs e)
		{
			// Convert the control to the appropriate data type
			Control ctrl = (Control)sender;
			
			// Clear the error provider
			epValidation.SetError(ctrl, "");

			// Set up the appropriate column
			DataColumn dcCust=null;
			if (ctrl.Name == txtName.Name)
			{
				dcCust = m_dsCustomer.Tables[Customer.TN_CUSTOMER].Columns[Customer.FN_CUSTOMER_NAME];
			}

			if (ctrl.Name == txtPostalCode.Name)
			{
				dcCust = m_dsCustomer.Tables[Customer.TN_CUSTOMER].Columns[Customer.FN_POSTALCODE];
			}

			// Perform the validation
			// In  order to pass the value in by reference, it needs to be in a variable
			string sControlText = ctrl.Text;
			string sErrorText = ValidationUtility.ValidateColumn(ref sControlText, dcCust);
			//If the value was changed, need to reassign to the control
			ctrl.Text = sControlText;

			// If there was an error, assign it to the error provider
			if (sErrorText.Length != 0)
			{
				epValidation.SetError(ctrl, sErrorText);
			}
		}

#endregion


		#region Private Methods

		#region AddEventHandlers
		/// <summary>
		/// Iterates through all of the controls on the defined form or container 
		/// and adds the event handlers for the Enter and Leave events.
		/// </summary>
		/// <param name="pnl">Form or other container control containing the controls</param>
		private void AddEventHandlers(Control pnl)
		{
			foreach (Control ctrl in pnl.Controls)
			{
				if (ctrl is TextBox)
				{
					ctrl.Enter += new System.EventHandler(this.txt_Enter);
					ctrl.Leave += new System.EventHandler(this.txt_Leave);
				}
			
				// if the control has children, process them as well
				if (ctrl.HasChildren)
				{
					AddEventHandlers(ctrl);
				}
			}
		}

		/// <summary>
		/// Event handler for the Enter event.
		/// </summary>
		/// <param name="sender">Control receiving the Enter event</param>
		/// <param name="e">Enter event parameters</param>
		private void txt_Enter(object sender, System.EventArgs e)
		{
			TextBox tb=(TextBox)sender;
			tb.BackColor = Color.BlanchedAlmond;
		}
	
		/// <summary>
		/// Event handler for the Leave event.
		/// </summary>
		/// <param name="sender">Control receiving the Leave event</param>
		/// <param name="e">Leave event parameters</param>
		private void txt_Leave(object sender, System.EventArgs e)
		{
			TextBox tb=(TextBox)sender;
			tb.BackColor = Color.FromKnownColor(KnownColor.Window);
		}
	#endregion

	#region  FillForm
		/// <summary>
		/// Fills the form using data from the Customer dataset.
		/// </summary>
		private void FillForm()
		{
			// Populate the controls from the DataSet
			System.Data.DataRow drCustomer = m_dsCustomer.Tables[Customer.TN_CUSTOMER].Rows[0];

			txtName.Text = drCustomer[Customer.FN_CUSTOMER_NAME].ToString();
			txtCountry.Text = drCustomer[Customer.FN_COUNTRY].ToString();
			txtPostalCode.Text = drCustomer[Customer.FN_POSTALCODE].ToString();
			//TODO: Add the rest of the controls here

			// Set the customer name width appropriate for the contents
			// Create a graphics object to use to measure the width.
			Graphics g = txtName.CreateGraphics();
			Int32 iWidth  =(Int32)g.MeasureString(txtName.Text, txtName.Font).Width + 5;
			txtName.Width = iWidth;
			g.Dispose();
		}
	#endregion

#endregion

	}
}
