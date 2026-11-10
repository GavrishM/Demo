namespace DemoUILib
{
    partial class MainUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Font = new System.Drawing.Font("Calibri", 18F);
            this.SupplierLabel.Location = new System.Drawing.Point(295, 15);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(158, 29);
            this.SupplierLabel.TabIndex = 8;
            this.SupplierLabel.Text = "Производство";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.ForeColor = System.Drawing.Color.Black;
            this.CategoryLabel.Location = new System.Drawing.Point(404, 79);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(101, 26);
            this.CategoryLabel.TabIndex = 3;
            this.CategoryLabel.Text = "Категория";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityLabel.ForeColor = System.Drawing.Color.Black;
            this.QuantityLabel.Location = new System.Drawing.Point(404, 105);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(102, 23);
            this.QuantityLabel.TabIndex = 3;
            this.QuantityLabel.Text = "Количество";
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.PartsLabel.Location = new System.Drawing.Point(404, 128);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(49, 19);
            this.PartsLabel.TabIndex = 5;
            this.PartsLabel.Text = "label5";
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Location = new System.Drawing.Point(16, 15);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(217, 142);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPictureBox.TabIndex = 5;
            this.MainPictureBox.TabStop = false;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Calibri", 21.75F);
            this.PriceLabel.Location = new System.Drawing.Point(726, 79);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(78, 36);
            this.PriceLabel.TabIndex = 11;
            this.PriceLabel.Text = "Цена";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.NameLabel);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.SupplierLabel);
            this.MainPanel.Controls.Add(this.CategoryLabel);
            this.MainPanel.Controls.Add(this.PriceLabel);
            this.MainPanel.Controls.Add(this.PartsLabel);
            this.MainPanel.Controls.Add(this.QuantityLabel);
            this.MainPanel.Controls.Add(this.MainPictureBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(880, 180);
            this.MainPanel.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label1.Location = new System.Drawing.Point(239, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Категория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label2.Location = new System.Drawing.Point(240, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.Location = new System.Drawing.Point(240, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Состав";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 18F);
            this.NameLabel.Location = new System.Drawing.Point(459, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(169, 29);
            this.NameLabel.TabIndex = 12;
            this.NameLabel.Text = "Наименование";
            // 
            // MainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(246)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.MainPanel);
            this.Name = "MainUserControl";
            this.Size = new System.Drawing.Size(880, 180);
            this.Load += new System.EventHandler(this.MainUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NameLabel;
    }
}
