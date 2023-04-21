namespace ExperimentExceptionErrorHandling
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
            this.buttonDivideByZero = new System.Windows.Forms.Button();
            this.buttonIndexOutOfBound = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.buttonReadFromMissingFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDivideByZero
            // 
            this.buttonDivideByZero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDivideByZero.Location = new System.Drawing.Point(13, 13);
            this.buttonDivideByZero.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDivideByZero.Name = "buttonDivideByZero";
            this.buttonDivideByZero.Size = new System.Drawing.Size(197, 32);
            this.buttonDivideByZero.TabIndex = 0;
            this.buttonDivideByZero.Text = "Divide by 0";
            this.buttonDivideByZero.UseVisualStyleBackColor = true;
            this.buttonDivideByZero.Click += new System.EventHandler(this.buttonTestDivideByZero_Click);
            // 
            // buttonIndexOutOfBound
            // 
            this.buttonIndexOutOfBound.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIndexOutOfBound.Location = new System.Drawing.Point(218, 13);
            this.buttonIndexOutOfBound.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIndexOutOfBound.Name = "buttonIndexOutOfBound";
            this.buttonIndexOutOfBound.Size = new System.Drawing.Size(197, 32);
            this.buttonIndexOutOfBound.TabIndex = 0;
            this.buttonIndexOutOfBound.Text = "Index out of bound";
            this.buttonIndexOutOfBound.UseVisualStyleBackColor = true;
            this.buttonIndexOutOfBound.Click += new System.EventHandler(this.buttonIndexOutOfBound_Click);
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textResult.Location = new System.Drawing.Point(12, 52);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(681, 193);
            this.textResult.TabIndex = 1;
            // 
            // buttonReadFromMissingFile
            // 
            this.buttonReadFromMissingFile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReadFromMissingFile.Location = new System.Drawing.Point(422, 13);
            this.buttonReadFromMissingFile.Name = "buttonReadFromMissingFile";
            this.buttonReadFromMissingFile.Size = new System.Drawing.Size(271, 32);
            this.buttonReadFromMissingFile.TabIndex = 2;
            this.buttonReadFromMissingFile.Text = "Open missing file";
            this.buttonReadFromMissingFile.UseVisualStyleBackColor = true;
            this.buttonReadFromMissingFile.Click += new System.EventHandler(this.buttonReadFromMissingFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 253);
            this.Controls.Add(this.buttonReadFromMissingFile);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.buttonIndexOutOfBound);
            this.Controls.Add(this.buttonDivideByZero);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDivideByZero;
        private System.Windows.Forms.Button buttonIndexOutOfBound;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button buttonReadFromMissingFile;
    }
}

