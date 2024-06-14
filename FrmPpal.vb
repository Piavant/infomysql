Public Class FrmPpal

Private Sub FrmPpal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
   Esc_Ini("SERVER", "DIRECCION", TxtDiBD.Text)
   Esc_Ini("SERVER", "PUERTO", TxtPuer.Text)
   Esc_Ini("SERVER", "USUARIO", TxtUsua.Text)
   Esc_Ini("SERVER", "PASSWORD", TxtPass.Text)
End Sub

Private Sub FrmPpal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
   TxtDiBD.Text = Lee_Ini("SERVER", "DIRECCION", "localhost")
   TxtPuer.Text = Lee_Ini("SERVER", "PUERTO", "3306")
   TxtUsua.Text = Lee_Ini("SERVER", "USUARIO", "root")
   TxtPass.Text = Lee_Ini("SERVER", "PASSWORD", "1234")
End Sub

Private Sub BtnCone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCone.Click
   Dim strConn As String
   Dim conn As MySqlConnection
   Dim DABaDa As MySqlDataAdapter
   Dim DtSet As DataSet

   Try
      strConn = "server=" & TxtDiBD.Text & "; user id=" & TxtUsua.Text & "; password=" & TxtPass.Text & "; port=" & TxtPuer.Text & ";  pooling=false;"
      conn = New MySqlConnection(strConn)
      conn.Open()
      DABaDa = New MySqlDataAdapter("Show Databases", conn)
      DtSet = New DataSet
      DABaDa.Fill(DtSet, "BDatos")
      conn.Close()
      LstBaDD.Items.Clear()
      LstBaDO.Items.Clear()
      If DtSet.Tables("BDatos").Rows.Count Then
         For Each oBase In DtSet.Tables("BDatos").Rows
            LstBaDO.Items.Add(oBase(0))
            LstBaDD.Items.Add(oBase(0))
         Next
         If LstBaDO.Items.Count > 0 Then LstBaDO.SelectedIndex = 0
         If LstBaDD.Items.Count > 0 Then LstBaDD.SelectedIndex = 0
      End If
      Emergente("Conexion realizada correctamente")
   Catch
      MsgBox("Problemas conectando con el server", vbInformation, "Atencion!")
   End Try
End Sub
Private Sub BtnComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComp.Click
   If LstBaDO.SelectedItem <> "" And LstBaDD.SelectedItem <> "" Then
      FrmComBD.LblMSql.Text = TxtDiBD.Text
      FrmComBD.LblPuer.Text = TxtPuer.Text
      FrmComBD.LblUser.Text = TxtUsua.Text
      FrmComBD.LblPass.Text = TxtPass.Text
      FrmComBD.LblBaDO.Text = LstBaDO.SelectedItem
      FrmComBD.LblBaDD.Text = LstBaDD.SelectedItem
      FrmComBD.Show()
   Else
      MsgBox("Indique una B.D. origen y una B.D. destino", vbInformation, "Atención")
   End If
End Sub
   Private Sub BtnUtil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUtil.Click
      FrmInfo.Show()
   End Sub

   Private Sub BtnCopia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopia.Click
   If LstBaDO.SelectedItem <> "" Then
      FrmCopia.LblMSql.Text = TxtDiBD.Text
      FrmCopia.LblPuer.Text = TxtPuer.Text
      FrmCopia.LblUser.Text = TxtUsua.Text
      FrmCopia.LblPass.Text = TxtPass.Text
      FrmCopia.LblBaDO.Text = LstBaDO.SelectedItem
      FrmCopia.Show()
   Else
      MsgBox("Indique una B.D. origen de la cual se va a realizar el backup", vbInformation, "Atención")
   End If
End Sub

Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRestaura.Click
   If LstBaDD.SelectedItem <> "" Then
      FrmRestaura.LblMSql.Text = TxtDiBD.Text
      FrmRestaura.LblPuer.Text = TxtPuer.Text
      FrmRestaura.LblUser.Text = TxtUsua.Text
      FrmRestaura.LblPass.Text = TxtPass.Text
      FrmRestaura.LblBaDO.Text = LstBaDD.SelectedItem
      FrmRestaura.Show()
   Else
      MsgBox("Indique una B.D. destino en la cual se va a RESTAURAR el backup", vbInformation, "Atención")
   End If
End Sub

Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
   If LstBaDO.SelectedItem <> "" Then
      FrmRepara.LblMSql.Text = TxtDiBD.Text
      FrmRepara.LblPuer.Text = TxtPuer.Text
      FrmRepara.LblUser.Text = TxtUsua.Text
      FrmRepara.LblPass.Text = TxtPass.Text
      FrmRepara.LblBaDO.Text = LstBaDO.SelectedItem
      FrmRepara.Show()
   Else
      MsgBox("Indique una B.D. origen la cual se va a REPARAR", vbInformation, "Atención")
   End If
End Sub

   Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles BtnClona.Click
      If LstBaDO.SelectedItem <> "" And LstBaDD.SelectedItem <> "" Then
         FrmClona.LblMSql.Text = TxtDiBD.Text
         FrmClona.LblPuer.Text = TxtPuer.Text
         FrmClona.LblUser.Text = TxtUsua.Text
         FrmClona.LblPass.Text = TxtPass.Text
         FrmClona.LblBaDO.Text = LstBaDO.SelectedItem
         FrmClona.Show()
      Else
         MsgBox("Indique una B.D. origen y una B.D. destino", vbInformation, "Atención")
      End If
   End Sub

   Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
      If LstBaDO.SelectedItem <> "" And LstBaDD.SelectedItem <> "" Then
         FrmFK.LblMSql.Text = TxtDiBD.Text
         FrmFK.LblPuer.Text = TxtPuer.Text
         FrmFK.LblUser.Text = TxtUsua.Text
         FrmFK.LblPass.Text = TxtPass.Text
         FrmFK.LblBaDO.Text = LstBaDO.SelectedItem
         FrmFK.Show()
      Else
         MsgBox("Indique una B.D. origen y una B.D. destino", vbInformation, "Atención")
      End If
   End Sub

   Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
      If LstBaDO.SelectedItem <> "" And LstBaDD.SelectedItem <> "" Then
         FrmDefVal.LblMSql.Text = TxtDiBD.Text
         FrmDefVal.LblPuer.Text = TxtPuer.Text
         FrmDefVal.LblUser.Text = TxtUsua.Text
         FrmDefVal.LblPass.Text = TxtPass.Text
         FrmDefVal.LblBaDO.Text = LstBaDO.SelectedItem
         FrmDefVal.Show()
      Else
         MsgBox("Indique una B.D. origen y una B.D. destino", vbInformation, "Atención")
      End If
   End Sub
End Class