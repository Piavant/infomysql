<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClona
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
        Me.TxtInfo = New System.Windows.Forms.TextBox()
        Me.BtnBorr = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblBaDO = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.LblPuer = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblMSql = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.CheCloD = New System.Windows.Forms.CheckBox()
        Me.BtnClBd = New System.Windows.Forms.Button()
        Me.TxtBDCl = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtTabD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNoBd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtInfo
        '
        Me.TxtInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtInfo.Location = New System.Drawing.Point(12, 251)
        Me.TxtInfo.Multiline = True
        Me.TxtInfo.Name = "TxtInfo"
        Me.TxtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtInfo.Size = New System.Drawing.Size(898, 229)
        Me.TxtInfo.TabIndex = 0
        '
        'BtnBorr
        '
        Me.BtnBorr.Location = New System.Drawing.Point(842, 219)
        Me.BtnBorr.Name = "BtnBorr"
        Me.BtnBorr.Size = New System.Drawing.Size(68, 22)
        Me.BtnBorr.TabIndex = 13
        Me.BtnBorr.Text = "Limpia"
        Me.BtnBorr.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LblBaDO)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblPass)
        Me.GroupBox1.Controls.Add(Me.LblUser)
        Me.GroupBox1.Controls.Add(Me.LblPuer)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LblMSql)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(898, 80)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BBDD. origen.."
        '
        'LblBaDO
        '
        Me.LblBaDO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblBaDO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblBaDO.Location = New System.Drawing.Point(87, 50)
        Me.LblBaDO.Name = "LblBaDO"
        Me.LblBaDO.Size = New System.Drawing.Size(249, 18)
        Me.LblBaDO.TabIndex = 22
        Me.LblBaDO.Text = "avantges"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "B.D. Origen"
        '
        'LblPass
        '
        Me.LblPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPass.Location = New System.Drawing.Point(795, 22)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(80, 18)
        Me.LblPass.TabIndex = 19
        Me.LblPass.Text = "1234"
        '
        'LblUser
        '
        Me.LblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblUser.Location = New System.Drawing.Point(591, 22)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(111, 18)
        Me.LblUser.TabIndex = 18
        Me.LblUser.Text = "root"
        '
        'LblPuer
        '
        Me.LblPuer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPuer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPuer.Location = New System.Drawing.Point(467, 22)
        Me.LblPuer.Name = "LblPuer"
        Me.LblPuer.Size = New System.Drawing.Size(52, 18)
        Me.LblPuer.TabIndex = 17
        Me.LblPuer.Text = "3306"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(725, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Contraseña..."
        '
        'LblMSql
        '
        Me.LblMSql.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblMSql.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMSql.Location = New System.Drawing.Point(87, 22)
        Me.LblMSql.Name = "LblMSql"
        Me.LblMSql.Size = New System.Drawing.Size(315, 18)
        Me.LblMSql.TabIndex = 2
        Me.LblMSql.Text = "localhost"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(539, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Usuario..."
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(420, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Puerto..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Server........"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 98)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(824, 147)
        Me.TabControl1.TabIndex = 20
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.CheCloD)
        Me.TabPage6.Controls.Add(Me.BtnClBd)
        Me.TabPage6.Controls.Add(Me.TxtBDCl)
        Me.TabPage6.Controls.Add(Me.Label20)
        Me.TabPage6.Location = New System.Drawing.Point(4, 24)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(816, 119)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Clonar B.D."
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'CheCloD
        '
        Me.CheCloD.AutoSize = True
        Me.CheCloD.Checked = True
        Me.CheCloD.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheCloD.Location = New System.Drawing.Point(19, 71)
        Me.CheCloD.Name = "CheCloD"
        Me.CheCloD.Size = New System.Drawing.Size(97, 19)
        Me.CheCloD.TabIndex = 19
        Me.CheCloD.Text = "Clonar Datos"
        Me.CheCloD.UseVisualStyleBackColor = True
        '
        'BtnClBd
        '
        Me.BtnClBd.Location = New System.Drawing.Point(733, 81)
        Me.BtnClBd.Name = "BtnClBd"
        Me.BtnClBd.Size = New System.Drawing.Size(71, 25)
        Me.BtnClBd.TabIndex = 18
        Me.BtnClBd.Text = "Reallizar"
        Me.BtnClBd.UseVisualStyleBackColor = True
        '
        'TxtBDCl
        '
        Me.TxtBDCl.Location = New System.Drawing.Point(100, 30)
        Me.TxtBDCl.Name = "TxtBDCl"
        Me.TxtBDCl.Size = New System.Drawing.Size(178, 21)
        Me.TxtBDCl.TabIndex = 16
        Me.TxtBDCl.Text = "hsavant21"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(19, 33)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 15)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "B.D. Destino"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TxtTabD)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.TxtNoBd)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(816, 119)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Copiar datos (selectivo)"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TxtTabD
        '
        Me.TxtTabD.Location = New System.Drawing.Point(127, 74)
        Me.TxtTabD.Name = "TxtTabD"
        Me.TxtTabD.Size = New System.Drawing.Size(158, 21)
        Me.TxtTabD.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Tabla (opcional).."
        '
        'TxtNoBd
        '
        Me.TxtNoBd.Location = New System.Drawing.Point(107, 47)
        Me.TxtNoBd.Name = "TxtNoBd"
        Me.TxtNoBd.Size = New System.Drawing.Size(178, 21)
        Me.TxtNoBd.TabIndex = 14
        Me.TxtNoBd.Text = "hsavant21"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "B.D. Destino"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(703, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 25)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Realizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(816, 119)
        Me.TabPage1.TabIndex = 6
        Me.TabPage1.Text = "Borrar datos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(484, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Borrar TODOS los datos de TODAS las tablas de la BBDD indicada"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(699, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 26)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Realizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmClona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 490)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnBorr)
        Me.Controls.Add(Me.TxtInfo)
        Me.Name = "FrmClona"
        Me.Text = "Clonacion BBDD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtInfo As System.Windows.Forms.TextBox
    Friend WithEvents BtnBorr As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblBaDO As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblPass As Label
    Friend WithEvents LblUser As Label
    Friend WithEvents LblPuer As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblMSql As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents CheCloD As CheckBox
    Friend WithEvents BtnClBd As Button
    Friend WithEvents TxtBDCl As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TxtNoBd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtTabD As TextBox
    Friend WithEvents Label7 As Label
End Class
