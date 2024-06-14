Public Class FrmComBD
   Dim conn As MySqlConnection
   Dim StrConn As String
Private Sub FrmComBD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
   StrConn = "server=" & LblMSql.Text & "; user id=" & LblUser.Text & "; password=" & LblPass.Text & "; port=" & LblPuer.Text & ";  pooling=false;"
   conn = New MySqlConnection(StrConn)
End Sub

Private Sub BtnCoBD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCoBD.Click
      Dim ColuAnt As String
      Dim DtSet As DataSet
      Dim DATabO As MySqlDataAdapter
      Dim DATabD As MySqlDataAdapter
      Dim DAColO As MySqlDataAdapter
      Dim DAColD As MySqlDataAdapter
      Dim DAIndO As MySqlDataAdapter
      Dim DAIndD As MySqlDataAdapter
      Dim DAITaO As MySqlDataAdapter
      Dim DAITaD As MySqlDataAdapter
      Dim DAFKO As MySqlDataAdapter
      Dim DAFKD As MySqlDataAdapter
      Dim oFilFKO, oFilFKD, oFilsFKO(), oFilsFKD() As DataRow

      Cursor = Cursors.WaitCursor
      LblCamp.Text = "" : LblTipD.Text = "" : LblPKeD.Text = "" : LblNulD.Text = "" : LblVaPD.Text = "" : LblPosD.Text = ""
      LblTipO.Text = "" : LblPkeO.Text = "" : LblNulO.Text = "" : LblVaPO.Text = "" : LblPosO.Text = ""
      LblIndi.Text = "" : LstIndD.Items.Clear() : LstIndO.Items.Clear()
      'Vacia Campos Info Tabla
      LblNTab.Text = "" : LblTiTD.Text = "" : LblTiTO.Text = ""
      '
      BtnRepT.Visible = False : BtnCopi.Visible = False : BtnRepa.Visible = False
      LstErro.Items.Clear() : LstTabE.Items.Clear()
      AbrirBd()
      DtSet = New DataSet
      'Information schema
      'DAITaO = New MySqlDataAdapter("SELECT TABLE_NAME, ENGINE FROM information_schema.TABLES where TABLE_SCHEMA =  " & LblBaDO.Text & " AND ENGINE IS NOT NULL", conn)
      'DAITaO.Fill(DtSet, "InfTablasO")
      'If DtSet.Tables("TablasO").Rows.Count Then

      'End If
      DATabO = New MySqlDataAdapter("Show Tables in " & LblBaDO.Text, conn)      'Tablas B.D. origen
      DATabO.Fill(DtSet, "TablasO")
      If DtSet.Tables("TablasO").Rows.Count Then
         DATabD = New MySqlDataAdapter("Show Tables in " & LblBaDD.Text, conn)   'Tablas B.D. destino
         DATabD.Fill(DtSet, "TablasD")
         For Each oTablaO In DtSet.Tables("TablasO").Rows
            If IsNothing(DtSet.Tables("TablasD")) OrElse
            DtSet.Tables("TablasD").Select("Tables_in_" & LblBaDD.Text & "='" & oTablaO.item(0) & "'").Length = 0 Then
               LstTabE.Items.Add(oTablaO.item(0) & ": Tabla no encontrada")
               BtnRepT.Visible = True
            Else
               'Verificar modificardores  de la tabla
               'DAITaO = New MySqlDataAdapter("SHOW TABLE STATUS WHERE Name ='" & LblBaDO.Text & "." & oTablaO.item(0) & "'", conn) 'Informacion Tabla origen
               'DAITaO.Fill(DtSet, "InfTablasO")

               ''xxx'
               'Verificacion de campos
               DAColO = New MySqlDataAdapter("Show Columns in " & LblBaDO.Text & "." & oTablaO.item(0), conn)        'Campos Tabla Origen
               If DtSet.Tables.Contains("CamposO") Then DtSet.Tables.Remove("CamposO")
               DAColO.Fill(DtSet, "CamposO")
               If DtSet.Tables("CamposO").Rows.Count Then
                  DAColD = New MySqlDataAdapter("Show Columns in " & LblBaDD.Text & "." & oTablaO.item(0), conn)
                  If DtSet.Tables.Contains("CamposD") Then DtSet.Tables.Remove("CamposD")
                  DAColD.Fill(DtSet, "CamposD")
                  ColuAnt = ""
                  'Recorremos campos tabla Origen
                  For Each oCampoO In DtSet.Tables("CamposO").Rows
                     Dim oFila() As DataRow
                     oFila = DtSet.Tables("CamposD").Select("Field='" & oCampoO.item(0) & "'")
                     If oFila.Length = 0 Then                                                'Campo no existe
                        LstTabE.Items.Add(oTablaO.item(0) & ": Campos incorrectos") : BtnRepT.Visible = True
                        Exit For
                     Else
                        'Verificar que los campos son iguales
                        'oCampoO(3) = oFila(0)(3) And _ Campo indice que se encargue la revision de indices
                        If oCampoO(1) = oFila(0)(1) And oCampoO(2) = oFila(0)(2) And
                        Asig(oCampoO(4)) = Asig(oFila(0)(4)) And (ChePosi.Checked = False OrElse
                           (ChePosi.Checked AndAlso FColAnt(DtSet.Tables("CamposD"), oFila(0)(0)) = ColuAnt)) Then    'And oCampoO(5) = oFila(0)(5) Then
                        Else
                           LstTabE.Items.Add(oTablaO.item(0) & ": Campos incorrectos") : BtnRepT.Visible = True       'Tipo diferente
                           Exit For
                        End If
                     End If
                     ColuAnt = oCampoO(0)
                  Next
               Else
                  MsgBox("No se han encontrado campos en la Tabla " & oTablaO.item(0) & " de la B.D. Origen", vbInformation, "Atencion!")
               End If
               'Verificar indices
               If CheNMIn.Checked = False Then
                  DAIndO = New MySqlDataAdapter("Show Index from " & LblBaDO.Text & "." & oTablaO.item(0), conn)
                  If DtSet.Tables.Contains("IndicesO") Then DtSet.Tables.Remove("IndicesO")
                  DAIndO.Fill(DtSet, "IndicesO")
                  If DtSet.Tables("IndicesO").Rows.Count Then
                     DAIndD = New MySqlDataAdapter("Show Index from " & LblBaDD.Text & "." & oTablaO.item(0), conn)
                     If DtSet.Tables.Contains("IndicesD") Then DtSet.Tables.Remove("IndicesD")
                     DAIndD.Fill(DtSet, "IndicesD")
                     For Each oIndice In DtSet.Tables("IndicesO").Rows
                        Dim oFilI() As DataRow
                        oFilI = DtSet.Tables("IndicesD").Select("Key_name='" & oIndice.item(2) & "' AND Seq_in_index=" & oIndice.item(3))
                        If oFilI.Length = 0 Then
                           LstTabE.Items.Add(oTablaO.item(0) & ": Indices incorrectos") : BtnRepT.Visible = True
                           Exit For
                        Else
                           If oIndice(1) = oFilI(0)(1) And oIndice(4) = oFilI(0)(4) And
                        oIndice(5) = oFilI(0)(5) And Asig(oIndice(7)) = Asig(oFilI(0)(7)) And
                        Asig(oIndice(8)) = Asig(oFilI(0)(8)) And Asig(oIndice(9)) = Asig(oFilI(0)(9)) And
                        Asig(oIndice(10)) = Asig(oFilI(0)(10)) And Asig(oIndice(11)) = Asig(oFilI(0)(11)) Then
                           Else
                              LstTabE.Items.Add(oTablaO.item(0) & ": Indices incorrectos") : BtnRepT.Visible = True
                              Exit For
                           End If
                        End If
                     Next
                  End If
               End If
               'Verificar foreign Key
               If CheFk.Checked Then
                  'DAFKO = New MySqlDataAdapter("SELECT TABLE_NAME, COLUMN_NAME, CONSTRAINT_NAME, REFERENCED_TABLE_NAME, REFERENCED_COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE	REFERENCED_TABLE_SCHEMA = '" & LblBaDO.Text & "' AND REFERENCED_TABLE_NAME = '" & oTablaO.item(0) & "' Order by TABLE_NAME, COLUMN_NAME", conn)
                  DAFKO = New MySqlDataAdapter("SELECT * FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE	REFERENCED_TABLE_SCHEMA = '" & LblBaDO.Text & "' AND REFERENCED_TABLE_NAME = '" & oTablaO.item(0) & "' Order by TABLE_NAME, COLUMN_NAME", conn)
                  If DtSet.Tables.Contains("ForKeyO") Then DtSet.Tables.Remove("ForKeyO")
                  DAFKO.Fill(DtSet, "ForKeyO")
                  DAFKD = New MySqlDataAdapter("SELECT TABLE_NAME, COLUMN_NAME, ORDINAL_POSITION, POSITION_IN_UNIQUE_CONSTRAINT, CONSTRAINT_NAME, REFERENCED_TABLE_NAME, REFERENCED_COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE	REFERENCED_TABLE_SCHEMA = '" & LblBaDD.Text & "' AND REFERENCED_TABLE_NAME = '" & oTablaO.item(0) & "' Order by Table_Name, Column_Name", conn)
                  If DtSet.Tables.Contains("ForKeyD") Then DtSet.Tables.Remove("ForKeyD")
                  DAFKD.Fill(DtSet, "ForKeyD")
                  ColuAnt = ""
                  For Each oFilFKO In DtSet.Tables("ForKeyO").Rows
                     If ColuAnt = "" OrElse ColuAnt <> oFilFKO("CONSTRAINT_NAME") Then
                        oFilsFKD = DtSet.Tables("ForKeyD").Select("CONSTRAINT_NAME='" & oFilFKO("CONSTRAINT_NAME") & "'")
                        If IsNothing(oFilsFKD) OrElse oFilsFKD.Length = 0 Then
                           LstTabE.Items.Add(oTablaO.item(0) & ": FK NO EXISTE:" & oFilFKO("CONSTRAINT_NAME")) : BtnRepT.Visible = True
                        Else  'Comprobamos que las FK sean iguales
                           oFilsFKO = DtSet.Tables("ForKeyO").Select("CONSTRAINT_NAME='" & oFilFKO("CONSTRAINT_NAME") & "'")
                           If oFilsFKO.Length <> oFilsFKD.Length Then
                              LstTabE.Items.Add(oTablaO.item(0) & ": FK Nº CAMPOS DIFERENTES:" & oFilFKO("CONSTRAINT_NAME")) : BtnRepT.Visible = True
                           Else
                              For IND = 0 To oFilsFKO.Length - 1
                                 If oFilsFKD(IND).Item("TABLE_NAME") <> oFilsFKO(IND).Item("TABLE_NAME") OrElse oFilsFKD(IND).Item("COLUMN_NAME") <> oFilsFKO(IND).Item("COLUMN_NAME") OrElse oFilsFKD(IND).Item("ORDINAL_POSITION") <> oFilsFKO(IND).Item("ORDINAL_POSITION") OrElse oFilsFKD(IND).Item("POSITION_IN_UNIQUE_CONSTRAINT") <> oFilsFKO(IND).Item("POSITION_IN_UNIQUE_CONSTRAINT") Then
                                    LstTabE.Items.Add(oTablaO.item(0) & ": FK VALORES DIFERENTES:" & oFilFKO("CONSTRAINT_NAME")) : BtnRepT.Visible = True
                                 End If
                              Next
                           End If
                           'For Each oFilFKO
                           '   'NO ES
                           '   LstTabE.Items.Add(oTablaO.item(0) & ": No existe Foreing Keys:" & oFilFKO("CONSTRAINT_NAME")) : BtnRepT.Visible = True
                           'End If
                        End If
                        ColuAnt = oFilFKO("CONSTRAINT_NAME")
                     End If
                  Next
               End If
            End If
         Next
         '
         'BORRABLES
         '
         For Each oTablaD In DtSet.Tables("TablasD").Rows         'Verifica Tabla y campos borrables
            If DtSet.Tables("TablasO").Select("Tables_in_" & LblBaDO.Text & "='" & oTablaD.item(0) & "'").Length = 0 Then
               LstTabE.Items.Add(oTablaD.item(0) & ": Tabla borrable") : BtnRepT.Visible = True
            Else
               DAColD = New MySqlDataAdapter("Show Columns in " & LblBaDD.Text & "." & oTablaD(0), conn)        'Campos Tabla Origen
               If DtSet.Tables.Contains("CamposD") Then DtSet.Tables.Remove("CamposD")
               DAColD.Fill(DtSet, "CamposD")
               If DtSet.Tables("CamposD").Rows.Count Then
                  DAColO = New MySqlDataAdapter("Show Columns in " & LblBaDO.Text & "." & oTablaD(0), conn)
                  If DtSet.Tables.Contains("CamposO") Then DtSet.Tables.Remove("CamposO")
                  DAColO.Fill(DtSet, "CamposO")
                  'Recorremos campos tabla Origen
                  For Each oCampoD In DtSet.Tables("CamposD").Rows
                     Dim oFila() As DataRow
                     oFila = DtSet.Tables("CamposO").Select("Field='" & oCampoD.item(0) & "'")
                     If oFila.Length = 0 Then                                       'Campo no existe
                        LstTabE.Items.Add(oTablaD.item(0) & ": Campos borrables") : BtnRepT.Visible = True
                        Exit For
                     End If
                  Next
               Else
                  MsgBox("No se han encontrado campos en la Tabla " & oTablaD.item(0) & " de la B.D. Origen", vbInformation, "Atencion!")
               End If
               If CheNMIn.Checked = False Then
                  'Indices borrables
                  DAIndD = New MySqlDataAdapter("Show Index from " & LblBaDD.Text & "." & oTablaD.item(0), conn)
                  If DtSet.Tables.Contains("IndicesD") Then DtSet.Tables.Remove("IndicesD")
                  DAIndD.Fill(DtSet, "IndicesD")
                  If DtSet.Tables("IndicesD").Rows.Count Then
                     DAIndO = New MySqlDataAdapter("Show Index from " & LblBaDO.Text & "." & oTablaD.item(0), conn)
                     If DtSet.Tables.Contains("IndicesO") Then DtSet.Tables.Remove("IndicesO")
                     DAIndO.Fill(DtSet, "IndicesO")
                     For Each oIndice In DtSet.Tables("IndicesD").Rows
                        Dim oFilI() As DataRow
                        oFilI = DtSet.Tables("IndicesO").Select("Key_name='" & oIndice.item(2) & "'")
                        If oFilI.Length = 0 Then
                           LstTabE.Items.Add(oTablaD.item(0) & ": Indices borrables") : BtnRepT.Visible = True
                        End If
                     Next
                  End If
               End If
               'Verificar foreign Key
               If CheFk.Checked Then
                  'DAFKO = New MySqlDataAdapter("SELECT TABLE_NAME, COLUMN_NAME, CONSTRAINT_NAME, REFERENCED_TABLE_NAME, REFERENCED_COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE	REFERENCED_TABLE_SCHEMA = '" & LblBaDO.Text & "' AND REFERENCED_TABLE_NAME = '" & oTablaO.item(0) & "' Order by TABLE_NAME, COLUMN_NAME", conn)
                  DAFKO = New MySqlDataAdapter("SELECT * FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE	REFERENCED_TABLE_SCHEMA = '" & LblBaDO.Text & "' AND REFERENCED_TABLE_NAME = '" & oTablaD.item(0) & "' Order by TABLE_NAME, COLUMN_NAME", conn)
                  If DtSet.Tables.Contains("ForKeyO") Then DtSet.Tables.Remove("ForKeyO")
                  DAFKO.Fill(DtSet, "ForKeyO")
                  DAFKD = New MySqlDataAdapter("SELECT TABLE_NAME, COLUMN_NAME, ORDINAL_POSITION, POSITION_IN_UNIQUE_CONSTRAINT, CONSTRAINT_NAME, REFERENCED_TABLE_NAME, REFERENCED_COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE	REFERENCED_TABLE_SCHEMA = '" & LblBaDD.Text & "' AND REFERENCED_TABLE_NAME = '" & oTablaD.item(0) & "' Order by Table_Name, Column_Name", conn)
                  If DtSet.Tables.Contains("ForKeyD") Then DtSet.Tables.Remove("ForKeyD")
                  DAFKD.Fill(DtSet, "ForKeyD")
                  For Each oFilFKD In DtSet.Tables("ForKeyD").Rows
                     oFilsFKO = DtSet.Tables("ForKeyO").Select("CONSTRAINT_NAME='" & oFilFKD("CONSTRAINT_NAME") & "'")
                     If IsNothing(oFilsFKO) OrElse oFilsFKO.Length = 0 Then
                        LstTabE.Items.Add(oTablaD.item(0) & ": FK BORRABLE:" & oFilFKD("CONSTRAINT_NAME")) : BtnRepT.Visible = True
                     End If
                  Next
               End If
            End If
         Next
         If LstTabE.Items.Count > 0 Then
            Emergente("Comparacion realizada, se encontraron algunos errores")
         Else
            MsgBox("No se han encontrado errores", vbInformation, "Atención")
         End If
      Else
         MsgBox("No se han encontrado tablas en la B.D. Origen", vbInformation, "Atencion!")
      End If
      conn.Close()
      Cursor = Cursors.Default
   End Sub
