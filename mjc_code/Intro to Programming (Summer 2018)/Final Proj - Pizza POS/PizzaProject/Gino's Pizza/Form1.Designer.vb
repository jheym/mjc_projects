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
        Me.Frame = New System.Windows.Forms.Panel()
        Me.pnlOrderOnline = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlOrderInfo = New System.Windows.Forms.Panel()
        Me.rdoTakeout = New System.Windows.Forms.RadioButton()
        Me.rdoDelivery = New System.Windows.Forms.RadioButton()
        Me.txtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.pnlAddress = New System.Windows.Forms.Panel()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblStreetAddress = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picPizza = New System.Windows.Forms.PictureBox()
        Me.pnlPizza = New System.Windows.Forms.Panel()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.grpVeggies = New System.Windows.Forms.GroupBox()
        Me.chkBananaPeppers = New System.Windows.Forms.CheckBox()
        Me.chkTomatoes = New System.Windows.Forms.CheckBox()
        Me.chkGarlic = New System.Windows.Forms.CheckBox()
        Me.chkOnion = New System.Windows.Forms.CheckBox()
        Me.chkMushrooms = New System.Windows.Forms.CheckBox()
        Me.chkBellPeppers = New System.Windows.Forms.CheckBox()
        Me.chkBlackOlives = New System.Windows.Forms.CheckBox()
        Me.chkArtichoke = New System.Windows.Forms.CheckBox()
        Me.grpMeats = New System.Windows.Forms.GroupBox()
        Me.chkAnchovies = New System.Windows.Forms.CheckBox()
        Me.chkBacon = New System.Windows.Forms.CheckBox()
        Me.chkChicken = New System.Windows.Forms.CheckBox()
        Me.chkItalianSausage = New System.Windows.Forms.CheckBox()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.chkLinguini = New System.Windows.Forms.CheckBox()
        Me.chkHam = New System.Windows.Forms.CheckBox()
        Me.grpCrust = New System.Windows.Forms.GroupBox()
        Me.rdoStuffed = New System.Windows.Forms.RadioButton()
        Me.rdoPan = New System.Windows.Forms.RadioButton()
        Me.rdoOriginal = New System.Windows.Forms.RadioButton()
        Me.grpCheese = New System.Windows.Forms.GroupBox()
        Me.rdoExtraCheese = New System.Windows.Forms.RadioButton()
        Me.rdoNormalCheese = New System.Windows.Forms.RadioButton()
        Me.rdoLightCheese = New System.Windows.Forms.RadioButton()
        Me.grpSauce = New System.Windows.Forms.GroupBox()
        Me.rdoSauceBarbeque = New System.Windows.Forms.RadioButton()
        Me.rdoSauceAlfredo = New System.Windows.Forms.RadioButton()
        Me.rdoSauceTomato = New System.Windows.Forms.RadioButton()
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.rdoLarge = New System.Windows.Forms.RadioButton()
        Me.rdoMedium = New System.Windows.Forms.RadioButton()
        Me.rdoSmall = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame.SuspendLayout()
        Me.pnlOrderOnline.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlOrderInfo.SuspendLayout()
        Me.pnlAddress.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPizza.SuspendLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpVeggies.SuspendLayout()
        Me.grpMeats.SuspendLayout()
        Me.grpCrust.SuspendLayout()
        Me.grpCheese.SuspendLayout()
        Me.grpSauce.SuspendLayout()
        Me.grpSize.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame
        '
        Me.Frame.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame.AutoSize = True
        Me.Frame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Frame.BackColor = System.Drawing.Color.SaddleBrown
        Me.Frame.Controls.Add(Me.pnlOrderOnline)
        Me.Frame.Controls.Add(Me.pnlHeader)
        Me.Frame.Controls.Add(Me.pnlPizza)
        Me.Frame.Location = New System.Drawing.Point(6, 4)
        Me.Frame.Margin = New System.Windows.Forms.Padding(6)
        Me.Frame.Name = "Frame"
        Me.Frame.Size = New System.Drawing.Size(2327, 1298)
        Me.Frame.TabIndex = 0
        '
        'pnlOrderOnline
        '
        Me.pnlOrderOnline.BackColor = System.Drawing.Color.NavajoWhite
        Me.pnlOrderOnline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOrderOnline.Controls.Add(Me.Panel1)
        Me.pnlOrderOnline.Location = New System.Drawing.Point(18, 271)
        Me.pnlOrderOnline.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlOrderOnline.Name = "pnlOrderOnline"
        Me.pnlOrderOnline.Size = New System.Drawing.Size(881, 1021)
        Me.pnlOrderOnline.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.pnlOrderInfo)
        Me.Panel1.Controls.Add(Me.pnlAddress)
        Me.Panel1.Location = New System.Drawing.Point(48, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 697)
        Me.Panel1.TabIndex = 13
        '
        'pnlOrderInfo
        '
        Me.pnlOrderInfo.BackColor = System.Drawing.Color.Transparent
        Me.pnlOrderInfo.Controls.Add(Me.rdoTakeout)
        Me.pnlOrderInfo.Controls.Add(Me.rdoDelivery)
        Me.pnlOrderInfo.Controls.Add(Me.txtPhoneNumber)
        Me.pnlOrderInfo.Controls.Add(Me.lblPhoneNumber)
        Me.pnlOrderInfo.Controls.Add(Me.txtName)
        Me.pnlOrderInfo.Controls.Add(Me.lblName)
        Me.pnlOrderInfo.Location = New System.Drawing.Point(30, 31)
        Me.pnlOrderInfo.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlOrderInfo.Name = "pnlOrderInfo"
        Me.pnlOrderInfo.Size = New System.Drawing.Size(674, 225)
        Me.pnlOrderInfo.TabIndex = 11
        '
        'rdoTakeout
        '
        Me.rdoTakeout.AutoSize = True
        Me.rdoTakeout.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoTakeout.Location = New System.Drawing.Point(6, 161)
        Me.rdoTakeout.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoTakeout.Name = "rdoTakeout"
        Me.rdoTakeout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rdoTakeout.Size = New System.Drawing.Size(178, 49)
        Me.rdoTakeout.TabIndex = 10
        Me.rdoTakeout.TabStop = True
        Me.rdoTakeout.Text = "Takeout"
        Me.rdoTakeout.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rdoTakeout.UseVisualStyleBackColor = True
        '
        'rdoDelivery
        '
        Me.rdoDelivery.AutoSize = True
        Me.rdoDelivery.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoDelivery.Location = New System.Drawing.Point(418, 161)
        Me.rdoDelivery.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoDelivery.Name = "rdoDelivery"
        Me.rdoDelivery.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rdoDelivery.Size = New System.Drawing.Size(177, 49)
        Me.rdoDelivery.TabIndex = 9
        Me.rdoDelivery.TabStop = True
        Me.rdoDelivery.Text = "Delivery"
        Me.rdoDelivery.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rdoDelivery.UseVisualStyleBackColor = True
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(280, 74)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(315, 44)
        Me.txtPhoneNumber.TabIndex = 6
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(6, 74)
        Me.lblPhoneNumber.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(262, 45)
        Me.lblPhoneNumber.TabIndex = 5
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(149, 6)
        Me.txtName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(446, 44)
        Me.txtName.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(6, 15)
        Me.lblName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(131, 45)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name: "
        '
        'pnlAddress
        '
        Me.pnlAddress.Controls.Add(Me.txtZipCode)
        Me.pnlAddress.Controls.Add(Me.txtState)
        Me.pnlAddress.Controls.Add(Me.txtCity)
        Me.pnlAddress.Controls.Add(Me.txtStreetAddress)
        Me.pnlAddress.Controls.Add(Me.lblZipCode)
        Me.pnlAddress.Controls.Add(Me.lblState)
        Me.pnlAddress.Controls.Add(Me.lblCity)
        Me.pnlAddress.Controls.Add(Me.lblStreetAddress)
        Me.pnlAddress.Location = New System.Drawing.Point(30, 278)
        Me.pnlAddress.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlAddress.Name = "pnlAddress"
        Me.pnlAddress.Size = New System.Drawing.Size(727, 313)
        Me.pnlAddress.TabIndex = 12
        Me.pnlAddress.Visible = False
        '
        'txtZipCode
        '
        Me.txtZipCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipCode.Location = New System.Drawing.Point(188, 196)
        Me.txtZipCode.Margin = New System.Windows.Forms.Padding(6)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(246, 44)
        Me.txtZipCode.TabIndex = 13
        '
        'txtState
        '
        Me.txtState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(126, 135)
        Me.txtState.Margin = New System.Windows.Forms.Padding(6)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(70, 44)
        Me.txtState.TabIndex = 16
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(116, 73)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(408, 44)
        Me.txtCity.TabIndex = 15
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreetAddress.Location = New System.Drawing.Point(180, 10)
        Me.txtStreetAddress.Margin = New System.Windows.Forms.Padding(6)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(514, 44)
        Me.txtStreetAddress.TabIndex = 11
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZipCode.Location = New System.Drawing.Point(6, 200)
        Me.lblZipCode.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(169, 45)
        Me.lblZipCode.TabIndex = 14
        Me.lblZipCode.Text = "Zip Code:"
        Me.lblZipCode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(6, 138)
        Me.lblState.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(109, 45)
        Me.lblState.TabIndex = 13
        Me.lblState.Text = "State:"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(6, 77)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(101, 45)
        Me.lblCity.TabIndex = 12
        Me.lblCity.Text = "City: "
        Me.lblCity.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblStreetAddress
        '
        Me.lblStreetAddress.AutoSize = True
        Me.lblStreetAddress.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreetAddress.Location = New System.Drawing.Point(6, 15)
        Me.lblStreetAddress.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblStreetAddress.Name = "lblStreetAddress"
        Me.lblStreetAddress.Size = New System.Drawing.Size(161, 45)
        Me.lblStreetAddress.TabIndex = 11
        Me.lblStreetAddress.Text = "Address: "
        Me.lblStreetAddress.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.NavajoWhite
        Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHeader.Controls.Add(Me.PictureBox3)
        Me.pnlHeader.Controls.Add(Me.PictureBox2)
        Me.pnlHeader.Controls.Add(Me.PictureBox1)
        Me.pnlHeader.Controls.Add(Me.picPizza)
        Me.pnlHeader.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlHeader.Location = New System.Drawing.Point(18, 19)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(2303, 240)
        Me.pnlHeader.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1833, 6)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(394, 226)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1401, 6)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(394, 226)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(977, 6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(394, 226)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'picPizza
        '
        Me.picPizza.Image = CType(resources.GetObject("picPizza.Image"), System.Drawing.Image)
        Me.picPizza.Location = New System.Drawing.Point(0, -1)
        Me.picPizza.Margin = New System.Windows.Forms.Padding(6)
        Me.picPizza.Name = "picPizza"
        Me.picPizza.Size = New System.Drawing.Size(951, 240)
        Me.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPizza.TabIndex = 3
        Me.picPizza.TabStop = False
        '
        'pnlPizza
        '
        Me.pnlPizza.BackColor = System.Drawing.Color.NavajoWhite
        Me.pnlPizza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPizza.Controls.Add(Me.lblQuantity)
        Me.pnlPizza.Controls.Add(Me.nudQuantity)
        Me.pnlPizza.Controls.Add(Me.btnExit)
        Me.pnlPizza.Controls.Add(Me.btnSubmit)
        Me.pnlPizza.Controls.Add(Me.grpVeggies)
        Me.pnlPizza.Controls.Add(Me.grpMeats)
        Me.pnlPizza.Controls.Add(Me.grpCrust)
        Me.pnlPizza.Controls.Add(Me.grpCheese)
        Me.pnlPizza.Controls.Add(Me.grpSauce)
        Me.pnlPizza.Controls.Add(Me.grpSize)
        Me.pnlPizza.Controls.Add(Me.Label1)
        Me.pnlPizza.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlPizza.Location = New System.Drawing.Point(911, 271)
        Me.pnlPizza.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlPizza.Name = "pnlPizza"
        Me.pnlPizza.Size = New System.Drawing.Size(1410, 1021)
        Me.pnlPizza.TabIndex = 13
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(77, 893)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(142, 45)
        Me.lblQuantity.TabIndex = 11
        Me.lblQuantity.Text = "Quantity:"
        '
        'nudQuantity
        '
        Me.nudQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudQuantity.Location = New System.Drawing.Point(267, 888)
        Me.nudQuantity.Margin = New System.Windows.Forms.Padding(6)
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(98, 44)
        Me.nudQuantity.TabIndex = 21
        Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1112, 888)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(212, 69)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(631, 880)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(212, 69)
        Me.btnSubmit.TabIndex = 19
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'grpVeggies
        '
        Me.grpVeggies.BackColor = System.Drawing.Color.Transparent
        Me.grpVeggies.Controls.Add(Me.chkBananaPeppers)
        Me.grpVeggies.Controls.Add(Me.chkTomatoes)
        Me.grpVeggies.Controls.Add(Me.chkGarlic)
        Me.grpVeggies.Controls.Add(Me.chkOnion)
        Me.grpVeggies.Controls.Add(Me.chkMushrooms)
        Me.grpVeggies.Controls.Add(Me.chkBellPeppers)
        Me.grpVeggies.Controls.Add(Me.chkBlackOlives)
        Me.grpVeggies.Controls.Add(Me.chkArtichoke)
        Me.grpVeggies.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVeggies.Location = New System.Drawing.Point(84, 623)
        Me.grpVeggies.Margin = New System.Windows.Forms.Padding(6)
        Me.grpVeggies.Name = "grpVeggies"
        Me.grpVeggies.Padding = New System.Windows.Forms.Padding(6)
        Me.grpVeggies.Size = New System.Drawing.Size(878, 231)
        Me.grpVeggies.TabIndex = 18
        Me.grpVeggies.TabStop = False
        Me.grpVeggies.Text = "Veggies"
        '
        'chkBananaPeppers
        '
        Me.chkBananaPeppers.AutoSize = True
        Me.chkBananaPeppers.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBananaPeppers.Location = New System.Drawing.Point(574, 60)
        Me.chkBananaPeppers.Margin = New System.Windows.Forms.Padding(6)
        Me.chkBananaPeppers.Name = "chkBananaPeppers"
        Me.chkBananaPeppers.Size = New System.Drawing.Size(256, 49)
        Me.chkBananaPeppers.TabIndex = 21
        Me.chkBananaPeppers.Text = "Banana Peppers"
        Me.chkBananaPeppers.UseVisualStyleBackColor = True
        '
        'chkTomatoes
        '
        Me.chkTomatoes.AutoSize = True
        Me.chkTomatoes.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTomatoes.Location = New System.Drawing.Point(292, 150)
        Me.chkTomatoes.Margin = New System.Windows.Forms.Padding(6)
        Me.chkTomatoes.Name = "chkTomatoes"
        Me.chkTomatoes.Size = New System.Drawing.Size(184, 49)
        Me.chkTomatoes.TabIndex = 26
        Me.chkTomatoes.Text = "Tomatoes"
        Me.chkTomatoes.UseVisualStyleBackColor = True
        '
        'chkGarlic
        '
        Me.chkGarlic.AutoSize = True
        Me.chkGarlic.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGarlic.Location = New System.Drawing.Point(574, 104)
        Me.chkGarlic.Margin = New System.Windows.Forms.Padding(6)
        Me.chkGarlic.Name = "chkGarlic"
        Me.chkGarlic.Size = New System.Drawing.Size(131, 49)
        Me.chkGarlic.TabIndex = 25
        Me.chkGarlic.Text = "Garlic"
        Me.chkGarlic.UseVisualStyleBackColor = True
        '
        'chkOnion
        '
        Me.chkOnion.AutoSize = True
        Me.chkOnion.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOnion.Location = New System.Drawing.Point(292, 104)
        Me.chkOnion.Margin = New System.Windows.Forms.Padding(6)
        Me.chkOnion.Name = "chkOnion"
        Me.chkOnion.Size = New System.Drawing.Size(135, 49)
        Me.chkOnion.TabIndex = 25
        Me.chkOnion.Text = "Onion"
        Me.chkOnion.UseVisualStyleBackColor = True
        '
        'chkMushrooms
        '
        Me.chkMushrooms.AutoSize = True
        Me.chkMushrooms.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMushrooms.Location = New System.Drawing.Point(292, 60)
        Me.chkMushrooms.Margin = New System.Windows.Forms.Padding(6)
        Me.chkMushrooms.Name = "chkMushrooms"
        Me.chkMushrooms.Size = New System.Drawing.Size(207, 49)
        Me.chkMushrooms.TabIndex = 24
        Me.chkMushrooms.Text = "Mushrooms"
        Me.chkMushrooms.UseVisualStyleBackColor = True
        '
        'chkBellPeppers
        '
        Me.chkBellPeppers.AutoSize = True
        Me.chkBellPeppers.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBellPeppers.Location = New System.Drawing.Point(22, 150)
        Me.chkBellPeppers.Margin = New System.Windows.Forms.Padding(6)
        Me.chkBellPeppers.Name = "chkBellPeppers"
        Me.chkBellPeppers.Size = New System.Drawing.Size(211, 49)
        Me.chkBellPeppers.TabIndex = 23
        Me.chkBellPeppers.Text = "Bell Peppers"
        Me.chkBellPeppers.UseVisualStyleBackColor = True
        '
        'chkBlackOlives
        '
        Me.chkBlackOlives.AutoSize = True
        Me.chkBlackOlives.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBlackOlives.Location = New System.Drawing.Point(22, 104)
        Me.chkBlackOlives.Margin = New System.Windows.Forms.Padding(6)
        Me.chkBlackOlives.Name = "chkBlackOlives"
        Me.chkBlackOlives.Size = New System.Drawing.Size(210, 49)
        Me.chkBlackOlives.TabIndex = 22
        Me.chkBlackOlives.Text = "Black Olives"
        Me.chkBlackOlives.UseVisualStyleBackColor = True
        '
        'chkArtichoke
        '
        Me.chkArtichoke.AutoSize = True
        Me.chkArtichoke.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkArtichoke.Location = New System.Drawing.Point(22, 60)
        Me.chkArtichoke.Margin = New System.Windows.Forms.Padding(6)
        Me.chkArtichoke.Name = "chkArtichoke"
        Me.chkArtichoke.Size = New System.Drawing.Size(182, 49)
        Me.chkArtichoke.TabIndex = 21
        Me.chkArtichoke.Text = "Artichoke"
        Me.chkArtichoke.UseVisualStyleBackColor = True
        '
        'grpMeats
        '
        Me.grpMeats.BackColor = System.Drawing.Color.Transparent
        Me.grpMeats.Controls.Add(Me.chkAnchovies)
        Me.grpMeats.Controls.Add(Me.chkBacon)
        Me.grpMeats.Controls.Add(Me.chkChicken)
        Me.grpMeats.Controls.Add(Me.chkItalianSausage)
        Me.grpMeats.Controls.Add(Me.chkPepperoni)
        Me.grpMeats.Controls.Add(Me.chkLinguini)
        Me.grpMeats.Controls.Add(Me.chkHam)
        Me.grpMeats.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMeats.Location = New System.Drawing.Point(84, 371)
        Me.grpMeats.Margin = New System.Windows.Forms.Padding(6)
        Me.grpMeats.Name = "grpMeats"
        Me.grpMeats.Padding = New System.Windows.Forms.Padding(6)
        Me.grpMeats.Size = New System.Drawing.Size(878, 231)
        Me.grpMeats.TabIndex = 17
        Me.grpMeats.TabStop = False
        Me.grpMeats.Text = "Meats"
        '
        'chkAnchovies
        '
        Me.chkAnchovies.AutoSize = True
        Me.chkAnchovies.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnchovies.Location = New System.Drawing.Point(21, 152)
        Me.chkAnchovies.Margin = New System.Windows.Forms.Padding(6)
        Me.chkAnchovies.Name = "chkAnchovies"
        Me.chkAnchovies.Size = New System.Drawing.Size(185, 49)
        Me.chkAnchovies.TabIndex = 27
        Me.chkAnchovies.Text = "Anchovies"
        Me.chkAnchovies.UseVisualStyleBackColor = True
        '
        'chkBacon
        '
        Me.chkBacon.AutoSize = True
        Me.chkBacon.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBacon.Location = New System.Drawing.Point(574, 60)
        Me.chkBacon.Margin = New System.Windows.Forms.Padding(6)
        Me.chkBacon.Name = "chkBacon"
        Me.chkBacon.Size = New System.Drawing.Size(132, 49)
        Me.chkBacon.TabIndex = 21
        Me.chkBacon.Text = "Bacon"
        Me.chkBacon.UseVisualStyleBackColor = True
        '
        'chkChicken
        '
        Me.chkChicken.AutoSize = True
        Me.chkChicken.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChicken.Location = New System.Drawing.Point(292, 104)
        Me.chkChicken.Margin = New System.Windows.Forms.Padding(6)
        Me.chkChicken.Name = "chkChicken"
        Me.chkChicken.Size = New System.Drawing.Size(158, 49)
        Me.chkChicken.TabIndex = 25
        Me.chkChicken.Text = "Chicken"
        Me.chkChicken.UseVisualStyleBackColor = True
        '
        'chkItalianSausage
        '
        Me.chkItalianSausage.AutoSize = True
        Me.chkItalianSausage.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkItalianSausage.Location = New System.Drawing.Point(22, 104)
        Me.chkItalianSausage.Margin = New System.Windows.Forms.Padding(6)
        Me.chkItalianSausage.Name = "chkItalianSausage"
        Me.chkItalianSausage.Size = New System.Drawing.Size(238, 49)
        Me.chkItalianSausage.TabIndex = 24
        Me.chkItalianSausage.Text = "Italian Sausage"
        Me.chkItalianSausage.UseVisualStyleBackColor = True
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPepperoni.Location = New System.Drawing.Point(22, 60)
        Me.chkPepperoni.Margin = New System.Windows.Forms.Padding(6)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(184, 49)
        Me.chkPepperoni.TabIndex = 23
        Me.chkPepperoni.Text = "Pepperoni"
        Me.chkPepperoni.UseVisualStyleBackColor = True
        '
        'chkLinguini
        '
        Me.chkLinguini.AutoSize = True
        Me.chkLinguini.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLinguini.Location = New System.Drawing.Point(574, 104)
        Me.chkLinguini.Margin = New System.Windows.Forms.Padding(6)
        Me.chkLinguini.Name = "chkLinguini"
        Me.chkLinguini.Size = New System.Drawing.Size(151, 49)
        Me.chkLinguini.TabIndex = 22
        Me.chkLinguini.Text = "Linguini"
        Me.chkLinguini.UseVisualStyleBackColor = True
        '
        'chkHam
        '
        Me.chkHam.AutoSize = True
        Me.chkHam.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHam.Location = New System.Drawing.Point(292, 60)
        Me.chkHam.Margin = New System.Windows.Forms.Padding(6)
        Me.chkHam.Name = "chkHam"
        Me.chkHam.Size = New System.Drawing.Size(114, 49)
        Me.chkHam.TabIndex = 20
        Me.chkHam.Text = "Ham"
        Me.chkHam.UseVisualStyleBackColor = True
        '
        'grpCrust
        '
        Me.grpCrust.BackColor = System.Drawing.Color.Transparent
        Me.grpCrust.Controls.Add(Me.rdoStuffed)
        Me.grpCrust.Controls.Add(Me.rdoPan)
        Me.grpCrust.Controls.Add(Me.rdoOriginal)
        Me.grpCrust.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCrust.Location = New System.Drawing.Point(396, 112)
        Me.grpCrust.Margin = New System.Windows.Forms.Padding(6)
        Me.grpCrust.Name = "grpCrust"
        Me.grpCrust.Padding = New System.Windows.Forms.Padding(6)
        Me.grpCrust.Size = New System.Drawing.Size(260, 231)
        Me.grpCrust.TabIndex = 14
        Me.grpCrust.TabStop = False
        Me.grpCrust.Text = "Crust"
        '
        'rdoStuffed
        '
        Me.rdoStuffed.AutoSize = True
        Me.rdoStuffed.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoStuffed.Location = New System.Drawing.Point(22, 148)
        Me.rdoStuffed.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoStuffed.Name = "rdoStuffed"
        Me.rdoStuffed.Size = New System.Drawing.Size(140, 49)
        Me.rdoStuffed.TabIndex = 13
        Me.rdoStuffed.TabStop = True
        Me.rdoStuffed.Text = "Stuffed"
        Me.rdoStuffed.UseVisualStyleBackColor = True
        '
        'rdoPan
        '
        Me.rdoPan.AutoSize = True
        Me.rdoPan.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPan.Location = New System.Drawing.Point(22, 102)
        Me.rdoPan.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoPan.Name = "rdoPan"
        Me.rdoPan.Size = New System.Drawing.Size(97, 49)
        Me.rdoPan.TabIndex = 1
        Me.rdoPan.TabStop = True
        Me.rdoPan.Text = "Pan"
        Me.rdoPan.UseVisualStyleBackColor = True
        '
        'rdoOriginal
        '
        Me.rdoOriginal.AutoSize = True
        Me.rdoOriginal.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoOriginal.Location = New System.Drawing.Point(22, 58)
        Me.rdoOriginal.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoOriginal.Name = "rdoOriginal"
        Me.rdoOriginal.Size = New System.Drawing.Size(155, 49)
        Me.rdoOriginal.TabIndex = 0
        Me.rdoOriginal.TabStop = True
        Me.rdoOriginal.Text = "Original"
        Me.rdoOriginal.UseVisualStyleBackColor = True
        '
        'grpCheese
        '
        Me.grpCheese.BackColor = System.Drawing.Color.Transparent
        Me.grpCheese.Controls.Add(Me.rdoExtraCheese)
        Me.grpCheese.Controls.Add(Me.rdoNormalCheese)
        Me.grpCheese.Controls.Add(Me.rdoLightCheese)
        Me.grpCheese.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCheese.Location = New System.Drawing.Point(1064, 119)
        Me.grpCheese.Margin = New System.Windows.Forms.Padding(6)
        Me.grpCheese.Name = "grpCheese"
        Me.grpCheese.Padding = New System.Windows.Forms.Padding(6)
        Me.grpCheese.Size = New System.Drawing.Size(260, 231)
        Me.grpCheese.TabIndex = 16
        Me.grpCheese.TabStop = False
        Me.grpCheese.Text = "Cheese"
        '
        'rdoExtraCheese
        '
        Me.rdoExtraCheese.AutoSize = True
        Me.rdoExtraCheese.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoExtraCheese.Location = New System.Drawing.Point(22, 148)
        Me.rdoExtraCheese.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoExtraCheese.Name = "rdoExtraCheese"
        Me.rdoExtraCheese.Size = New System.Drawing.Size(121, 49)
        Me.rdoExtraCheese.TabIndex = 13
        Me.rdoExtraCheese.TabStop = True
        Me.rdoExtraCheese.Text = "Extra"
        Me.rdoExtraCheese.UseVisualStyleBackColor = True
        '
        'rdoNormalCheese
        '
        Me.rdoNormalCheese.AutoSize = True
        Me.rdoNormalCheese.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoNormalCheese.Location = New System.Drawing.Point(22, 102)
        Me.rdoNormalCheese.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoNormalCheese.Name = "rdoNormalCheese"
        Me.rdoNormalCheese.Size = New System.Drawing.Size(153, 49)
        Me.rdoNormalCheese.TabIndex = 1
        Me.rdoNormalCheese.TabStop = True
        Me.rdoNormalCheese.Text = "Normal"
        Me.rdoNormalCheese.UseVisualStyleBackColor = True
        '
        'rdoLightCheese
        '
        Me.rdoLightCheese.AutoSize = True
        Me.rdoLightCheese.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLightCheese.Location = New System.Drawing.Point(22, 58)
        Me.rdoLightCheese.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoLightCheese.Name = "rdoLightCheese"
        Me.rdoLightCheese.Size = New System.Drawing.Size(115, 49)
        Me.rdoLightCheese.TabIndex = 0
        Me.rdoLightCheese.TabStop = True
        Me.rdoLightCheese.Text = "Light"
        Me.rdoLightCheese.UseVisualStyleBackColor = True
        '
        'grpSauce
        '
        Me.grpSauce.BackColor = System.Drawing.Color.Transparent
        Me.grpSauce.Controls.Add(Me.rdoSauceBarbeque)
        Me.grpSauce.Controls.Add(Me.rdoSauceAlfredo)
        Me.grpSauce.Controls.Add(Me.rdoSauceTomato)
        Me.grpSauce.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSauce.Location = New System.Drawing.Point(758, 112)
        Me.grpSauce.Margin = New System.Windows.Forms.Padding(6)
        Me.grpSauce.Name = "grpSauce"
        Me.grpSauce.Padding = New System.Windows.Forms.Padding(6)
        Me.grpSauce.Size = New System.Drawing.Size(210, 231)
        Me.grpSauce.TabIndex = 15
        Me.grpSauce.TabStop = False
        Me.grpSauce.Text = "Sauce"
        '
        'rdoSauceBarbeque
        '
        Me.rdoSauceBarbeque.AutoSize = True
        Me.rdoSauceBarbeque.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSauceBarbeque.Location = New System.Drawing.Point(22, 148)
        Me.rdoSauceBarbeque.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoSauceBarbeque.Name = "rdoSauceBarbeque"
        Me.rdoSauceBarbeque.Size = New System.Drawing.Size(174, 49)
        Me.rdoSauceBarbeque.TabIndex = 13
        Me.rdoSauceBarbeque.TabStop = True
        Me.rdoSauceBarbeque.Text = "Barbeque"
        Me.rdoSauceBarbeque.UseVisualStyleBackColor = True
        '
        'rdoSauceAlfredo
        '
        Me.rdoSauceAlfredo.AutoSize = True
        Me.rdoSauceAlfredo.BackColor = System.Drawing.Color.Transparent
        Me.rdoSauceAlfredo.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSauceAlfredo.Location = New System.Drawing.Point(22, 102)
        Me.rdoSauceAlfredo.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoSauceAlfredo.Name = "rdoSauceAlfredo"
        Me.rdoSauceAlfredo.Size = New System.Drawing.Size(149, 49)
        Me.rdoSauceAlfredo.TabIndex = 1
        Me.rdoSauceAlfredo.TabStop = True
        Me.rdoSauceAlfredo.Text = "Alfredo"
        Me.rdoSauceAlfredo.UseVisualStyleBackColor = False
        '
        'rdoSauceTomato
        '
        Me.rdoSauceTomato.AutoSize = True
        Me.rdoSauceTomato.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSauceTomato.Location = New System.Drawing.Point(22, 58)
        Me.rdoSauceTomato.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoSauceTomato.Name = "rdoSauceTomato"
        Me.rdoSauceTomato.Size = New System.Drawing.Size(156, 49)
        Me.rdoSauceTomato.TabIndex = 0
        Me.rdoSauceTomato.TabStop = True
        Me.rdoSauceTomato.Text = "Tomato"
        Me.rdoSauceTomato.UseVisualStyleBackColor = True
        '
        'grpSize
        '
        Me.grpSize.BackColor = System.Drawing.Color.Transparent
        Me.grpSize.Controls.Add(Me.rdoLarge)
        Me.grpSize.Controls.Add(Me.rdoMedium)
        Me.grpSize.Controls.Add(Me.rdoSmall)
        Me.grpSize.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSize.Location = New System.Drawing.Point(84, 112)
        Me.grpSize.Margin = New System.Windows.Forms.Padding(6)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Padding = New System.Windows.Forms.Padding(6)
        Me.grpSize.Size = New System.Drawing.Size(210, 231)
        Me.grpSize.TabIndex = 12
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "Size"
        '
        'rdoLarge
        '
        Me.rdoLarge.AutoSize = True
        Me.rdoLarge.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLarge.Location = New System.Drawing.Point(22, 148)
        Me.rdoLarge.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoLarge.Name = "rdoLarge"
        Me.rdoLarge.Size = New System.Drawing.Size(123, 49)
        Me.rdoLarge.TabIndex = 13
        Me.rdoLarge.TabStop = True
        Me.rdoLarge.Text = "Large"
        Me.rdoLarge.UseVisualStyleBackColor = True
        '
        'rdoMedium
        '
        Me.rdoMedium.AutoSize = True
        Me.rdoMedium.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMedium.Location = New System.Drawing.Point(22, 102)
        Me.rdoMedium.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoMedium.Name = "rdoMedium"
        Me.rdoMedium.Size = New System.Drawing.Size(155, 49)
        Me.rdoMedium.TabIndex = 1
        Me.rdoMedium.TabStop = True
        Me.rdoMedium.Text = "Medium"
        Me.rdoMedium.UseVisualStyleBackColor = True
        '
        'rdoSmall
        '
        Me.rdoSmall.AutoSize = True
        Me.rdoSmall.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSmall.Location = New System.Drawing.Point(22, 58)
        Me.rdoSmall.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoSmall.Name = "rdoSmall"
        Me.rdoSmall.Size = New System.Drawing.Size(119, 49)
        Me.rdoSmall.TabIndex = 0
        Me.rdoSmall.TabStop = True
        Me.rdoSmall.Text = "Small"
        Me.rdoSmall.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 16.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(532, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 62)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Pizza Creator"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(2338, 1307)
        Me.Controls.Add(Me.Frame)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Gino's POS"
        Me.Frame.ResumeLayout(False)
        Me.pnlOrderOnline.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlOrderInfo.ResumeLayout(False)
        Me.pnlOrderInfo.PerformLayout()
        Me.pnlAddress.ResumeLayout(False)
        Me.pnlAddress.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPizza.ResumeLayout(False)
        Me.pnlPizza.PerformLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpVeggies.ResumeLayout(False)
        Me.grpVeggies.PerformLayout()
        Me.grpMeats.ResumeLayout(False)
        Me.grpMeats.PerformLayout()
        Me.grpCrust.ResumeLayout(False)
        Me.grpCrust.PerformLayout()
        Me.grpCheese.ResumeLayout(False)
        Me.grpCheese.PerformLayout()
        Me.grpSauce.ResumeLayout(False)
        Me.grpSauce.PerformLayout()
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Frame As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlAddress As Panel
    Friend WithEvents lblStreetAddress As Label
    Friend WithEvents lblZipCode As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents pnlPizza As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents grpCheese As GroupBox
    Friend WithEvents rdoExtraCheese As RadioButton
    Friend WithEvents rdoNormalCheese As RadioButton
    Friend WithEvents rdoLightCheese As RadioButton
    Friend WithEvents grpSauce As GroupBox
    Friend WithEvents rdoSauceBarbeque As RadioButton
    Friend WithEvents rdoSauceAlfredo As RadioButton
    Friend WithEvents rdoSauceTomato As RadioButton
    Friend WithEvents grpCrust As GroupBox
    Friend WithEvents rdoStuffed As RadioButton
    Friend WithEvents rdoPan As RadioButton
    Friend WithEvents rdoOriginal As RadioButton
    Friend WithEvents grpSize As GroupBox
    Friend WithEvents rdoLarge As RadioButton
    Friend WithEvents rdoMedium As RadioButton
    Friend WithEvents rdoSmall As RadioButton
    Friend WithEvents grpVeggies As GroupBox
    Friend WithEvents grpMeats As GroupBox
    Friend WithEvents picPizza As PictureBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents chkBananaPeppers As CheckBox
    Friend WithEvents chkTomatoes As CheckBox
    Friend WithEvents chkOnion As CheckBox
    Friend WithEvents chkMushrooms As CheckBox
    Friend WithEvents chkBellPeppers As CheckBox
    Friend WithEvents chkBlackOlives As CheckBox
    Friend WithEvents chkArtichoke As CheckBox
    Friend WithEvents chkAnchovies As CheckBox
    Friend WithEvents chkBacon As CheckBox
    Friend WithEvents chkChicken As CheckBox
    Friend WithEvents chkItalianSausage As CheckBox
    Friend WithEvents chkPepperoni As CheckBox
    Friend WithEvents chkLinguini As CheckBox
    Friend WithEvents chkHam As CheckBox
    Friend WithEvents pnlOrderOnline As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents lblQuantity As Label
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlOrderInfo As Panel
    Friend WithEvents rdoTakeout As RadioButton
    Friend WithEvents rdoDelivery As RadioButton
    Friend WithEvents txtPhoneNumber As MaskedTextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents chkGarlic As CheckBox
End Class
