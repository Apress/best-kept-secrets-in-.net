Option Strict On

Imports CRMBO
Imports GeneralUtility

#Region " Comment Header"
' Name  :       CustomerWin
'
' NameSpace:    WFW
'
' Purpose:      The purpose of this form is to allow the user to perform
'               the following functions:
'               - Add a Customer to the system
'               - Edit a Customer
'
' Dependencies: This form uses the following classes or other components:
'               - Customer
'
' Developer:    Deborah Kurata
'               InStep Technologies, Inc.
'               www.insteptech.com
'
' Copyright:    © 2004, InStep Technologies, Inc.  All rights reserved.
'
' Date:         4/16/2004
'
' Modifications:
'   Date        Developer   Description
'   9/15/03     DJK         Developed the first draft of this form
#End Region

Public Class CustomerWin
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    ''' <summary>
    ''' Form constructor
    ''' </summary>
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    ''' <summary>
    ''' Form overrides dispose to clean up the component list..
    ''' </summary>
    ''' <param name=disposing></param>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents tbBtnSave As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbSeparator2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents pnlSelection As System.Windows.Forms.Panel
    Friend WithEvents cboSelectDescription As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbBtnNew As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbSeparator1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbSeparator3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImListToolbar As System.Windows.Forms.ImageList
    Friend WithEvents pnlInformation As System.Windows.Forms.Panel
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPostalCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents tbCustomer As System.Windows.Forms.ToolBar
    Friend WithEvents tbBtnCancel As System.Windows.Forms.ToolBarButton
    ''' <summary>
    ''' Summary of InitializeComponent.
    ''' </summary>
    ''' 
    Friend WithEvents epValidation As System.Windows.Forms.ErrorProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CustomerWin))
        Me.tbBtnSave = New System.Windows.Forms.ToolBarButton
        Me.tbSeparator2 = New System.Windows.Forms.ToolBarButton
        Me.pnlSelection = New System.Windows.Forms.Panel
        Me.cboSelectDescription = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbCustomer = New System.Windows.Forms.ToolBar
        Me.tbBtnNew = New System.Windows.Forms.ToolBarButton
        Me.tbSeparator1 = New System.Windows.Forms.ToolBarButton
        Me.tbBtnCancel = New System.Windows.Forms.ToolBarButton
        Me.tbSeparator3 = New System.Windows.Forms.ToolBarButton
        Me.ImListToolbar = New System.Windows.Forms.ImageList(Me.components)
        Me.Label9 = New System.Windows.Forms.Label
        Me.pnlInformation = New System.Windows.Forms.Panel
        Me.txtCountry = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPostalCode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.epValidation = New System.Windows.Forms.ErrorProvider
        Me.pnlSelection.SuspendLayout()
        Me.pnlInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbBtnSave
        '
        Me.tbBtnSave.ImageIndex = 3
        Me.tbBtnSave.Text = "Save"
        Me.tbBtnSave.ToolTipText = "Save this Customer"
        '
        'tbSeparator2
        '
        Me.tbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'pnlSelection
        '
        Me.pnlSelection.BackColor = System.Drawing.Color.Silver
        Me.pnlSelection.Controls.Add(Me.cboSelectDescription)
        Me.pnlSelection.Controls.Add(Me.Label4)
        Me.pnlSelection.Controls.Add(Me.tbCustomer)
        Me.pnlSelection.Controls.Add(Me.Label9)
        Me.pnlSelection.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSelection.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSelection.ForeColor = System.Drawing.Color.DarkBlue
        Me.pnlSelection.Location = New System.Drawing.Point(0, 0)
        Me.pnlSelection.Name = "pnlSelection"
        Me.pnlSelection.Size = New System.Drawing.Size(432, 88)
        Me.pnlSelection.TabIndex = 0
        '
        'cboSelectDescription
        '
        Me.cboSelectDescription.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectDescription.Location = New System.Drawing.Point(140, 56)
        Me.cboSelectDescription.Name = "cboSelectDescription"
        Me.cboSelectDescription.Size = New System.Drawing.Size(273, 21)
        Me.cboSelectDescription.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(8, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Company Name"
        '
        'tbCustomer
        '
        Me.tbCustomer.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.tbCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCustomer.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbBtnNew, Me.tbSeparator1, Me.tbBtnSave, Me.tbSeparator2, Me.tbBtnCancel, Me.tbSeparator3})
        Me.tbCustomer.ButtonSize = New System.Drawing.Size(16, 16)
        Me.tbCustomer.DropDownArrows = True
        Me.tbCustomer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomer.ImageList = Me.ImListToolbar
        Me.tbCustomer.Location = New System.Drawing.Point(0, 0)
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.ShowToolTips = True
        Me.tbCustomer.Size = New System.Drawing.Size(432, 29)
        Me.tbCustomer.TabIndex = 0
        Me.tbCustomer.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'tbBtnNew
        '
        Me.tbBtnNew.ImageIndex = 5
        Me.tbBtnNew.Text = "New"
        Me.tbBtnNew.ToolTipText = "Create a new Customer"
        '
        'tbSeparator1
        '
        Me.tbSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbBtnCancel
        '
        Me.tbBtnCancel.ImageIndex = 6
        Me.tbBtnCancel.Text = "Cancel"
        Me.tbBtnCancel.ToolTipText = "Discard changes"
        '
        'tbSeparator3
        '
        Me.tbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ImListToolbar
        '
        Me.ImListToolbar.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImListToolbar.ImageStream = CType(resources.GetObject("ImListToolbar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImListToolbar.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Silver
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(8, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(272, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Select Customer"
        '
        'pnlInformation
        '
        Me.pnlInformation.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlInformation.Controls.Add(Me.txtCountry)
        Me.pnlInformation.Controls.Add(Me.Label15)
        Me.pnlInformation.Controls.Add(Me.Label10)
        Me.pnlInformation.Controls.Add(Me.Label5)
        Me.pnlInformation.Controls.Add(Me.txtPostalCode)
        Me.pnlInformation.Controls.Add(Me.Label3)
        Me.pnlInformation.Controls.Add(Me.txtName)
        Me.pnlInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInformation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlInformation.ForeColor = System.Drawing.Color.DarkBlue
        Me.pnlInformation.Location = New System.Drawing.Point(0, 88)
        Me.pnlInformation.Name = "pnlInformation"
        Me.pnlInformation.Size = New System.Drawing.Size(432, 154)
        Me.pnlInformation.TabIndex = 1
        '
        'txtCountry
        '
        Me.txtCountry.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCountry.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.Location = New System.Drawing.Point(136, 64)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(272, 21)
        Me.txtCountry.TabIndex = 4
        Me.txtCountry.Text = ""
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Gainsboro
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label15.Location = New System.Drawing.Point(12, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 16)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Country"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label10.Location = New System.Drawing.Point(8, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(272, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Customer Information"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Postal Code"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPostalCode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostalCode.Location = New System.Drawing.Point(136, 96)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.TabIndex = 6
        Me.txtPostalCode.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Company Name"
        '
        'txtName
        '
        Me.txtName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(136, 28)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(272, 21)
        Me.txtName.TabIndex = 2
        Me.txtName.Text = ""
        '
        'epValidation
        '
        Me.epValidation.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.epValidation.ContainerControl = Me
        '
        'CustomerWin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 242)
        Me.Controls.Add(Me.pnlInformation)
        Me.Controls.Add(Me.pnlSelection)
        Me.Name = "CustomerWin"
        Me.Text = "Customer Maintenance"
        Me.pnlSelection.ResumeLayout(False)
        Me.pnlInformation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Private Member Variables"
    Private m_oCustomer As Customer
    Private m_dsCustomer As DataSet
#End Region

#Region " Form Events"
    Private Sub CustomerWin_Load(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles MyBase.Load
        ' Create an instance of the class
        m_oCustomer = New Customer

        ' Set up the event handler
        AddEventHandlers(Me)

    End Sub

    Private Sub CustomerWin_Closing(ByVal sender As Object, _
        ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Not m_oCustomer Is Nothing Then
            m_oCustomer.Dispose()
        End If
    End Sub
#End Region

#Region " Toolbar Events"
    Private Sub tbCustomer_ButtonClick(ByVal sender As Object, _
            ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) _
            Handles tbCustomer.ButtonClick

        ' The toolbar does not seem to perform validation
        Me.Validate()

        Select Case e.Button.Text
            Case tbBtnCancel.Text
                Me.Close()

            Case tbBtnNew.Text
                MessageBox.Show("This would perform a new operation")
                Throw New ApplicationException("This is a test of the global exception")

            Case tbBtnSave.Text
                MessageBox.Show("This would perform a save")

            Case Else
                MessageBox.Show("Invalid button selection")
        End Select
    End Sub
#End Region

#Region " Control Events"
    Private Sub cboSelectDescription_DropDown(ByVal sender As Object, _
                        ByVal e As System.EventArgs) _
                        Handles cboSelectDescription.DropDown
        Dim dsAllCustomers As System.Data.DataSet

        ' Retrieve all customers
        dsAllCustomers = m_oCustomer.Retrieve()

        ' Bind to the combo box
        cboSelectDescription.DisplayMember = Customer.FN_CUSTOMER_NAME
        cboSelectDescription.DataSource = dsAllCustomers.Tables(0)
        cboSelectDescription.ValueMember = Customer.FN_CUSTOMER_ID
        cboSelectDescription.SelectedIndex = -1

        dsAllCustomers.Dispose()
        dsAllCustomers = Nothing

    End Sub

    Private Sub cboSelectDecription_SelectionChangeCommitted(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles cboSelectDescription.SelectionChangeCommitted

        ' Convert the selected value to the appropriate data type
        Dim sID As String
        sID = DirectCast(cboSelectDescription.SelectedValue, String)

        ' Retrieve the defined Customer
        m_dsCustomer = m_oCustomer.Retrieve(sID)

        ' Attempt to call an obsolete method
        'm_dsCustomer = m_oCustomer.Retrieve(0)

        ' Fill the form
        FillForm()

    End Sub

    Private Sub txt_Validating(ByVal sender As Object, _
        ByVal e As System.ComponentModel.CancelEventArgs) _
        Handles txtName.Validating, txtPostalCode.Validating

        ' Convert the control to the appropriate data type
        Dim ctrl As Control = DirectCast(sender, Control)

        ' Clear the error provider
        epValidation.SetError(ctrl, "")

        ' Set up the appropriate column
        Dim dcCust As DataColumn
        Select Case ctrl.Name
            Case txtName.Name
                dcCust = m_dsCustomer.Tables(Customer.TN_CUSTOMER).Columns(Customer.FN_CUSTOMER_NAME)

            Case txtPostalCode.Name
                dcCust = m_dsCustomer.Tables(Customer.TN_CUSTOMER).Columns(Customer.FN_POSTALCODE)
        End Select

        ' Perform the validation
        Dim sErrorText As String
        sErrorText = ValidationUtility.ValidateColumn(ctrl.Text, dcCust)

        ' If there was an error, assign it to the error provider
        If sErrorText.Length <> 0 Then
            epValidation.SetError(ctrl, sErrorText)
        End If

    End Sub
#End Region

#Region " Private Methods"

#Region " AddEventHandlers"
    ''' <summary>
    ''' Iterates through all of the controls on the defined form or container 
    ''' and adds the event handlers for the Enter and Leave events.
    ''' </summary>
    ''' <param name="pnl">Form or other container control containing the controls</param>
    Private Sub AddEventHandlers(ByVal pnl As Control)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is TextBox Then
                AddHandler ctrl.Enter, AddressOf txt_Enter
                AddHandler ctrl.Leave, AddressOf txt_Leave
            End If

            ' if the control has children, process them as well
            If ctrl.HasChildren Then
                AddEventHandlers(ctrl)
            End If
        Next

    End Sub

    ''' <summary>
    ''' Event handler for the Enter event.
    ''' </summary>
    ''' <param name="sender">Control receiving the Enter event</param>
    ''' <param name="e">Enter event parameters</param>
    Private Sub txt_Enter(ByVal sender As Object, _
        ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.BlanchedAlmond
    End Sub

    ''' <summary>
    ''' Event handler for the Leave event.
    ''' </summary>
    ''' <param name="sender">Control receiving the Leave event</param>
    ''' <param name="e">Leave event parameters</param>
    Private Sub txt_Leave(ByVal sender As Object, _
        ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = Color.FromKnownColor(KnownColor.Window)
    End Sub
#End Region

#Region " FillForm"
    ''' <summary>
    ''' Fills the form using data from the Customer dataset.
    ''' </summary>
    Private Sub FillForm()
        ' Populate the controls from the DataSet
        With m_dsCustomer.Tables(Customer.TN_CUSTOMER).Rows(0)

            txtName.Text = .Item(Customer.FN_CUSTOMER_NAME).ToString
            txtCountry.Text = .Item(Customer.FN_COUNTRY).ToString
            txtPostalCode.Text = .Item(Customer.FN_POSTALCODE).ToString
            'TODO: Add the rest of the controls here

        End With

        ' Set the customer name width appropriate for the contents
        ' Create a graphics object to use to measure the width.
        Dim g As Graphics = txtName.CreateGraphics()
        Dim iWidth As Int32 = CInt(g.MeasureString(txtName.Text, txtName.Font).Width) + 5
        txtName.Width = iWidth
        g.Dispose()

    End Sub
#End Region

#End Region

End Class
