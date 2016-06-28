namespace EEDev_IDE.Controls
{
    partial class NewProjectChoice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbProjectImage = new System.Windows.Forms.PictureBox();
            this.lblProjectType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjectImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProjectImage
            // 
            this.pbProjectImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbProjectImage.Location = new System.Drawing.Point(0, 0);
            this.pbProjectImage.Name = "pbProjectImage";
            this.pbProjectImage.Size = new System.Drawing.Size(150, 100);
            this.pbProjectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProjectImage.TabIndex = 0;
            this.pbProjectImage.TabStop = false;
            this.pbProjectImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbProjectImage_MouseDown);
            this.pbProjectImage.MouseEnter += new System.EventHandler(this.pbProjectImage_MouseEnter);
            this.pbProjectImage.MouseLeave += new System.EventHandler(this.pbProjectImage_MouseLeave);
            this.pbProjectImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbProjectImage_MouseUp);
            // 
            // lblProjectType
            // 
            this.lblProjectType.AutoEllipsis = true;
            this.lblProjectType.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblProjectType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblProjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectType.Location = new System.Drawing.Point(0, 103);
            this.lblProjectType.Name = "lblProjectType";
            this.lblProjectType.Size = new System.Drawing.Size(150, 47);
            this.lblProjectType.TabIndex = 1;
            this.lblProjectType.Text = "...";
            this.lblProjectType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProjectType.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblProjectType_MouseDown);
            this.lblProjectType.MouseEnter += new System.EventHandler(this.lblProjectType_MouseEnter);
            this.lblProjectType.MouseLeave += new System.EventHandler(this.lblProjectType_MouseLeave);
            this.lblProjectType.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblProjectType_MouseUp);
            // 
            // NewProjectChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProjectType);
            this.Controls.Add(this.pbProjectImage);
            this.Name = "NewProjectChoice";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewProjectChoice_MouseDown);
            this.MouseEnter += new System.EventHandler(this.NewProjectChoice_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NewProjectChoice_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NewProjectChoice_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbProjectImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProjectImage;
        private System.Windows.Forms.Label lblProjectType;
    }
}
