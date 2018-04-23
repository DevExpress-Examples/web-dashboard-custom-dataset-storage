using System;
using DevExpress.DashboardWeb;
using DevExpress.Web;

    namespace WebDesigner_CustomDashboardStorage {
        public class Global_asax : System.Web.HttpApplication {
            void Application_Start(object sender, EventArgs e) {
                ASPxWebControl.CallbackError += new EventHandler(Application_Error);
                DashboardService.SetDashboardStorage(new CustomDashboardStorage());
            }

            void Application_End(object sender, EventArgs e) {
            }

            void Application_Error(object sender, EventArgs e) {
            }

            void Session_Start(object sender, EventArgs e) {
            }

            void Session_End(object sender, EventArgs e) {
            }
        }
    }