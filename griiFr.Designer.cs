
namespace WindowsFormsApp1
{
    partial class griiFr
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortalamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açıklıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.islemBox = new System.Windows.Forms.PictureBox();
            this.kaynakBox = new System.Windows.Forms.PictureBox();
            this.tekRenkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalizingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.uygulaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1163, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(131, 34);
            this.aToolStripMenuItem.Text = "aç";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // uygulaToolStripMenuItem
            // 
            this.uygulaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ortalamaToolStripMenuItem,
            this.bTToolStripMenuItem,
            this.lumaToolStripMenuItem,
            this.açıklıkToolStripMenuItem,
            this.tekRenkToolStripMenuItem,
            this.normalizingToolStripMenuItem});
            this.uygulaToolStripMenuItem.Name = "uygulaToolStripMenuItem";
            this.uygulaToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.uygulaToolStripMenuItem.Text = "griYontem";
            this.uygulaToolStripMenuItem.Click += new System.EventHandler(this.uygulaToolStripMenuItem_Click);
            // 
            // ortalamaToolStripMenuItem
            // 
            this.ortalamaToolStripMenuItem.Name = "ortalamaToolStripMenuItem";
            this.ortalamaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ortalamaToolStripMenuItem.Text = "ortalama";
            this.ortalamaToolStripMenuItem.Click += new System.EventHandler(this.ortalamaToolStripMenuItem_Click);
            // 
            // bTToolStripMenuItem
            // 
            this.bTToolStripMenuItem.Name = "bTToolStripMenuItem";
            this.bTToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.bTToolStripMenuItem.Text = "BT";
            this.bTToolStripMenuItem.Click += new System.EventHandler(this.bTToolStripMenuItem_Click);
            // 
            // lumaToolStripMenuItem
            // 
            this.lumaToolStripMenuItem.Name = "lumaToolStripMenuItem";
            this.lumaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.lumaToolStripMenuItem.Text = "luma";
            this.lumaToolStripMenuItem.Click += new System.EventHandler(this.LumaToolStripMenuItem_Click);
            // 
            // açıklıkToolStripMenuItem
            // 
            this.açıklıkToolStripMenuItem.Name = "açıklıkToolStripMenuItem";
            this.açıklıkToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.açıklıkToolStripMenuItem.Text = "açıklık";
            this.açıklıkToolStripMenuItem.Click += new System.EventHandler(this.açıklıkToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // islemBox
            // 
            this.islemBox.Location = new System.Drawing.Point(691, 36);
            this.islemBox.Name = "islemBox";
            this.islemBox.Size = new System.Drawing.Size(460, 480);
            this.islemBox.TabIndex = 1;
            this.islemBox.TabStop = false;
            this.islemBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kaynakBox
            // 
            this.kaynakBox.Location = new System.Drawing.Point(12, 36);
            this.kaynakBox.Name = "kaynakBox";
            this.kaynakBox.Size = new System.Drawing.Size(460, 480);
            this.kaynakBox.TabIndex = 2;
            this.kaynakBox.TabStop = false;
            // 
            // tekRenkToolStripMenuItem
            // 
            this.tekRenkToolStripMenuItem.Name = "tekRenkToolStripMenuItem";
            this.tekRenkToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.tekRenkToolStripMenuItem.Text = "tekRenk";
            this.tekRenkToolStripMenuItem.Click += new System.EventHandler(this.tekRenkToolStripMenuItem_Click);
            // 
            // normalizingToolStripMenuItem
            // 
            this.normalizingToolStripMenuItem.Name = "normalizingToolStripMenuItem";
            this.normalizingToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.normalizingToolStripMenuItem.Text = "Normalizing";
            this.normalizingToolStripMenuItem.Click += new System.EventHandler(this.normalizingToolStripMenuItem_Click);
            // 
            // griiFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 672);
            this.Controls.Add(this.kaynakBox);
            this.Controls.Add(this.islemBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "griiFr";
            this.Text = "griiFr";
            this.Load += new System.EventHandler(this.griiFr_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygulaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox islemBox;
        private System.Windows.Forms.PictureBox kaynakBox;
        private System.Windows.Forms.ToolStripMenuItem ortalamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açıklıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekRenkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalizingToolStripMenuItem;
    }
}