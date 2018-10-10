namespace MUSTAFA_TOKUR_2014010812029_GRİ_TONLAMA
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tonlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt709ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortalamaDeğerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açıklıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(161, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.tonlamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dosyaToolStripMenuItem.Text = "dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.açToolStripMenuItem.Text = "aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kaydetToolStripMenuItem.Text = "kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // tonlamaToolStripMenuItem
            // 
            this.tonlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt709ToolStripMenuItem,
            this.ortalamaDeğerToolStripMenuItem,
            this.lumaToolStripMenuItem,
            this.açıklıkToolStripMenuItem,
            this.kalanToolStripMenuItem});
            this.tonlamaToolStripMenuItem.Name = "tonlamaToolStripMenuItem";
            this.tonlamaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.tonlamaToolStripMenuItem.Text = "tonlama";
            // 
            // bt709ToolStripMenuItem
            // 
            this.bt709ToolStripMenuItem.Name = "bt709ToolStripMenuItem";
            this.bt709ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.bt709ToolStripMenuItem.Text = "bt709";
            this.bt709ToolStripMenuItem.Click += new System.EventHandler(this.bt709ToolStripMenuItem_Click);
            // 
            // ortalamaDeğerToolStripMenuItem
            // 
            this.ortalamaDeğerToolStripMenuItem.Name = "ortalamaDeğerToolStripMenuItem";
            this.ortalamaDeğerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ortalamaDeğerToolStripMenuItem.Text = "ortalama değer";
            this.ortalamaDeğerToolStripMenuItem.Click += new System.EventHandler(this.ortalamaDeğerToolStripMenuItem_Click);
            // 
            // lumaToolStripMenuItem
            // 
            this.lumaToolStripMenuItem.Name = "lumaToolStripMenuItem";
            this.lumaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.lumaToolStripMenuItem.Text = "luma";
            this.lumaToolStripMenuItem.Click += new System.EventHandler(this.lumaToolStripMenuItem_Click);
            // 
            // açıklıkToolStripMenuItem
            // 
            this.açıklıkToolStripMenuItem.Name = "açıklıkToolStripMenuItem";
            this.açıklıkToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.açıklıkToolStripMenuItem.Text = "açıklık";
            this.açıklıkToolStripMenuItem.Click += new System.EventHandler(this.açıklıkToolStripMenuItem_Click);
            // 
            // kalanToolStripMenuItem
            // 
            this.kalanToolStripMenuItem.Name = "kalanToolStripMenuItem";
            this.kalanToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.kalanToolStripMenuItem.Text = "kalan";
            this.kalanToolStripMenuItem.Click += new System.EventHandler(this.kalanToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kapatToolStripMenuItem.Text = "kapat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tonlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bt709ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortalamaDeğerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açıklıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalanToolStripMenuItem;
    }
}

