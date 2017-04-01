namespace VS2012_Graphics_Tests
{
    partial class MainForm
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
            this.renderBackdrop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.renderBackdrop)).BeginInit();
            this.SuspendLayout();
            // 
            // renderBackdrop
            // 
            this.renderBackdrop.BackColor = System.Drawing.Color.Black;
            this.renderBackdrop.Location = new System.Drawing.Point(12, 12);
            this.renderBackdrop.Name = "renderBackdrop";
            this.renderBackdrop.Size = new System.Drawing.Size(260, 207);
            this.renderBackdrop.TabIndex = 0;
            this.renderBackdrop.TabStop = false;
            this.renderBackdrop.Paint += new System.Windows.Forms.PaintEventHandler(this.renderBackdrop_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.renderBackdrop);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.renderBackdrop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox renderBackdrop;
    }
}

