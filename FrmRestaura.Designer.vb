<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRestaura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRestaura))
Me.GroupBox1 = New System.Windows.Forms.GroupBox()
Me.LblBaDO = New System.Windows.Forms.Label()
Me.Label1 = New System.Windows.Forms.Label()
Me.LblPass = New System.Windows.Forms.Label()
Me.LblUser = New System.Windows.Forms.Label()
Me.LblPuer = New System.Windows.Forms.Label()
Me.Label4 = New System.Windows.Forms.Label()
Me.LblMSql = New System.Windows.Forms.Label()
Me.Label3 = New System.Windows.Forms.Label()
Me.Label2 = New System.Windows.Forms.Label()
Me.Label5 = New System.Windows.Forms.Label()
Me.BtnRest = New System.Windows.Forms.Button()
Me.Abrir = New System.Windows.Forms.OpenFileDialog()
Me.cbEncrypt = New System.Windows.Forms.CheckBox()
Me.txtKey = New System.Windows.Forms.TextBox()
Me.lbKey = New System.Windows.Forms.Label()
Me.GroupBox1.SuspendLayout()
Me.SuspendLayout()
'
'GroupBox1
'
Me.GroupBox1.Controls.Add(Me.LblBaDO)
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
Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
Me.GroupBox1.Name = "GroupBox1"
Me.GroupBox1.Size = New System.Drawing.Size(439, 105)
Me.GroupBox1.TabIndex = 5
Me.GroupBox1.TabStop = False
Me.GroupBox1.Text = "Destino backup"
'
'LblBaDO
'
Me.LblBaDO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.LblBaDO.Location = New System.Drawing.Point(98, 65)
Me.LblBaDO.Name = "LblBaDO"
Me.LblBaDO.Size = New System.Drawing.Size(257, 18)
Me.LblBaDO.TabIndex = 22
Me.LblBaDO.Text = "avantges"
'
'Label1
'
Me.Label1.AutoSize = True
Me.Label1.Location = New System.Drawing.Point(16, 68)
Me.Label1.Name = "Label1"
Me.Label1.Size = New System.Drawing.Size(82, 15)
Me.Label1.TabIndex = 20
Me.Label1.Text = "B.D. restaurar"
'
'LblPass
'
Me.LblPass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.LblPass.Location = New System.Drawing.Point(264, 47)
Me.LblPass.Name = "LblPass"
Me.LblPass.Size = New System.Drawing.Size(91, 18)
Me.LblPass.TabIndex = 19
Me.LblPass.Text = "1234"
'
'LblUser
'
Me.LblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.LblUser.Location = New System.Drawing.Point(98, 47)
Me.LblUser.Name = "LblUser"
Me.LblUser.Size = New System.Drawing.Size(85, 18)
Me.LblUser.TabIndex = 18
Me.LblUser.Text = "root"
'
'LblPuer
'
Me.LblPuer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.LblPuer.Location = New System.Drawing.Point(340, 26)
Me.LblPuer.Name = "LblPuer"
Me.LblPuer.Size = New System.Drawing.Size(52, 18)
Me.LblPuer.TabIndex = 17
Me.LblPuer.Text = "3306"
'
'Label4
'
Me.Label4.AutoSize = True
Me.Label4.Location = New System.Drawing.Point(194, 49)
Me.Label4.Name = "Label4"
Me.Label4.Size = New System.Drawing.Size(79, 15)
Me.Label4.TabIndex = 15
Me.Label4.Text = "Contraseña..."
'
'LblMSql
'
Me.LblMSql.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.LblMSql.Location = New System.Drawing.Point(98, 26)
Me.LblMSql.Name = "LblMSql"
Me.LblMSql.Size = New System.Drawing.Size(195, 18)
Me.LblMSql.TabIndex = 2
Me.LblMSql.Text = "localhost"
'
'Label3
'
Me.Label3.AutoSize = True
Me.Label3.Location = New System.Drawing.Point(16, 49)
Me.Label3.Name = "Label3"
Me.Label3.Size = New System.Drawing.Size(59, 15)
Me.Label3.TabIndex = 13
Me.Label3.Text = "Usuario..."
'
'Label2
'
Me.Label2.AutoSize = True
Me.Label2.Location = New System.Drawing.Point(293, 29)
Me.Label2.Name = "Label2"
Me.Label2.Size = New System.Drawing.Size(52, 15)
Me.Label2.TabIndex = 11
Me.Label2.Text = "Puerto..."
'
'Label5
'
Me.Label5.AutoSize = True
Me.Label5.Location = New System.Drawing.Point(16, 29)
Me.Label5.Name = "Label5"
Me.Label5.Size = New System.Drawing.Size(66, 15)
Me.Label5.TabIndex = 10
Me.Label5.Text = "Server........"
'
'BtnRest
'
Me.BtnRest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.BtnRest.Image = CType(resources.GetObject("BtnRest.Image"), System.Drawing.Image)
Me.BtnRest.ImageAlign = System.Drawing.ContentAlignment.TopCenter
Me.BtnRest.Location = New System.Drawing.Point(378, 142)
Me.BtnRest.Name = "BtnRest"
Me.BtnRest.Size = New System.Drawing.Size(73, 56)
Me.BtnRest.TabIndex = 30
Me.BtnRest.Text = "Restaura    B.D."
Me.BtnRest.TextAlign = System.Drawing.ContentAlignment.BottomCenter
Me.BtnRest.UseVisualStyleBackColor = True
'
'Abrir
'
Me.Abrir.FileName = "OpenFileDialog1"
'
'cbEncrypt
'
Me.cbEncrypt.AutoSize = True
Me.cbEncrypt.Location = New System.Drawing.Point(12, 142)
Me.cbEncrypt.Name = "cbEncrypt"
Me.cbEncrypt.Size = New System.Drawing.Size(137, 17)
Me.cbEncrypt.TabIndex = 32
Me.cbEncrypt.Text = "Activar desencriptación"
Me.cbEncrypt.UseVisualStyleBackColor = True
'
'txtKey
'
Me.txtKey.Location = New System.Drawing.Point(12, 178)
Me.txtKey.Name = "txtKey"
Me.txtKey.Size = New System.Drawing.Size(119, 20)
Me.txtKey.TabIndex = 35
Me.txtKey.Visible = False
'
'lbKey
'
Me.lbKey.AutoSize = True
Me.lbKey.Location = New System.Drawing.Point(9, 162)
Me.lbKey.Name = "lbKey"
Me.lbKey.Size = New System.Drawing.Size(28, 13)
Me.lbKey.TabIndex = 34
Me.lbKey.Text = "Key:"
Me.lbKey.Visible = False
'
'FrmRestaura
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(474, 222)
Me.Controls.Add(Me.txtKey)
Me.Controls.Add(Me.lbKey)
Me.Controls.Add(Me.cbEncrypt)
Me.Controls.Add(Me.BtnRest)
Me.Controls.Add(Me.GroupBox1)
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
Me.Name = "FrmRestaura"
Me.Text = "Restauración de base de datos"
Me.GroupBox1.ResumeLayout(False)
Me.GroupBox1.PerformLayout()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblBaDO As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblPass As System.Windows.Forms.Label
    Friend WithEvents LblUser As System.Windows.Forms.Label
    Friend WithEvents LblPuer As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblMSql As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnRest As System.Windows.Forms.Button
    Friend WithEvents Abrir As System.Windows.Forms.OpenFileDialog
    Private WithEvents cbEncrypt As System.Windows.Forms.CheckBox
    Private WithEvents txtKey As System.Windows.Forms.TextBox
    Private WithEvents lbKey As System.Windows.Forms.Label
End Class
