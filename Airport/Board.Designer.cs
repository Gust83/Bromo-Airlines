namespace Airport
{
    partial class Board
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.omoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterJadwalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterKodePromoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubahStatusPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 97);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(91, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Airport.Properties.Resources.menu_alt_72;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 71);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 637);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Image = global::Airport.Properties.Resources.log_out_unselected_72;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(3, 546);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 91);
            this.button2.TabIndex = 1;
            this.button2.Text = "Log Out";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omoToolStripMenuItem,
            this.iriToolStripMenuItem,
            this.masterJadwalToolStripMenuItem,
            this.masterKodePromoToolStripMenuItem,
            this.ubahStatusPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(261, 635);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // omoToolStripMenuItem
            // 
            this.omoToolStripMenuItem.Image = global::Airport.Properties.Resources.map_unselected_72;
            this.omoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.omoToolStripMenuItem.Name = "omoToolStripMenuItem";
            this.omoToolStripMenuItem.Size = new System.Drawing.Size(248, 29);
            this.omoToolStripMenuItem.Text = "Master Bandara";
            this.omoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.omoToolStripMenuItem.Click += new System.EventHandler(this.MasterBandaraToolStripMenuItem_Click_1);
            // 
            // iriToolStripMenuItem
            // 
            this.iriToolStripMenuItem.Image = global::Airport.Properties.Resources.plane_take_off_unselected_72;
            this.iriToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iriToolStripMenuItem.Name = "iriToolStripMenuItem";
            this.iriToolStripMenuItem.Size = new System.Drawing.Size(248, 29);
            this.iriToolStripMenuItem.Text = "Master Maskapai";
            this.iriToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iriToolStripMenuItem.Click += new System.EventHandler(this.iriToolStripMenuItem_Click);
            // 
            // masterJadwalToolStripMenuItem
            // 
            this.masterJadwalToolStripMenuItem.Image = global::Airport.Properties.Resources.calendar_unselected_72;
            this.masterJadwalToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.masterJadwalToolStripMenuItem.Name = "masterJadwalToolStripMenuItem";
            this.masterJadwalToolStripMenuItem.Size = new System.Drawing.Size(248, 29);
            this.masterJadwalToolStripMenuItem.Text = "Master Jadwal";
            this.masterJadwalToolStripMenuItem.Click += new System.EventHandler(this.masterJadwalToolStripMenuItem_Click_1);
            // 
            // masterKodePromoToolStripMenuItem
            // 
            this.masterKodePromoToolStripMenuItem.Image = global::Airport.Properties.Resources.purchase_tag_alt_unselected_72;
            this.masterKodePromoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.masterKodePromoToolStripMenuItem.Name = "masterKodePromoToolStripMenuItem";
            this.masterKodePromoToolStripMenuItem.Size = new System.Drawing.Size(248, 29);
            this.masterKodePromoToolStripMenuItem.Text = "Master Kode Promo";
            this.masterKodePromoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.masterKodePromoToolStripMenuItem.Click += new System.EventHandler(this.masterKodePromoToolStripMenuItem_Click);
            // 
            // ubahStatusPToolStripMenuItem
            // 
            this.ubahStatusPToolStripMenuItem.Image = global::Airport.Properties.Resources.notepad_unselected_72;
            this.ubahStatusPToolStripMenuItem.Name = "ubahStatusPToolStripMenuItem";
            this.ubahStatusPToolStripMenuItem.Size = new System.Drawing.Size(248, 29);
            this.ubahStatusPToolStripMenuItem.Text = "Ubah Status Penerbangan";
            this.ubahStatusPToolStripMenuItem.Click += new System.EventHandler(this.ubahStatusPToolStripMenuItem_Click_2);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 734);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Board";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem omoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterJadwalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterKodePromoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubahStatusPToolStripMenuItem;
    }
}