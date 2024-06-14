Public Class FrmCopia

Private Sub BtnCopi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopi.Click
   Dim Fichero As String
   Dim mb As MySqlBackup


   Guardar.DefaultExt = "sql"
   Guardar.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
   Guardar.FileName = LblBaDO.Text & "_Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"
   If Guardar.ShowDialog = DialogResult.OK And Guardar.FileName <> "" Then
      Try
         Fichero = Guardar.FileName
         mb = New MySqlBackup("server=" & LblMSql.Text & ";user=" & LblUser.Text & ";pwd=" & LblPass.Text & ";database=" & LblBaDO.Text & ";")
         If cbEncrypt.Checked Then
            mb.EnableEncryption = cbEncrypt.Checked
            mb.EncryptionKey = txtKey.Text.Trim()
         End If
         mb.Export(Fichero)
         Emergente("Exportacion realizada correctamente")
      Catch ex As Exception
         MsgBox("Ocurrio un error al exportar " & ex.ToString, MsgBoxStyle.Critical, "Informacion")
      End Try
   End If
End Sub
Private Sub cbEncrypt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEncrypt.CheckedChanged
   lbKey.Visible = cbEncrypt.Checked
   txtKey.Visible = cbEncrypt.Checked
End Sub
End Class