Imports System.Linq

Namespace DashboardParameters

    Public Partial Class DesignerForm1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            dashboardDesigner.CreateRibbon()
            dashboardDesigner.LoadDashboard("Dashboards\dashboard1.xml")
            AddHandler dashboardDesigner.CustomParameters, AddressOf DashboardDesigner_CustomParameters
        End Sub

        Private Sub DashboardDesigner_CustomParameters(ByVal sender As Object, ByVal e As DevExpress.DashboardCommon.CustomParametersEventArgs)
            Dim customerIDsparam = e.Parameters.FirstOrDefault(Function(p) Equals(p.Name, "orderIDs"))
            If customerIDsparam IsNot Nothing Then
                customerIDsparam.Value = New String() {"10251", "10252", "10253", "10254"}
            End If
        End Sub
    End Class
End Namespace
