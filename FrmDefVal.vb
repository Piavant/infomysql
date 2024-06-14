Public Class FrmDefVal
   Dim conn As MySqlConnection
   Dim StrConn As String
   Private Sub FrmDefVal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      StrConn = "server=" & LblMSql.Text & "; user id=" & LblUser.Text & "; password=" & LblPass.Text & "; port=" & LblPuer.Text & ";  pooling=false;"
      conn = New MySqlConnection(StrConn)
   End Sub

   Private Sub BtnClBd_Click(sender As Object, e As EventArgs) Handles BtnClBd.Click
      Dim ComanMsql As MySqlCommand
      Dim DATAB, DADEV As MySqlDataAdapter
      Dim DTTAB, DTDEV As DataTable
      Dim StrSql As String
      Dim CadAux As String

      Try
         If MsgBox("Se van a borrar los DEFAULT VALUES de la BBDD " & TxtBDDe.Text & ". ¿Desea continuar?", vbYesNo + vbQuestion, "Atencion!") = vbYes Then
            AbrirBd()
            DTTAB = New DataTable
            DATAB = New MySqlDataAdapter("Show TABLES in " & TxtBDDe.Text, conn)        'Campos Tabla Origen
            DATAB.Fill(DTTAB)
            TxtInfo.Text = "" : StrSql = ""
            For Each vtabla In DTTAB.Rows
               If TxtTabla.Text <> "" AndAlso vtabla(0) <> TxtTabla.Text Then GoTo Sigui_
               DTDEV = New DataTable
               If TxtCampo.Text <> "" Then CadAux = " Where field='" & TxtCampo.Text & "'" Else CadAux = ""
               DADEV = New MySqlDataAdapter("Show Columns in " & TxtBDDe.Text & "." & vtabla(0) & CadAux, conn)        'Campos Tabla Origen
               DADEV.Fill(DTDEV)
               For Each oFilCol In DTDEV.Rows
                  TxtInfo.Text &= "Borrando DEFAULT VALUE " & vtabla(0) & " " & oFilCol("field") & vbCrLf
                  StrSql &= "ALTER TABLE `" & TxtBDDe.Text & "`.`" & vtabla(0) & "` CHANGE COLUMN `" & oFilCol("field") & "` `" & oFilCol("field") & "` " & oFilCol("type") & " " & IIf(oFilCol("null") = "YES", "null", "Not null") & " Default null;"
               Next
               If StrSql <> "" Then
                  ComanMsql = New MySqlCommand(StrSql, conn)
                  ComanMsql.ExecuteNonQuery() ' ejecuta la consulta de creación
               End If
Sigui_:
            Next
            conn.Close()
            MsgBox("Proceso finalizado correctamente", vbInformation, Me.Text)
         End If
      Catch
         MsgBox("No se pudo borrar correctamente " & Err.Number & "," & Err.Description)
      End Try
   End Sub
   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      Dim ComanMsql As MySqlCommand
      Dim DATAB, DATAD, DADEV As MySqlDataAdapter
      Dim DTTAB, DTTAD, DTDEV As DataTable
      Dim StrSql As String
      Dim CadAux As String
      Dim oFilDev() As DataRow

      Try
         If MsgBox("Se van a clonar los DEFAULT VALUES  de la BBDD " & LblBaDO.Text & " a la BBDD " & TxtBDDe.Text & ". ¿Desea continuar?", vbYesNo + vbQuestion, "Atencion!") = vbYes Then
            AbrirBd()
            DTTAB = New DataTable
            DATAB = New MySqlDataAdapter("Show TABLES in " & LblBaDO.Text, conn)        'Campos Tabla Origen
            DATAB.Fill(DTTAB)
            DTTAD = New DataTable
            DATAD = New MySqlDataAdapter("Show TABLES in " & TxtBDDe.Text, conn)        'Campos Tabla Origen
            DATAD.Fill(DTTAD)
            TxtInfo.Text = "" : StrSql = ""
            For Each vtabla In DTTAB.Rows
               If TxtTabla.Text <> "" AndAlso vtabla(0) <> TxtTabla.Text Then GoTo SIGUI_
               oFilDev = DTTAD.Select("Tables_in_" & TxtBDDe.Text & "='" & vtabla(0) & "'")
               If IsNothing(oFilDev) OrElse oFilDev.Length = 0 Then GoTo SIGUI_ : 
               DTDEV = New DataTable
               If TxtCampo.Text <> "" Then CadAux = " Where field='" & TxtCampo.Text & "'" Else CadAux = ""
               DADEV = New MySqlDataAdapter("Show Columns in " & LblBaDO.Text & "." & vtabla(0) & CadAux, conn)        'Campos Tabla Origen
               DADEV.Fill(DTDEV)
               For Each oFilCol In DTDEV.Rows
                  TxtInfo.Text &= "Establaciendo DEFAULT VALUE " & vtabla(0) & " " & oFilCol("field") & vbCrLf
                  StrSql &= "ALTER TABLE `" & TxtBDDe.Text & "`.`" & vtabla(0) & "` CHANGE COLUMN `" & oFilCol("field") & "` `" & oFilCol("field") & "` " & oFilCol("type") & " " & IIf(oFilCol("null") = "YES", "null", "Not null") & " Default " & oFilCol("default") & IIf(oFilCol("Extra") = "", "", Mid(oFilCol("Extra"), 18))
               Next
               If StrSql <> "" Then
                  ComanMsql = New MySqlCommand(StrSql, conn)
                  ComanMsql.ExecuteNonQuery() ' ejecuta la consulta de creación
               End If
