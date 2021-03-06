//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
	using Neo.ApplicationFramework.Tools.Actions;
	using Neo.ApplicationFramework.Common.MultiLanguage;
	
	
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
	public partial class Screen1 : Neo.ApplicationFramework.Controls.Screen.ScreenWindow, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage
	{
		
		public Screen1()
		{
			this.DataContext = Globals.Instance;
			this.InitializeComponent();
			this.Adapter.Opened += new System.EventHandler(this.Screen1_Opened);
			this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
			this.btnStartlog.Click += new System.EventHandler(this.btnStartlog_Click);
			this.btnStopLog.Click += new System.EventHandler(this.btnStopLog_Click);
			this.btnLogOnce.Click += new System.EventHandler(this.btnLogOnce_Click);
			this.btnQueryWithTime.Click += new System.EventHandler(this.btnQueryWithTime_Click);
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
			this.m_btnImport.Click += new System.Windows.RoutedEventHandler(this.m_btnImport_Action_Click);
			this.m_btnSetting.Click += new System.Windows.RoutedEventHandler(this.m_btnSetting_Action_Click);
			this.m_btnExportSetting.Click += new System.Windows.RoutedEventHandler(this.m_btnExportSetting_Action_Click);
			this.ApplyLanguageInternal();
		}
		
		public System.Windows.Forms.DataGridView DataGridView
		{
			get
			{
				return ((System.Windows.Forms.DataGridView)(this.m_DataGridView.Control));
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ButtonAdapter btnQuery
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonAdapter>(this.m_btnQuery);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ButtonAdapter btnStartlog
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonAdapter>(this.m_btnStartlog);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ButtonAdapter btnStopLog
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonAdapter>(this.m_btnStopLog);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ButtonAdapter btnLogOnce
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonAdapter>(this.m_btnLogOnce);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ButtonAdapter btnQueryWithTime
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonAdapter>(this.m_btnQueryWithTime);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ButtonAdapter btnImport
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonAdapter>(this.m_btnImport);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ButtonAdapter btnExport
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonAdapter>(this.m_btnExport);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ButtonAdapter btnSetting
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonAdapter>(this.m_btnSetting);
			}
		}
		
		public System.Windows.Forms.DateTimePicker queryStartDate
		{
			get
			{
				return ((System.Windows.Forms.DateTimePicker)(this.m_queryStartDate.Control));
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.TextElementAdapter Text
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextElementAdapter>(this.m_Text);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ComboBoxAdapter cbbEndHour
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ComboBoxAdapter>(this.m_cbbEndHour);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ComboBoxAdapter cbbStartHour
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ComboBoxAdapter>(this.m_cbbStartHour);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ComboBoxAdapter cbbEndMinute
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ComboBoxAdapter>(this.m_cbbEndMinute);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ComboBoxAdapter cbbStartMinute
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ComboBoxAdapter>(this.m_cbbStartMinute);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.TextElementAdapter Text1
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextElementAdapter>(this.m_Text1);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ComboBoxAdapter cbbStartSecond
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ComboBoxAdapter>(this.m_cbbStartSecond);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ComboBoxAdapter cbbEndSecond
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ComboBoxAdapter>(this.m_cbbEndSecond);
			}
		}
		
		public System.Windows.Forms.DateTimePicker queryEndDate
		{
			get
			{
				return ((System.Windows.Forms.DateTimePicker)(this.m_queryEndDate.Control));
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ButtonAdapter btnExportSetting
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonAdapter>(this.m_btnExportSetting);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ButtonAdapter btnHistory
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonAdapter>(this.m_btnHistory);
			}
		}
		
		protected override Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF CreateInstanceData()
		{
			System.Collections.Generic.List<Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF> instanceList = new System.Collections.Generic.List<Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF>(1);
			instanceList.Add(this.CreateInstanceData_Default());
			Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF aliasInstances = new Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF();
			aliasInstances.Instances = instanceList.ToArray();
			return aliasInstances;
		}
		
		private Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF CreateInstanceData_Default()
		{
			Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF AliasInstanceCF1 = new Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF();
			AliasInstanceCF1.Name = "Default";
			AliasInstanceCF1.Values = new Neo.ApplicationFramework.Common.Alias.Entities.AliasValueCF[0];
			return AliasInstanceCF1;
		}
		
		protected override void BindAliases()
		{
		}
		
		private void m_btnImport_Action_Click(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnImport", "Click", "Show Screen", "Screen5", "Default", "");
			Neo.ApplicationFramework.Generated.Globals.Screen5.Show();
		}
		
		private void m_btnSetting_Action_Click(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnSetting", "Click", "Show Screen", "Screen4", "Default", "");
			Neo.ApplicationFramework.Generated.Globals.Screen4.Show();
		}
		
		private void m_btnExportSetting_Action_Click(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnExportSetting", "Click", "Show Screen", "Screen3", "Default", "");
			Neo.ApplicationFramework.Generated.Globals.Screen3.Show();
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(Screen1));
			this.m_btnQuery.Text = resources.GetText("Screen1.btnQuery.Text", "QueryAll");
			this.m_btnStartlog.Text = resources.GetText("Screen1.btnStartlog.Text", "Start Log");
			this.m_btnStopLog.Text = resources.GetText("Screen1.btnStopLog.Text", "Stop Log");
			this.m_btnLogOnce.Text = resources.GetText("Screen1.btnLogOnce.Text", "Log Once");
			this.m_btnQueryWithTime.Text = resources.GetText("Screen1.btnQueryWithTime.Text", "Query with Time");
			this.m_btnImport.Text = resources.GetText("Screen1.btnImport.Text", "Import DataLogger");
			this.m_btnExport.Text = resources.GetText("Screen1.btnExport.Text", "Export DataLogger");
			this.m_btnSetting.Text = resources.GetText("Screen1.btnSetting.Text", "DataLogger Column Name Setting");
			this.m_Text.Text = resources.GetText("Screen1.Text.Text", "From");
			this.m_Text1.Text = resources.GetText("Screen1.Text1.Text", "To");
			this.m_btnExportSetting.Text = resources.GetText("Screen1.btnExportSetting.Text", "Export Setting");
			this.m_btnHistory.Text = resources.GetText("Screen1.btnHistory.Text", "History Data");
			this.ApplyResourcesOnWindow();
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		void Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage.ApplyLanguage()
		{
			this.ApplyLanguage();
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected override void ApplyLanguage()
		{
			if (((Neo.ApplicationFramework.Interfaces.IScreen)(this)).IsCachedDeactivated)
			{
				return;
			}
			this.ApplyLanguageInternal();
			base.ApplyLanguage();
			this.RefreshBindingsOnObjects();
		}
		
		private void RefreshBindingsOnObjects()
		{
		}
	}
}
