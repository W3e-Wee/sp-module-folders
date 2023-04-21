namespace Assignment_Prep_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGenerateSeats = new System.Windows.Forms.Button();
            this.panelSeats = new System.Windows.Forms.Panel();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerateSeats
            // 
            this.buttonGenerateSeats.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonGenerateSeats.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerateSeats.Location = new System.Drawing.Point(27, 67);
            this.buttonGenerateSeats.Name = "buttonGenerateSeats";
            this.buttonGenerateSeats.Size = new System.Drawing.Size(308, 42);
            this.buttonGenerateSeats.TabIndex = 0;
            this.buttonGenerateSeats.Text = "Generate Seats";
            this.buttonGenerateSeats.UseVisualStyleBackColor = false;
            this.buttonGenerateSeats.Click += new System.EventHandler(this.buttonGenerateSeats_Click);
            // 
            // panelSeats
            // 
            this.panelSeats.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSeats.Location = new System.Drawing.Point(367, 12);
            this.panelSeats.Name = "panelSeats";
            this.panelSeats.Size = new System.Drawing.Size(684, 566);
            this.panelSeats.TabIndex = 1;
            // 
            // labelMessage
            // 
            this.labelMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMessage.Location = new System.Drawing.Point(27, 125);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(308, 442);
            this.labelMessage.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 590);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.panelSeats);
            this.Controls.Add(this.buttonGenerateSeats);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateSeats;
        private System.Windows.Forms.Panel panelSeats;
        private System.Windows.Forms.Label labelMessage;
    }
}
