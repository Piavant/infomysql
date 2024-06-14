<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepara
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
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRepara))
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
Me.BtnRepa = New System.Windows.Forms.Button()
Me.Guardar = New System.Windows.Forms.SaveFileDialog()
Me.PBarBDa = New System.Windows.Forms.ProgressBar()
Me.CheOpti = New System.Windows.Forms.CheckBox()
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
Me.GroupBox1.Text = "B.D. a reparar"
'
'LblBaDO
'
Me.LblBaDO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.LblBaDO.Location = New System.Drawing.Point(93, 65)
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
Me.Label1.Size = New System.Drawing.Size(73, 15)
Me.Label1.TabIndex = 20
Me.Label1.Text = "B.D. backup"
'
'LblPass
'
Me.LblPass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.LblPass.Location = New System.Drawing.Point(259, 47)
Me.LblPass.Name = "LblPass"
Me.LblPass.Size = New System.Drawing.Size(91, 18)
Me.LblPass.TabIndex = 19
Me.LblPass.Text = "1234"
'
'LblUser
'
Me.LblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.LblUser.Location = New System.Drawing.Point(93, 47)
Me.LblUser.Name = "LblUser"
Me.LblUser.Size = New System.Drawing.Size(85, 18)
Me.LblUser.TabIndex = 18
Me.LblUser.Text = "root"
'
'LblPuer
'
Me.LblPuer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.LblPuer.Location = New System.Drawing.Point(335, 26)
Me.LblPuer.Name = "LblPuer"
Me.LblPuer.Size = New System.Drawing.Size(52, 18)
Me.LblPuer.TabIndex = 17
Me.LblPuer.Text = "3306"
'
'Label4
'
Me.Label4.AutoSize = True
Me.Label4.Location = New System.Drawing.Point(189, 49)
Me.Label4.Name = "Label4"
Me.Label4.Size = New System.Drawing.Size(79, 15)
Me.Label4.TabIndex = 15
Me.Label4.Text = "Contraseña..."
'
'LblMSql
'
Me.LblMSql.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.LblMSql.Location = New System.Drawing.Point(93, 26)
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
Me.Label2.Location = New System.Drawing.Point(288, 29)
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
'BtnRepa
'
Me.BtnRepa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.BtnRepa.Image = CType(resources.GetObject("BtnRepa.Image"), System.Drawing.Image)
Me.BtnRepa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
Me.BtnRepa.Location = New System.Drawing.Point(378, 141)
Me.BtnRepa.Name = "BtnRepa"
Me.BtnRepa.Size = New System.Drawing.Size(73, 56)
Me.BtnRepa.TabIndex = 30
Me.BtnRepa.Text = "  Repara    B.D."
Me.BtnRepa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
Me.BtnRepa.UseVisualStyleBackColor = True
'
'PBarBDa
'
Me.PBarBDa.Location = New System.Drawing.Point(16, 165)
Me.PBarBDa.Name = "PBarBDa"
Me.PBarBDa.Size = New System.Drawing.Size(345, 31)
Me.PBarBDa.TabIndex = 31
'
'CheOpti
'
Me.CheOpti.AutoSize = True
Me.CheOpti.Location = New System.Drawing.Point(16, 135)
Me.CheOpti.Name = "CheOpti"
Me.CheOpti.Size = New System.Drawing.Size(100, 17)
Me.CheOpti.TabIndex = 32
Me.CheOpti.Text = "Optimizar tablas"
Me.CheOpti.UseVisualStyleBackColor = True
'
'FrmRepara
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(474, 222)
Me.Controls.Add(Me.CheOpti)
Me.Controls.Add(Me.PBarBDa)
Me.Controls.Add(Me.BtnRepa)
Me.Controls.Add(Me.GroupBox1)
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
Me.Name = "FrmRepara"
Me.Text = "Reparación de base de datos"
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
    Friend WithEvents BtnRepa As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PBarBDa As System.Windows.Forms.ProgressBar
    Friend WithEvents CheOpti As System.Windows.Forms.CheckBox
End Class
