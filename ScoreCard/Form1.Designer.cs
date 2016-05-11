namespace ScoreCard
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
            this.btnNational = new System.Windows.Forms.Button();
            this.btnAmerican = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNational
            // 
            this.btnNational.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNational.Location = new System.Drawing.Point(61, 40);
            this.btnNational.Name = "btnNational";
            this.btnNational.Size = new System.Drawing.Size(148, 70);
            this.btnNational.TabIndex = 0;
            this.btnNational.Text = "National League";
            this.btnNational.UseVisualStyleBackColor = true;
            this.btnNational.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAmerican
            // 
            this.btnAmerican.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmerican.Location = new System.Drawing.Point(252, 40);
            this.btnAmerican.Name = "btnAmerican";
            this.btnAmerican.Size = new System.Drawing.Size(149, 70);
            this.btnAmerican.TabIndex = 1;
            this.btnAmerican.Text = "American League";
            this.btnAmerican.UseVisualStyleBackColor = true;
            this.btnAmerican.Click += new System.EventHandler(this.btnAmerican_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 179);
            this.Controls.Add(this.btnAmerican);
            this.Controls.Add(this.btnNational);
            this.Name = "Form1";
            this.Text = "ScoreCard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNational;
        private System.Windows.Forms.Button btnAmerican;
    }
}

