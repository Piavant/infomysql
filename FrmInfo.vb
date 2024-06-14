Imports System.IO.StreamWriter
Imports System.IO
Public Class FrmInfo

Private Sub BtnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInfo.Click
   Dim strConn As String
   Dim BaseD As String
   Dim Tabla As String
   Dim CadAux As String
   Dim conn As MySqlConnection
   Dim DtSet As DataSet
   Dim DABaDa As MySqlDataAdapter
   Dim DATabl As MySqlDataAdapter
   Dim DAColu As MySqlDataAdapter
      Dim DAIndex As MySqlDataAdapter
      '
      Dim DAColX As MySqlDataAdapter


      strConn = "server=" & TxtDiBD.Text & "; user id=" & TxtUsua.Text & "; password=" & TxtPass.Text & "; port=" & TxtPuer.Text & ";  pooling=false;"
      conn = New MySqlConnection(strConn)
      conn.Open()
      DABaDa = New MySqlDataAdapter("Show Databases", conn)
      DtSet = New DataSet
      DABaDa.Fill(DtSet, "BDatos")

      If DtSet.Tables("BDatos").Rows.Count Then
         For Each oBase In DtSet.Tables("BDatos").Rows               
            If TxtNoBD.Text <> "" AndAlso oBase("Database") <> TxtNoBD.Text Then GoTo sigui_
            If CheBaDa.Checked Then TxtInfo.Text &= "BASE DE DATOS: " & oBase("Database") & vbCrLf
            If CheTabl.Checked Then
               DATabl = New MySqlDataAdapter("Show Tables in " & oBase("Database"), conn)
               If DtSet.Tables.Contains("Tablas") Then DtSet.Tables.Remove("Tablas")
               DATabl.Fill(DtSet, "Tablas")
               If DtSet.Tables("Tablas").Rows.Count Then
                  For Each oTabla In DtSet.Tables("Tablas").Rows
                     'Tabla = oTabla("Database").ToString
                     TxtInfo.Text &= "Tabla: " & oTabla(0) & vbCrLf
                     If TxtTabla.Text <> "" AndAlso oTabla(0) <> TxtTabla.Text Then GoTo SigTabla_

                     If CheColu.Checked Then
                        'DAColu = New MySqlDataAdapter("Show Columns in " & oBase("Database") & "." & oTabla(0), conn)
                        'If DtSet.Tables.Contains("Columnas") Then DtSet.Tables.Remove("Columnas")
                        'DAColu.Fill(DtSet, "Columnas")
                        'If DtSet.Tables("Columnas").Rows.Count Then
                        '   For Each oColumn In DtSet.Tables("Columnas").Rows
                        '      CadAux = ""
                        '      CadAux &= "     Campo: " & oColumn(0)
                        '      CadAux &= ", tipo: " & oColumn(1)
                        '      CadAux &= ", Nulls: " & oColumn(2)
                        '      CadAux &= IIf(oColumn(3) = "", "", ", Key: " & oColumn(3))
                        '      CadAux &= IIf(IsNothing(oColumn(4)) Or IsDBNull(oColumn(4)), "", ", Valor pred.: " & oColumn(4))
                        '      CadAux &= IIf(IsNothing(oColumn(5)), "", ", " & oColumn(5))
                        '      TxtInfo.Text &= CadAux & vbCrLf
                        '   Next
                        'End If
                        DAColu = New MySqlDataAdapter("SELECT column_name, column_type, is_nullable, column_key, column_default, extra, column_comment FROM  information_schema.columns WHERE table_schema='" & oBase("Database") & "' and table_name ='" & oTabla(0) & "' order by ordinal_position", conn)
                        If DtSet.Tables.Contains("Columnas") Then DtSet.Tables.Remove("Columnas")
                        DAColu.Fill(DtSet, "Columnas")
                        If DtSet.Tables("Columnas").Rows.Count Then
                           For Each oColumn In DtSet.Tables("Columnas").Rows
                              CadAux = ""
                              CadAux &= vbTab & "Campo: " & oColumn(0)
                              CadAux &= vbTab & vbTab & "tipo: " & oColumn(1)
                              CadAux &= vbTab & vbTab & "Nulls: " & oColumn(2)
                              CadAux &= IIf(oColumn(3) = "", vbTab & "", vbTab & "Key: " & oColumn(3))
                              CadAux &= IIf(IsNothing(oColumn(4)) Or IsDBNull(oColumn(4)), vbTab & "", vbTab & "Valor pred.: " & oColumn(4))
                              CadAux &= IIf(IsNothing(oColumn(5)), vbTab & "", vbTab & oColumn(5))
                              CadAux &= IIf(IsNothing(oColumn(6)), vbTab & "", vbTab & "Comment: " & oColumn(6))
                              TxtInfo.Text &= CadAux & vbCrLf
                           Next
                        End If
                     End If
                     If CheIndi.Checked Then
                        DAIndex = New MySqlDataAdapter("Show Index from " & oBase("Database") & "." & oTabla(0), conn)
                        If DtSet.Tables.Contains("Indices") Then DtSet.Tables.Remove("Indices")
                        DAIndex.Fill(DtSet, "Indices")
                        If DtSet.Tables("Indices").Rows.Count Then
                           For Each oIndice In DtSet.Tables("Indices").Rows
                              CadAux = ""
                              CadAux &= "     Indice: " & oIndice(2)
                              'CadAux &= ", tabla: " & oIndice(0)
                              CadAux &= ",  duplicados: " & IIf(oIndice(1) = 0, "No", "Si")
                              CadAux &= ",  Nº Sec.(Col): " & oIndice(3)
                              CadAux &= ",  Nomb.Col.: " & oIndice(4)
                              CadAux &= ",  Ordenacion: " & oIndice(5)
                              CadAux &= ",  Cardinality: " & oIndice(6)
                              CadAux &= ",  Sub_part: " & oIndice(7)
                              CadAux &= ",  packed: " & oIndice(8)
                              CadAux &= ",  nulleable: " & oIndice(9)
                              CadAux &= ",  index type: " & oIndice(10)
                              CadAux &= ",  comment: " & oIndice(11)
                              TxtInfo.Text &= CadAux & vbCrLf
                              'TxtInfo.Text &= "     Indice: " & CadAux & vbCrLf
                           Next
                        End If
                     End If
