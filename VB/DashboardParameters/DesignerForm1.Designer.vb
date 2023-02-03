Namespace DashboardParameters

    Partial Class DesignerForm1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim dashboardBarAndDockingController1 As DevExpress.DashboardWin.Native.DashboardBarAndDockingController = New DevExpress.DashboardWin.Native.DashboardBarAndDockingController()
            Me.dashboardDesigner = New DevExpress.DashboardWin.DashboardDesigner()
            CType((dashboardBarAndDockingController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dashboardDesigner
            ' 
            Me.dashboardDesigner.AllowMaximizeAnimation = True
            Me.dashboardDesigner.AllowMaximizeDashboardItems = True
            Me.dashboardDesigner.AllowPrintDashboard = True
            Me.dashboardDesigner.AllowPrintDashboardItems = True
            Me.dashboardDesigner.AsyncMode = True
            dashboardBarAndDockingController1.PropertiesDocking.ViewStyle = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Classic
            Me.dashboardDesigner.BarAndDockingController = dashboardBarAndDockingController1
            Me.dashboardDesigner.DataSourceWizard.ShowConnectionsFromAppConfig = True
            Me.dashboardDesigner.DataSourceWizard.SqlWizardSettings.DatabaseCredentialsSavingBehavior = DevExpress.DataAccess.Wizard.SensitiveInfoSavingBehavior.Prompt
            Me.dashboardDesigner.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dashboardDesigner.Location = New System.Drawing.Point(0, 0)
            Me.dashboardDesigner.Name = "dashboardDesigner"
            Me.dashboardDesigner.Size = New System.Drawing.Size(1190, 595)
            Me.dashboardDesigner.TabIndex = 0
            Me.dashboardDesigner.UseNeutralFilterMode = True
            ' 
            ' DesignerForm1
            ' 
            Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1190, 595)
            Me.Controls.Add(Me.dashboardDesigner)
            Me.Name = "DesignerForm1"
            Me.Text = "Dashboard Designer"
            CType((dashboardBarAndDockingController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private dashboardDesigner As DevExpress.DashboardWin.DashboardDesigner
    End Class
End Namespace
