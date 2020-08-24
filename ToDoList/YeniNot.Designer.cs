namespace ToDoList
{
    partial class YeniNot
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
            this.richText = new System.Windows.Forms.RichTextBox();
            this.lblWriteNote = new System.Windows.Forms.Label();
            this.lblRemainingLetter = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richText
            // 
            this.richText.Location = new System.Drawing.Point(12, 42);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(421, 122);
            this.richText.TabIndex = 0;
            this.richText.Text = "";
            this.richText.TextChanged += new System.EventHandler(this.richText_TextChanged);
            // 
            // lblWriteNote
            // 
            this.lblWriteNote.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteNote.Location = new System.Drawing.Point(13, 13);
            this.lblWriteNote.Name = "lblWriteNote";
            this.lblWriteNote.Size = new System.Drawing.Size(100, 23);
            this.lblWriteNote.TabIndex = 1;
            this.lblWriteNote.Text = "Notu Yazın:";
            // 
            // lblRemainingLetter
            // 
            this.lblRemainingLetter.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingLetter.Location = new System.Drawing.Point(203, 171);
            this.lblRemainingLetter.Name = "lblRemainingLetter";
            this.lblRemainingLetter.Size = new System.Drawing.Size(150, 23);
            this.lblRemainingLetter.TabIndex = 2;
            this.lblRemainingLetter.Text = "Kalan Karakter Sayınız: ";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(358, 197);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Oluştur";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(355, 171);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(87, 23);
            this.lblResult.TabIndex = 4;
            // 
            // YeniNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 237);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblRemainingLetter);
            this.Controls.Add(this.lblWriteNote);
            this.Controls.Add(this.richText);
            this.Name = "YeniNot";
            this.Text = "YeniNot";
            this.Load += new System.EventHandler(this.YeniNot_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.Label lblWriteNote;
        private System.Windows.Forms.Label lblRemainingLetter;
        private System.Windows.Forms.Label lblResult;
        public System.Windows.Forms.Button btnCreate;
    }
}