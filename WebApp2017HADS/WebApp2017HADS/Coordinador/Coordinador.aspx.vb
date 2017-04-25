﻿Public Class Coordinador
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LabelUser.Text = Session("UserID")
    End Sub

    Protected Sub LinkButtonCerrarSesion_Click(sender As Object, e As EventArgs) Handles LinkButtonCerrarSesion.Click
        Application("numeroProfesores") = Application("numeroProfesores") - 1
        Listas.eliminarProfesor(Session("UserID"))
        Session.Abandon()
        System.Web.Security.FormsAuthentication.SignOut()
        Response.Redirect("~/Inicio.aspx")
    End Sub

    Protected Sub ButtonMostrarMedia_Click(sender As Object, e As EventArgs) Handles ButtonMostrarMedia.Click
        Dim resultados As New WebService1

        GridView1.DataSource = resultados.obtenerDedicaciones(DropDownListAsignaturas.SelectedValue)
        GridView1.DataBind()
    End Sub
End Class