SigTabla_:
                  Next
               End If
            End If
            If CheBaDa.Checked Then TxtInfo.Text &= vbCrLf
Sigui_:
         Next
      End If
      conn.Close()
End Sub

Private Sub BtnBorr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorr.Click
  TxtInfo.Text = ""
End Sub

Private Sub BtnCreS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreS.Click
   Dim conn As MySqlConnection
   Dim strConn As String
   'Crear Schema
   'CREATE SCHEMA `pruebas`
   conn = New MySqlConnection
   Try 'Comprueba primero si la base de datos creaprueba ya existe intentando conectarse a ella.
      'conn.ConnectionString = "Server=SERVIDOR; Port=3306; Database=creaprueba; Uid=root; Pwd=tucontraseña" ' cadena de conexion a la base de datos.
      strConn = "Server=" & TxtDiBD.Text & "; Port=" & TxtPuer.Text & "; Uid=" & TxtUsua.Text & "; password=" & TxtPass.Text & "; Database = " & TxtNoBD.Text & "; pooling=false;"
      conn = New MySqlConnection(strConn)
      conn.Open() 'abre la conexion.
      Emergente("Conexion correcta")
   Catch ex As Exception 'si la conexion no es correcta es que no existe la base de datos y se intenta crear.
      Emergente("La base de datos no existe, se creara ahora")
      Try
         conn.ConnectionString = "Server=" & TxtDiBD.Text & "; Port=" & TxtPuer.Text & "; Uid=" & TxtUsua.Text & "; Pwd=" & TxtPass.Text  ' cadena de conexion a nuestro MySQL (sin especificar base de datos, aunque tambien se puede poner una que sepamos que existe)."
         conn.Open() 'abre la conexion.
         Dim creabasedatos As New MySqlCommand("create schema " & TxtNoBD.Text, conn) 'crea la consulta de creación de la nueva base de datos.
         creabasedatos.ExecuteReader() 'realiza la consulta de creacion de base de datos.
         MsgBox("base de datos creada") 'si creaprueba se creo correctamente se muestra este mensaje.
      Catch ex1 As Exception
         MsgBox("No se puede crear la base de datos") 'si la falla la creacion de la base de datos se muestra este mensaje.
      End Try
   End Try
   conn.Close() 'cierra la conexion.
End Sub

