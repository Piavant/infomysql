<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmComBD
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComBD))
        Me.LstTabE = New System.Windows.Forms.ListBox()
        Me.LstErro = New System.Windows.Forms.ListBox()
        Me.LblMSql = New System.Windows.Forms.Label()
        Me.BtnCoBD = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblBaDD = New System.Windows.Forms.Label()
        Me.LblBaDO = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.LblPuer = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblTipO = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblTipD = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LblPKeD = New System.Windows.Forms.Label()
        Me.LblPkeO = New System.Windows.Forms.Label()
        Me.LblNulD = New System.Windows.Forms.Label()
        Me.LblNulO = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.LblVaPD = New System.Windows.Forms.Label()
        Me.LblVaPO = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LblAInD = New System.Windows.Forms.Label()
        Me.LblAInO = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.LblPosD = New System.Windows.Forms.Label()
        Me.LblPosO = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.BtnCamb = New System.Windows.Forms.Button()
        Me.BtnCopi = New System.Windows.Forms.Button()
        Me.BtnRepa = New System.Windows.Forms.Button()
        Me.CheSiTo = New System.Windows.Forms.CheckBox()
        Me.ChePosi = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnRepT = New System.Windows.Forms.Button()
        Me.CheNoMo = New System.Windows.Forms.CheckBox()
        Me.CheNMIn = New System.Windows.Forms.CheckBox()
        Me.CheFk = New System.Windows.Forms.CheckBox()
        Me.FraCamp = New System.Windows.Forms.GroupBox()
        Me.LblCamp = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FraIndice = New System.Windows.Forms.GroupBox()
        Me.LstIndD = New System.Windows.Forms.ListBox()
        Me.LstIndO = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LblIndi = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FraTabla = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblTiTO = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.LblTiTD = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.LblNTab = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CheIgFK = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.FraCamp.SuspendLayout()
        Me.FraIndice.SuspendLayout()
        Me.FraTabla.SuspendLayout()
        Me.SuspendLayout()
        '
        'LstTabE
        '
        Me.LstTabE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LstTabE.FormattingEnabled = True
        Me.LstTabE.Location = New System.Drawing.Point(8, 114)
        Me.LstTabE.Name = "LstTabE"
        Me.LstTabE.Size = New System.Drawing.Size(206, 264)
        Me.LstTabE.TabIndex = 0
        '
        'LstErro
        '
        Me.LstErro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstErro.FormattingEnabled = True
        Me.LstErro.Location = New System.Drawing.Point(227, 114)
        Me.LstErro.Name = "LstErro"
        Me.LstErro.Size = New System.Drawing.Size(451, 264)
        Me.LstErro.TabIndex = 1
        '
        'LblMSql
        '
        Me.LblMSql.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblMSql.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMSql.Location = New System.Drawing.Point(87, 22)
        Me.LblMSql.Name = "LblMSql"
        Me.LblMSql.Size = New System.Drawing.Size(319, 18)
        Me.LblMSql.TabIndex = 2
        Me.LblMSql.Text = "localhost"
        '
        'BtnCoBD
        '
        Me.BtnCoBD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCoBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCoBD.Location = New System.Drawing.Point(665, 497)
        Me.BtnCoBD.Name = "BtnCoBD"
        Me.BtnCoBD.Size = New System.Drawing.Size(84, 46)
        Me.BtnCoBD.TabIndex = 3
        Me.BtnCoBD.Text = "Compara B.D."
        Me.ToolTip1.SetToolTip(Me.BtnCoBD, "Compara las Bases de Datos Origen / Destino")
        Me.BtnCoBD.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LblBaDD)
        Me.GroupBox1.Controls.Add(Me.LblBaDO)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LblPass)
        Me.GroupBox1.Controls.Add(Me.LblUser)
        Me.GroupBox1.Controls.Add(Me.LblPuer)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LblMSql)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(902, 80)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "B.D. a comparar"
        '
        'LblBaDD
        '
        Me.LblBaDD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblBaDD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblBaDD.Location = New System.Drawing.Point(525, 50)
        Me.LblBaDD.Name = "LblBaDD"
        Me.LblBaDD.Size = New System.Drawing.Size(253, 18)
        Me.LblBaDD.TabIndex = 23
        Me.LblBaDD.Text = "avantgesbases"
        '
        'LblBaDO
        '
        Me.LblBaDO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblBaDO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblBaDO.Location = New System.Drawing.Point(87, 50)
        Me.LblBaDO.Name = "LblBaDO"
        Me.LblBaDO.Size = New System.Drawing.Size(253, 18)
        Me.LblBaDO.TabIndex = 22
        Me.LblBaDO.Text = "avantges"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(447, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "B.D. Destino"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "B.D. Origen"
        '
        'LblPass
        '
        Me.LblPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPass.Location = New System.Drawing.Point(799, 22)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(80, 18)
        Me.LblPass.TabIndex = 19
        Me.LblPass.Text = "1234"
        '
        'LblUser
        '
        Me.LblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblUser.Location = New System.Drawing.Point(595, 22)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(111, 18)
        Me.LblUser.TabIndex = 18
        Me.LblUser.Text = "root"
        '
        'LblPuer
        '
        Me.LblPuer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPuer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPuer.Location = New System.Drawing.Point(471, 22)
        Me.LblPuer.Name = "LblPuer"
        Me.LblPuer.Size = New System.Drawing.Size(52, 18)
        Me.LblPuer.TabIndex = 17
        Me.LblPuer.Text = "3306"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(729, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Contraseña..."
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(543, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Usuario..."
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(424, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Puerto..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Server........"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(8, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Tabla con errores..."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(223, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Errores..."
        '
        'LblTipO
        '
        Me.LblTipO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTipO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipO.Location = New System.Drawing.Point(265, 32)
        Me.LblTipO.Name = "LblTipO"
        Me.LblTipO.Size = New System.Drawing.Size(157, 18)
        Me.LblTipO.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(191, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 18)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Origen..."
        '
        'LblTipD
        '
        Me.LblTipD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTipD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipD.Location = New System.Drawing.Point(265, 59)
        Me.LblTipD.Name = "LblTipD"
        Me.LblTipD.Size = New System.Drawing.Size(157, 18)
        Me.LblTipD.TabIndex = 28
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(191, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 18)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Destino..."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(261, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 18)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Tipo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(426, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 18)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "P.Key"
        '
        'LblPKeD
        '
        Me.LblPKeD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPKeD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPKeD.Location = New System.Drawing.Point(425, 59)
        Me.LblPKeD.Name = "LblPKeD"
        Me.LblPKeD.Size = New System.Drawing.Size(49, 18)
        Me.LblPKeD.TabIndex = 32
        '
        'LblPkeO
        '
        Me.LblPkeO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPkeO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPkeO.Location = New System.Drawing.Point(425, 32)
        Me.LblPkeO.Name = "LblPkeO"
        Me.LblPkeO.Size = New System.Drawing.Size(49, 18)
        Me.LblPkeO.TabIndex = 31
        '
        'LblNulD
        '
        Me.LblNulD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNulD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNulD.Location = New System.Drawing.Point(474, 59)
        Me.LblNulD.Name = "LblNulD"
        Me.LblNulD.Size = New System.Drawing.Size(49, 18)
        Me.LblNulD.TabIndex = 35
        '
        'LblNulO
        '
        Me.LblNulO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNulO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNulO.Location = New System.Drawing.Point(474, 32)
        Me.LblNulO.Name = "LblNulO"
        Me.LblNulO.Size = New System.Drawing.Size(49, 18)
        Me.LblNulO.TabIndex = 34
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Blue
        Me.Label23.Location = New System.Drawing.Point(474, 13)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 18)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "N.Null"
        '
        'LblVaPD
        '
        Me.LblVaPD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblVaPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVaPD.Location = New System.Drawing.Point(523, 59)
        Me.LblVaPD.Name = "LblVaPD"
        Me.LblVaPD.Size = New System.Drawing.Size(49, 18)
        Me.LblVaPD.TabIndex = 38
        '
        'LblVaPO
        '
        Me.LblVaPO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblVaPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVaPO.Location = New System.Drawing.Point(523, 32)
        Me.LblVaPO.Name = "LblVaPO"
        Me.LblVaPO.Size = New System.Drawing.Size(49, 18)
        Me.LblVaPO.TabIndex = 37
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(518, 13)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(59, 18)
        Me.Label26.TabIndex = 36
        Me.Label26.Text = "Val.Pre."
        '
        'LblAInD
        '
        Me.LblAInD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAInD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAInD.Location = New System.Drawing.Point(572, 59)
        Me.LblAInD.Name = "LblAInD"
        Me.LblAInD.Size = New System.Drawing.Size(49, 18)
        Me.LblAInD.TabIndex = 41
        '
        'LblAInO
        '
        Me.LblAInO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAInO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAInO.Location = New System.Drawing.Point(572, 32)
        Me.LblAInO.Name = "LblAInO"
        Me.LblAInO.Size = New System.Drawing.Size(49, 18)
        Me.LblAInO.TabIndex = 40
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Blue
        Me.Label29.Location = New System.Drawing.Point(574, 14)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 18)
        Me.Label29.TabIndex = 39
        Me.Label29.Text = "A.Inc."
        '
        'LblPosD
        '
        Me.LblPosD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPosD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPosD.Location = New System.Drawing.Point(624, 59)
        Me.LblPosD.Name = "LblPosD"
        Me.LblPosD.Size = New System.Drawing.Size(92, 18)
        Me.LblPosD.TabIndex = 47
        '
        'LblPosO
        '
        Me.LblPosO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPosO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPosO.Location = New System.Drawing.Point(624, 32)
        Me.LblPosO.Name = "LblPosO"
        Me.LblPosO.Size = New System.Drawing.Size(92, 18)
        Me.LblPosO.TabIndex = 46
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Blue
        Me.Label35.Location = New System.Drawing.Point(672, 13)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(39, 18)
        Me.Label35.TabIndex = 45
        Me.Label35.Text = "Pos."
        '
        'BtnCamb
        '
        Me.BtnCamb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCamb.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCamb.Location = New System.Drawing.Point(564, 497)
        Me.BtnCamb.Name = "BtnCamb"
        Me.BtnCamb.Size = New System.Drawing.Size(84, 46)
        Me.BtnCamb.TabIndex = 48
        Me.BtnCamb.Text = "<>"
        Me.ToolTip1.SetToolTip(Me.BtnCamb, "Intercambia las Bases de Datos Origen / Destino")
        Me.BtnCamb.UseVisualStyleBackColor = True
        '
        'BtnCopi
        '
        Me.BtnCopi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCopi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopi.Location = New System.Drawing.Point(397, 497)
        Me.BtnCopi.Name = "BtnCopi"
        Me.BtnCopi.Size = New System.Drawing.Size(84, 46)
        Me.BtnCopi.TabIndex = 49
        Me.BtnCopi.Text = "Copiar"
        Me.ToolTip1.SetToolTip(Me.BtnCopi, "Repara el error especifico seleccionado")
        Me.BtnCopi.UseVisualStyleBackColor = True
        Me.BtnCopi.Visible = False
        '
        'BtnRepa
        '
        Me.BtnRepa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnRepa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRepa.Location = New System.Drawing.Point(292, 497)
        Me.BtnRepa.Name = "BtnRepa"
        Me.BtnRepa.Size = New System.Drawing.Size(84, 46)
        Me.BtnRepa.TabIndex = 50
        Me.BtnRepa.Text = "Reparar Tabla"
        Me.ToolTip1.SetToolTip(Me.BtnRepa, "Repara TODOS los errores en la tabla seleccionada")
        Me.BtnRepa.UseVisualStyleBackColor = True
        Me.BtnRepa.Visible = False
        '
        'CheSiTo
        '
        Me.CheSiTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheSiTo.AutoSize = True
        Me.CheSiTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheSiTo.Location = New System.Drawing.Point(12, 512)
        Me.CheSiTo.Name = "CheSiTo"
        Me.CheSiTo.Size = New System.Drawing.Size(68, 17)
        Me.CheSiTo.TabIndex = 51
        Me.CheSiTo.Text = "Si a todo"
        Me.ToolTip1.SetToolTip(Me.CheSiTo, "Asume SI a todas la preguntas de confirmacion de reparación")
        Me.CheSiTo.UseVisualStyleBackColor = True
        '
        'ChePosi
        '
        Me.ChePosi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChePosi.AutoSize = True
        Me.ChePosi.Location = New System.Drawing.Point(759, 514)
        Me.ChePosi.Name = "ChePosi"
        Me.ChePosi.Size = New System.Drawing.Size(140, 17)
        Me.ChePosi.TabIndex = 52
        Me.ChePosi.Text = "Comprobar pos. campos"
        Me.ToolTip1.SetToolTip(Me.ChePosi, "Comprueba la posicion de los campos en las Bases de datos")
        Me.ChePosi.UseVisualStyleBackColor = True
        '
        'BtnRepT
        '
        Me.BtnRepT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnRepT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRepT.Location = New System.Drawing.Point(194, 497)
        Me.BtnRepT.Name = "BtnRepT"
        Me.BtnRepT.Size = New System.Drawing.Size(84, 46)
        Me.BtnRepT.TabIndex = 53
        Me.BtnRepT.Text = "Reparar TODO"
        Me.ToolTip1.SetToolTip(Me.BtnRepT, "Repara TODOS los errores en TODAS las tablas")
        Me.BtnRepT.UseVisualStyleBackColor = True
        Me.BtnRepT.Visible = False
        '
        'CheNoMo
        '
        Me.CheNoMo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheNoMo.AutoSize = True
        Me.CheNoMo.Location = New System.Drawing.Point(12, 495)
        Me.CheNoMo.Name = "CheNoMo"
        Me.CheNoMo.Size = New System.Drawing.Size(176, 17)
        Me.CheNoMo.TabIndex = 54
        Me.CheNoMo.Text = "No mostrar msj. de confirmación"
        Me.ToolTip1.SetToolTip(Me.CheNoMo, "No muestra mensajes de confirmacion de operación realizada correcamente")
        Me.CheNoMo.UseVisualStyleBackColor = True
        '
        'CheNMIn
        '
        Me.CheNMIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheNMIn.AutoSize = True
        Me.CheNMIn.Location = New System.Drawing.Point(759, 497)
        Me.CheNMIn.Name = "CheNMIn"
        Me.CheNMIn.Size = New System.Drawing.Size(151, 17)
        Me.CheNMIn.TabIndex = 58
        Me.CheNMIn.Text = "No mostrar errs. de indices"
        Me.ToolTip1.SetToolTip(Me.CheNMIn, "No muestra mensajes de confirmacion de operación realizada correcamente")
        Me.CheNMIn.UseVisualStyleBackColor = True
        '
        'CheFk
        '
        Me.CheFk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheFk.AutoSize = True
        Me.CheFk.Location = New System.Drawing.Point(759, 531)
        Me.CheFk.Name = "CheFk"
        Me.CheFk.Size = New System.Drawing.Size(123, 17)
        Me.CheFk.TabIndex = 59
        Me.CheFk.Text = "Verificar Foreing Key"
        Me.ToolTip1.SetToolTip(Me.CheFk, "Revisa las foreing keys")
        Me.CheFk.UseVisualStyleBackColor = True
        '
        'FraCamp
        '
        Me.FraCamp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraCamp.Controls.Add(Me.Label17)
        Me.FraCamp.Controls.Add(Me.Label14)
        Me.FraCamp.Controls.Add(Me.LblTipO)
        Me.FraCamp.Controls.Add(Me.Label16)
        Me.FraCamp.Controls.Add(Me.LblTipD)
        Me.FraCamp.Controls.Add(Me.Label18)
        Me.FraCamp.Controls.Add(Me.LblPkeO)
        Me.FraCamp.Controls.Add(Me.LblPKeD)
        Me.FraCamp.Controls.Add(Me.LblCamp)
        Me.FraCamp.Controls.Add(Me.LblPosD)
        Me.FraCamp.Controls.Add(Me.Label11)
        Me.FraCamp.Controls.Add(Me.Label23)
        Me.FraCamp.Controls.Add(Me.LblPosO)
        Me.FraCamp.Controls.Add(Me.LblNulO)
        Me.FraCamp.Controls.Add(Me.Label35)
        Me.FraCamp.Controls.Add(Me.LblNulD)
        Me.FraCamp.Controls.Add(Me.LblAInD)
        Me.FraCamp.Controls.Add(Me.Label26)
        Me.FraCamp.Controls.Add(Me.LblAInO)
        Me.FraCamp.Controls.Add(Me.LblVaPO)
        Me.FraCamp.Controls.Add(Me.Label29)
        Me.FraCamp.Controls.Add(Me.LblVaPD)
        Me.FraCamp.Location = New System.Drawing.Point(8, 385)
        Me.FraCamp.Name = "FraCamp"
        Me.FraCamp.Size = New System.Drawing.Size(905, 86)
        Me.FraCamp.TabIndex = 55
        Me.FraCamp.TabStop = False
        Me.FraCamp.Visible = False
        '
        'LblCamp
        '
        Me.LblCamp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCamp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCamp.Location = New System.Drawing.Point(14, 32)
        Me.LblCamp.Name = "LblCamp"
        Me.LblCamp.Size = New System.Drawing.Size(157, 18)
        Me.LblCamp.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(10, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Campo..."
        '
        'FraIndice
        '
        Me.FraIndice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraIndice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FraIndice.Controls.Add(Me.LstIndD)
        Me.FraIndice.Controls.Add(Me.LstIndO)
        Me.FraIndice.Controls.Add(Me.Label13)
        Me.FraIndice.Controls.Add(Me.Label19)
        Me.FraIndice.Controls.Add(Me.LblIndi)
        Me.FraIndice.Controls.Add(Me.Label8)
        Me.FraIndice.Location = New System.Drawing.Point(684, 131)
        Me.FraIndice.Name = "FraIndice"
        Me.FraIndice.Size = New System.Drawing.Size(229, 248)
        Me.FraIndice.TabIndex = 56
        Me.FraIndice.TabStop = False
        Me.FraIndice.Visible = False
        '
        'LstIndD
        '
        Me.LstIndD.FormattingEnabled = True
        Me.LstIndD.Location = New System.Drawing.Point(11, 181)
        Me.LstIndD.MultiColumn = True
        Me.LstIndD.Name = "LstIndD"
        Me.LstIndD.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.LstIndD.Size = New System.Drawing.Size(202, 56)
        Me.LstIndD.TabIndex = 52
        '
        'LstIndO
        '
        Me.LstIndO.FormattingEnabled = True
        Me.LstIndO.Location = New System.Drawing.Point(12, 87)
        Me.LstIndO.MultiColumn = True
        Me.LstIndO.Name = "LstIndO"
        Me.LstIndO.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.LstIndO.Size = New System.Drawing.Size(202, 56)
        Me.LstIndO.TabIndex = 51
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 18)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Origen..."
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 160)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 18)
        Me.Label19.TabIndex = 50
        Me.Label19.Text = "Destino..."
        '
        'LblIndi
        '
        Me.LblIndi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblIndi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIndi.Location = New System.Drawing.Point(11, 35)
        Me.LblIndi.Name = "LblIndi"
        Me.LblIndi.Size = New System.Drawing.Size(155, 18)
        Me.LblIndi.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(11, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Indice..."
        '
        'FraTabla
        '
        Me.FraTabla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraTabla.Controls.Add(Me.Label7)
        Me.FraTabla.Controls.Add(Me.Label12)
        Me.FraTabla.Controls.Add(Me.LblTiTO)
        Me.FraTabla.Controls.Add(Me.Label22)
        Me.FraTabla.Controls.Add(Me.LblTiTD)
        Me.FraTabla.Controls.Add(Me.Label25)
        Me.FraTabla.Controls.Add(Me.Label27)
        Me.FraTabla.Controls.Add(Me.Label28)
        Me.FraTabla.Controls.Add(Me.Label30)
        Me.FraTabla.Controls.Add(Me.Label31)
        Me.FraTabla.Controls.Add(Me.Label32)
        Me.FraTabla.Controls.Add(Me.Label33)
        Me.FraTabla.Controls.Add(Me.Label34)
        Me.FraTabla.Controls.Add(Me.Label36)
        Me.FraTabla.Controls.Add(Me.Label37)
        Me.FraTabla.Controls.Add(Me.LblNTab)
        Me.FraTabla.Controls.Add(Me.Label20)
        Me.FraTabla.Location = New System.Drawing.Point(5, 256)
        Me.FraTabla.Name = "FraTabla"
        Me.FraTabla.Size = New System.Drawing.Size(905, 86)
        Me.FraTabla.TabIndex = 57
        Me.FraTabla.TabStop = False
        Me.FraTabla.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(248, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 18)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Tipo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(178, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 18)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Origen..."
        '
        'LblTiTO
        '
        Me.LblTiTO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTiTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTiTO.Location = New System.Drawing.Point(252, 35)
        Me.LblTiTO.Name = "LblTiTO"
        Me.LblTiTO.Size = New System.Drawing.Size(157, 18)
        Me.LblTiTO.TabIndex = 49
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(178, 62)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 18)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "Destino..."
        '
        'LblTiTD
        '
        Me.LblTiTD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTiTD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTiTD.Location = New System.Drawing.Point(252, 62)
        Me.LblTiTD.Name = "LblTiTD"
        Me.LblTiTD.Size = New System.Drawing.Size(157, 18)
        Me.LblTiTD.TabIndex = 51
        '
        'Label25
        '
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(412, 35)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(49, 18)
        Me.Label25.TabIndex = 53
        '
        'Label27
        '
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(412, 62)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 18)
        Me.Label27.TabIndex = 54
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(611, 62)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(92, 18)
        Me.Label28.TabIndex = 62
        '
        'Label30
        '
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(611, 35)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(92, 18)
        Me.Label30.TabIndex = 61
        '
        'Label31
        '
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(461, 35)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(49, 18)
        Me.Label31.TabIndex = 55
        '
        'Label32
        '
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(461, 62)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(49, 18)
        Me.Label32.TabIndex = 56
        '
        'Label33
        '
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(559, 62)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(49, 18)
        Me.Label33.TabIndex = 60
        '
        'Label34
        '
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(559, 35)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(49, 18)
        Me.Label34.TabIndex = 59
        '
        'Label36
        '
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(510, 35)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(49, 18)
        Me.Label36.TabIndex = 57
        '
        'Label37
        '
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(510, 62)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(49, 18)
        Me.Label37.TabIndex = 58
        '
        'LblNTab
        '
        Me.LblNTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNTab.Location = New System.Drawing.Point(11, 35)
        Me.LblNTab.Name = "LblNTab"
        Me.LblNTab.Size = New System.Drawing.Size(155, 18)
        Me.LblNTab.TabIndex = 26
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(7, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 20)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Tabla..."
        '
        'CheIgFK
        '
        Me.CheIgFK.AutoSize = True
        Me.CheIgFK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheIgFK.ForeColor = System.Drawing.Color.Black
        Me.CheIgFK.Location = New System.Drawing.Point(12, 529)
        Me.CheIgFK.Name = "CheIgFK"
        Me.CheIgFK.Size = New System.Drawing.Size(118, 17)
        Me.CheIgFK.TabIndex = 128
        Me.CheIgFK.Text = "Ignorar Foreign Key"
        Me.CheIgFK.UseVisualStyleBackColor = True
        '
        'FrmComBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 559)
        Me.Controls.Add(Me.CheIgFK)
        Me.Controls.Add(Me.CheFk)
        Me.Controls.Add(Me.CheNMIn)
        Me.Controls.Add(Me.FraIndice)
        Me.Controls.Add(Me.FraTabla)
        Me.Controls.Add(Me.CheNoMo)
        Me.Controls.Add(Me.BtnRepT)
        Me.Controls.Add(Me.ChePosi)
        Me.Controls.Add(Me.CheSiTo)
        Me.Controls.Add(Me.BtnRepa)
        Me.Controls.Add(Me.BtnCopi)
        Me.Controls.Add(Me.BtnCamb)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnCoBD)
        Me.Controls.Add(Me.LstErro)
        Me.Controls.Add(Me.LstTabE)
        Me.Controls.Add(Me.FraCamp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmComBD"
        Me.Text = "Comparar Bases de datos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FraCamp.ResumeLayout(False)
        Me.FraCamp.PerformLayout()
        Me.FraIndice.ResumeLayout(False)
        Me.FraIndice.PerformLayout()
        Me.FraTabla.ResumeLayout(False)
        Me.FraTabla.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LstTabE As System.Windows.Forms.ListBox
    Friend WithEvents LstErro As System.Windows.Forms.ListBox
    Friend WithEvents LblMSql As System.Windows.Forms.Label
    Friend WithEvents BtnCoBD As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblBaDD As System.Windows.Forms.Label
    Friend WithEvents LblBaDO As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblPass As System.Windows.Forms.Label
    Friend WithEvents LblUser As System.Windows.Forms.Label
    Friend WithEvents LblPuer As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblTipO As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LblTipD As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LblPKeD As System.Windows.Forms.Label
    Friend WithEvents LblPkeO As System.Windows.Forms.Label
    Friend WithEvents LblNulD As System.Windows.Forms.Label
    Friend WithEvents LblNulO As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents LblVaPD As System.Windows.Forms.Label
    Friend WithEvents LblVaPO As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents LblAInD As System.Windows.Forms.Label
    Friend WithEvents LblAInO As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents LblPosD As System.Windows.Forms.Label
    Friend WithEvents LblPosO As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents BtnCamb As System.Windows.Forms.Button
    Friend WithEvents BtnCopi As System.Windows.Forms.Button
    Friend WithEvents BtnRepa As System.Windows.Forms.Button
    Friend WithEvents CheSiTo As System.Windows.Forms.CheckBox
    Friend WithEvents ChePosi As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BtnRepT As System.Windows.Forms.Button
    Friend WithEvents CheNoMo As System.Windows.Forms.CheckBox
    Friend WithEvents FraCamp As System.Windows.Forms.GroupBox
    Friend WithEvents LblCamp As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents FraIndice As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LblIndi As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LstIndD As System.Windows.Forms.ListBox
    Friend WithEvents LstIndO As System.Windows.Forms.ListBox
    Friend WithEvents FraTabla As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblTiTO As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LblTiTD As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents LblNTab As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CheNMIn As CheckBox
    Friend WithEvents CheFk As CheckBox
    Friend WithEvents CheIgFK As CheckBox
End Class
