﻿namespace SMOWMS.UI.Analyze.Assets
{
    partial class frmAssCusAnalysis : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.Title1 = new SMOWMS.UI.UserControl.Title();
            this.plCondition = new Smobiler.Core.Controls.Panel();
            this.dpStart = new Smobiler.Core.Controls.DatePicker();
            this.dpEnd = new Smobiler.Core.Controls.DatePicker();
            this.btnTime = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.btnCus = new Smobiler.Core.Controls.Button();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.popTime = new Smobiler.Core.Controls.PopList();
            this.popCus = new Smobiler.Core.Controls.PopList();
            this.tpvData = new Smobiler.Core.Controls.TabPageView();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "客户报表";
            // 
            // plCondition
            // 
            this.plCondition.BackColor = System.Drawing.Color.White;
            this.plCondition.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plCondition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plCondition.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.dpStart,
            this.dpEnd,
            this.btnTime,
            this.label1,
            this.label2,
            this.label3,
            this.btnCus,
            this.label4});
            this.plCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.plCondition.Location = new System.Drawing.Point(0, 40);
            this.plCondition.Name = "plCondition";
            this.plCondition.Size = new System.Drawing.Size(300, 90);
            // 
            // dpStart
            // 
            this.dpStart.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.dpStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpStart.Location = new System.Drawing.Point(80, 0);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(85, 30);
            this.dpStart.ValueChanged += new System.EventHandler(this.dpStart_ValueChanged);
            // 
            // dpEnd
            // 
            this.dpEnd.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.dpEnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dpEnd.Location = new System.Drawing.Point(205, 0);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(95, 30);
            this.dpEnd.ValueChanged += new System.EventHandler(this.dpEnd_ValueChanged);
            // 
            // btnTime
            // 
            this.btnTime.BackColor = System.Drawing.Color.White;
            this.btnTime.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.btnTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnTime.BorderRadius = 0;
            this.btnTime.ForeColor = System.Drawing.Color.Black;
            this.btnTime.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnTime.Location = new System.Drawing.Point(80, 30);
            this.btnTime.Name = "btnTime";
            this.btnTime.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.btnTime.Size = new System.Drawing.Size(220, 30);
            this.btnTime.Text = "本月   > ";
            this.btnTime.Press += new System.EventHandler(this.btnTime_Press);
            // 
            // label1
            // 
            this.label1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(165, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 30);
            this.label1.Text = "—";
            // 
            // label2
            // 
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(80, 30);
            this.label2.Text = "自定义";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 60);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(80, 30);
            this.label3.Text = "客户";
            // 
            // btnCus
            // 
            this.btnCus.BackColor = System.Drawing.Color.White;
            this.btnCus.BorderRadius = 0;
            this.btnCus.ForeColor = System.Drawing.Color.Black;
            this.btnCus.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnCus.Location = new System.Drawing.Point(80, 60);
            this.btnCus.Name = "btnCus";
            this.btnCus.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.btnCus.Size = new System.Drawing.Size(220, 30);
            this.btnCus.Text = "全部   > ";
            this.btnCus.Press += new System.EventHandler(this.btnCus_Press);
            // 
            // label4
            // 
            this.label4.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(0, 30);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(80, 30);
            this.label4.Text = "常用时间";
            // 
            // popTime
            // 
            this.popTime.Name = "popTime";
            this.popTime.Selected += new System.EventHandler(this.popTime_Selected);
            // 
            // popCus
            // 
            this.popCus.Name = "popCus";
            this.popCus.Selected += new System.EventHandler(this.popCus_Selected);
            // 
            // tpvData
            // 
            this.tpvData.BackColor = System.Drawing.Color.White;
            this.tpvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpvData.Location = new System.Drawing.Point(0, 100);
            this.tpvData.Name = "tpvData";
            this.tpvData.PageIndicator = Smobiler.Core.Controls.TabPageIndicator.Title;
            this.tpvData.Size = new System.Drawing.Size(300, 300);
            this.tpvData.Titles = new string[] {
        "总览",
        "详情"};
            this.tpvData.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), 13F, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), 2);
            // 
            // frmAssCusAnalysis
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popTime,
            this.popCus});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plCondition,
            this.tpvData});
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssCusAnalysis_KeyDown);
            this.Load += new System.EventHandler(this.frmAssCusAnalysis_Load);
            this.Name = "frmAssCusAnalysis";

        }
        #endregion

        private UserControl.Title Title1;
        private Smobiler.Core.Controls.Panel plCondition;
        private Smobiler.Core.Controls.DatePicker dpStart;
        private Smobiler.Core.Controls.DatePicker dpEnd;
        private Smobiler.Core.Controls.Button btnTime;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.PopList popTime;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Button btnCus;
        private Smobiler.Core.Controls.PopList popCus;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.TabPageView tpvData;
    }
}