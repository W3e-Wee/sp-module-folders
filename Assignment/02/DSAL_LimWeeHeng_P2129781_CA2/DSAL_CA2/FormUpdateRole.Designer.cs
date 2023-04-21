namespace DSAL_CA2
{
    partial class FormUpdateRole
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
            this.groupBoxUpdateRole = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxIsProjectLeader = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRoleName = new System.Windows.Forms.TextBox();
            this.textBoxRoleUUID = new System.Windows.Forms.TextBox();
            this.groupBoxUpdateRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUpdateRole
            // 
            this.groupBoxUpdateRole.Controls.Add(this.textBoxRoleUUID);
            this.groupBoxUpdateRole.Controls.Add(this.label2);
            this.groupBoxUpdateRole.Controls.Add(this.buttonCancel);
            this.groupBoxUpdateRole.Controls.Add(this.buttonSave);
            this.groupBoxUpdateRole.Controls.Add(this.checkBoxIsProjectLeader);
            this.groupBoxUpdateRole.Controls.Add(this.label1);
            this.groupBoxUpdateRole.Controls.Add(this.textBoxRoleName);
            this.groupBoxUpdateRole.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxUpdateRole.Location = new System.Drawing.Point(31, 31);
            this.groupBoxUpdateRole.Name = "groupBoxUpdateRole";
            this.groupBoxUpdateRole.Size = new System.Drawing.Size(630, 331);
            this.groupBoxUpdateRole.TabIndex = 0;
            this.groupBoxUpdateRole.TabStop = false;
            this.groupBoxUpdateRole.Text = "Update role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Role UUID";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(462, 250);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(139, 41);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(102, 250);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(139, 41);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxIsProjectLeader
            // 
            this.checkBoxIsProjectLeader.AutoSize = true;
            this.checkBoxIsProjectLeader.Location = new System.Drawing.Point(265, 171);
            this.checkBoxIsProjectLeader.Name = "checkBoxIsProjectLeader";
            this.checkBoxIsProjectLeader.Size = new System.Drawing.Size(179, 28);
            this.checkBoxIsProjectLeader.TabIndex = 2;
            this.checkBoxIsProjectLeader.Text = "Is Project Leader?";
            this.checkBoxIsProjectLeader.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Role Name";
            // 
            // textBoxRoleName
            // 
            this.textBoxRoleName.Location = new System.Drawing.Point(265, 119);
            this.textBoxRoleName.Name = "textBoxRoleName";
            this.textBoxRoleName.Size = new System.Drawing.Size(283, 32);
            this.textBoxRoleName.TabIndex = 0;
            // 
            // textBoxRoleUUID
            // 
            this.textBoxRoleUUID.Enabled = false;
            this.textBoxRoleUUID.Location = new System.Drawing.Point(265, 68);
            this.textBoxRoleUUID.Name = "textBoxRoleUUID";
            this.textBoxRoleUUID.Size = new System.Drawing.Size(283, 32);
            this.textBoxRoleUUID.TabIndex = 6;
            // 
            // FormUpdateRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 416);
            this.Controls.Add(this.groupBoxUpdateRole);
            this.Name = "FormUpdateRole";
            this.Text = "FormUpdateRole";
            this.Load += new System.EventHandler(this.FormUpdateRole_Load);
            this.groupBoxUpdateRole.ResumeLayout(false);
            this.groupBoxUpdateRole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUpdateRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRoleName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxIsProjectLeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRoleUUID;
    }
}