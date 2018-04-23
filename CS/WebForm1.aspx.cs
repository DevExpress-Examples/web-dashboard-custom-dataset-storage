using System;
using DevExpress.DashboardWeb;

namespace WebDesigner_CustomDashboardStorage {
    public partial class WebForm1 : System.Web.UI.Page {
        static CustomDashboardStorage dashboardStorage = new CustomDashboardStorage();
        protected void Page_Load(object sender, EventArgs e) {
            ASPxDashboard1.SetDashboardStorage(dashboardStorage);
        }
    }
}