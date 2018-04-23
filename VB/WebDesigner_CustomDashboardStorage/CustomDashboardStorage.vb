Imports System.Collections.Generic
Imports System.Data
Imports System.Xml.Linq
Imports DevExpress.DashboardWeb

Namespace WebDesigner_CustomDashboardStorage
    Public Class CustomDashboardStorage
        Implements IEditableDashboardStorage

        Private dashboards As New DashboardStorageDataSet()

        ' Adds a dashboard with the specified ID and name to a DataSet. 
        ' Note that the 'DashboardID' column is an auto-increment column that is used to store unique dashboard IDs.
        Public Function AddDashboard(ByVal dashboard As XDocument, ByVal dashboardName As String) As String _
                        Implements IEditableDashboardStorage.AddDashboard
            Dim newRow As DataRow = dashboards.Tables(0).NewRow()
            newRow("DashboardName") = dashboardName
            newRow("DashboardXml") = dashboard
            dashboards.Tables(0).Rows.Add(newRow)
            Return newRow("DashboardID").ToString()
        End Function

        ' Gets information about dashboards available in a DataSet.
        Public Function GetAvailableDashboardsInfo() As IEnumerable(Of DashboardInfo) _
                        Implements IEditableDashboardStorage.GetAvailableDashboardsInfo
            Dim dashboardInfos As New List(Of DashboardInfo)()
            For Each row As DataRow In dashboards.Tables(0).Rows
                Dim dashboardInfo As New DashboardInfo()
                dashboardInfo.ID = row("DashboardID").ToString()
                dashboardInfo.Name = row("DashboardName").ToString()
                dashboardInfos.Add(dashboardInfo)
            Next row
            Return dashboardInfos
        End Function

        ' Loads a dashboard corresponding to the specified ID.
        Public Function LoadDashboard(ByVal dashboardID As String) As XDocument _
                        Implements IEditableDashboardStorage.LoadDashboard
            Dim currentRow As DataRow = dashboards.Tables(0).Rows.Find(dashboardID)
            Dim dashboardXml As XDocument = XDocument.Parse(currentRow("DashboardXml").ToString())
            Return dashboardXml
        End Function

        ' Saves the dashboard with the specified ID to a DataSet.
        Public Sub SaveDashboard(ByVal dashboardID As String, ByVal dashboard As XDocument) _
                        Implements IEditableDashboardStorage.SaveDashboard
            Dim currentRow As DataRow = dashboards.Tables(0).Rows.Find(dashboardID)
            currentRow("DashboardXml") = dashboard
        End Sub
    End Class
End Namespace