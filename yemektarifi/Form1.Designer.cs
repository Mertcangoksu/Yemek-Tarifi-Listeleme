namespace yemektarifi
{
    partial class Form1
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
            this.btnAddStage = new System.Windows.Forms.Button();
            this.lstStages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddStage
            // 
            this.btnAddStage.Location = new System.Drawing.Point(704, 304);
            this.btnAddStage.Name = "btnAddStage";
            this.btnAddStage.Size = new System.Drawing.Size(165, 40);
            this.btnAddStage.TabIndex = 0;
            this.btnAddStage.Text = "Aşama Ekle";
            this.btnAddStage.UseVisualStyleBackColor = true;
            this.btnAddStage.Click += new System.EventHandler(this.btnAddStage_Click);
            // 
            // lstStages
            // 
            this.lstStages.FormattingEnabled = true;
            this.lstStages.ItemHeight = 24;
            this.lstStages.Location = new System.Drawing.Point(147, 113);
            this.lstStages.Name = "lstStages";
            this.lstStages.Size = new System.Drawing.Size(217, 364);
            this.lstStages.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 633);
            this.Controls.Add(this.lstStages);
            this.Controls.Add(this.btnAddStage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStage;
        private System.Windows.Forms.ListBox lstStages;
    }
}

