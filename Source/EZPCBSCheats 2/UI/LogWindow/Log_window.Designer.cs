namespace EZPCBSCheats_2.UI.LogWindow
{
    partial class Log_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_window));
            this.Log_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Log_listBox
            // 
            this.Log_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Log_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_listBox.ForeColor = System.Drawing.Color.White;
            this.Log_listBox.FormattingEnabled = true;
            this.Log_listBox.ItemHeight = 20;
            this.Log_listBox.Location = new System.Drawing.Point(0, 0);
            this.Log_listBox.Name = "Log_listBox";
            this.Log_listBox.Size = new System.Drawing.Size(628, 410);
            this.Log_listBox.TabIndex = 0;
            // 
            // Log_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(628, 410);
            this.Controls.Add(this.Log_listBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Log_window";
            this.Text = "Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Log_window_FormClosing);
            this.Load += new System.EventHandler(this.Log_window_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Log_listBox;
    }
}