//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated {
    using Neo.ApplicationFramework.Controls.Controls;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
    using Neo.ApplicationFramework.Tools.Security;
    using Neo.ApplicationFramework.Tools.Actions;
    using Neo.ApplicationFramework.Common.MultiLanguage;
    
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class Screen3 : Neo.ApplicationFramework.Controls.Controls.Form, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage {
        
        private Neo.ApplicationFramework.Controls.Controls.RadioButton m_rbtExportOption1;
        
        private Neo.ApplicationFramework.Controls.Controls.RadioButton m_rbtExportOption2;
        
        private Neo.ApplicationFramework.Controls.Controls.RadioButton m_rbtExportOption3;
        
        private Neo.ApplicationFramework.Controls.Controls.CheckBox m_cbExportFilesName;
        
        private Neo.ApplicationFramework.Controls.Controls.AnalogNumeric m_AnalogNumericFileName;
        
        private bool m_Initialized_Screen3;
        
        public Screen3() {
            this.InitializeComponent();
            this.rbtExportOption1.Click += new System.EventHandler(this.rbtExportOption1_Click);
            this.rbtExportOption2.Click += new System.EventHandler(this.rbtExportOption2_Click);
            this.rbtExportOption3.Click += new System.EventHandler(this.rbtExportOption3_Click);
            this.cbExportFilesName.Click += new System.EventHandler(this.cbExportFilesName_Click);
            this.Adapter.Opened += new System.EventHandler(this.Screen3_Opened);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RadioButtonCFAdapter rbtExportOption1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RadioButtonCFAdapter>(this.m_rbtExportOption1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RadioButtonCFAdapter rbtExportOption2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RadioButtonCFAdapter>(this.m_rbtExportOption2);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RadioButtonCFAdapter rbtExportOption3 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RadioButtonCFAdapter>(this.m_rbtExportOption3);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter AnalogNumericFileName {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter>(this.m_AnalogNumericFileName);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.CheckBoxCFAdapter cbExportFilesName {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.CheckBoxCFAdapter>(this.m_cbExportFilesName);
            }
        }
        
        private void InitializeComponent() {
            this.m_rbtExportOption1 = new Neo.ApplicationFramework.Controls.Controls.RadioButton();
            this.m_rbtExportOption2 = new Neo.ApplicationFramework.Controls.Controls.RadioButton();
            this.m_rbtExportOption3 = new Neo.ApplicationFramework.Controls.Controls.RadioButton();
            this.m_cbExportFilesName = new Neo.ApplicationFramework.Controls.Controls.CheckBox();
            this.m_AnalogNumericFileName = new Neo.ApplicationFramework.Controls.Controls.AnalogNumeric();
            ((System.ComponentModel.ISupportInitialize)(this.m_rbtExportOption1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rbtExportOption2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rbtExportOption3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_cbExportFilesName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_AnalogNumericFileName)).BeginInit();
            this.SuspendLayout();
            // 
            // Screen3
            // 
            this.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.SingleBorder;
            this.ControlBox = false;
            // 
            // m_rbtExportOption1
            // 
            this.m_rbtExportOption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.m_rbtExportOption1.EnabledDynamicsValue = true;
            this.m_rbtExportOption1.FontFamily = "Tahoma";
            this.m_rbtExportOption1.FontSizePixels = 9;
            this.m_rbtExportOption1.ForeColor = System.Drawing.Color.Black;
            this.m_rbtExportOption1.Location = new System.Drawing.Point(33, 19);
            this.m_rbtExportOption1.Name = "m_rbtExportOption1";
            this.m_rbtExportOption1.Size = new System.Drawing.Size(140, 14);
            this.m_rbtExportOption1.TabIndex = 2147483647;
            this.m_rbtExportOption1.VisibleDynamicsValue = true;
            // 
            // m_rbtExportOption2
            // 
            this.m_rbtExportOption2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.m_rbtExportOption2.EnabledDynamicsValue = true;
            this.m_rbtExportOption2.FontFamily = "Tahoma";
            this.m_rbtExportOption2.FontSizePixels = 9;
            this.m_rbtExportOption2.ForeColor = System.Drawing.Color.Black;
            this.m_rbtExportOption2.Location = new System.Drawing.Point(33, 50);
            this.m_rbtExportOption2.Name = "m_rbtExportOption2";
            this.m_rbtExportOption2.Size = new System.Drawing.Size(109, 14);
            this.m_rbtExportOption2.TabIndex = 2147483647;
            this.m_rbtExportOption2.VisibleDynamicsValue = true;
            // 
            // m_rbtExportOption3
            // 
            this.m_rbtExportOption3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.m_rbtExportOption3.EnabledDynamicsValue = true;
            this.m_rbtExportOption3.FontFamily = "Tahoma";
            this.m_rbtExportOption3.FontSizePixels = 9;
            this.m_rbtExportOption3.ForeColor = System.Drawing.Color.Black;
            this.m_rbtExportOption3.Location = new System.Drawing.Point(33, 78);
            this.m_rbtExportOption3.Name = "m_rbtExportOption3";
            this.m_rbtExportOption3.Size = new System.Drawing.Size(190, 14);
            this.m_rbtExportOption3.TabIndex = 2147483647;
            this.m_rbtExportOption3.VisibleDynamicsValue = true;
            // 
            // m_cbExportFilesName
            // 
            this.m_cbExportFilesName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.m_cbExportFilesName.EnabledDynamicsValue = true;
            this.m_cbExportFilesName.FontFamily = "Tahoma";
            this.m_cbExportFilesName.FontSizePixels = 9;
            this.m_cbExportFilesName.ForeColor = System.Drawing.Color.Black;
            this.m_cbExportFilesName.Location = new System.Drawing.Point(33, 109);
            this.m_cbExportFilesName.Name = "m_cbExportFilesName";
            this.m_cbExportFilesName.Size = new System.Drawing.Size(122, 15);
            this.m_cbExportFilesName.TabIndex = 2147483647;
            this.m_cbExportFilesName.VisibleDynamicsValue = true;
            // 
            // m_AnalogNumericFileName
            // 
            this.m_AnalogNumericFileName.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200))))), Neo.ApplicationFramework.Interfaces.FillDirection.VerticalBottomToTop);
            this.m_AnalogNumericFileName.BitmapEffect = new Neo.ApplicationFramework.Common.Graphics.Logic.BitmapEffectCF(2, 0, Neo.ApplicationFramework.Common.Graphics.Logic.LightAngle.LowerRight);
            this.m_AnalogNumericFileName.BlinkDynamicsValue = false;
            this.m_AnalogNumericFileName.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AnalogNumericFileName.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_AnalogNumericFileName.DelayMouseInputPeriod = 0;
            this.m_AnalogNumericFileName.DisplayFormat = Neo.ApplicationFramework.Interfaces.AnalogNumericDisplayFormat.String;
            this.m_AnalogNumericFileName.Enabled = false;
            this.m_AnalogNumericFileName.EnabledDynamicsValue = false;
            this.m_AnalogNumericFileName.FontSizePixels = 9;
            this.m_AnalogNumericFileName.Height = 22;
            this.m_AnalogNumericFileName.Left = 163;
            this.m_AnalogNumericFileName.Name = "m_AnalogNumericFileName";
            this.m_AnalogNumericFileName.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_AnalogNumericFileName.ScreenOwnerName = "Screen3";
            this.m_AnalogNumericFileName.Top = 105;
            this.m_AnalogNumericFileName.VisibleDynamicsValue = true;
            this.m_AnalogNumericFileName.Width = 124;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ClientSize = new System.Drawing.Size(312, 144);
            this.IsCacheable = false;
            this.Location = new System.Drawing.Point(156, 152);
            this.ModalScreen = true;
            this.Name = "Screen3";
            this.PopupScreen = true;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "Default";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_Screen3 = true;
            this.AddControlsAndPrimitives();
            this.ResumeLayout(false);
        }
        
        protected override Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF CreateInstanceData() {
            System.Collections.Generic.List<Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF> instanceList = new System.Collections.Generic.List<Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF>(1);
            instanceList.Add(this.CreateInstanceData_Default());
            Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF aliasInstances = new Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF();
            aliasInstances.Instances = instanceList.ToArray();
            return aliasInstances;
        }
        
        private Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF CreateInstanceData_Default() {
            Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF aliasinstancecf1 = new Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF();
            aliasinstancecf1.Name = "Default";
            aliasinstancecf1.Values = new Neo.ApplicationFramework.Common.Alias.Entities.AliasValueCF[0];
            return aliasinstancecf1;
        }
        
        protected override void BindAliases() {
        }
        
        protected override void Dispose(bool disposing) {
            base.Dispose(disposing);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddControlsAndPrimitives() {
            if (!m_Initialized_Screen3) {
                return;
            }
            this.AddControls();
            this.AddDrawingPrimitives();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddControls() {
            this.Controls.Add(this.m_cbExportFilesName);
            this.Controls.Add(this.m_rbtExportOption3);
            this.Controls.Add(this.m_rbtExportOption2);
            this.Controls.Add(this.m_rbtExportOption1);
            ((System.ComponentModel.ISupportInitialize)(this.m_rbtExportOption1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rbtExportOption2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rbtExportOption3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_cbExportFilesName)).EndInit();
            base.AddControls();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddDrawingPrimitives() {
            base.AddDrawingPrimitives();
            this.DrawingPrimitives.Add(this.m_AnalogNumericFileName);
            ((System.ComponentModel.ISupportInitialize)(this.m_AnalogNumericFileName)).EndInit();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(Screen3));
            this.m_rbtExportOption1.Text = resources.GetText("Screen3.rbtExportOption1.Text", "Export to Project Files Folder");
            this.m_rbtExportOption2.Text = resources.GetText("Screen3.rbtExportOption2.Text", "Export to USB");
            this.m_rbtExportOption3.Text = resources.GetText("Screen3.rbtExportOption3.Text", "Export to external memory card");
            this.m_cbExportFilesName.Text = resources.GetText("Screen3.cbExportFilesName.Text", "Name of exported file");
            this.ApplyResourcesOnForm();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        void Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage.ApplyLanguage() {
            this.ApplyLanguage();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected override void ApplyLanguage() {
            if (((Neo.ApplicationFramework.Interfaces.IScreen)(this)).IsCachedDeactivated) {
                return;
            }
            this.ApplyLanguageInternal();
            base.ApplyLanguage();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ApplyLanguageInitialize() {
            if (!m_Initialized_Screen3) {
                return;
            }
            base.ApplyLanguageInitialize();
            this.ApplyLanguageInternal();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ConnectDataBindings() {
            base.ConnectDataBindings();
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding1 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.ExportFileName"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_AnalogNumericFileName.DataBindings.Add(dynamicBinding1);
            this.m_DynamicBindings.Add(dynamicBinding1);
        }
    }
}
