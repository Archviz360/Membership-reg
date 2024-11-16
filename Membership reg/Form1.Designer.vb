<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        PictureBox13 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtName = New TextBox()
        txtAge = New TextBox()
        txtAddress = New TextBox()
        dtpDateOfBirth = New DateTimePicker()
        txtReligion = New TextBox()
        GroupBox2 = New GroupBox()
        PictureBox11 = New PictureBox()
        PictureBox10 = New PictureBox()
        Label6 = New Label()
        Label7 = New Label()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        GroupBox3 = New GroupBox()
        Label8 = New Label()
        txtOccupation = New TextBox()
        GroupBox4 = New GroupBox()
        PictureBox12 = New PictureBox()
        Label9 = New Label()
        Label10 = New Label()
        cboPaymentMethod = New ComboBox()
        txtBankAccount = New TextBox()
        GroupBox5 = New GroupBox()
        txtReason = New TextBox()
        dgvMembers = New DataGridView()
        btnAdd = New Button()
        btnEdit = New Button()
        btnRemove = New Button()
        btnPrint = New Button()
        btnExport = New Button()
        btnImport = New Button()
        PictureBox1 = New PictureBox()
        txtSearch = New TextBox()
        btnSearch = New Button()
        Label11 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        CType(dgvMembers, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PictureBox13)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(txtAge)
        GroupBox1.Controls.Add(txtAddress)
        GroupBox1.Controls.Add(dtpDateOfBirth)
        GroupBox1.Controls.Add(txtReligion)
        GroupBox1.Location = New Point(8, 115)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(400, 200)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Personal Information"
        ' 
        ' PictureBox13
        ' 
        PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), Image)
        PictureBox13.Location = New Point(77, 80)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(37, 33)
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.TabIndex = 24
        PictureBox13.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(20, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(20, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 1
        Label2.Text = "Age:"
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(20, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 2
        Label3.Text = "Address:"
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(20, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 23)
        Label4.TabIndex = 3
        Label4.Text = "Date of Birth:"
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(20, 150)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 4
        Label5.Text = "Religion: optional"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(120, 27)
        txtName.Name = "txtName"
        txtName.Size = New Size(250, 23)
        txtName.TabIndex = 5
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(120, 57)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(100, 23)
        txtAge.TabIndex = 6
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(120, 87)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(250, 23)
        txtAddress.TabIndex = 7
        ' 
        ' dtpDateOfBirth
        ' 
        dtpDateOfBirth.Location = New Point(120, 117)
        dtpDateOfBirth.Name = "dtpDateOfBirth"
        dtpDateOfBirth.Size = New Size(200, 23)
        dtpDateOfBirth.TabIndex = 8
        ' 
        ' txtReligion
        ' 
        txtReligion.Location = New Point(120, 147)
        txtReligion.Name = "txtReligion"
        txtReligion.Size = New Size(200, 23)
        txtReligion.TabIndex = 9
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(PictureBox11)
        GroupBox2.Controls.Add(PictureBox10)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(txtPhone)
        GroupBox2.Controls.Add(txtEmail)
        GroupBox2.Location = New Point(426, 115)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(400, 100)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Contact Information"
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), Image)
        PictureBox11.Location = New Point(78, 56)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(27, 26)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 5
        PictureBox11.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), Image)
        PictureBox10.Location = New Point(78, 27)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(27, 26)
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 4
        PictureBox10.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(20, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 23)
        Label6.TabIndex = 0
        Label6.Text = "Phone:"
        ' 
        ' Label7
        ' 
        Label7.Location = New Point(20, 60)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 23)
        Label7.TabIndex = 1
        Label7.Text = "Email:"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(120, 27)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(200, 23)
        txtPhone.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(120, 57)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(250, 23)
        txtEmail.TabIndex = 3
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(txtOccupation)
        GroupBox3.Location = New Point(426, 225)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(400, 90)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Occupation Status(optional)"
        ' 
        ' Label8
        ' 
        Label8.Location = New Point(20, 30)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 23)
        Label8.TabIndex = 0
        Label8.Text = "Occupation:"
        ' 
        ' txtOccupation
        ' 
        txtOccupation.Location = New Point(120, 27)
        txtOccupation.Name = "txtOccupation"
        txtOccupation.Size = New Size(250, 23)
        txtOccupation.TabIndex = 1
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(PictureBox12)
        GroupBox4.Controls.Add(Label9)
        GroupBox4.Controls.Add(Label10)
        GroupBox4.Controls.Add(cboPaymentMethod)
        GroupBox4.Controls.Add(txtBankAccount)
        GroupBox4.Location = New Point(846, 115)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(320, 100)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Bank Information"
        ' 
        ' PictureBox12
        ' 
        PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), Image)
        PictureBox12.Location = New Point(87, 24)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(27, 26)
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.TabIndex = 6
        PictureBox12.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.Location = New Point(20, 30)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 23)
        Label9.TabIndex = 0
        Label9.Text = "Payment Method:"
        ' 
        ' Label10
        ' 
        Label10.Location = New Point(20, 60)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 23)
        Label10.TabIndex = 1
        Label10.Text = "Bank Account:"
        ' 
        ' cboPaymentMethod
        ' 
        cboPaymentMethod.Items.AddRange(New Object() {"Cash", "Credit Card", "Bank Transfer"})
        cboPaymentMethod.Location = New Point(120, 27)
        cboPaymentMethod.Name = "cboPaymentMethod"
        cboPaymentMethod.Size = New Size(180, 23)
        cboPaymentMethod.TabIndex = 2
        ' 
        ' txtBankAccount
        ' 
        txtBankAccount.Location = New Point(120, 57)
        txtBankAccount.Name = "txtBankAccount"
        txtBankAccount.Size = New Size(180, 23)
        txtBankAccount.TabIndex = 3
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(txtReason)
        GroupBox5.Location = New Point(846, 225)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(320, 90)
        GroupBox5.TabIndex = 4
        GroupBox5.TabStop = False
        GroupBox5.Text = "Reason for Joining"
        ' 
        ' txtReason
        ' 
        txtReason.Location = New Point(20, 20)
        txtReason.Multiline = True
        txtReason.Name = "txtReason"
        txtReason.Size = New Size(280, 60)
        txtReason.TabIndex = 0
        ' 
        ' dgvMembers
        ' 
        dgvMembers.AllowUserToAddRows = False
        dgvMembers.AllowUserToDeleteRows = False
        dgvMembers.BackgroundColor = SystemColors.ControlDarkDark
        dgvMembers.BorderStyle = BorderStyle.Fixed3D
        dgvMembers.Dock = DockStyle.Bottom
        dgvMembers.Location = New Point(0, 395)
        dgvMembers.MultiSelect = False
        dgvMembers.Name = "dgvMembers"
        dgvMembers.ReadOnly = True
        dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMembers.Size = New Size(1370, 450)
        dgvMembers.TabIndex = 5
        ' 
        ' btnAdd
        ' 
        btnAdd.AutoSize = True
        btnAdd.Location = New Point(170, 12)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(124, 65)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Add Member"
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.Orange
        btnEdit.Location = New Point(300, 12)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(124, 65)
        btnEdit.TabIndex = 7
        btnEdit.Text = "Edit Member"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.LightCoral
        btnRemove.Location = New Point(430, 12)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(124, 65)
        btnRemove.TabIndex = 8
        btnRemove.Text = "Remove Member"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.CornflowerBlue
        btnPrint.Location = New Point(560, 12)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(124, 65)
        btnPrint.TabIndex = 9
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.ForestGreen
        btnExport.Location = New Point(690, 12)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(124, 65)
        btnExport.TabIndex = 10
        btnExport.Text = "Export to Excel"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' btnImport
        ' 
        btnImport.BackColor = Color.ForestGreen
        btnImport.Location = New Point(820, 12)
        btnImport.Name = "btnImport"
        btnImport.Size = New Size(146, 65)
        btnImport.TabIndex = 11
        btnImport.Text = "Import from Excel"
        btnImport.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1172, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(371, 345)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(104, 321)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(1042, 23)
        txtSearch.TabIndex = 14
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Blue
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(12, 321)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(86, 23)
        btnSearch.TabIndex = 13
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.ForeColor = Color.Red
        Label11.Location = New Point(12, 342)
        Label11.Name = "Label11"
        Label11.Size = New Size(86, 15)
        Label11.TabIndex = 15
        Label11.Text = "!!NAME ONLY!!"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(8, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(133, 97)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(209, 77)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(33, 32)
        PictureBox3.TabIndex = 17
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(345, 77)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(33, 32)
        PictureBox4.TabIndex = 18
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(470, 77)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(33, 32)
        PictureBox5.TabIndex = 19
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(607, 77)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(33, 32)
        PictureBox6.TabIndex = 20
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(740, 77)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(33, 32)
        PictureBox7.TabIndex = 21
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(866, 77)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(33, 32)
        PictureBox8.TabIndex = 22
        PictureBox8.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(28, 360)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(36, 34)
        PictureBox9.TabIndex = 23
        PictureBox9.TabStop = False
        ' 
        ' Form1
        ' 
        AutoSize = True
        BackColor = Color.LightGreen
        ClientSize = New Size(1370, 845)
        Controls.Add(PictureBox9)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label11)
        Controls.Add(txtSearch)
        Controls.Add(btnSearch)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox5)
        Controls.Add(dgvMembers)
        Controls.Add(btnAdd)
        Controls.Add(btnEdit)
        Controls.Add(btnRemove)
        Controls.Add(btnPrint)
        Controls.Add(btnExport)
        Controls.Add(btnImport)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Membership Registration v 1.0"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        CType(dgvMembers, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents GroupBox2 As GroupBox
    Private WithEvents GroupBox3 As GroupBox
    Private WithEvents GroupBox4 As GroupBox
    Private WithEvents GroupBox5 As GroupBox
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Private WithEvents Label6 As Label
    Private WithEvents Label7 As Label
    Private WithEvents Label8 As Label
    Private WithEvents Label9 As Label
    Private WithEvents Label10 As Label
    Private WithEvents txtName As TextBox
    Private WithEvents txtAge As TextBox
    Private WithEvents txtAddress As TextBox
    Private WithEvents dtpDateOfBirth As DateTimePicker
    Private WithEvents txtReligion As TextBox
    Private WithEvents txtPhone As TextBox
    Private WithEvents txtEmail As TextBox
    Private WithEvents txtOccupation As TextBox
    Private WithEvents cboPaymentMethod As ComboBox
    Private WithEvents txtBankAccount As TextBox
    Private WithEvents txtReason As TextBox
    Private WithEvents dgvMembers As DataGridView
    Private WithEvents btnAdd As Button
    Private WithEvents btnEdit As Button
    Private WithEvents btnRemove As Button
    Private WithEvents btnPrint As Button
    Private WithEvents btnExport As Button
    Private WithEvents btnImport As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
End Class
