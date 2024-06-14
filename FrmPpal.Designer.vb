<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPpal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPpal))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCone = New System.Windows.Forms.Button()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtUsua = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPuer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDiBD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LstBaDO = New System.Windows.Forms.ComboBox()
        Me.LstBaDD = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnComp = New System.Windows.Forms.Button()
        Me.BtnUtil = New System.Windows.Forms.Button()
        Me.BtnCopia = New System.Windows.Forms.Button()
        Me.BtnRestaura = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnClona = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCone)
        Me.GroupBox1.Controls.Add(Me.TxtPass)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtUsua)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtPuer)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtDiBD)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(766, 68)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Servidor..."
        '
        'BtnCone
        '
        Me.BtnCone.Image = CType(resources.GetObject("BtnCone.Image"), System.Drawing.Image)
        Me.BtnCone.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCone.Location = New System.Drawing.Point(699, 15)
        Me.BtnCone.Name = "BtnCone"
        Me.BtnCone.Size = New System.Drawing.Size(55, 42)
        Me.BtnCone.TabIndex = 21
        Me.BtnCone.Tag = "Conecta con la Base de datos"
        Me.BtnCone.Text = "Conecta"
        Me.BtnCone.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCone.UseVisualStyleBackColor = True
        '
        'TxtPass
        '
        Me.TxtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.Location = New System.Drawing.Point(623, 26)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(70, 22)
        Me.TxtPass.TabIndex = 20
        Me.TxtPass.Text = "1234"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(537, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Contraseña..."
        '
        'TxtUsua
        '
        Me.TxtUsua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsua.Location = New System.Drawing.Point(451, 26)
        Me.TxtUsua.Name = "TxtUsua"
        Me.TxtUsua.Size = New System.Drawing.Size(70, 22)
        Me.TxtUsua.TabIndex = 18
        Me.TxtUsua.Text = "root"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(387, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Usuario..."
        '
        'TxtPuer
        '
        Me.TxtPuer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPuer.Location = New System.Drawing.Point(336, 26)
        Me.TxtPuer.Name = "TxtPuer"
        Me.TxtPuer.Size = New System.Drawing.Size(40, 22)
        Me.TxtPuer.TabIndex = 16
        Me.TxtPuer.Text = "3306"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Puerto..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Server..."
        '
        'TxtDiBD
        '
        Me.TxtDiBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiBD.Location = New System.Drawing.Point(73, 26)
        Me.TxtDiBD.Name = "TxtDiBD"
        Me.TxtDiBD.Size = New System.Drawing.Size(190, 22)
        Me.TxtDiBD.TabIndex = 13
        Me.TxtDiBD.Text = "localhost"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Base de datos origen..."
        '
        'LstBaDO
        '
        Me.LstBaDO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LstBaDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstBaDO.FormattingEnabled = True
        Me.LstBaDO.Location = New System.Drawing.Point(164, 99)
        Me.LstBaDO.Name = "LstBaDO"
        Me.LstBaDO.Size = New System.Drawing.Size(256, 24)
        Me.LstBaDO.TabIndex = 24
        '
        'LstBaDD
        '
        Me.LstBaDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LstBaDD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstBaDD.FormattingEnabled = True
        Me.LstBaDD.Location = New System.Drawing.Point(164, 141)
        Me.LstBaDD.Name = "LstBaDD"
        Me.LstBaDD.Size = New System.Drawing.Size(256, 24)
        Me.LstBaDD.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Base de datos destino..."
        '
        'BtnComp
        '
        Me.BtnComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComp.Image = CType(resources.GetObject("BtnComp.Image"), System.Drawing.Image)
        Me.BtnComp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnComp.Location = New System.Drawing.Point(12, 205)
        Me.BtnComp.Name = "BtnComp"
        Me.BtnComp.Size = New System.Drawing.Size(73, 56)
        Me.BtnComp.TabIndex = 27
        Me.BtnComp.Text = "Compara B.D."
        Me.BtnComp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnComp.UseVisualStyleBackColor = True
        '
        'BtnUtil
        '
        Me.BtnUtil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUtil.Image = CType(resources.GetObject("BtnUtil.Image"), System.Drawing.Image)
        Me.BtnUtil.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnUtil.Location = New System.Drawing.Point(104, 207)
        Me.BtnUtil.Name = "BtnUtil"
        Me.BtnUtil.Size = New System.Drawing.Size(73, 56)
        Me.BtnUtil.TabIndex = 28
        Me.BtnUtil.Text = "Utilidades B.D."
        Me.BtnUtil.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUtil.UseVisualStyleBackColor = True
        '
        'BtnCopia
        '
        Me.BtnCopia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopia.Image = CType(resources.GetObject("BtnCopia.Image"), System.Drawing.Image)
        Me.BtnCopia.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCopia.Location = New System.Drawing.Point(202, 207)
        Me.BtnCopia.Name = "BtnCopia"
        Me.BtnCopia.Size = New System.Drawing.Size(73, 56)
        Me.BtnCopia.TabIndex = 29
        Me.BtnCopia.Text = "  Backup    B.D."
        Me.BtnCopia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCopia.UseVisualStyleBackColor = True
        '
        'BtnRestaura
        '
        Me.BtnRestaura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestaura.Image = CType(resources.GetObject("BtnRestaura.Image"), System.Drawing.Image)
        Me.BtnRestaura.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRestaura.Location = New System.Drawing.Point(295, 207)
        Me.BtnRestaura.Name = "BtnRestaura"
        Me.BtnRestaura.Size = New System.Drawing.Size(73, 56)
        Me.BtnRestaura.TabIndex = 30
        Me.BtnRestaura.Text = " Restaura    B.D."
        Me.BtnRestaura.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRestaura.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(390, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 56)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Reparar B.D."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnClona
        '
        Me.BtnClona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClona.Image = CType(resources.GetObject("BtnClona.Image"), System.Drawing.Image)
        Me.BtnClona.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnClona.Location = New System.Drawing.Point(498, 208)
        Me.BtnClona.Name = "BtnClona"
        Me.BtnClona.Size = New System.Drawing.Size(73, 56)
        Me.BtnClona.TabIndex = 32
        Me.BtnClona.Text = "Clonar B.D."
        Me.BtnClona.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnClona.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(589, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 56)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "FK"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(676, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 56)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Defaul Values"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FrmPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 275)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnClona)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnRestaura)
        Me.Controls.Add(Me.BtnCopia)
        Me.Controls.Add(Me.BtnUtil)
        Me.Controls.Add(Me.BtnComp)
        Me.Controls.Add(Me.LstBaDD)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LstBaDO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPpal"
        Me.Text = "Utiles P.I.Avant, utilidades para bases de datos MySql"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtUsua As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPuer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDiBD As System.Windows.Forms.TextBox
    Friend WithEvents BtnCone As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LstBaDO As System.Windows.Forms.ComboBox
    Friend WithEvents LstBaDD As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnComp As System.Windows.Forms.Button
    Friend WithEvents BtnUtil As System.Windows.Forms.Button
    Friend WithEvents BtnCopia As System.Windows.Forms.Button
    Friend WithEvents BtnRestaura As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnClona As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
