Public Class FrmRepara

Dim Conn As MySqlConnection
Private Sub FrmRepara_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
   PBarBDa.Style = ProgressBarStyle.Continuous
   PBarBDa.Step = 1
   PBarBDa.Minimum = 0
End Sub
Private Sub BtnRepa_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRepa.Click
  RepairDB("SHOW TABLES IN " & LblBaDO.Text)
End Sub
Private Sub RepairDB(ByVal Query As String)
   Dim DTab As DataTable
   Dim DAdap As MySqlDataAdapter

   Try
      Conn = New MySqlConnection("server=" & LblMSql.Text & "; user id=" & LblUser.Text & "; password=" & LblPass.Text & "; port=" & LblPuer.Text & "; database=" & LblBaDO.Text & "; pooling=false;")
      Conn.Open()
      DAdap = New MySqlDataAdapter(Query, Conn)
      DTab = New DataTable
      DAdap.Fill(DTab)
      PBarBDa.Maximum = DTab.Rows.Count : PBarBDa.Value = 0
      For i = 0 To DTab.Rows.Count - 1
         EjecutaQuery("repair table " + DTab.Rows(i)(0))
         If CheOpti.Checked Then EjecutaQuery("optimize table " + DTab.Rows(i)(0))
         PBarBDa.Value += 1
      Next
      Conn.Close()
      Emergente("Reparacion realizada correctamente")
   Catch ex As Exception
      MsgBox("Ocurrio un error al reparar B.D. " & ex.ToString, MsgBoxStyle.Critical, "Informacion")
   End Try
End Sub
Private Sub EjecutaQuery(ByVal query As String)
   Dim cmd As MySqlCommand

   Try
      cmd = New MySqlCommand
      cmd = Conn.CreateCommand()
      cmd.CommandText = query
      cmd.ExecuteNonQuery()
   Catch ex As Exception
      MsgBox("Ocurrio un error al ejecutar el query " & query & " " & ex.ToString, MsgBoxStyle.Critical, "Informacion")
   End Try

End Sub

End Class