namespace Assignment_Prep_Exercise_1
{
    partial class Form2
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
            this.buttonCreateAndDisplay = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.panelSeats = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonCreateAndDisplay
            // 
            this.buttonCreateAndDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCreateAndDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateAndDisplay.Location = new System.Drawing.Point(12, 26);
            this.buttonCreateAndDisplay.Name = "buttonCreateAndDisplay";
            this.buttonCreateAndDisplay.Size = new System.Drawing.Size(296, 79);
            this.buttonCreateAndDisplay.TabIndex = 0;
            this.buttonCreateAndDisplay.Text = "Start create and display seats";
            this.buttonCreateAndDisplay.UseVisualStyleBackColor = false;
            // 
            // labelMessage
            // 
            this.labelMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMessage.Location = new System.Drawing.Point(12, 118);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(296, 320);
            this.labelMessage.TabIndex = 1;
            // 
            // panelSeats
            // 
            this.panelSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSeats.Location = new System.Drawing.Point(328, 12);
            this.panelSeats.Name = "panelSeats";
            this.panelSeats.Size = new System.Drawing.Size(627, 426);
            this.panelSeats.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.panelSeats);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonCreateAndDisplay);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateAndDisplay;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Panel panelSeats;
    }
}