Private Sub BtnCreT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreT.Click
   Dim strConn As String
   Dim conn As MySqlConnection
   Dim CadAux As String
   'Crear Tabla
   Try
      strConn = "Server=" & TxtDiBD.Text & "; Port=" & TxtPuer.Text & "; Uid=" & TxtUsua.Text & "; password=" & TxtPass.Text & "; Database = " & TxtNoBD.Text & "; pooling=false;"
      conn = New MySqlConnection(strConn)
      Emergente("Conexion correcta")
      Try 'si la conexion ha sido correcta intenta crear la tabla
         conn.Open()
         If TxtCam1.Text <> "" Then

         End If
         Dim creatabla As New MySqlCommand("create table " & TxtTCre.Text & " (id INTEGER UNIQUE NOT NULL AUTO_INCREMENT PRIMARY KEY, nombre text) ENGINE=InnoDB DEFAULT CHARSET=utf8", conn) ' crea la consulta para la creacion de tabla1 con todos los datos necesarios
         'Dim creatabla As New MySqlCommand("create table tbpruebasxxx ", conn)
         creatabla.ExecuteNonQuery() ' ejecuta la consulta de creación
         TxtInfo.Text &= "Tabla creada correctamente"     ' si no hay ningun error se muestra este mensaje
      Catch ex As Exception ' en caso de que no se cree la tabla porque ya exista o por error en la consulta de creacion
            MsgBox("La tabla ya existe o error en la consulta de creacion de tabla " & ex.Message) ' muestra este mensaje en caso de error
      End Try
   Catch ex As Exception
      MsgBox("No se pudo conectar a la base de datos") ' si no es posible conectar con la base de datos se muestra este mensaje
   End Try
   conn.Close() 'cierra la conexion a la base de datos creaprueba
End Sub

Private Sub BtnCreU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreU.Click
   'CREATE(USER) 'jeffrey'@'localhost' IDENTIFIED BY 'mypass';
   'GRANT ALL ON db1.* TO 'jeffrey'@'localhost';
   'GRANT SELECT ON db2.invoice TO 'jeffrey'@'localhost';
   'GRANT USAGE ON *.* TO 'jeffrey'@'localhost' WITH MAX_QUERIES_PER_HOUR 90;
End Sub

Private Sub BtnClon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClon.Click

   Dim strConn As String
   Dim conn As MySqlConnection
   'Clonar tabla
   Try
      'strConn = "server=" & TxtDiBD.Text & "; user id=" & TxtUsua.Text & "; password=" & TxtPass.Text & "; port=" & TxtPuer.Text & "; database=" & TxtNoBD.Text & "; pooling=false;"
      strConn = "server=" & TxtDiBD.Text & "; user id=" & TxtUsua.Text & "; password=" & TxtPass.Text & "; port=" & TxtPuer.Text & ";  pooling=false;"
      conn = New MySqlConnection(strConn)
      Emergente("Conexion correcta")
      Try
         conn.Open()
         Dim clonatabla As New MySqlCommand("CREATE TABLE " & TxtBaDD.Text & "." & TxtTabD.Text & " SELECT * FROM " & TxtNoBD.Text & "." & TxtTabO.Text, conn)
         clonatabla.ExecuteNonQuery() ' ejecuta la consulta de creación
         TxtInfo.Text &= "Tabla clonada correctamente"  ' si no hay ningun error se muestra este mensaje
      Catch ex As Exception ' en caso de que no se cree la tabla porque ya exista o por error en la consulta de creacion
         MsgBox("La tabla ya existe o error en la consulta de clonacion de tabla, " & ex.Message) ' muestra este mensaje en caso de error
      End Try
   Catch ex As Exception
      MsgBox("No se pudo conectar a la base de datos") ' si no es posible conectar con la base de datos se muestra este mensaje
   End Try
   conn.Close() 'cierra la conexion a la base de datos creaprueba
End Sub

