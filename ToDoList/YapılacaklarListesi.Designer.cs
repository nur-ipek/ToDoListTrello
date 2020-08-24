namespace ToDoList
{
    partial class YapılacaklarListesi
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
            this.pnlToDo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToDo = new System.Windows.Forms.Label();
            this.pnlDoing = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDoing = new System.Windows.Forms.Label();
            this.pnlDone = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlToDo
            // 
            this.pnlToDo.Location = new System.Drawing.Point(1, 65);
            this.pnlToDo.Name = "pnlToDo";
            this.pnlToDo.Size = new System.Drawing.Size(267, 381);
            this.pnlToDo.TabIndex = 0;
            this.pnlToDo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlToDo_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 10);
            this.label1.TabIndex = 1;
            // 
            // lblToDo
            // 
            this.lblToDo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDo.Location = new System.Drawing.Point(95, 9);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(70, 22);
            this.lblToDo.TabIndex = 0;
            this.lblToDo.Text = "To Do";
            this.lblToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDoing
            // 
            this.pnlDoing.Location = new System.Drawing.Point(265, 68);
            this.pnlDoing.Name = "pnlDoing";
            this.pnlDoing.Size = new System.Drawing.Size(273, 378);
            this.pnlDoing.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(262, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 443);
            this.label7.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(272, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 10);
            this.label2.TabIndex = 1;
            // 
            // lblDoing
            // 
            this.lblDoing.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoing.Location = new System.Drawing.Point(357, 12);
            this.lblDoing.Name = "lblDoing";
            this.lblDoing.Size = new System.Drawing.Size(100, 23);
            this.lblDoing.TabIndex = 0;
            this.lblDoing.Text = "Doing";
            // 
            // pnlDone
            // 
            this.pnlDone.Location = new System.Drawing.Point(536, 65);
            this.pnlDone.Name = "pnlDone";
            this.pnlDone.Size = new System.Drawing.Size(262, 381);
            this.pnlDone.TabIndex = 2;
            this.pnlDone.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDone_Paint);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(533, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 443);
            this.label6.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(536, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 10);
            this.label5.TabIndex = 1;
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.Location = new System.Drawing.Point(629, 12);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(58, 23);
            this.lblDone.TabIndex = 0;
            this.lblDone.Text = "Done";
            // 
            // YapılacaklarListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDoing);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlDone);
            this.Controls.Add(this.lblToDo);
            this.Controls.Add(this.pnlDoing);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.pnlToDo);
            this.Name = "YapılacaklarListesi";
            this.Text = "todoList";
            this.Load += new System.EventHandler(this.todoList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlToDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Panel pnlDoing;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDoing;
        private System.Windows.Forms.Panel pnlDone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDone;
    }
}