namespace ExperimentTreeStructure
{
    partial class FormExperimentTreeStructure
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
            this.buttonExperiment1 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.treeViewEmployeeData = new System.Windows.Forms.TreeView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonExperiment1
            // 
            this.buttonExperiment1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExperiment1.Location = new System.Drawing.Point(33, 21);
            this.buttonExperiment1.Name = "buttonExperiment1";
            this.buttonExperiment1.Size = new System.Drawing.Size(365, 59);
            this.buttonExperiment1.TabIndex = 1;
            this.buttonExperiment1.Text = "Experiment 1";
            this.buttonExperiment1.UseVisualStyleBackColor = true;
            this.buttonExperiment1.Click += new System.EventHandler(this.buttonExperiment1_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(33, 106);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(365, 59);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add new employee";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // treeViewEmployeeData
            // 
            this.treeViewEmployeeData.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.treeViewEmployeeData.Location = new System.Drawing.Point(463, 21);
            this.treeViewEmployeeData.Name = "treeViewEmployeeData";
            this.treeViewEmployeeData.Size = new System.Drawing.Size(937, 701);
            this.treeViewEmployeeData.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(33, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(365, 59);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update employee";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxMessage.Location = new System.Drawing.Point(33, 272);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(365, 271);
            this.textBoxMessage.TabIndex = 5;
            // 
            // FormExperimentTreeStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 734);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.treeViewEmployeeData);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonExperiment1);
            this.Name = "FormExperimentTreeStructure";
            this.Text = "FormExperimentTreeStructure";
            this.Load += new System.EventHandler(this.FormExperimentTreeStructure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExperiment1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TreeView treeViewEmployeeData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxMessage;
    }
}