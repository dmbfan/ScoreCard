namespace ScoreCard
{
    partial class OutOrSac
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
            this.btnOut = new System.Windows.Forms.Button();
            this.btnSac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOut
            // 
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(36, 86);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 0;
            this.btnOut.Text = "Out";
            this.btnOut.UseVisualStyleBackColor = true;
            // 
            // btnSac
            // 
            this.btnSac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSac.Location = new System.Drawing.Point(166, 86);
            this.btnSac.Name = "btnSac";
            this.btnSac.Size = new System.Drawing.Size(75, 23);
            this.btnSac.TabIndex = 1;
            this.btnSac.Text = "Sacrifice";
            this.btnSac.UseVisualStyleBackColor = true;
            // 
            // OutOrSac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 197);
            this.Controls.Add(this.btnSac);
            this.Controls.Add(this.btnOut);
            this.Name = "OutOrSac";
            this.Text = "OutOrSac";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnSac;
    }
}