Private Function FColAnt(ByRef vTabla As DataTable, ByRef Campo As String) As String
   Dim CampoAnt As String
   Dim Existe As Boolean

   CampoAnt = ""           'El campo esta en la primera posicion
   Existe = False          'El campo no se ha encontrado en la Tabla ¿?¿?¿? o deberia poder ser
   For Each oCampo In vTabla.Rows
      If Campo = oCampo(0) Then
         Existe = True
         Exit For
      End If
      CampoAnt = oCampo(0)
   Next
   If Existe Then Return CampoAnt Else Return "·"
End Function
Private Sub LstTabE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstTabE.SelectedIndexChanged
      Dim vTabla As String
      Dim vError As String
      Dim ColuAnt As String
      Dim DAColO As MySqlDataAdapter
      Dim DAColD As MySqlDataAdapter
      Dim DAIndO As MySqlDataAdapter
      Dim DAIndD As MySqlDataAdapter
      Dim DtSet As DataSet
      Dim IndAnt As String
      Dim DAFKO As MySqlDataAdapter
      Dim DAFKD As MySqlDataAdapter
      Dim oFilFKO, oFilFKD, oFilsFKO(), oFilsFKD() As DataRow

      FraIndice.Visible = False
      FraCamp.Visible = False
      AbrirBd()
      If LstTabE.SelectedItem <> "" Then
         LstErro.Items.Clear()
         vTabla = Trim(Mid(LstTabE.SelectedItem, 1, InStr(LstTabE.SelectedItem, ":") - 1))
         vError = Trim(Mid(LstTabE.SelectedItem, InStr(LstTabE.SelectedItem, ":") + 1))
         If vError = "Tabla no encontrada" Then
            BtnCopi.Text = "Copiar Tabla"
            BtnCopi.Visible = True
            BtnRepa.Visible = False
         ElseIf vError = "Tabla borrable" Then
            BtnCopi.Text = "Borrar Tabla"
            BtnCopi.Visible = True
            BtnRepa.Visible = False
         ElseIf vError = "Campos borrables" Then
            DtSet = New DataSet
            DAColD = New MySqlDataAdapter("Show Columns in " & LblBaDD.Text & "." & vTabla, conn)        'Campos Tabla Origen
            DAColD.Fill(DtSet, "CamposD")
            If DtSet.Tables("CamposD").Rows.Count Then
               DAColO = New MySqlDataAdapter("Show Columns in " & LblBaDO.Text & "." & vTabla, conn)
               DAColO.Fill(DtSet, "CamposO")
               For Each oCampoD In DtSet.Tables("CamposD").Rows
                  Dim oFila() As DataRow
                  oFila = DtSet.Tables("CamposO").Select("Field='" & oCampoD.item(0) & "'")
                  If oFila.Length = 0 Then                                       'Campo no existe
                     LstErro.Items.Add(oCampoD(0) & ": Campo no existe en origen > Borrar campo")
                  End If
               Next
            Else
               MsgBox("Error Campo borrables")
            End If
         ElseIf vError = "Indices incorrectos" Then
            'Verificar indices
            DtSet = New DataSet
            DAIndO = New MySqlDataAdapter("Show Index from " & LblBaDO.Text & "." & vTabla, conn)
            DAIndO.Fill(DtSet, "IndicesO")
            If DtSet.Tables("IndicesO").Rows.Count Then
               DAIndD = New MySqlDataAdapter("Show Index from " & LblBaDD.Text & "." & vTabla, conn)
               DAIndD.Fill(DtSet, "IndicesD")
               ColuAnt = ""
               For Each oIndice In DtSet.Tables("IndicesO").Rows
                  If oIndice(2) <> ColuAnt Then     'Para indices con multiples campos
                     ColuAnt = oIndice(2)
                     Dim oFilI() As DataRow
                     oFilI = DtSet.Tables("IndicesD").Select("Key_name='" & oIndice.item(2) & "'") ')& "' AND Seq_in_index=" & oIndice.item(3))
                     If oFilI.Length = 0 Then
                        LstErro.Items.Add(oIndice.item(2) & ": Indice no encontrado > Añadir indice")
                     Else
                        If oIndice(1) = oFilI(0)(1) And oIndice(4) = oFilI(0)(4) And
                           oIndice(5) = oFilI(0)(5) And Asig(oIndice(7)) = Asig(oFilI(0)(7)) And
                           Asig(oIndice(8)) = Asig(oFilI(0)(8)) And Asig(oIndice(9)) = Asig(oFilI(0)(9)) And
                           Asig(oIndice(10)) = Asig(oFilI(0)(10)) And Asig(oIndice(11)) = Asig(oFilI(0)(11)) Then
                           'No hacemos nada
                        Else
                           LstErro.Items.Add(oIndice(2) & ": Indices diferentes > Modificar indices")
                        End If
                     End If
                  End If
               Next
            End If
         ElseIf vError = "Indices borrables" Then
            'Indices borrables
            DtSet = New DataSet
            DAIndD = New MySqlDataAdapter("Show Index from " & LblBaDD.Text & "." & vTabla, conn)
            DAIndD.Fill(DtSet, "IndicesD")
            If DtSet.Tables("IndicesD").Rows.Count Then
               DAIndO = New MySqlDataAdapter("Show Index from " & LblBaDO.Text & "." & vTabla, conn)
               DAIndO.Fill(DtSet, "IndicesO")
               ColuAnt = ""
               For Each oIndice In DtSet.Tables("IndicesD").Rows
                  If oIndice(2) <> ColuAnt Then     'Para indices con multiples campos
                     ColuAnt = oIndice(2)
                     Dim oFilI() As DataRow
                     oFilI = DtSet.Tables("IndicesO").Select("Key_name='" & oIndice.item(2) & "' AND Seq_in_index=" & oIndice.item(3))
                     If oFilI.Length = 0 Then
                        LstErro.Items.Add(oIndice(2) & ": Indice no existe en origen > Borrar indice") : BtnRepT.Visible = True
                     End If
                  End If
               Next
            End If
         ElseIf vError = "FK BORRABLE" Then
            DtSet = New DataSet
            DAFKO = New MySqlDataAdapter("SELECT * FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE	REFERENCED_TABLE_SCHEMA = '" & LblBaDO.Text & "' AND REFERENCED_TABLE_NAME = '" & vTabla & "' Order by TABLE_NAME, COLUMN_NAME", conn)
            If DtSet.Tables.Contains("ForKeyO") Then DtSet.Tables.Remove("ForKeyO")
            DAFKO.Fill(DtSet, "ForKeyO")
            DAFKD = New MySqlDataAdapter("SELECT * FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE	REFERENCED_TABLE_SCHEMA = '" & LblBaDD.Text & "' AND REFERENCED_TABLE_NAME = '" & vTabla & "' Order by Table_Name, Column_Name", conn)
            If DtSet.Tables.Contains("ForKeyD") Then DtSet.Tables.Remove("ForKeyD")
            DAFKD.Fill(DtSet, "ForKeyD")
            For Each oFilFKD In DtSet.Tables("ForKeyD").Rows
               oFilsFKO = DtSet.Tables("ForKeyO").Select("CONSTRAINT_NAME='" & oFilFKD("CONSTRAINT_NAME") & "'")
               If IsNothing(oFilsFKO) OrElse oFilsFKO.Length = 0 Then
                  LstErro.Items.Add(oFilFKD("CONSTRAINT_NAME") & ": Foreing no existe en origen > Borrar FK") : BtnRepT.Visible = True
               End If
            Next
         ElseIf vError = "Indices borrables" Then
         Else
            DtSet = New DataSet
               DAColO = New MySqlDataAdapter("Show Columns in " & LblBaDO.Text & "." & vTabla, conn)        'Campos Tabla Origen
               DAColO.Fill(DtSet, "CamposO")
               If DtSet.Tables("CamposO").Rows.Count Then
                  DAColD = New MySqlDataAdapter("Show Columns in " & LblBaDD.Text & "." & vTabla, conn)
                  DAColD.Fill(DtSet, "CamposD")
                  ColuAnt = ""
                  For Each oCampoO In DtSet.Tables("CamposO").Rows
                     Dim oFila() As DataRow
                     oFila = DtSet.Tables("CamposD").Select("Field='" & oCampoO.item(0) & "'")
                     If oFila.Length = 0 Then                                       'Campo no existe
                        LstErro.Items.Add(oCampoO.item(0) & ": Campo no encontrado, acción > Añadir campo")
                     Else
                        'Verificar que los campos son iguales
                        If oCampoO(1) = oFila(0)(1) Then    'Mismo tipo
                           If oCampoO(2) = oFila(0)(2) Then    'Admite nulos
                              'If oCampoO(3) = oFila(0)(3) Then    'Campo clave (desactivado, que se encargue la revision de indices)
                              If Asig(oCampoO(4)) = Asig(oFila(0)(4)) Then    'Valor predeterminado                        
                                 '   If oCampoO(5) = oFila(0)(5) Then    'Extra ¿?¿?¿?
                                 If ChePosi.Checked = False OrElse (ChePosi.Checked = True AndAlso ColuAnt = FColAnt(DtSet.Tables("CamposD"), oFila(0)(0))) Then
                                 Else
                                    LstErro.Items.Add(oFila(0)(0) & ": Posicion del campo diferente, acción > cambiar posicion campos")  'Posicion del campo diferente
                                 End If
                                 '   Else
                                 '      LstTabE.Items.Add(oTablaO.item(0) & ": Campos incorrectos")       'Valor predeterminado diferente
                                 '      Exit For
                                 '   End If
                              Else
                                 LstErro.Items.Add(oFila(0)(0) & ": Valor predeterminado diferente, acción > Modificar campo")  'Campo clave diferente
                              End If
                              'Else
                              '   LstErro.Items.Add(oFila(0)(0) & ": Campo clave, acción > Modificar campo")                        'Campo clave diferente                           
                              'End If
                           Else
                              LstErro.Items.Add(oFila(0)(0) & ": Admite nulos, acción > Modificar campo")                    'Admite nulos diferente
                           End If
                        Else
                           LstErro.Items.Add(oFila(0)(0) & ": Tipo de dato diferente, acción > Modificar campo")             'Tipo diferente
                        End If
                     End If
                     ColuAnt = oCampoO(0)
                  Next
               Else
                  MsgBox("No se han encontrado campos en la Tabla " & vTabla & " de la B.D. Origen", vbInformation, "Atencion!")
               End If
      End If
         If LstErro.Items.Count > 0 Then LstErro.SelectedIndex = 0
      End If
      conn.Close()
   End Sub
