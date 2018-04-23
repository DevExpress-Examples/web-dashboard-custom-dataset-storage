Imports System
Imports DevExpress.DashboardWeb
Imports DevExpress.Web

    Namespace WebDesigner_CustomDashboardStorage
        Public Class Global_asax
            Inherits System.Web.HttpApplication

            Private Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
                AddHandler ASPxWebControl.CallbackError, AddressOf Application_Error
                DashboardService.SetDashboardStorage(New CustomDashboardStorage())
            End Sub

            Private Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
            End Sub

            Private Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
            End Sub

            Private Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
            End Sub

            Private Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
            End Sub
        End Class
    End Namespace