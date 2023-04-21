namespace ExperimentFileIOWithToDoList
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
            this.checkStatus = new System.Windows.Forms.CheckBox();
            this.listviewToDoList = new System.Windows.Forms.ListView();
            this.radioHigh = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioLow = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textToDoTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkStatus
            // 
            this.checkStatus.AutoSize = true;
            this.checkStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkStatus.Location = new System.Drawing.Point(26, 181);
            this.checkStatus.Name = "checkStatus";
            this.checkStatus.Size = new System.Drawing.Size(72, 24);
            this.checkStatus.TabIndex = 0;
            this.checkStatus.Text = "Status";
            this.checkStatus.UseVisualStyleBackColor = true;
            // 
            // listviewToDoList
            // 
            this.listviewToDoList.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listviewToDoList.HideSelection = false;
            this.listviewToDoList.Location = new System.Drawing.Point(224, 29);
            this.listviewToDoList.Name = "listviewToDoList";
            this.listviewToDoList.Size = new System.Drawing.Size(457, 284);
            this.listviewToDoList.TabIndex = 2;
            this.listviewToDoList.UseCompatibleStateImageBehavior = false;
            // 
            // radioHigh
            // 
            this.radioHigh.AutoSize = true;
            this.radioHigh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioHigh.Location = new System.Drawing.Point(26, 77);
            this.radioHigh.Name = "radioHigh";
            this.radioHigh.Size = new System.Drawing.Size(116, 24);
            this.radioHigh.TabIndex = 3;
            this.radioHigh.TabStop = true;
            this.radioHigh.Text = "High priority";
            this.radioHigh.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioMedium.Location = new System.Drawing.Point(26, 107);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(141, 24);
            this.radioMedium.TabIndex = 3;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "Medium priority";
            this.radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioLow
            // 
            this.radioLow.AutoSize = true;
            this.radioLow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioLow.Location = new System.Drawing.Point(26, 137);
            this.radioLow.Name = "radioLow";
            this.radioLow.Size = new System.Drawing.Size(112, 24);
            this.radioLow.TabIndex = 3;
            this.radioLow.TabStop = true;
            this.radioLow.Text = "Low priority";
            this.radioLow.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(107, 226);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 33);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textToDoTitle
            // 
            this.textToDoTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textToDoTitle.Location = new System.Drawing.Point(106, 38);
            this.textToDoTitle.Name = "textToDoTitle";
            this.textToDoTitle.Size = new System.Drawing.Size(100, 27);
            this.textToDoTitle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Task title";
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNew.Location = new System.Drawing.Point(26, 226);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 33);
            this.buttonNew.TabIndex = 1;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveToFile.Location = new System.Drawing.Point(59, 265);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(123, 33);
            this.buttonSaveToFile.TabIndex = 1;
            this.buttonSaveToFile.Text = "Save to file";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 319);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textToDoTitle);
            this.Controls.Add(this.radioLow);
            this.Controls.Add(this.radioMedium);
            this.Controls.Add(this.radioHigh);
            this.Controls.Add(this.listviewToDoList);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkStatus);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Experiment File IO with To Do List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkStatus;
        private System.Windows.Forms.ListView listviewToDoList;
        private System.Windows.Forms.RadioButton radioHigh;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioLow;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textToDoTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonSaveToFile;
    }
}