Private Sub LstErro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstErro.SelectedIndexChanged
   Dim vTabla As String
   Dim vError As String
   Dim vAccion As String
   Dim DtSet As New DataSet
   Dim DAColO As MySqlDataAdapter
   Dim DAColD As MySqlDataAdapter
   Dim DAIndO As MySqlDataAdapter
   Dim CadAux As String

   If LstErro.SelectedItem = "" Then Exit Sub 'No hay ningun item seleccionado (Copiar Tabla)

   vTabla = Trim(Mid(LstTabE.SelectedItem, 1, InStr(LstTabE.SelectedItem, ":") - 1))
   vError = Trim(Mid(LstErro.SelectedItem, InStr(LstTabE.SelectedItem, ":") + 1))
   vAccion = Trim(Mid(LstErro.SelectedItem, InStr(LstErro.SelectedItem, ">") + 1))

   FraIndice.Visible = False
   FraCamp.Visible = False

   If InStr(vError, "indice") <> 0 Then     'Error con los indices
      LblIndi.Text = Trim(Mid(LstErro.SelectedItem, 1, InStr(LstErro.SelectedItem, ":") - 1))
      FraIndice.Visible = True
      'Rellenamos los datos del campo ORIGEN
      LstIndO.Items.Clear()
      If vAccion <> "Borrar indice" Then
         DAIndO = New MySqlDataAdapter("Show Index in " & LblBaDO.Text & "." & vTabla, conn)        'Campos Tabla Origen
         DAIndO.Fill(DtSet, "IndicesO")
         If DtSet.Tables("IndicesO").Rows.Count Then      'Datos del campo origen
            Dim oIndiO() As DataRow
            oIndiO = DtSet.Tables("IndicesO").Select("Key_name ='" & LblIndi.Text & "'")
            For Each oIndOO In oIndiO
               cadaux = oIndOO(4)
               CadAux &= " " & IIf(oIndOO(5) = "A", "ASC ", "DESC")
               cadaux &= " | " & oIndOO(1) & " " & oIndOO(3) & " " & oIndOO(6) & " " & _
                           oIndOO(7) & " " & oIndOO(8) & " " & oIndOO(9) & " " & oIndOO(10)
               LstIndO.Items.Add(CadAux)
            Next
         End If
      End If
      'Rellenamos los datos del indice DESTINO
      LstIndD.Items.Clear()
      DAColD = New MySqlDataAdapter("Show Index in " & LblBaDD.Text & "." & vTabla, conn)        'Campos Tabla Destino
      DAColD.Fill(DtSet, "IndicesD")
      If DtSet.Tables("IndicesD").Rows.Count Then
         Dim oIndiD() As DataRow
         oIndiD = DtSet.Tables("IndicesD").Select("Key_name='" & LblIndi.Text & "'")
         LstIndD.Items.Clear()
         For Each oIndOD In oIndiD
            CadAux = oIndOD(4)
            CadAux &= " " & IIf(oIndOD(5) = "A", "ASC", "DESC")
            CadAux &= " | " & oIndOD(1) & " " & oIndOD(3) & " " & oIndOD(6) & " " & _
                        oIndOD(7) & " " & oIndOD(8) & " " & oIndOD(9) & " " & oIndOD(10)
            LstIndD.Items.Add(CadAux)
         Next
      End If
   Else
      LblCamp.Text = Trim(Mid(LstErro.SelectedItem, 1, InStr(LstErro.SelectedItem, ":") - 1))
      FraCamp.Visible = True : FraIndice.Visible = False
      'Rellenamos los datos del campo ORIGEN
      If vAccion = "Borrar campo" Then
         LblTipO.Text = ""
         LblTipO.Text = ""
         LblPkeO.Text = ""
         LblNulO.Text = ""
         LblVaPO.Text = ""
         LblPosO.Text = ""
      Else
         DAColO = New MySqlDataAdapter("Show Columns in " & LblBaDO.Text & "." & vTabla, conn)        'Campos Tabla Origen
         DAColO.Fill(DtSet, "CamposO")
         If DtSet.Tables("CamposO").Rows.Count Then      'Datos del campo origen
            Dim oCampoO() As DataRow
            oCampoO = DtSet.Tables("CamposO").Select("Field='" & LblCamp.Text & "'")
            If oCampoO.Length = 1 Then
               LblTipO.Text = oCampoO(0)(1)
               LblPkeO.Text = oCampoO(0)(3)
               LblNulO.Text = oCampoO(0)(2)
               LblVaPO.Text = IIf(IsNothing(oCampoO(0)(4)) Or IsDBNull(oCampoO(0)(4)), "", oCampoO(0)(4))
               'LblVaPO.Text = Replace(LblVaPO.Text, "'", "'''")
               'LblVaPO.Text = Replace(LblVaPO.Text, "b", "")
               LblPosO.Text = FColAnt(DtSet.Tables("CamposO"), LblCamp.Text)
            Else
               MsgBox("Error, campo no encontrado " & oCampoO(0)(0) & "'")
            End If
         End If
      End If
      'Rellenamos los datos del campo DESTINO
      If vAccion = "Añadir campo" Then
         LblTipD.Text = ""
         LblPKeD.Text = ""
         LblNulD.Text = ""
         LblVaPD.Text = ""
         LblPosD.Text = ""
      Else
         DAColD = New MySqlDataAdapter("Show Columns in " & LblBaDD.Text & "." & vTabla, conn)        'Campos Tabla Destino
         DAColD.Fill(DtSet, "CamposD")
         If DtSet.Tables("CamposD").Rows.Count Then
            Dim oCampoD() As DataRow
            oCampoD = DtSet.Tables("CamposD").Select("Field='" & LblCamp.Text & "'")
            If oCampoD.Length = 1 Then
               LblTipD.Text = oCampoD(0)(1)
               LblPKeD.Text = oCampoD(0)(3)
               LblNulD.Text = oCampoD(0)(2)
               LblVaPD.Text = IIf(IsNothing(oCampoD(0)(4)) Or IsDBNull(oCampoD(0)(4)), "", oCampoD(0)(4))
               LblPosD.Text = FColAnt(DtSet.Tables("CamposD"), LblCamp.Text)
            Else
               MsgBox("Error, campo no encontrado " & LblCamp.Text & "'")
            End If
         End If
      End If
   End If
   BtnCopi.Text = vAccion
   BtnCopi.Visible = True
   BtnRepa.Visible = True
End Sub
Private Sub BtnCopi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopi.Click
      Dim vTabla As String
      Dim CadAux As String = ""
      Dim IndAux As String = ""
      Dim IndLst As Integer
      Dim Comandoc As MySqlCommand

      If CheIgFK.Checked Then
         conn.Open()
         Comandoc = New MySqlCommand("SET FOREIGN_KEY_CHECKS=0", conn)
         Comandoc.ExecuteNonQuery()
         conn.Close()
      End If

      vTabla = Trim(Mid(LstTabE.SelectedItem, 1, InStr(LstTabE.SelectedItem, ":") - 1))
      If BtnCopi.Text = "Copiar Tabla" Then
         Try
            If CheSiTo.Checked OrElse (CheSiTo.Checked = False And MsgBox("Se va a copiar la tabla " & vTabla & " de la base de datos " & LblBaDO.Text & " en la base de datos " & LblBaDD.Text & ". ¿Desea continuar?", vbYesNo + vbQuestion, "Atencion!") = vbYes) Then
               AbrirBd()
               'Dim clonatabla As New MySqlCommand("CREATE TABLE " & LblBaDD.Text & "." & vTabla & " SELECT * FROM " & LblBaDO.Text & "." & vTabla & " LIMIT 1", conn)
               Dim ClonaTabla As New MySqlCommand("create table `" & LblBaDD.Text & "`.`" & vTabla & "` like `" & LblBaDO.Text & "`.`" & vTabla & "`", conn)
               ClonaTabla.ExecuteNonQuery() ' ejecuta la consulta de creación
               conn.Close()
               If CheNoMo.Checked = False Then Emergente("Tabla COPIADA correctamente")
            End If
            LstErro.Items.Remove(LstErro.SelectedItem)
         Catch
            If MsgBox("No se pudo copiar la tabla correctamente " & Err.Number & "," & Err.Description & vbCrLf & "¿Desea continuar?", vbCritical + vbYesNo, "Atencion!") = vbYes Then
               LstErro.Items.Remove(LstErro.SelectedItem)
            Else
               Exit Sub
            End If
         End Try
      ElseIf BtnCopi.Text = "Borrar Tabla" Then
         Try
            If CheSiTo.Checked OrElse (CheSiTo.Checked = False And MsgBox("Se va a borrar la tabla " & vTabla & " de la base de datos " & LblBaDD.Text & ". ¿Desea continuar?", vbYesNo + vbQuestion, "Atencion!") = vbYes) Then
               AbrirBd()
               'Dim clonatabla As New MySqlCommand("CREATE TABLE " & LblBaDD.Text & "." & vTabla & " SELECT * FROM " & LblBaDO.Text & "." & vTabla & " LIMIT 1", conn)
               Dim BorraTabla As New MySqlCommand("drop table `" & LblBaDD.Text & "`.`" & vTabla & "` ", conn)
               BorraTabla.ExecuteNonQuery() ' ejecuta la consulta de creación
               conn.Close()
               If CheNoMo.Checked = False Then Emergente("Tabla BORRADA correctamente")
            End If
            LstErro.Items.Remove(LstErro.SelectedItem)
         Catch
            If MsgBox("No se pudo borrar la tabla correctamente " & Err.Number & "," & Err.Description & vbCrLf & "¿Desea continuar?", vbCritical + vbYesNo, "Atencion!") = vbYes Then
               LstErro.Items.Remove(LstErro.SelectedItem)
            Else
               Exit Sub
            End If
         End Try
      ElseIf BtnCopi.Text = "Añadir campo" Then
         Try
            If CheSiTo.Checked OrElse (CheSiTo.Checked = False And MsgBox("Se va a añadir el campo " & LblCamp.Text & " a la tabla " & vTabla & " de la base de datos " & LblBaDD.Text & ". ¿Desea continuar?", vbYesNo + vbQuestion, "Atencion!") = vbYes) Then
               CadAux = LblTipO.Text
               If LblNulO.Text = "YES" Then CadAux &= " NULL " Else CadAux &= " NOT NULL "
               If LblVaPO.Text <> "" Then
                  If Strings.Left(LblVaPO.Text, 2) = "b'" OrElse InStr(LblVaPO.Text, "CURRENT_TIMESTAMP") Then
                     CadAux &= " DEFAULT " & LblVaPO.Text
                  Else
                     CadAux &= " DEFAULT '" & LblVaPO.Text & "'"
                  End If
               End If
               If LblAInO.Text <> "" Then CadAux &= " AUTO_INCREMENT "
               If ChePosi.Checked Then
                  If LblPosO.Text = "" Then CadAux &= " First " Else CadAux &= " AFTER `" & LblPosO.Text & "`"
               End If
               AbrirBd()
               Dim CopiaCampo As New MySqlCommand("ALTER TABLE `" & LblBaDD.Text & "`.`" & vTabla & "` ADD COLUMN `" & LblCamp.Text & "` " & CadAux, conn)
               CopiaCampo.ExecuteNonQuery() ' ejecuta la consulta de creación
               conn.Close()
               If CheNoMo.Checked = False Then Emergente("Campo añadido correctamente")
            End If
            LstErro.Items.Remove(LstErro.SelectedItem)
         Catch
            If MsgBox("No se pudo modificar el campo correctamente " & Err.Number & "," & Err.Description & vbCrLf & "¿Desea continuar?", vbCritical + vbYesNo, "Atencion!") = vbYes Then
               LstErro.Items.Remove(LstErro.SelectedItem)
            Else
               Exit Sub
            End If
         End Try
      ElseIf BtnCopi.Text = "Modificar campo" Or BtnCopi.Text = "cambiar posicion campos" Then
         Try
            If CheSiTo.Checked OrElse (CheSiTo.Checked = False And MsgBox("Se va a modificar el campo " & LblCamp.Text & " de la tabla " & vTabla & " de la base de datos " & LblBaDD.Text & ". ¿Desea continuar?", vbYesNo + vbQuestion, "Atencion!") = vbYes) Then
               CadAux = LblTipO.Text
               If LblNulO.Text = "YES" Then CadAux &= " NULL " Else CadAux &= " NOT NULL "
               If LblVaPO.Text <> "" Then
                  If Strings.Left(LblVaPO.Text, 2) = "b'" OrElse InStr(LblVaPO.Text, "CURRENT_TIMESTAMP") Then
                     CadAux &= " DEFAULT " & LblVaPO.Text
                  Else
                     CadAux &= " DEFAULT '" & LblVaPO.Text & "'"
                  End If
               End If
               If LblAInO.Text <> "" Then CadAux &= " AUTO_INCREMENT "
               If BtnCopi.Text = "cambiar posicion campos" Then
                  If LblPosO.Text = "" Then CadAux &= " First " Else CadAux &= " AFTER `" & LblPosO.Text & "`"
               End If
               AbrirBd()
               Dim CambCampo As New MySqlCommand("ALTER TABLE `" & LblBaDD.Text & "`.`" & vTabla & "` MODIFY COLUMN `" & LblCamp.Text & "` " & CadAux, conn)
               CambCampo.ExecuteNonQuery() ' ejecuta la consulta de creación
               conn.Close()
               If CheNoMo.Checked = False Then Emergente("Campo modificado correctamente")
            End If
            LstErro.Items.Remove(LstErro.SelectedItem)
         Catch
            If MsgBox("No se pudo modificar el campo correctamente " & Err.Number & "," & Err.Description & vbCrLf & "¿Desea continuar?", vbCritical + vbYesNo, "Atencion!") = vbYes Then
               LstErro.Items.Remove(LstErro.SelectedItem)
            Else
               Exit Sub
            End If
         End Try
      ElseIf BtnCopi.Text = "Borrar campo" Then
         Try
            If CheSiTo.Checked OrElse (CheSiTo.Checked = False And MsgBox("Se va a borrar el campo " & LblCamp.Text & " a la tabla " & vTabla & " de la base de datos " & LblBaDD.Text & ". ¿Desea continuar?", vbYesNo + vbQuestion, "Atencion!") = vbYes) Then
               AbrirBd()
               Dim CambCampo As New MySqlCommand("ALTER TABLE `" & LblBaDD.Text & "`.`" & vTabla & "` DROP COLUMN `" & LblCamp.Text & "`", conn)
               CambCampo.ExecuteNonQuery() ' ejecuta la consulta de creación
               conn.Close()
               If CheNoMo.Checked = False Then Emergente("Campo eliminado correctamente")
            End If
            LstErro.Items.Remove(LstErro.SelectedItem)
         Catch
            If MsgBox("No se pudo eliminar el campo correctamente " & Err.Number & "," & Err.Description & vbCrLf & "¿Desea continuar?", vbCritical + vbYesNo, "Atencion!") = vbYes Then
               LstErro.Items.Remove(LstErro.SelectedItem)
            Else
               Exit Sub
            End If
         End Try
      ElseIf BtnCopi.Text = "Modificar indices" Then
         Try
            If CheSiTo.Checked OrElse (CheSiTo.Checked = False And MsgBox("Se va a modificar el indice " & LblIndi.Text & " de la tabla " & vTabla & " de la base de datos " & LblBaDD.Text & ". ¿Desea continuar?", vbYesNo + vbQuestion, "Atencion!") = vbYes) Then
               If LblIndi.Text = "PRIMARY" Then
                  CadAux = " PRIMARY KEY ("
                  IndAux = " PRIMARY KEY "
               Else
                  CadAux = " INDEX `" & LblIndi.Text & "` ("
                  IndAux = " INDEX `" & LblIndi.Text & "`"
               End If
               For Each oIndi In LstIndO.Items
                  CadAux &= "`" & Trim(Mid(oIndi, 1, InStr(oIndi, "|") - 6)) & "` " & Trim(Mid(oIndi, InStr(oIndi, "|") - 5, 4)) & ", "
               Next
               CadAux = Strings.Left(CadAux, Len(CadAux) - 2) & ") "
               AbrirBd()
               Dim ModificaInd As New MySqlCommand("ALTER TABLE `" & LblBaDD.Text & "`.`" & vTabla & "` DROP " & IndAux & ", ADD " & CadAux, conn)
               ModificaInd.ExecuteNonQuery() ' ejecuta la consulta de creación
               conn.Close()
               If CheNoMo.Checked = False Then Emergente("Indice modificado correctamente")
            End If
            LstErro.Items.Remove(LstErro.SelectedItem)
         Catch
            If MsgBox("No se pudo modificar el indice correctamente" & Err.Number & "," & Err.Description & vbCrLf & "¿Desea continuar?", vbCritical + vbYesNo, "Atencion!") = vbYes Then
               LstErro.Items.Remove(LstErro.SelectedItem)
            Else
               Exit Sub
            End If
         End Try
      ElseIf BtnCopi.Text = "Añadir indice" Then
         Try
            If CheSiTo.Checked OrElse (CheSiTo.Checked = False And MsgBox("Se va a añadir el indice " & LblIndi.Text & " a la tabla " & vTabla & " de la base de datos " & LblBaDD.Text & ". ¿Desea continuar?", vbYesNo + vbQuestion, "Atencion!") = vbYes) Then
               If LblIndi.Text = "PRIMARY" Then CadAux = " PRIMARY KEY (" Else CadAux = " INDEX `" & LblIndi.Text & "` ("
               For Each oIndi In LstIndO.Items
                  CadAux &= "`" & Trim(Mid(oIndi, 1, InStr(oIndi, "|") - 6)) & "` " & Trim(Mid(oIndi, InStr(oIndi, "|") - 5, 4)) & ", "
               Next
               CadAux = Strings.Left(CadAux, Len(CadAux) - 2) & ") "
               AbrirBd()
               Dim AñadeInd As New MySqlCommand("ALTER TABLE `" & LblBaDD.Text & "`.`" & vTabla & "` ADD " & CadAux, conn)
               AñadeInd.ExecuteNonQuery() ' ejecuta la consulta de creación
               conn.Close()
               If CheNoMo.Checked = False Then Emergente("Indice añadido correctamente")
            End If
            LstErro.Items.Remove(LstErro.SelectedItem)
         Catch
            If MsgBox("No se pudo añadir el indice correctamente " & Err.Number & "," & Err.Description & vbCrLf & "¿Desea continuar?", vbCritical + vbYesNo, "Atencion!") = vbYes Then
               LstErro.Items.Remove(LstErro.SelectedItem)
            Else
               Exit Sub
            End If
         End Try
      ElseIf BtnCopi.Text = "Borrar indice" Then
         Try
            If CheSiTo.Checked OrElse (CheSiTo.Checked = False And MsgBox("Se va a borrar el indice " & LblIndi.Text & " de la tabla " & vTabla & " de la base de datos " & LblBaDD.Text & ". ¿Desea continuar?", vbYesNo + vbQuestion, "Atencion!") = vbYes) Then
               AbrirBd()
               If LblIndi.Text = "PRIMARY" Then CadAux = " PRIMARY KEY " Else CadAux = " INDEX `" & LblIndi.Text & "` "
               Dim BorraInd As New MySqlCommand("ALTER TABLE `" & LblBaDD.Text & "`.`" & vTabla & "` DROP " & CadAux, conn)
               BorraInd.ExecuteNonQuery() ' ejecuta la consulta de creación
               conn.Close()
               If CheNoMo.Checked = False Then Emergente("Indice eliminado correctamente")
            End If
            LstErro.Items.Remove(LstErro.SelectedItem)
         Catch
            If MsgBox("No se pudo eliminar el indice correctamente" & Err.Number & "," & Err.Description & vbCrLf & "¿Desea continuar?", vbCritical + vbYesNo, "Atencion!") = vbYes Then
               LstErro.Items.Remove(LstErro.SelectedItem)
            Else
               Exit Sub
            End If
         End Try
      Else
         MsgBox("No se ha realizado ninguna acción", vbInformation, "Atencion!")
      End If
      If CheIgFK.Checked Then
         AbrirBd()
         Comandoc = New MySqlCommand("SET FOREIGN_KEY_CHECKS=1", conn)
         Comandoc.ExecuteNonQuery()
         conn.Close()
      End If
      Try
         If LstTabE.SelectedItem <> "" AndAlso LstErro.Items.Count = 0 Then
            IndLst = LstTabE.SelectedIndex
            LstTabE.Items.Remove(LstTabE.SelectedItem)
            If IndLst > LstTabE.Items.Count Then
               LstTabE.SelectedIndex = IndLst
            Else
               If LstTabE.Items.Count > 0 Then
                  LstTabE.SelectedIndex = 0
               End If
            End If
         End If
      Catch
         Emergente("Error estableciendo siguiente elemento activo")
      End Try
   End Sub

Private Sub BtnCamb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCamb.Click
  Dim CadAux As String
   CadAux = LblBaDO.Text
   LblBaDO.Text = LblBaDD.Text
   LblBaDD.Text = CadAux
End Sub

Private Sub BtnRepa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRepa.Click
      Dim NElem As Integer
      If LstErro.Items.Count > 0 Then
         NElem = LstErro.Items.Count
         For Ind = 1 To NElem
            LstErro.SelectedIndex = 0
            BtnCopi_Click(Nothing, Nothing)
         Next Ind
      End If
   End Sub

Private Sub BtnRepT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRepT.Click
      Dim NTabs As Integer
      If LstTabE.Items.Count > 0 Then
         NTabs = LstTabE.Items.Count
         For Ind = 1 To NTabs
            LstTabE.SelectedIndex = 0
            If LstErro.Items.Count > 0 Then
               BtnRepa_Click(Nothing, Nothing)
            Else
               BtnCopi_Click(Nothing, Nothing)
            End If
         Next Ind
      End If
   End Sub
Private Sub AbrirBd()
   Try
      conn.Open()
   Catch
      conn.Close()
      conn.Open()
   End Try
End Sub
End Class