Private Sub BtnLReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLReg.Click
   Dim strConn As String
   Dim conn As MySqlConnection
   Dim contador As Integer

   'Contar los registros de una tabla
   Try
      strConn = "server=" & TxtDiBD.Text & "; user id=" & TxtUsua.Text & "; password=" & TxtPass.Text & "; port=" & TxtPuer.Text & "; database=" & TxtNoBD.Text & "; pooling=false"
      conn = New MySqlConnection(strConn)
      Emergente("Conexion correcta")
      Try
         conn.Open()
         Dim contarreg As New MySqlCommand("select count(*) from " & TxtTLReg.Text, conn)
         contador = contarreg.ExecuteScalar
         TxtInfo.Text &= "Registros en la tabla " & TxtTLReg.Text & ": " & contador & vbCrLf
      Catch ex As Exception ' en caso de que no se cree la tabla porque ya exista o por error en la consulta de creacion
         MsgBox("La tabla ya existe o error en la consulta de clonacion de tabla, " & ex.Message) ' muestra este mensaje en caso de error
      End Try
   Catch ex As Exception
      MsgBox("No se pudo conectar a la base de datos") ' si no es posible conectar con la base de datos se muestra este mensaje
   End Try
   conn.Close() 'cierra la conexion a la base de datos creaprueba
End Sub

