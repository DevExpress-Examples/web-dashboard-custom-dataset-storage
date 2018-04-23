Imports System
Imports DevExpress.DashboardWeb

Namespace WebDesigner_CustomDashboardStorage
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Private Shared dashboardStorage As New CustomDashboardStorage()
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            ASPxDashboard1.SetDashboardStorage(dashboardStorage)
        End Sub
    End Class
End Namespace