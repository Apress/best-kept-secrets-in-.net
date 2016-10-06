Option Strict On

Imports CRMBO

#Region " Comment Header"
' Name:         	LoginWin  
'
' Purpose:      	The purpose of this form is to allow the user to 
'               	perform the following functions:
'              	 	- Login to the system
'
' Developer:    	Deborah Kurata
'		            InStep Technologies, Inc.
'               	www.insteptech.com
'
' Copyright:    	2003 InStep Technologies
'
' Date:         	01/08/04
'
' Modifications:
'   Date        	Developer   	Description
'   01/08/04     	DJK        		Created this form
#End Region

Public Class LoginWin
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
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
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdLogin = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.lblPassword = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.lblUserName = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(220, 80)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(88, 32)
        Me.cmdCancel.TabIndex = 15
        Me.cmdCancel.Text = "E&xit"
        '
        'cmdLogin
        '
        Me.cmdLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogin.Location = New System.Drawing.Point(116, 80)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(88, 32)
        Me.cmdLogin.TabIndex = 14
        Me.cmdLogin.Text = "&Login"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(116, 40)
        Me.txtPassword.MaxLength = 32
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(200, 21)
        Me.txtPassword.TabIndex = 13
        Me.txtPassword.Text = "password"
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblPassword.Location = New System.Drawing.Point(28, 42)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(92, 16)
        Me.lblPassword.TabIndex = 12
        Me.lblPassword.Text = "Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(116, 8)
        Me.txtUserName.MaxLength = 32
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(200, 21)
        Me.txtUserName.TabIndex = 11
        Me.txtUserName.Text = "DeborahK"
        '
        'lblUserName
        '
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblUserName.Location = New System.Drawing.Point(28, 8)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(88, 21)
        Me.lblUserName.TabIndex = 10
        Me.lblUserName.Text = "Username"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LoginWin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(322, 123)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "LoginWin"
        Me.Text = "Please log in"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Form Events"
    ''' <summary>
    ''' Handles the Paint event to draw a line on the form
    ''' </summary>
    ''' <param name="sender">form</param>
    ''' <param name="e">PaintEventArgs</param>
    Private Sub LoginWin_Paint(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.PaintEventArgs) _
        Handles MyBase.Paint

        ' Draw a line on the form for a visual effect
        Dim g As Graphics = e.Graphics
        Dim penLine As Pen = New Pen(Color.CornflowerBlue, 12)
        g.DrawLine(penLine, 15, 0, 15, Me.Height)
        penLine.Dispose()
    End Sub

#End Region

#Region " Control Events"
    ''' <summary>
    ''' Processes the login when the Login button is clicked
    ''' </summary>
    ''' <param name="sender">Login button</param>
    ''' <param name="e">EventArgs</param>
    Private Sub cmdLogin_Click(ByVal sender As Object, _
            ByVal e As System.EventArgs) Handles cmdLogin.Click
        Try
            Dim bValid As Boolean
            Dim oUser As New User

            bValid = oUser.ValidateLogin(txtUserName.Text, txtPassword.Text)
            If bValid Then
                Me.DialogResult = DialogResult.OK
            End If

        Catch ex As UsernameNotFoundException
            MessageBox.Show(ex.Message)
            txtUserName.Focus()

        Catch ex As PasswordInvalidException
            MessageBox.Show(ex.Message)
            txtPassword.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_Enter(ByVal sender As Object, _
            ByVal e As System.EventArgs) Handles txtUserName.Enter, txtPassword.Enter
        DirectCast(sender, TextBox).BackColor = Color.BlanchedAlmond
    End Sub

    Private Sub txt_Leave(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles txtUserName.Leave, txtPassword.Leave
        DirectCast(sender, TextBox).BackColor = Color.FromKnownColor(KnownColor.Window)
    End Sub

#End Region

End Class
