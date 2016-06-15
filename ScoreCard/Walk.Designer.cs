namespace ScoreCard
{
    partial class Walk
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
            this.rdioIBB = new System.Windows.Forms.RadioButton();
            this.rdioUIBB = new System.Windows.Forms.RadioButton();
            this.rdioHIBP = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rdioIBB
            // 
            this.rdioIBB.AutoSize = true;
            this.rdioIBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdioIBB.Location = new System.Drawing.Point(82, 41);
            this.rdioIBB.Name = "rdioIBB";
            this.rdioIBB.Size = new System.Drawing.Size(45, 17);
            this.rdioIBB.TabIndex = 0;
            this.rdioIBB.TabStop = true;
            this.rdioIBB.Text = "IBB";
            this.rdioIBB.UseVisualStyleBackColor = true;
            // 
            // rdioUIBB
            // 
            this.rdioUIBB.AutoSize = true;
            this.rdioUIBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdioUIBB.Location = new System.Drawing.Point(82, 85);
            this.rdioUIBB.Name = "rdioUIBB";
            this.rdioUIBB.Size = new System.Drawing.Size(54, 17);
            this.rdioUIBB.TabIndex = 1;
            this.rdioUIBB.TabStop = true;
            this.rdioUIBB.Text = "UIBB";
            this.rdioUIBB.UseVisualStyleBackColor = true;
            // 
            // rdioHIBP
            // 
            this.rdioHIBP.AutoSize = true;
            this.rdioHIBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdioHIBP.Location = new System.Drawing.Point(82, 125);
            this.rdioHIBP.Name = "rdioHIBP";
            this.rdioHIBP.Size = new System.Drawing.Size(54, 17);
            this.rdioHIBP.TabIndex = 2;
            this.rdioHIBP.TabStop = true;
            this.rdioHIBP.Text = "HIBP";
            this.rdioHIBP.UseVisualStyleBackColor = true;
            // 
            // Walk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rdioHIBP);
            this.Controls.Add(this.rdioUIBB);
            this.Controls.Add(this.rdioIBB);
            this.Name = "Walk";
            this.Text = "Walk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdioIBB;
        private System.Windows.Forms.RadioButton rdioUIBB;
        private System.Windows.Forms.RadioButton rdioHIBP;
    }
}