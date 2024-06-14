
Public Class FrmRestaura

Private Sub BtnRest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRest.Click
   Dim Fichero As String
   Dim mb As MySqlBackup

   Abrir.DefaultExt = "sql"
   Abrir.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
		If Abrir.ShowDialog() = DialogResult.OK Then
			Try
				Fichero = Abrir.FileName
				mb = New MySqlBackup("server=" & LblMSql.Text & ";user=" & LblUser.Text & ";pwd=" & LblPass.Text & ";database=" & LblBaDO.Text & ";")
				If cbEncrypt.Checked Then
					mb.EnableEncryption = cbEncrypt.Checked
					mb.EncryptionKey = txtKey.Text.Trim()
				End If
				mb.Import(Fichero)
				mb = Nothing
				Emergente("Recuperacion realizada correctamente")
			Catch ex As Exception
				MsgBox("Ocurrio un error al restaurar " & ex.ToString, MsgBoxStyle.Critical, "Informacion")
			End Try
		End If
	End Sub

Private Sub cbEncrypt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEncrypt.CheckedChanged
   lbKey.Visible = cbEncrypt.Checked
   txtKey.Visible = cbEncrypt.Checked
End Sub
End Class