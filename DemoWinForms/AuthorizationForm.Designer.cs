namespace DemoWinForms
{
    partial class AuthorizationForm
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
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.EmblemToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.OrgNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmblemToolStripLabel,
            this.OrgNameToolStripLabel});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(208, 25);
            this.MainToolStrip.TabIndex = 0;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // EmblemToolStripLabel
            // 
            this.EmblemToolStripLabel.Name = "EmblemToolStripLabel";
            this.EmblemToolStripLabel.Size = new System.Drawing.Size(58, 22);
            this.EmblemToolStripLabel.Text = "Эмблема";
            // 
            // OrgNameToolStripLabel
            // 
            this.OrgNameToolStripLabel.Name = "OrgNameToolStripLabel";
            this.OrgNameToolStripLabel.Size = new System.Drawing.Size(133, 22);
            this.OrgNameToolStripLabel.Text = "Название организации";
            // 
            // LoginLabel
            // 
            this.LoginLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginLabel.Location = new System.Drawing.Point(0, 25);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginLabel.Size = new System.Drawing.Size(208, 13);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Логин";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginTextBox.Location = new System.Drawing.Point(0, 38);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(208, 20);
            this.LoginTextBox.TabIndex = 2;
            // 
            // CancelButton
            // 
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CancelButton.Location = new System.Drawing.Point(0, 58);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(109, 34);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // EnterButton
            // 
            this.EnterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnterButton.Location = new System.Drawing.Point(109, 58);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(99, 34);
            this.EnterButton.TabIndex = 4;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = true;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 92);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.MainToolStrip);
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripLabel EmblemToolStripLabel;
        private System.Windows.Forms.ToolStripLabel OrgNameToolStripLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button EnterButton;
    }
}