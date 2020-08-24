namespace ToDoList
{
    partial class SayfaİsmiFormu
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
            this.lblPageName = new System.Windows.Forms.Label();
            this.txtPageName = new System.Windows.Forms.TextBox();
            this.btnOpenthePage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPageName
            // 
            this.lblPageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageName.Location = new System.Drawing.Point(12, 40);
            this.lblPageName.Name = "lblPageName";
            this.lblPageName.Size = new System.Drawing.Size(93, 25);
            this.lblPageName.TabIndex = 0;
            this.lblPageName.Text = "Sayfa İsmi:";
            // 
            // txtPageName
            // 
            this.txtPageName.Location = new System.Drawing.Point(95, 39);
            this.txtPageName.Name = "txtPageName";
            this.txtPageName.Size = new System.Drawing.Size(265, 20);
            this.txtPageName.TabIndex = 1;
            // 
            // btnOpenthePage
            // 
            this.btnOpenthePage.Location = new System.Drawing.Point(262, 89);
            this.btnOpenthePage.Name = "btnOpenthePage";
            this.btnOpenthePage.Size = new System.Drawing.Size(98, 32);
            this.btnOpenthePage.TabIndex = 2;
            this.btnOpenthePage.Text = "Sayfa Aç";
            this.btnOpenthePage.UseVisualStyleBackColor = true;
            this.btnOpenthePage.Click += new System.EventHandler(this.btnOpenthePage_Click);
            // 
            // SayfaİsmiFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 165);
            this.Controls.Add(this.btnOpenthePage);
            this.Controls.Add(this.txtPageName);
            this.Controls.Add(this.lblPageName);
            this.Name = "SayfaİsmiFormu";
            this.Text = "SayfaİsmiFormu";
            this.Load += new System.EventHandler(this.SayfaİsmiFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageName;
        private System.Windows.Forms.Button btnOpenthePage;
        public System.Windows.Forms.TextBox txtPageName;
    }
}