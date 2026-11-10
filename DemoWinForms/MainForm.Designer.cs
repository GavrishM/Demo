namespace DemoWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.CardsTabPage = new System.Windows.Forms.TabPage();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.EmblemToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.OrganizationNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.RoleToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.UserNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.UserIconToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.CardsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(3, 3);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.Size = new System.Drawing.Size(786, 393);
            this.MainLayout.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmblemToolStripLabel,
            this.OrganizationNameToolStripLabel,
            this.UserIconToolStripLabel,
            this.UserNameToolStripLabel,
            this.RoleToolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.CardsTabPage);
            this.MainTabControl.Controls.Add(this.OrdersTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 25);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(800, 425);
            this.MainTabControl.TabIndex = 1;
            // 
            // CardsTabPage
            // 
            this.CardsTabPage.Controls.Add(this.MainLayout);
            this.CardsTabPage.Location = new System.Drawing.Point(4, 22);
            this.CardsTabPage.Name = "CardsTabPage";
            this.CardsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CardsTabPage.Size = new System.Drawing.Size(792, 399);
            this.CardsTabPage.TabIndex = 0;
            this.CardsTabPage.Text = "Карточки";
            this.CardsTabPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTabPage.Size = new System.Drawing.Size(792, 399);
            this.OrdersTabPage.TabIndex = 1;
            this.OrdersTabPage.Text = "Заказы";
            this.OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // EmblemToolStripLabel
            // 
            this.EmblemToolStripLabel.Name = "EmblemToolStripLabel";
            this.EmblemToolStripLabel.Size = new System.Drawing.Size(58, 22);
            this.EmblemToolStripLabel.Text = "Эмблема";
            // 
            // OrganizationNameToolStripLabel
            // 
            this.OrganizationNameToolStripLabel.Name = "OrganizationNameToolStripLabel";
            this.OrganizationNameToolStripLabel.Size = new System.Drawing.Size(133, 22);
            this.OrganizationNameToolStripLabel.Text = "Название организации";
            // 
            // RoleToolStripLabel
            // 
            this.RoleToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.RoleToolStripLabel.Name = "RoleToolStripLabel";
            this.RoleToolStripLabel.Size = new System.Drawing.Size(34, 22);
            this.RoleToolStripLabel.Text = "Роль";
            // 
            // UserNameToolStripLabel
            // 
            this.UserNameToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UserNameToolStripLabel.Name = "UserNameToolStripLabel";
            this.UserNameToolStripLabel.Size = new System.Drawing.Size(34, 22);
            this.UserNameToolStripLabel.Text = "ФИО";
            // 
            // UserIconToolStripLabel
            // 
            this.UserIconToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UserIconToolStripLabel.Name = "UserIconToolStripLabel";
            this.UserIconToolStripLabel.Size = new System.Drawing.Size(48, 22);
            this.UserIconToolStripLabel.Text = "Иконка";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.CardsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainLayout;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage CardsTabPage;
        private System.Windows.Forms.TabPage OrdersTabPage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel EmblemToolStripLabel;
        private System.Windows.Forms.ToolStripLabel OrganizationNameToolStripLabel;
        private System.Windows.Forms.ToolStripLabel UserIconToolStripLabel;
        private System.Windows.Forms.ToolStripLabel UserNameToolStripLabel;
        private System.Windows.Forms.ToolStripLabel RoleToolStripLabel;
    }
}

