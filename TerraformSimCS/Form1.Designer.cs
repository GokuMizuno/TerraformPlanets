namespace TerraformSimCS
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
            this.planetMap = new System.Windows.Forms.PictureBox();
            this.planetLayers = new System.Windows.Forms.PictureBox();
            this.terraformProgress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.planetMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetLayers)).BeginInit();
            this.SuspendLayout();
            // 
            // planetMap
            // 
            this.planetMap.Location = new System.Drawing.Point(10, 10);
            this.planetMap.Name = "planetMap";
            this.planetMap.Size = new System.Drawing.Size(800, 400);
            this.planetMap.TabIndex = 0;
            this.planetMap.TabStop = false;
            // 
            // planetLayers
            // 
            this.planetLayers.Location = new System.Drawing.Point(825, 10);
            this.planetLayers.Name = "planetLayers";
            this.planetLayers.Size = new System.Drawing.Size(150, 400);
            this.planetLayers.TabIndex = 1;
            this.planetLayers.TabStop = false;
            // 
            // terraformProgress
            // 
            this.terraformProgress.Location = new System.Drawing.Point(525, 425);
            this.terraformProgress.Name = "terraformProgress";
            this.terraformProgress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.terraformProgress.Size = new System.Drawing.Size(450, 25);
            this.terraformProgress.Step = 5;
            this.terraformProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.terraformProgress.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.terraformProgress);
            this.Controls.Add(this.planetLayers);
            this.Controls.Add(this.planetMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planetMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetLayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox planetMap;
        private System.Windows.Forms.PictureBox planetLayers;
        private System.Windows.Forms.ProgressBar terraformProgress;
    }
}

