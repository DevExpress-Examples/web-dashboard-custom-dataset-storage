<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579940/16.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T392813)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->

# Dashboard for Web Forms - How to Save Dashboards to a DataSet

The following example shows how to create a custom dashboard storage. In this example, a <a href="https://msdn.microsoft.com/en-us/library/system.data.dataset(v=vs.110).aspx">DataSet</a> is used as an in-memory storage of dashboards. You can use <a href="https://msdn.microsoft.com/en-us/library/system.data.common.dataadapter(v=vs.110).aspx">DataAdapter</a> to save dashboard from this DataSet to a database.

The custom dashboard storage should implement one of the following interfaces: [IDashboardStorage](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.IDashboardStorage) or [IEditableDashboardStorage](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.IEditableDashboardStorage).

## Files to Look at

* [CustomDashboardStorage.cs](./CS/CustomDashboardStorage.cs) (VB: [CustomDashboardStorage.vb](./VB/CustomDashboardStorage.vb))
* [DashboardStorageDataSet.cs](./CS/DashboardStorageDataSet.cs) (VB: [DashboardStorageDataSet.vb](./VB/DashboardStorageDataSet.vb))
* [WebForm1.aspx](./CS/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/WebForm1.aspx))
* [WebForm1.aspx.cs](./CS/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/WebForm1.aspx.vb))
<!-- default file list end -->

## Documentation 

* [Prepare Dashboard Storage](https://docs.devexpress.com/Dashboard/16979/web-dashboard/dashboard-backend/prepare-dashboard-storage)
* [IDashboardStorage Interface](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.IDashboardStorage)
* [Manage Multi-Tenancy](https://docs.devexpress.com/Dashboard/402924/web-dashboard/dashboard-backend/manage-multi-tenancy)

## More Examples

- [Dashboard for Web Forms - How to Load and Save Dashboards from/to a Database](https://github.com/DevExpress-Examples/web-dashboard-custom-storage)




<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=web-dashboard-custom-dataset-storage&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=web-dashboard-custom-dataset-storage&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
