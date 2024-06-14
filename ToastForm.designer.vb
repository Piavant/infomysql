<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToastForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Me.messageLabel = New System.Windows.Forms.Label
      Me.lifeTimer = New System.Windows.Forms.Timer(Me.components)
      Me.SuspendLayout()
      '
      'messageLabel
      '
      Me.messageLabel.Dock = System.Windows.Forms.DockStyle.Fill
      Me.messageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.messageLabel.Location = New System.Drawing.Point(0, 0)
      Me.messageLabel.Name = "messageLabel"
      Me.messageLabel.Size = New System.Drawing.Size(333, 176)
      Me.messageLabel.TabIndex = 0
      Me.messageLabel.Text = "Mensaje aparece aqui"
      Me.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'lifeTimer
      '
      '
      'ToastForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.AutoSize = True
      Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
      Me.CausesValidation = False
      Me.ClientSize = New System.Drawing.Size(333, 176)
      Me.Controls.Add(Me.messageLabel)
      Me.Enabled = False
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Name = "ToastForm"
      Me.Text = "Mensaje..."
      Me.TopMost = True
      Me.ResumeLayout(False)

   End Sub
    Private WithEvents messageLabel As System.Windows.Forms.Label
    Private WithEvents lifeTimer As System.Windows.Forms.Timer
End Class
