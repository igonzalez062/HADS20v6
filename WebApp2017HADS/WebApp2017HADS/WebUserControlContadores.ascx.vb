Public Class WebUserControlContadores
    Inherits System.Web.UI.UserControl

    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelProfesoresLogueados.Text = Application("numeroProfesores")
        ListBoxProfesores.Items.Clear()
        For i As Integer = 0 To Listas.getContadorProfesores - 1
            ListBoxProfesores.Items.Add(Listas.getProfesoresIndice(i))
        Next

        LabelAlumnosLogueados.Text = Application("numeroAlumnos")
        ListBoxAlumnos.Items.Clear()
        For i As Integer = 0 To Listas.getContadorAlumnos - 1
            ListBoxAlumnos.Items.Add(Listas.getAlumnosIndice(i))
        Next
    End Sub
   
End Class