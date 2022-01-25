
namespace DemoSoundSleep
{
    partial class SoundSleep
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundSleep));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbm = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbs = new System.Windows.Forms.Label();
            this.media = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListSong = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.media)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbh
            // 
            this.lbh.AutoSize = true;
            this.lbh.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbh.ForeColor = System.Drawing.Color.Maroon;
            this.lbh.Location = new System.Drawing.Point(303, 0);
            this.lbh.Name = "lbh";
            this.lbh.Size = new System.Drawing.Size(57, 39);
            this.lbh.TabIndex = 5;
            this.lbh.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(366, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // lbm
            // 
            this.lbm.AutoSize = true;
            this.lbm.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbm.ForeColor = System.Drawing.Color.Maroon;
            this.lbm.Location = new System.Drawing.Point(391, 0);
            this.lbm.Name = "lbm";
            this.lbm.Size = new System.Drawing.Size(57, 39);
            this.lbm.TabIndex = 7;
            this.lbm.Text = "00";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Maroon;
            this.lb1.Location = new System.Drawing.Point(463, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(19, 25);
            this.lb1.TabIndex = 8;
            this.lb1.Text = ":";
            // 
            // lbs
            // 
            this.lbs.AutoSize = true;
            this.lbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbs.ForeColor = System.Drawing.Color.Maroon;
            this.lbs.Location = new System.Drawing.Point(488, 9);
            this.lbs.Name = "lbs";
            this.lbs.Size = new System.Drawing.Size(41, 29);
            this.lbs.TabIndex = 9;
            this.lbs.Text = "00";
            // 
            // media
            // 
            this.media.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.media.Enabled = true;
            this.media.Location = new System.Drawing.Point(206, 347);
            this.media.Name = "media";
            this.media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media.OcxState")));
            this.media.Size = new System.Drawing.Size(655, 128);
            this.media.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DemoSoundSleep.Properties.Resources.hinh_nen_anime_4k_dep_48;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(861, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(3, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Open My PlayList";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListSong);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 451);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // ListSong
            // 
            this.ListSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListSong.HideSelection = false;
            this.ListSong.Location = new System.Drawing.Point(3, 16);
            this.ListSong.Name = "ListSong";
            this.ListSong.Size = new System.Drawing.Size(200, 406);
            this.ListSong.TabIndex = 12;
            this.ListSong.UseCompatibleStateImageBehavior = false;
            this.ListSong.View = System.Windows.Forms.View.List;
            this.ListSong.SelectedIndexChanged += new System.EventHandler(this.lstnhac_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbh);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbm);
            this.groupBox2.Controls.Add(this.lbs);
            this.groupBox2.Controls.Add(this.lb1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(206, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 37);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 5000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // SoundSleep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.media);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SoundSleep";
            this.Text = "Sound Sleep";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SoundSleep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.media)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer media;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbm;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ListView ListSong;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}