namespace EZPCBSCheats_2.UI.Spash
{
    partial class Splash_window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash_window));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Loadingbar = new Telerik.WinControls.UI.RadWaitingBar();
            this.fadingRingWaitingBarIndicatorElement1 = new Telerik.WinControls.UI.FadingRingWaitingBarIndicatorElement();
            this.LaunchPcbs_Button = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Splash_context = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.Close_item = new Telerik.WinControls.UI.RadMenuItem();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.Hook_timer = new System.Windows.Forms.Timer(this.components);
            this.detect_timer = new System.Windows.Forms.Timer(this.components);
            this.Waiting_label = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Loadingbar)).BeginInit();
            this.SuspendLayout();
            // 
            // Loadingbar
            // 
            this.Loadingbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Loadingbar.Location = new System.Drawing.Point(12, 12);
            this.Loadingbar.Name = "Loadingbar";
            this.Loadingbar.Size = new System.Drawing.Size(292, 56);
            this.Loadingbar.TabIndex = 0;
            this.Loadingbar.Text = "radWaitingBar1";
            this.Loadingbar.WaitingIndicators.Add(this.fadingRingWaitingBarIndicatorElement1);
            this.Loadingbar.WaitingStep = 8;
            this.Loadingbar.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.FadingRing;
            this.Loadingbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Splash_window_MouseDown);
            this.Loadingbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Splash_window_MouseMove);
            this.Loadingbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Splash_window_MouseUp);
            // 
            // fadingRingWaitingBarIndicatorElement1
            // 
            this.fadingRingWaitingBarIndicatorElement1.ElementColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.fadingRingWaitingBarIndicatorElement1.ElementColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.fadingRingWaitingBarIndicatorElement1.ElementColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fadingRingWaitingBarIndicatorElement1.Name = "fadingRingWaitingBarIndicatorElement1";
            // 
            // LaunchPcbs_Button
            // 
            this.LaunchPcbs_Button.AllowAnimations = true;
            this.LaunchPcbs_Button.AllowMouseEffects = true;
            this.LaunchPcbs_Button.AllowToggling = false;
            this.LaunchPcbs_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LaunchPcbs_Button.AnimationSpeed = 200;
            this.LaunchPcbs_Button.AutoGenerateColors = false;
            this.LaunchPcbs_Button.AutoRoundBorders = true;
            this.LaunchPcbs_Button.AutoSizeLeftIcon = true;
            this.LaunchPcbs_Button.AutoSizeRightIcon = true;
            this.LaunchPcbs_Button.BackColor = System.Drawing.Color.Transparent;
            this.LaunchPcbs_Button.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LaunchPcbs_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LaunchPcbs_Button.BackgroundImage")));
            this.LaunchPcbs_Button.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LaunchPcbs_Button.ButtonText = "Launch PCBS2";
            this.LaunchPcbs_Button.ButtonTextMarginLeft = 0;
            this.LaunchPcbs_Button.ColorContrastOnClick = 45;
            this.LaunchPcbs_Button.ColorContrastOnHover = 45;
            this.LaunchPcbs_Button.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.LaunchPcbs_Button.CustomizableEdges = borderEdges2;
            this.LaunchPcbs_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LaunchPcbs_Button.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LaunchPcbs_Button.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LaunchPcbs_Button.DisabledForecolor = System.Drawing.Color.White;
            this.LaunchPcbs_Button.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.LaunchPcbs_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LaunchPcbs_Button.ForeColor = System.Drawing.Color.White;
            this.LaunchPcbs_Button.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LaunchPcbs_Button.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LaunchPcbs_Button.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.LaunchPcbs_Button.IconMarginLeft = 11;
            this.LaunchPcbs_Button.IconPadding = 10;
            this.LaunchPcbs_Button.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LaunchPcbs_Button.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LaunchPcbs_Button.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.LaunchPcbs_Button.IconSize = 25;
            this.LaunchPcbs_Button.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LaunchPcbs_Button.IdleBorderRadius = 37;
            this.LaunchPcbs_Button.IdleBorderThickness = 1;
            this.LaunchPcbs_Button.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LaunchPcbs_Button.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("LaunchPcbs_Button.IdleIconLeftImage")));
            this.LaunchPcbs_Button.IdleIconRightImage = null;
            this.LaunchPcbs_Button.IndicateFocus = false;
            this.LaunchPcbs_Button.Location = new System.Drawing.Point(12, 86);
            this.LaunchPcbs_Button.Name = "LaunchPcbs_Button";
            this.LaunchPcbs_Button.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LaunchPcbs_Button.OnDisabledState.BorderRadius = 50;
            this.LaunchPcbs_Button.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LaunchPcbs_Button.OnDisabledState.BorderThickness = 1;
            this.LaunchPcbs_Button.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LaunchPcbs_Button.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.LaunchPcbs_Button.OnDisabledState.IconLeftImage = null;
            this.LaunchPcbs_Button.OnDisabledState.IconRightImage = null;
            this.LaunchPcbs_Button.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.LaunchPcbs_Button.onHoverState.BorderRadius = 50;
            this.LaunchPcbs_Button.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LaunchPcbs_Button.onHoverState.BorderThickness = 1;
            this.LaunchPcbs_Button.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.LaunchPcbs_Button.onHoverState.ForeColor = System.Drawing.Color.White;
            this.LaunchPcbs_Button.onHoverState.IconLeftImage = null;
            this.LaunchPcbs_Button.onHoverState.IconRightImage = null;
            this.LaunchPcbs_Button.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LaunchPcbs_Button.OnIdleState.BorderRadius = 50;
            this.LaunchPcbs_Button.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LaunchPcbs_Button.OnIdleState.BorderThickness = 1;
            this.LaunchPcbs_Button.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LaunchPcbs_Button.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.LaunchPcbs_Button.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("LaunchPcbs_Button.OnIdleState.IconLeftImage")));
            this.LaunchPcbs_Button.OnIdleState.IconRightImage = null;
            this.LaunchPcbs_Button.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.LaunchPcbs_Button.OnPressedState.BorderRadius = 50;
            this.LaunchPcbs_Button.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LaunchPcbs_Button.OnPressedState.BorderThickness = 1;
            this.LaunchPcbs_Button.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.LaunchPcbs_Button.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.LaunchPcbs_Button.OnPressedState.IconLeftImage = null;
            this.LaunchPcbs_Button.OnPressedState.IconRightImage = null;
            this.LaunchPcbs_Button.Size = new System.Drawing.Size(292, 39);
            this.LaunchPcbs_Button.TabIndex = 1;
            this.LaunchPcbs_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LaunchPcbs_Button.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.LaunchPcbs_Button.TextMarginLeft = 0;
            this.LaunchPcbs_Button.TextPadding = new System.Windows.Forms.Padding(0);
            this.LaunchPcbs_Button.UseDefaultRadiusAndThickness = true;
            this.LaunchPcbs_Button.Visible = false;
            this.LaunchPcbs_Button.Click += new System.EventHandler(this.LaunchPcbs_Button_Click);
            // 
            // Splash_context
            // 
            this.Splash_context.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.Close_item});
            this.Splash_context.ThemeName = "CrystalDark";
            // 
            // Close_item
            // 
            this.Close_item.Name = "Close_item";
            this.Close_item.Text = "Close";
            // 
            // Hook_timer
            // 
            this.Hook_timer.Interval = 1000;
            this.Hook_timer.Tick += new System.EventHandler(this.Hook_timer_Tick);
            // 
            // detect_timer
            // 
            this.detect_timer.Enabled = true;
            this.detect_timer.Interval = 1000;
            this.detect_timer.Tick += new System.EventHandler(this.detect_timer_Tick);
            // 
            // Waiting_label
            // 
            this.Waiting_label.AllowParentOverrides = false;
            this.Waiting_label.AutoEllipsis = false;
            this.Waiting_label.CursorType = System.Windows.Forms.Cursors.Default;
            this.Waiting_label.Font = new System.Drawing.Font("Orbitron", 13F, System.Drawing.FontStyle.Bold);
            this.Waiting_label.ForeColor = System.Drawing.Color.White;
            this.Waiting_label.Location = new System.Drawing.Point(27, 95);
            this.Waiting_label.Name = "Waiting_label";
            this.Waiting_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Waiting_label.Size = new System.Drawing.Size(261, 20);
            this.Waiting_label.TabIndex = 2;
            this.Waiting_label.Text = "Wating for process to start";
            this.Waiting_label.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Waiting_label.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Splash_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(316, 137);
            this.Controls.Add(this.Waiting_label);
            this.Controls.Add(this.LaunchPcbs_Button);
            this.Controls.Add(this.Loadingbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash_window";
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Splash_window_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Splash_window_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Splash_window_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Splash_window_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.Loadingbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadWaitingBar Loadingbar;
        private Telerik.WinControls.UI.FadingRingWaitingBarIndicatorElement fadingRingWaitingBarIndicatorElement1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LaunchPcbs_Button;
        private Telerik.WinControls.UI.RadContextMenu Splash_context;
        private Telerik.WinControls.UI.RadMenuItem Close_item;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private System.Windows.Forms.Timer Hook_timer;
        private System.Windows.Forms.Timer detect_timer;
        private Bunifu.UI.WinForms.BunifuLabel Waiting_label;
    }
}