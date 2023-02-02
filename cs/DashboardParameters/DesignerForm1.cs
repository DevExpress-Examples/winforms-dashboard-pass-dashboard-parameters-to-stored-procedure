using System.Linq;

namespace DashboardParameters {
    public partial class DesignerForm1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        public DesignerForm1() {
            InitializeComponent();
            dashboardDesigner.CreateRibbon();
            dashboardDesigner.LoadDashboard(@"Dashboards\dashboard1.xml");
            dashboardDesigner.CustomParameters += DashboardDesigner_CustomParameters;
        }

        private void DashboardDesigner_CustomParameters(object sender, DevExpress.DashboardCommon.CustomParametersEventArgs e) {
            var customerIDsparam = e.Parameters.FirstOrDefault(p => p.Name == "orderIDs"); ;
            if (customerIDsparam != null) {
                customerIDsparam.Value = new string[] {"10251", "10252", "10253", "10254"} ;

            }
        }
    }
}