SIGUI_:
            Next
            MsgBox("Proceso finalizado correctamente", vbInformation, Me.Text)
         End If
      Catch
         MsgBox("No se pudo crear correctamente " & Err.Number & "," & Err.Description)
      End Try

   End Sub
   Private Sub BtnRInf_Click(sender As Object, e As EventArgs) Handles BtnRInf.Click
      Dim DATAB, DADEV As MySqlDataAdapter
      Dim DTTAB, DTDEV As DataTable
      Dim StrSql As String
      Dim CadAux As String

      Try
         Cursor = Cursors.WaitCursor
         AbrirBd()
         DTTAB = New DataTable
         If RdnOrig.Checked Then
            DATAB = New MySqlDataAdapter("Show TABLES in " & LblBaDO.Text, conn)        'Campos Tabla Origen
         Else
            DATAB = New MySqlDataAdapter("Show TABLES in " & TxtBDDe.Text, conn)        'Campos Tabla Origen
         End If
         DATAB.Fill(DTTAB)
         TxtInfo.Text = "" : StrSql = ""
         For Each vtabla In DTTAB.Rows
            If TxtTabla.Text <> "" AndAlso vtabla(0) <> TxtTabla.Text Then GoTo Sigui_
            TxtInfo.Text &= "Tabla:" & vtabla(0) & vbCrLf
            DTDEV = New DataTable
            If TxtCampo.Text <> "" Then CadAux = " Where field='" & TxtCampo.Text & "'" Else CadAux = ""
            DADEV = New MySqlDataAdapter("Show Columns in " & LblBaDO.Text & "." & vtabla(0) & CadAux, conn)        'Campos Tabla Origen
            DADEV.Fill(DTDEV)
            For Each oFilCol In DTDEV.Rows
               TxtInfo.Text &= vbTab & "Campo:" & oFilCol("field") & vbTab & "Default:" & oFilCol("Default") & vbTab & "Extra:" & oFilCol("Extra") & vbCrLf
            Next
Sigui_:
         Next
         conn.Close()
         Cursor = Cursors.Default
         MsgBox("Proceso finalizado correctamente", vbInformation, Me.Text)
      Catch
         MsgBox("No se pudo crear correctamente " & Err.Number & "," & Err.Description)
      End Try

   End Sub
   Private Sub AbrirBd()
      Try
         conn.Open()
      Catch
         conn.Close()
         conn.Open()
      End Try
   End Sub

   Private Sub BtnBorr_Click(sender As Object, e As EventArgs) Handles BtnBorr.Click
      TxtInfo.Text = ""
   End Sub

   Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

   End Sub

   Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged

   End Sub
End Class
