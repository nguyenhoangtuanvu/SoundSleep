
namespace DemoSoundSleep
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnAdd = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.l = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(415, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.Transparent;
            this.about.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.Location = new System.Drawing.Point(502, 271);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(98, 33);
            this.about.TabIndex = 1;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30100;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // l
            // 
            this.l.Dock = System.Windows.Forms.DockStyle.Top;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.l.FormattingEnabled = true;
            this.l.ItemHeight = 20;
            this.l.Location = new System.Drawing.Point(0, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(612, 224);
            this.l.TabIndex = 4;
            this.l.SelectedIndexChanged += new System.EventHandler(this.l_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(612, 315);
            this.Controls.Add(this.about);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.l);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scheduled Breaks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox l;
    }
}

