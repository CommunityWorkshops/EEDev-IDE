namespace EEDev_IDE.Forms.Dialog
{
    partial class FrmNewProject
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
            this.flpProjectTypes = new System.Windows.Forms.FlowLayoutPanel();
            this.flpProjectTypeVariations = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIsLibrary = new System.Windows.Forms.CheckBox();
            this.cbIsOpenSource = new System.Windows.Forms.CheckBox();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalProjectTypes = new System.Windows.Forms.Label();
            this.lblTotalVariants = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelectedProjectType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpProjectTypes
            // 
            this.flpProjectTypes.AutoScroll = true;
            this.flpProjectTypes.BackColor = System.Drawing.Color.DimGray;
            this.flpProjectTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpProjectTypes.Location = new System.Drawing.Point(0, 0);
            this.flpProjectTypes.Name = "flpProjectTypes";
            this.flpProjectTypes.Size = new System.Drawing.Size(794, 228);
            this.flpProjectTypes.TabIndex = 0;
            // 
            // flpProjectTypeVariations
            // 
            this.flpProjectTypeVariations.AutoScroll = true;
            this.flpProjectTypeVariations.BackColor = System.Drawing.Color.Gray;
            this.flpProjectTypeVariations.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpProjectTypeVariations.Location = new System.Drawing.Point(0, 228);
            this.flpProjectTypeVariations.Name = "flpProjectTypeVariations";
            this.flpProjectTypeVariations.Size = new System.Drawing.Size(794, 228);
            this.flpProjectTypeVariations.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project Name";
            // 
            // cbIsLibrary
            // 
            this.cbIsLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIsLibrary.AutoSize = true;
            this.cbIsLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsLibrary.Location = new System.Drawing.Point(17, 614);
            this.cbIsLibrary.Name = "cbIsLibrary";
            this.cbIsLibrary.Size = new System.Drawing.Size(136, 24);
            this.cbIsLibrary.TabIndex = 3;
            this.cbIsLibrary.Text = "This is a Library";
            this.cbIsLibrary.UseVisualStyleBackColor = true;
            // 
            // cbIsOpenSource
            // 
            this.cbIsOpenSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIsOpenSource.AutoSize = true;
            this.cbIsOpenSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsOpenSource.Location = new System.Drawing.Point(17, 644);
            this.cbIsOpenSource.Name = "cbIsOpenSource";
            this.cbIsOpenSource.Size = new System.Drawing.Size(170, 24);
            this.cbIsOpenSource.TabIndex = 4;
            this.cbIsOpenSource.Text = "This is Open Source";
            this.cbIsOpenSource.UseVisualStyleBackColor = true;
            // 
            // tbProjectName
            // 
            this.tbProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProjectName.Location = new System.Drawing.Point(123, 575);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(529, 26);
            this.tbProjectName.TabIndex = 5;
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateProject.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreateProject.Location = new System.Drawing.Point(707, 639);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(75, 23);
            this.btnCreateProject.TabIndex = 6;
            this.btnCreateProject.Text = "Create";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(626, 639);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Project Types";
            // 
            // lblTotalProjectTypes
            // 
            this.lblTotalProjectTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalProjectTypes.AutoSize = true;
            this.lblTotalProjectTypes.Location = new System.Drawing.Point(123, 503);
            this.lblTotalProjectTypes.Name = "lblTotalProjectTypes";
            this.lblTotalProjectTypes.Size = new System.Drawing.Size(13, 13);
            this.lblTotalProjectTypes.TabIndex = 9;
            this.lblTotalProjectTypes.Text = "0";
            // 
            // lblTotalVariants
            // 
            this.lblTotalVariants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalVariants.AutoSize = true;
            this.lblTotalVariants.Location = new System.Drawing.Point(251, 503);
            this.lblTotalVariants.Name = "lblTotalVariants";
            this.lblTotalVariants.Size = new System.Drawing.Size(13, 13);
            this.lblTotalVariants.TabIndex = 11;
            this.lblTotalVariants.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Variants";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Project Type";
            // 
            // lblSelectedProjectType
            // 
            this.lblSelectedProjectType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSelectedProjectType.AutoSize = true;
            this.lblSelectedProjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedProjectType.Location = new System.Drawing.Point(123, 537);
            this.lblSelectedProjectType.Name = "lblSelectedProjectType";
            this.lblSelectedProjectType.Size = new System.Drawing.Size(21, 20);
            this.lblSelectedProjectType.TabIndex = 13;
            this.lblSelectedProjectType.Text = "...";
            // 
            // FrmNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 674);
            this.Controls.Add(this.lblSelectedProjectType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalVariants);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalProjectTypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.tbProjectName);
            this.Controls.Add(this.cbIsOpenSource);
            this.Controls.Add(this.cbIsLibrary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpProjectTypeVariations);
            this.Controls.Add(this.flpProjectTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmNewProject";
            this.Text = "New Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProjectTypes;
        private System.Windows.Forms.FlowLayoutPanel flpProjectTypeVariations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbIsLibrary;
        private System.Windows.Forms.CheckBox cbIsOpenSource;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalProjectTypes;
        private System.Windows.Forms.Label lblTotalVariants;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSelectedProjectType;
    }
}