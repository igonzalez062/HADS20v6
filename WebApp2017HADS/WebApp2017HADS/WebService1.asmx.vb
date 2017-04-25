Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Data.SqlClient

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class WebService1
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function obtenerDedicaciones(ByVal asignatura As String) As DataSet
        Dim con As New SqlConnection
        con.ConnectionString = "Server=tcp:1617hads20f2.database.windows.net,1433;Initial Catalog=HADS20_F2;Persist Security Info=False;User ID=hads20@1617hads20f2;Password=Ballena1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30"
        con.Open()

        Dim da As New SqlDataAdapter("SELECT (sum(EstudiantesTareas.HReales)/count(EstudiantesTareas.HReales)) as media FROM EstudiantesTareas INNER JOIN TareasGenericas ON TareasGenericas.Codigo = EstudiantesTareas.CodTarea WHERE TareasGenericas.CodAsig='" & asignatura & "'", con)
        Dim ds As New DataSet
        da.Fill(ds, "Users")

        con.Close()

        Return ds
    End Function

End Class