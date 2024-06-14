Option Explicit On

Module ModGeneral

#Region "API Calls"
   ' standard API declarations for INI access
   ' changing only "As Long" to "As Int32" (As Integer would work also)
   Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpString As String, _
    ByVal lpFileName As String) As Int32

   Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpDefault As String, _
    ByVal lpReturnedString As String, ByVal nSize As Int32, _
    ByVal lpFileName As String) As Int32
   Public Declare Function GetVolumeInformation Lib "kernel32" _
    Alias "GetVolumeInformationA" (ByVal lpRootPathName As String, _
    ByVal lpVolumeNameBuffer As String, ByVal nVolumeNameSize As Long, _
    ByVal lpVolumeSerialNumber As Long, ByVal lpMaximumComponentLength As Long, _
    ByVal lpFileSystemFlags As Long, ByVal lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Long) As Long

#End Region

#Region "E/S .Ini"

   Public Function Lee_Ini(ByVal SectionName As String, ByVal KeyName As String, ByVal DefaultValue As String) As String
      ' primary version of call gets single value given all parameters
      Dim n As Int32
      Dim sData As String
      Dim INIPath As String

      INIPath = Left(Application.ExecutablePath, Len(Application.ExecutablePath) - 3) & "ini"
      sData = Space$(1024) ' allocate some room
      n = GetPrivateProfileString(SectionName, KeyName, DefaultValue, _
      sData, sData.Length, INIPath)
      If n > 0 Then ' return whatever it gave us
         Lee_Ini = sData.Substring(0, n)
      Else
         Lee_Ini = ""
      End If
   End Function
   Public Sub Esc_Ini(ByVal SectionName As String, ByVal KeyName As String, ByVal TheValue As String)
      Dim INIPath As String

      INIPath = Left(Application.ExecutablePath, Len(Application.ExecutablePath) - 3) & "ini"
      Call WritePrivateProfileString(SectionName, KeyName, TheValue, INIPath)
   End Sub
   Public Sub Bor_Ini(ByVal SectionName As String, ByVal KeyName As String) ' delete single line from section
      Dim INIPath As String

      INIPath = Left(Application.ExecutablePath, Len(Application.ExecutablePath) - 3) & "ini"
      Call WritePrivateProfileString(SectionName, KeyName, Nothing, INIPath)
   End Sub
#End Region

   Function Asig(ByVal cadena As Object) As String
      If IsDBNull(cadena) OrElse (cadena Is Nothing) OrElse (cadena.ToString = "") Then
         Asig = ""
      Else
         Asig = cadena
      End If
   End Function
   Function Valor(ByVal Cadena As Object) As Integer
      'CONVIERTE UNA CADENA DE TEXTO EN UN NUMERO
      Try
         If IsDBNull(Cadena) OrElse (Cadena Is Nothing) OrElse (Cadena = "") Then
            Valor = 0
         Else
            'If Not IsNumeric(Cadena) Then
               Valor = CInt(Cadena)
            'Else
            '   Valor = Val(Cadena)
            'End If
         End If
      Catch

      Finally
         Valor = 0
      End Try
   End Function
   Public Function ConvTxt(ByVal Cad As String) As String
   Dim Res As String = ""
   Dim CadX As String = ""
   Dim Car As String
   Dim Ind As Integer = 0

      If Cad <> "" Then
         CadX = ""
         For Each Car In Cad
            If Car < "0" Or Car > "9" Then
               If IsNumeric(CadX) Then Res = Res & Chr(CadX)
               CadX = ""
            Else
               CadX = CadX & Car
            End If
         Next
      End If
      If IsNumeric(CadX) Then Res = Res & Chr(CadX)
      Return Res
   End Function
   Public Sub Emergente(ByVal Cadena As String, Optional ByVal Tiempo As Integer = 2000, Optional ByVal Alto As Integer = 200)
      Dim slice As New ToastForm(Tiempo, Cadena)
      slice.Height = Alto
      slice.Show()
   End Sub
End Module