Private Sub BtnRest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRest.Click
   Dim abrir As New OpenFileDialog
   Dim carpeta As New FolderBrowserDialog

         abrir.DefaultExt = "sql"
        Dim pathmysql As String
        Dim comando As String
        Dim arg As String
        abrir.Filter = "File MYSQL (*.sql)|*.sql"
        pathmysql = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\MySQL AB\MYSQL Server 5.5", "Location", 0)
        If pathmysql = Nothing Then
            MsgBox("No se encontro en tu equipo Mysql, escoge la carpeta donde esta ubicado")
            carpeta.ShowDialog()
            pathmysql = carpeta.SelectedPath
        End If

		If abrir.ShowDialog() = DialogResult.OK Then
			'Try

			comando = pathmysql & "\bin\mysql.exe"
			comando.Replace("\\", "\")
			arg = " --user=root --password= --host=localhost --database catalogos < " & Chr(34) & abrir.FileName & Chr(34)
			Dim proceso As New Process
			proceso.StartInfo.FileName = "cmd.exe"
			proceso.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
			proceso.StartInfo.UseShellExecute = False
			proceso.StartInfo.RedirectStandardOutput = True
			proceso.StartInfo.RedirectStandardInput = True
			proceso.StartInfo.CreateNoWindow = True
			proceso.Start()
			Dim escribeconsola As StreamWriter = proceso.StandardInput
			Dim leyendoconsola As StreamReader = proceso.StandardOutput
			escribeconsola.WriteLine(comando & arg)
			escribeconsola.Close()
			proceso.WaitForExit()
			proceso.Close()

		End If
	End Sub

   Private Sub BtnCopi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopi.Click
      Dim Destino As String
      Dim strConn As String
      Dim conn As MySqlConnection
      strConn = "server=" & TxtDiBD.Text & "; user id=" & TxtUsua.Text & "; password=" & TxtPass.Text & "; port=" & TxtPuer.Text & ";  pooling=false;"
'"server=" & TxtDiBD.Text & "; user id=" & TxtUsua.Text & "; password=" & TxtPass.Text & "; port=" & TxtPuer.Text & "; database=" & TxtNoBD.Text & "; pooling=false"
      conn = New MySqlConnection(strConn)
      'Coneccion.IntegratedSecurity = True 
      If TxtDesC.Text.Length <> 4 Then
         Destino = TxtDesC.Text + "" + TxtBDCo.Text + ".bak"
      Else
         Destino = TxtDesC.Text + TxtBDCo.Text + ".bak"
      End If
      Using conn
         Try
            conn.Open()
            Dim sCmd As String
            'sCmd = "BACKUP DATABASE [" + TxtNoBD.Text + "] TO DISK = N'" + TxtDesC.Text + "' WITH NOFORMAT, NOINIT" + ", "
            'sCmd &= "Name = N'" + TxtNoBD.Text + "', SKIP, NOREWIND, NOUNLOAD, STATS = 10"
            'sCmd = "BACKUP DATABASE [" + TxtNoBD.Text + "] TO DISK = N'" + Destino + "' WITH NOFORMAT, NOINIT" + ", Name = N'" + TxtNoBD.Text + "', SKIP, NOREWIND, NOUNLOAD, STATS = 10"
            Dim archdestino = "C:\copiadatos"
            Dim kk = Application.StartupPath & "\mysqldump"
            sCmd = "" & kk & """ --user=root --pasword=1234 --avantges """ & archdestino & """"
            Dim cmd As New MySqlCommand(sCmd, conn)
            cmd.ExecuteNonQuery()
            TxtInfo.Text &= "Copia seguridad correcta " & vbCrLf
         Catch ex As Exception
            MessageBox.Show(ex.Message)
         Finally
            conn.Close()
         End Try
      End Using
   End Sub

   Private Sub BtnClBd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClBd.Click
      'Clonar Base de datos
      Dim Destino As String
      Dim strConn As String
      Dim conn As MySqlConnection
      Dim Datos As String
      Dim cmd As MySqlCommand
      Dim DtSet As DataSet
      Dim DATabl As MySqlDataAdapter

      TxtInfo.Text = ""
      strConn = "server=" & TxtDiBD.Text & "; user id=" & TxtUsua.Text & "; password=" & TxtPass.Text & "; port=" & TxtPuer.Text '& "; database=" & TxtNoBD.Text & "; pooling=false"
      conn = New MySqlConnection(strConn)
      Using conn
         Try
            conn.Open()
            Dim sCmd As String
            ''sCmd = "create database " & TxtBDCl.Text & "; grant all privileges on " & TxtBDCl.Text & ".* to root"
            'If CheClDa.Checked Then
            '   Datos = ""
            'Else
            '   Datos = "--no-data"
            'End If
            'sCmd = "mysqldump -uroot -p " & TxtNoBD.Text & " -r " & TxtBDCl.Text & Datos
            DtSet = New DataSet
            DATabl = New MySqlDataAdapter("Show Tables in " & TxtNoBD.Text, conn)
            If DtSet.Tables.Contains("Tablas") Then DtSet.Tables.Remove("Tablas")
            DATabl.Fill(DtSet, "Tablas")

            If CheClon.Checked Then
               Try
                  sCmd = "CREATE DATABASE " & TxtBDCl.Text
                  cmd = New MySqlCommand(sCmd, conn)
                  cmd.ExecuteNonQuery()
               Catch
                  MsgBox(Err.Description)
               End Try
            End If

            If DtSet.Tables("Tablas").Rows.Count Then
               For Each oTabla In DtSet.Tables("Tablas").Rows

                  If CheClon.Checked Then
                     Try
                        sCmd = "create table " & TxtBDCl.Text & "." & oTabla(0) & " like " & TxtNoBD.Text & "." & oTabla(0)
                        cmd = New MySqlCommand(sCmd, conn)
                        cmd.ExecuteNonQuery()
                     Catch ex As Exception
                        TxtInfo.Text &= "No se puedo clonar " & oTabla(0) & vbCrLf
                     End Try
                  End If
                  If CheCloD.Checked Then
                     Try
                        sCmd = "insert into " & TxtBDCl.Text & "." & oTabla(0) & " select * from " & TxtNoBD.Text & "." & oTabla(0)
                        cmd = New MySqlCommand(sCmd, conn)
                        cmd.ExecuteNonQuery()
                     Catch ex As Exception
                        TxtInfo.Text &= "No se puedo copiar datos de " & oTabla(0) & vbCrLf
                     End Try
                  End If
               Next
            End If
            TxtInfo.Text &= "Proceso realizado correctamente " & vbCrLf
         Catch ex As Exception
            MessageBox.Show(ex.Message)
            Finally
               conn.Close()
         End Try
      End Using
   End Sub

   Private Sub BtnCopi_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles BtnCopi.Click
      'Dim startInfo As New ProcessStartInfo("c:\projects\MySQLdump.exe", " -u root -p1234 avantgesbases00 -r ""c:\copiadedatos""")
      'startInfo.WindowStyle = ProcessWindowStyle.Minimized
      'Process.Start(startInfo)
      'Process.Start()

      Try
         Dim pObj As New Process()
         pObj.StartInfo.RedirectStandardOutput = True
         pObj.StartInfo.FileName = "c:\projects\MySQLdump.exe"
         pObj.StartInfo.Arguments = "-u root -p1234 avantgesbases00x -r ""c:\kkkk\copiadedatos"""
         pObj.StartInfo.UseShellExecute = False
         pObj.StartInfo.CreateNoWindow = True
         pObj.Start()

         Dim outStr As String = pObj.StandardOutput.ReadToEnd()

         pObj.WaitForExit()

         MsgBox(outStr)

      Catch ex As Exception
         MsgBox(ex.Message)
      End Try
   End Sub

   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnReno.Click
      Dim DtSet As DataSet
      Dim DATab As MySqlDataAdapter
      Dim DACol As MySqlDataAdapter
      Dim StrConn As String
      Dim conn As MySqlConnection
      Dim NumCams As Integer = 0
      Dim cmd As MySqlCommand
      Dim sCmd As String
      Dim TipoDato As String
      Dim Resul As Integer

      'strConn = "server=" & TxtDiBD.Text & "; user id=" & TxtUsua.Text & "; password=" & TxtPass.Text & "; port=" & TxtPuer.Text & "; database=" & TxtNoBD.Text & "; pooling=false;"
      StrConn = "server=" & TxtDiBD.Text & "; user id=" & TxtUsua.Text & "; password=" & TxtPass.Text & "; port=" & TxtPuer.Text & ";  pooling=false;"
      conn = New MySqlConnection(StrConn)
      Emergente("Conexion correcta")
      Try
         conn.Open()
         DATab = New MySqlDataAdapter("Show Tables in " & TxtNoBD.Text, conn)      'Tablas B.D. origen
         DtSet = New DataSet
         DATab.Fill(DtSet, "Tablas")
         If DtSet.Tables("Tablas").Rows.Count Then
            For Each oTabla In DtSet.Tables("Tablas").Rows
               DACol = New MySqlDataAdapter("Show Columns in " & TxtNoBD.Text & "." & oTabla.item(0), conn)        'Campos Tabla Origen
               If DtSet.Tables.Contains("Campos") Then DtSet.Tables.Remove("Campos")
               DACol.Fill(DtSet, "Campos")
               If DtSet.Tables("Campos").Rows.Count Then
                  For Each oCampo In DtSet.Tables("Campos").Rows
                     If oCampo(0).toupper Like TxtColuAnt.Text.ToUpper Then
                        sCmd = $"ALTER TABLE {TxtNoBD.Text}.{oTabla.item(0)} RENAME COLUMN {oCampo(0)} to {TxtColuNuev.Text}"
                        cmd = New MySqlCommand(sCmd, conn)
                        cmd.ExecuteNonQuery()
                        TxtInfo.Text &= $"Cambiado {TxtNoBD.Text}.{oTabla.item(0)} "
                        NumCams += 1
                     End If
                  Next
               Else
                  MsgBox("No se han encontrado campos en la Tabla " & oTabla.item(0) & " de la B.D. Origen", vbInformation, "Atencion!")
               End If
            Next
            '
            If NumCams > 0 Then
               MsgBox("Campos cambios " & NumCams)
            Else
               MsgBox("No se han realizado cambios")
            End If
         Else
            MsgBox("No se han encontrado tablas en la B.D.", vbInformation, "Atencion!")
         End If
         conn.Close()
      Catch
         MsgBox(Err.Description)
      End Try
   End Sub

   Private Sub BtnCone_Click(sender As Object, e As EventArgs) Handles BtnCone.Click
      Dim Resul As Boolean = PruebaConexion()
      If Resul Then
         Emergente("Conexión realizada con exito")
      Else
         MsgBox("No se puedo realizar la conexion con el servidor especificado", vbCritical, Application.ProductName)
      End If
   End Sub
   Private Function PruebaConexion() As Boolean
      Dim StrConn As String
      Dim ConSql As MySqlConnection
      Dim DABaDa As MySqlDataAdapter
      Dim DtTab As DataTable
      Dim Password As String

      Try
         If TxtPass.Text = "" Then
            Password = InputBox("Password conexión B.D.")
         Else
            Password = TxtPass.Text
         End If
         StrConn = "server=" & TxtDiBD.Text & "; user id=" & TxtUsua.Text & "; password=" & TxtPass.Text &
               "; port=" & TxtPuer.Text & ";  pooling=false;"
         ConSql = New MySqlConnection(StrConn)
         ConSql.Open()
         DABaDa = New MySqlDataAdapter("Show Databases ", ConSql)
         DtTab = New DataTable
         DABaDa.Fill(DtTab)
         ConSql.Close()
         PruebaConexion = True
      Catch
         PruebaConexion = False
      End Try
   End Function

   Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnCamTip.Click
      Dim DtSet As DataSet
      Dim DATab As MySqlDataAdapter
      Dim DACol As MySqlDataAdapter
      Dim StrConn As String
      Dim conn As MySqlConnection
      Dim NumCams As Integer = 0
      Dim cmd As MySqlCommand
      Dim sCmd As String
      Dim oUnsig As String
      Dim oAutoI As String
      Dim oDefau As String
      Dim oLong As String

      'strConn = "server=" & TxtDiBD.Text & "; user id=" & TxtUsua.Text & "; password=" & TxtPass.Text & "; port=" & TxtPuer.Text & "; database=" & TxtNoBD.Text & "; pooling=false;"
      StrConn = "server=" & TxtDiBD.Text & "; user id=" & TxtUsua.Text & "; password=" & TxtPass.Text & "; port=" & TxtPuer.Text & ";  pooling=false;"
      conn = New MySqlConnection(StrConn)
      Emergente("Conexion correcta")
      Try
         conn.Open()
         'If CheIgFK.Checked Then
         cmd = New MySqlCommand("SET FOREIGN_KEY_CHECKS=0", conn)
         cmd.ExecuteNonQuery()
         'End If

         DATab = New MySqlDataAdapter("Show Tables in " & TxtNoBD.Text, conn)      'Tablas B.D. origen
         DtSet = New DataSet
         DATab.Fill(DtSet, "Tablas")

         If CheUnsi.Checked Then oUnsig = " UNSIGNED " Else oUnsig = ""

         If DtSet.Tables("Tablas").Rows.Count Then
            For Each oTabla In DtSet.Tables("Tablas").Rows
               DACol = New MySqlDataAdapter("Show Columns in " & TxtNoBD.Text & "." & oTabla.item(0), conn)        'Campos Tabla Origen
               If DtSet.Tables.Contains("Campos") Then DtSet.Tables.Remove("Campos")
               DACol.Fill(DtSet, "Campos")
               If DtSet.Tables("Campos").Rows.Count Then
                  For Each oCampo In DtSet.Tables("Campos").Rows
                     If (TxtColCam.Text = "" OrElse oCampo(0).toupper Like TxtColCam.Text.ToUpper) AndAlso (LstTipOld.Text = "" OrElse (LstTipOld.Text <> "" AndAlso LstTipOld.Text = oCampo(1).toupper)) Then
                        If TxtDefa.Text = "" Then
                           If IsDBNull(oCampo(4)) OrElse oCampo(4) = "" Then
                              oDefau = ""
                              If oCampo(5).toupper = "AUTO_INCREMENT" Then oAutoI = "AUTO_INCREMENT" Else oAutoI = ""
                           Else
                              oDefau = " DEFAULT " & oCampo(4)
                              oAutoI = ""
                           End If
                        Else
                           oDefau = " DEFAULT " & TxtDefa.Text
                        End If
                        If TxtLong.Text <> "" Then oLong = "(" & TxtLong.Text & ")" Else oLong = ""

                        sCmd = $"ALTER TABLE {TxtNoBD.Text}.{oTabla.item(0)} CHANGE COLUMN {oCampo(0)}  {oCampo(0)}  {LstTipNew.Text}{oLong} {oUnsig} {oAutoI} {oDefau};"
                        'ALTER TABLE `hslaguna22`.`albaranes_cab` CHANGE COLUMN `Idc` `Idc` SMALLINT(4) UNSIGNED Not NULL DEFAULT '0' COMMENT 'Id Centro de Trabajo' ;
                        cmd = New MySqlCommand(sCmd, conn)
                        cmd.ExecuteNonQuery()
                        NumCams += 1
                     End If
                  Next
               Else
                  MsgBox("No se han encontrado campos en la Tabla " & oTabla.item(0) & " de la B.D. Origen", vbInformation, "Atencion!")
               End If
            Next
            '
            If NumCams > 0 Then
               MsgBox("Campos cambios " & NumCams)
            Else
               MsgBox("No se han realizado cambios")
            End If
         Else
            MsgBox("No se han encontrado tablas en la B.D.", vbInformation, "Atencion!")
         End If
         'If CheIgFK.Checked Then
         cmd = New MySqlCommand("SET FOREIGN_KEY_CHECKS=1", conn)
         cmd.ExecuteNonQuery()
         'End If
         conn.Close()
      Catch
         MsgBox(Err.Description)
      End Try
   End Sub

   Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

   End Sub

   Private Sub TxtLong_TextChanged(sender As Object, e As EventArgs) Handles TxtLong.TextChanged

   End Sub
End Class
