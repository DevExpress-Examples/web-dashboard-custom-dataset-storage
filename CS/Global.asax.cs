using System;
using DevExpress.Web;

    namespace WebDesigner_CustomDashboardStorage {
        public class Global_asax : System.Web.HttpApplication {
            void Application_Start(object sender, EventArgs e) {
                ASPxWebControl.CallbackError += new EventHandler(Application_Error);                
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