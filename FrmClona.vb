Public Class FrmClona
   Dim conn As MySqlConnection
   Dim StrConn As String
   Private Sub FrmClona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      StrConn = "server=" & LblMSql.Text & "; user id=" & LblUser.Text & "; password=" & LblPass.Text & "; port=" & LblPuer.Text & ";  pooling=false;"
      conn = New MySqlConnection(StrConn)
   End Sub

   Private Sub BtnClBd_Click(sender As Object, e As EventArgs) Handles BtnClBd.Click
      Dim ClonaTabla As MySqlCommand
      Try
         If MsgBox("Se va a clonar la BBDD " & LblBaDO.Text & " con el nombre " & TxtBDCl.Text & ". ¿Desea continuar?", vbYesNo + vbQuestion, "Atencion!") = vbYes Then
            AbrirBd()
            If CheCloD.Checked Then
               ClonaTabla = New MySqlCommand("mysqldump -uroot -p " & LblBaDO.Text & " -r my_project.sql", conn)
            Else
               ClonaTabla = New MySqlCommand("mysqldump -uroot - p " & LblBaDO.Text & " -r my_project.sql --no-data")
            End If
            ClonaTabla.ExecuteNonQuery() ' ejecuta la consulta de creación
            conn.Close()
         End If
      Catch
         MsgBox("No se pudo clonar correctamente " & Err.Number & "," & Err.Description)
      End Try

   End Sub
   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      Dim DtSet As DataSet
      Dim DABaDa As MySqlDataAdapter
      Dim DATabO, DATabD As MySqlDataAdapter
      Dim DAColu As MySqlDataAdapter
      Dim DAIndex As MySqlDataAdapter
      Dim CadenaIns, CadenaVal As String
      Dim oExiste As DataRow
      Dim CampoIns As String
      Dim Intento As Integer
      Dim cmd As MySqlCommand
      Dim sCmd As String
      Dim oTabDes() As DataRow

      TxtInfo.Text = ""
      conn.Open()
      DtSet = New DataSet
      'Tabla destino
      DATabD = New MySqlDataAdapter("Show Tables in " & TxtNoBd.Text, conn)
      If DtSet.Tables.Contains("TablasD") Then DtSet.Tables.Remove("TablasD")
      DATabD.Fill(DtSet, "TablasD")
      'Tablas origen
      DATabO = New MySqlDataAdapter("Show Tables in " & LblBaDO.Text, conn)
      If DtSet.Tables.Contains("TablasO") Then DtSet.Tables.Remove("TablasO")
      DATabO.Fill(DtSet, "TablasO")
      If DtSet.Tables("TablasO").Rows.Count Then
         For Each oTabla In DtSet.Tables("TablasO").Rows
            If TxtTabD.Text <> "" AndAlso UCase(TxtTabD.Text) <> UCase(oTabla(0)) Then GoTo Sigui_
            'Verifica si existe la tabla destino
            oTabDes = DtSet.Tables("TablasD").Select(DtSet.Tables("TablasD").Columns(0).ColumnName & "='" & oTabla(0) & "'")
            If IsNothing(oTabDes) OrElse oTabDes.Length = 0 Then
               TxtInfo.Text &= " , Tabla: " & oTabla(0) & vbCrLf
               GoTo Sigui_
               '   sCmd = "Create data& oTabla(0)
               '   cmd = New MySqlCommand(sCmd, conn)
               '   cmd.ExecuteNonQuery()
            End If
            '
            TxtInfo.Text &= "Tabla: " & oTabla(0) & vbCrLf
            DAColu = New MySqlDataAdapter("Show Columns in " & LblBaDO.Text & "." & oTabla(0), conn)
            If DtSet.Tables.Contains("ColumnasO") Then DtSet.Tables.Remove("ColumnasO")
            DAColu.Fill(DtSet, "ColumnasO")
            DAColu = New MySqlDataAdapter("Show Columns in " & TxtNoBd.Text & "." & oTabla(0), conn)
            If DtSet.Tables.Contains("ColumnasD") Then DtSet.Tables.Remove("ColumnasD")
            DAColu.Fill(DtSet, "ColumnasD")
            If DtSet.Tables("ColumnasO").Rows.Count Then
                  CadenaIns = "" : CadenaVal = ""
                  For Each oColumn In DtSet.Tables("ColumnasO").Rows
                     Try
                        'Construimos el insert
                        CampoIns = oColumn(0)
                        If Strings.Left(CampoIns, 4) = "Actu" Then CampoIns = ("Actualizado")
                        If CampoIns = "NombreIdzh-CN" Then GoTo SiguiCampo_
                        'If Strings.Left(CampoIns, 4) = "Actu" Then CampoIns = ("Actualizado")
                        oExiste = DtSet.Tables("ColumnasD").Select("Field='" & CampoIns & "'")(0)
                        CadenaIns &= CampoIns & ","
                        CadenaVal &= oColumn(0) & ","
                     Catch
                        TxtInfo.Text &= " , Columna omitida: " & oTabla(0) & ", " & oColumn(0) & vbCrLf
                     End Try
SiguiCampo_:
                  Next
                  If CadenaIns <> "" Then
                     Try
                        CadenaIns = " (" & Strings.Left(CadenaIns, Len(CadenaIns) - 1) & ")"
                        CadenaVal = Strings.Left(CadenaVal, Len(CadenaVal) - 1)
                        sCmd = "insert into " & TxtNoBd.Text & "." & oTabla(0) & CadenaIns & " select " & CadenaVal & " from " & LblBaDO.Text & "." & oTabla(0)
                        cmd = New MySqlCommand(sCmd, conn)
                        cmd.ExecuteNonQuery()
                     Catch ex As Exception
                        TxtInfo.Text &= "No se puedo copiar datos de " & oTabla(0) & vbCrLf & vbCrLf
                     End Try
                  End If
               End If
Sigui_:
         Next
         MsgBox("Fin proceso finalizado con exito")
      End If
      conn.Close()
   End Sub
   Private Sub AbrirBd()
      Try
         conn.Open()
      Catch
         conn.Close()
         conn.Open()
      End Try
   End Sub

   Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
      Dim DtSet As DataSet

      Dim DATabl As MySqlDataAdapter
      Dim cmd As MySqlCommand
      Dim sCmd As String

      TxtInfo.Text = ""

      AbrirBd()

      DtSet = New DataSet
      DATabl = New MySqlDataAdapter("Show Tables in " & LblBaDO.Text, conn)
      If DtSet.Tables.Contains("Tablas") Then DtSet.Tables.Remove("Tablas")
      DATabl.Fill(DtSet, "Tablas")
      If DtSet.Tables("Tablas").Rows.Count Then
         For Each oTabla In DtSet.Tables("Tablas").Rows
            Try
               sCmd = "delete  from " & LblBaDO.Text & "." & oTabla(0)
               cmd = New MySqlCommand(sCmd, conn)
               cmd.ExecuteNonQuery()
               TxtInfo.Text &= "Tabla vaciada: " & oTabla(0) & vbCrLf
            Catch ex As Exception
               TxtInfo.Text &= "No se pudo vaciar " & oTabla(0) & vbCrLf
            End Try
         Next
      End If
      conn.Close()
   End Sub

   Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

   End Sub
End Class
