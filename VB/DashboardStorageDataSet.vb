Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Web

Namespace WebDesigner_CustomDashboardStorage
    Public Class DashboardStorageDataSet
        Inherits DataSet

        Public Sub New()
            Dim table As New DataTable("Dashboards")
            Dim idColumn As New DataColumn("DashboardID", GetType(Int32))
            idColumn.AutoIncrement = True
            idColumn.AutoIncrementSeed = 1
            idColumn.Unique = True
            idColumn.AllowDBNull = False
            table.Columns.Add(idColumn)
            table.Columns.Add("DashboardXml", GetType(String))
            table.Columns.Add("DashboardName", GetType(String))
            table.PrimaryKey = New DataColumn() {idColumn}
            Me.Tables.Add(table)
        End Sub
    End Class
End Namespace