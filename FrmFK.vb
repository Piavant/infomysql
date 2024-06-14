Public Class FrmFK
   Dim conn As MySqlConnection
   Dim StrConn As String
   Private Sub FrmFK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      StrConn = "server=" & LblMSql.Text & "; user id=" & LblUser.Text & "; password=" & LblPass.Text & "; port=" & LblPuer.Text & ";  pooling=false;"
      conn = New MySqlConnection(StrConn)
   End Sub

   Private Sub BtnClBd_Click(sender As Object, e As EventArgs) Handles BtnClBd.Click
      Dim ComanMsql As MySqlCommand
      Dim DAFK As MySqlDataAdapter
      Dim DTFK As DataTable
      Dim StrSql As String

      Try
         If MsgBox("Se van a borrar las F.K. de la BBDD " & TxtBDDe.Text & ". ¿Desea continuar?", vbYesNo + vbQuestion, "Atencion!") = vbYes Then
            AbrirBd()
            DAFK = New MySqlDataAdapter("SELECT * FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE	REFERENCED_TABLE_SCHEMA = '" & TxtBDDe.Text & "' group by CONSTRAINT_NAME Order by Table_Name, Column_Name", conn)
            DTFK = New DataTable
            DAFK.Fill(DTFK)
            TxtInfo.Text = "" : StrSql = ""
            For Each oFilFK In DTFK.Rows
               TxtInfo.Text &= "Borrando FK " & oFilFK("Table_name") & " " & oFilFK("CONSTRAINT_NAME") & vbCrLf
               StrSql &= "ALTER TABLE `" & TxtBDDe.Text & "`.`" & oFilFK("Table_name") & "` DROP FOREIGN KEY `" & oFilFK("CONSTRAINT_NAME") & "`;" & vbCrLf
            Next
            If StrSql <> "" Then
               ComanMsql = New MySqlCommand(StrSql, conn)
               ComanMsql.ExecuteNonQuery() ' ejecuta la consulta de creación
            End If
            conn.Close()
            MsgBox("Proceso finalizado correctamente", vbInformation, Me.Text)
         End If
      Catch
         MsgBox("No se pudo borrar correctamente " & Err.Number & "," & Err.Description)
      End Try
   End Sub
   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      Dim ComanMsql As MySqlCommand
      Dim DAFKO As MySqlDataAdapter
      Dim oFilFKO, oFilsFKO() As DataRow
      Dim DtFKO As DataTable
      Dim ColuAnt As String
      Dim StrCom, StrCol, StrCoR As String
      Try
         If MsgBox("Se van a clonar las F.K. de la BBDD " & LblBaDO.Text & " a la BBDD " & TxtBDDe.Text & ". ¿Desea continuar?", vbYesNo + vbQuestion, "Atencion!") = vbYes Then
            AbrirBd()
            DtFKO = New DataTable
            'DAFKO = New MySqlDataAdapter("SELECT * FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE where table_schema='" & LblBaDO.Text & "' And Referenced_table_schema<>'' Order by TABLE_NAME, CONSTRAINT_NAME ", conn)
            DAFKO = New MySqlDataAdapter("SELECT tab1.CONSTRAINT_NAME, tab1.TABLE_NAME, tab1.COLUMN_NAME,    tab1.TABLE_SCHEMA, tab1.REFERENCED_TABLE_NAME, tab1.REFERENCED_COLUMn_NAME,    TAB1.ORDINAL_POSITION, tab2.MATCH_OPTION,	TAB2.TABLE_NAME, tab2.UPDATE_RULE,    tab2.DELETE_RULE FROM INFORMATION_SCHEMA.`KEY_COLUMN_USAGE` AS tab1 INNER JOIN    INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS AS tab2 ON tab1.CONSTRAINT_NAME = tab2.CONSTRAINT_NAME AND TAB1.TABLE_SCHEMA=TAB2.CONSTRAINT_SCHEMA WHERE TAB1.TABLE_SCHEMA = '" & LblBaDO.Text & " ' AND referenced_column_name IS NOT NULL ORDER BY TAB1.TABLE_NAME, TAB1.CONSTRAINT_NAME , TAB1.ORDINAL_POSITION", conn)
            DAFKO.Fill(DtFKO)
            TxtInfo.Text = "" : ColuAnt = ""
            For Each oFilFKO In DtFKO.Rows
               Try
                  If ColuAnt = "" OrElse ColuAnt <> oFilFKO("CONSTRAINT_NAME") Then
                     oFilsFKO = DtFKO.Select("CONSTRAINT_NAME='" & oFilFKO("CONSTRAINT_NAME") & "'")
                     If IsNothing(oFilsFKO) OrElse oFilsFKO.Length = 0 Then
                        TxtInfo.Text &= "Error creando CONTRAINT_NAME: " & oFilFKO("CONSTRAINT_NAME") & " - " & oFilFKO("Table_NAME") & vbCrLf
                     Else  'Comprobamos que las FK sean iguales
                        StrCol = "" : StrCoR = ""
                        For IND = 0 To oFilsFKO.Length - 1
                           StrCol &= "`" & oFilsFKO(IND)("Column_name") & "`,"
                           StrCoR &= "`" & oFilsFKO(IND)("referenced_Column_name") & "`,"
                        Next
                        StrCol = Strings.Left(StrCol, Len(StrCol) - 1)
                        StrCoR = Strings.Left(StrCoR, Len(StrCoR) - 1)
                        StrCom = "ALTER TABLE `" & TxtBDDe.Text & "`.`" & oFilFKO("table_name") & "` ADD Constraint `" & oFilFKO("CONSTRAINT_NAME") & "` FOREIGN KEY(" & StrCol & ")  REFERENCES `" & TxtBDDe.Text & "`.`" & oFilFKO("REFERENCED_TABLE_NAME") & "` (" & StrCoR & ") On DELETE " & oFilFKO("DELETE_RULE") & " On UPDATE " & oFilFKO("UPDATE_RULE")
                        ComanMsql = New MySqlCommand(StrCom, conn)
                        ComanMsql.ExecuteNonQuery() ' ejecuta la consulta de creación
                        TxtInfo.Text &= "FK creada " & oFilFKO("table_name") & " " & oFilFKO("CONSTRAINT_NAME") & vbCrLf
                     End If
                     ColuAnt = oFilFKO("CONSTRAINT_NAME")
                  End If
               Catch
                  TxtInfo.Text &= Err.Number & " , " & Err.Description
               End Try
            Next
            MsgBox("Proceso finalizado correctamente", vbInformation, Me.Text)
         End If
      Catch
         MsgBox("No se pudo crear correctamente " & Err.Number & "," & Err.Description)
      End Try

   End Sub
   Private Sub BtnRInf_Click(sender As Object, e As EventArgs) Handles BtnRInf.Click
      Dim ComanMsql As MySqlCommand
      Dim DAFKO As MySqlDataAdapter
      Dim oFilFKO, oFilsFKO() As DataRow
      Dim DtFKO As DataTable
      Dim ColuAnt As String
      Dim StrCom, StrCol, StrCoR As String
      Dim StrBBDD As String
      Try
         AbrirBd()
         DtFKO = New DataTable
         If RdnOrig.Checked Then
            StrBBDD = "SELECT     tab1.CONSTRAINT_NAME,    tab1.TABLE_NAME,    tab1.COLUMN_NAME,    tab1.TABLE_SCHEMA,    tab1.REFERENCED_TABLE_NAME,    tab1.REFERENCED_COLUMn_NAME,    TAB1.ORDINAL_POSITION,	tab2.MATCH_OPTION,	TAB2.TABLE_NAME,    tab2.UPDATE_RULE,    tab2.DELETE_RULE FROM    INFORMATION_SCHEMA.`KEY_COLUMN_USAGE` AS tab1        INNER JOIN    INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS AS tab2 ON tab1.CONSTRAINT_NAME = tab2.CONSTRAINT_NAME AND TAB1.TABLE_SCHEMA=TAB2.CONSTRAINT_SCHEMA WHERE TAB1.TABLE_SCHEMA = '" & LblBaDO.Text & " ' AND referenced_column_name IS NOT NULL ORDER BY TAB1.TABLE_NAME, TAB1.CONSTRAINT_NAME , TAB1.ORDINAL_POSITION"
            'StrBBDD = "SELECT * FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE where table_schema='" & LblBaDO.Text & "' And Referenced_table_schema<>'' Order by TABLE_NAME, CONSTRAINT_NAME "
         Else
            StrBBDD = "SELECT     tab1.CONSTRAINT_NAME,    tab1.TABLE_NAME,    tab1.COLUMN_NAME,    tab1.TABLE_SCHEMA,    tab1.REFERENCED_TABLE_NAME,    tab1.REFERENCED_COLUMn_NAME,    TAB1.ORDINAL_POSITION,	tab2.MATCH_OPTION,	TAB2.TABLE_NAME,    tab2.UPDATE_RULE,    tab2.DELETE_RULE FROM    INFORMATION_SCHEMA.`KEY_COLUMN_USAGE` AS tab1        INNER JOIN    INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS AS tab2 ON tab1.CONSTRAINT_NAME = tab2.CONSTRAINT_NAME AND TAB1.TABLE_SCHEMA=TAB2.CONSTRAINT_SCHEMA WHERE TAB1.TABLE_SCHEMA = '" & TxtBDDe.Text & " ' AND referenced_column_name IS NOT NULL ORDER BY TAB1.CONSTRAINT_NAME , TAB1.ORDINAL_POSITION"
         End If
         DAFKO = New MySqlDataAdapter(StrBBDD, conn)
         DAFKO.Fill(DtFKO)
         TxtInfo.Text = "" : ColuAnt = ""
         For Each oFilFKO In DtFKO.Rows
            If ColuAnt = "" OrElse ColuAnt <> oFilFKO("CONSTRAINT_NAME") Then
               TxtInfo.Text &= "FK, Table_name:" & oFilFKO("table_name") & ", Contraint_name:" & oFilFKO("CONSTRAINT_NAME") & ", Referenced_Table_name:" & oFilFKO("Referenced_Table_name") & vbCrLf
               oFilsFKO = DtFKO.Select("CONSTRAINT_NAME='" & oFilFKO("CONSTRAINT_NAME") & "'")
               If IsNothing(oFilsFKO) OrElse oFilsFKO.Length = 0 Then
                  TxtInfo.Text &= "********* Error leyendo CONTRAINT_NAME: " & oFilFKO("CONSTRAINT_NAME") & " - " & oFilFKO("Table_NAME") & vbCrLf
               Else  'Comprobamos que las FK sean iguales
                  StrCol = "" : StrCoR = ""
                  For IND = 0 To oFilsFKO.Length - 1
                     StrCol &= "`" & oFilsFKO(IND)("Column_name") & "`,"
                     StrCoR &= "`" & oFilsFKO(IND)("referenced_Column_name") & "`,"
                  Next
                  StrCol = Strings.Left(StrCol, Len(StrCol) - 1)
                  StrCoR = Strings.Left(StrCoR, Len(StrCoR) - 1)
                  TxtInfo.Text &= vbTab & "Columnas origen:" & StrCol & vbTab & "Columnas referenciadas" & StrCoR & vbCrLf
               End If
               ColuAnt = oFilFKO("CONSTRAINT_NAME")
            End If
         Next
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


End Class
