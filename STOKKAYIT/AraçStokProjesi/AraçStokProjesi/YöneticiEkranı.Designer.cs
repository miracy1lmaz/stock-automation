
namespace AraçStokProjesi
{
    partial class YöneticiEkrani
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
            this.malzemeKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yntcgrup = new System.Windows.Forms.GroupBox();
            this.txttmnt = new System.Windows.Forms.TextBox();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.txtbirim = new System.Windows.Forms.TextBox();
            this.txtmvctstk = new System.Windows.Forms.TextBox();
            this.txtstkkd = new System.Windows.Forms.TextBox();
            this.txtprcad = new System.Windows.Forms.TextBox();
            this.btnprcgncl = new System.Windows.Forms.Button();
            this.btnprcsil = new System.Windows.Forms.Button();
            this.btnprcek = new System.Windows.Forms.Button();
            this.lbltmax = new System.Windows.Forms.Label();
            this.lbltmnt = new System.Windows.Forms.Label();
            this.lblbrmfyt = new System.Windows.Forms.Label();
            this.lblmvctstk = new System.Windows.Forms.Label();
            this.lblstkd = new System.Windows.Forms.Label();
            this.lblprcad = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.yntcgrup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.malzemeKayıtToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // malzemeKayıtToolStripMenuItem
            // 
            this.malzemeKayıtToolStripMenuItem.Name = "malzemeKayıtToolStripMenuItem";
            this.malzemeKayıtToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.malzemeKayıtToolStripMenuItem.Text = "Malzeme Kayıt";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // yntcgrup
            // 
            this.yntcgrup.BackColor = System.Drawing.SystemColors.Info;
            this.yntcgrup.Controls.Add(this.txttmnt);
            this.yntcgrup.Controls.Add(this.txtmax);
            this.yntcgrup.Controls.Add(this.txtbirim);
            this.yntcgrup.Controls.Add(this.txtmvctstk);
            this.yntcgrup.Controls.Add(this.txtstkkd);
            this.yntcgrup.Controls.Add(this.txtprcad);
            this.yntcgrup.Controls.Add(this.btnprcgncl);
            this.yntcgrup.Controls.Add(this.btnprcsil);
            this.yntcgrup.Controls.Add(this.btnprcek);
            this.yntcgrup.Controls.Add(this.lbltmax);
            this.yntcgrup.Controls.Add(this.lbltmnt);
            this.yntcgrup.Controls.Add(this.lblbrmfyt);
            this.yntcgrup.Controls.Add(this.lblmvctstk);
            this.yntcgrup.Controls.Add(this.lblstkd);
            this.yntcgrup.Controls.Add(this.lblprcad);
            this.yntcgrup.Location = new System.Drawing.Point(12, 31);
            this.yntcgrup.Name = "yntcgrup";
            this.yntcgrup.Size = new System.Drawing.Size(703, 185);
            this.yntcgrup.TabIndex = 1;
            this.yntcgrup.TabStop = false;
            this.yntcgrup.Text = "Yönetici Ekranı";
            this.yntcgrup.Enter += new System.EventHandler(this.yntcgrup_Enter);
            // 
            // txttmnt
            // 
            this.txttmnt.Location = new System.Drawing.Point(371, 120);
            this.txttmnt.Name = "txttmnt";
            this.txttmnt.Size = new System.Drawing.Size(139, 22);
            this.txttmnt.TabIndex = 22;
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(371, 72);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(139, 22);
            this.txtmax.TabIndex = 19;
            // 
            // txtbirim
            // 
            this.txtbirim.Location = new System.Drawing.Point(371, 29);
            this.txtbirim.Name = "txtbirim";
            this.txtbirim.Size = new System.Drawing.Size(139, 22);
            this.txtbirim.TabIndex = 18;
            // 
            // txtmvctstk
            // 
            this.txtmvctstk.Location = new System.Drawing.Point(95, 117);
            this.txtmvctstk.Name = "txtmvctstk";
            this.txtmvctstk.Size = new System.Drawing.Size(134, 22);
            this.txtmvctstk.TabIndex = 17;
            // 
            // txtstkkd
            // 
            this.txtstkkd.Location = new System.Drawing.Point(95, 72);
            this.txtstkkd.Name = "txtstkkd";
            this.txtstkkd.Size = new System.Drawing.Size(131, 22);
            this.txtstkkd.TabIndex = 16;
            // 
            // txtprcad
            // 
            this.txtprcad.Location = new System.Drawing.Point(94, 34);
            this.txtprcad.Name = "txtprcad";
            this.txtprcad.Size = new System.Drawing.Size(134, 22);
            this.txtprcad.TabIndex = 15;
            // 
            // btnprcgncl
            // 
            this.btnprcgncl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnprcgncl.Location = new System.Drawing.Point(550, 125);
            this.btnprcgncl.Name = "btnprcgncl";
            this.btnprcgncl.Size = new System.Drawing.Size(132, 32);
            this.btnprcgncl.TabIndex = 14;
            this.btnprcgncl.Text = "Parça Güncelle";
            this.btnprcgncl.UseVisualStyleBackColor = false;
            this.btnprcgncl.Click += new System.EventHandler(this.btnprcgncl_Click);
            // 
            // btnprcsil
            // 
            this.btnprcsil.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnprcsil.Location = new System.Drawing.Point(550, 77);
            this.btnprcsil.Name = "btnprcsil";
            this.btnprcsil.Size = new System.Drawing.Size(132, 32);
            this.btnprcsil.TabIndex = 13;
            this.btnprcsil.Text = "Parça Sil";
            this.btnprcsil.UseVisualStyleBackColor = false;
            this.btnprcsil.Click += new System.EventHandler(this.btnprcsil_Click);
            // 
            // btnprcek
            // 
            this.btnprcek.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnprcek.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnprcek.Location = new System.Drawing.Point(550, 24);
            this.btnprcek.Name = "btnprcek";
            this.btnprcek.Size = new System.Drawing.Size(132, 32);
            this.btnprcek.TabIndex = 12;
            this.btnprcek.Text = "Parça Ekle";
            this.btnprcek.UseVisualStyleBackColor = false;
            this.btnprcek.Click += new System.EventHandler(this.btnprcek_Click);
            // 
            // lbltmax
            // 
            this.lbltmax.AutoSize = true;
            this.lbltmax.Location = new System.Drawing.Point(258, 77);
            this.lbltmax.Name = "lbltmax";
            this.lbltmax.Size = new System.Drawing.Size(102, 17);
            this.lbltmax.TabIndex = 11;
            this.lbltmax.Text = "Maximum Stok:";
            this.lbltmax.Click += new System.EventHandler(this.lbltmnt_Click);
            // 
            // lbltmnt
            // 
            this.lbltmnt.AutoSize = true;
            this.lbltmnt.Location = new System.Drawing.Point(253, 125);
            this.lbltmnt.Name = "lbltmnt";
            this.lbltmnt.Size = new System.Drawing.Size(107, 17);
            this.lbltmnt.TabIndex = 9;
            this.lbltmnt.Text = "Teminat Süresi:";
            // 
            // lblbrmfyt
            // 
            this.lblbrmfyt.AutoSize = true;
            this.lblbrmfyt.Location = new System.Drawing.Point(263, 29);
            this.lblbrmfyt.Name = "lblbrmfyt";
            this.lblbrmfyt.Size = new System.Drawing.Size(80, 17);
            this.lblbrmfyt.TabIndex = 8;
            this.lblbrmfyt.Text = "Birim Fiyatı:";
            // 
            // lblmvctstk
            // 
            this.lblmvctstk.AutoSize = true;
            this.lblmvctstk.Location = new System.Drawing.Point(6, 120);
            this.lblmvctstk.Name = "lblmvctstk";
            this.lblmvctstk.Size = new System.Drawing.Size(89, 17);
            this.lblmvctstk.TabIndex = 7;
            this.lblmvctstk.Text = "Mevcut Stok:";
            // 
            // lblstkd
            // 
            this.lblstkd.AutoSize = true;
            this.lblstkd.Location = new System.Drawing.Point(12, 75);
            this.lblstkd.Name = "lblstkd";
            this.lblstkd.Size = new System.Drawing.Size(77, 17);
            this.lblstkd.TabIndex = 6;
            this.lblstkd.Text = "Stok Kodu:";
            // 
            // lblprcad
            // 
            this.lblprcad.AutoSize = true;
            this.lblprcad.Location = new System.Drawing.Point(15, 34);
            this.lblprcad.Name = "lblprcad";
            this.lblprcad.Size = new System.Drawing.Size(73, 17);
            this.lblprcad.TabIndex = 5;
            this.lblprcad.Text = "Parça Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 232);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // YöneticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 492);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.yntcgrup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "YöneticiEkrani";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.YöneticiEkranı_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.yntcgrup.ResumeLayout(false);
            this.yntcgrup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem malzemeKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.GroupBox yntcgrup;
        private System.Windows.Forms.Button btnprcsil;
        private System.Windows.Forms.Button btnprcek;
        private System.Windows.Forms.Label lbltmax;
        private System.Windows.Forms.Label lbltmnt;
        private System.Windows.Forms.Label lblbrmfyt;
        private System.Windows.Forms.Label lblmvctstk;
        private System.Windows.Forms.Label lblstkd;
        private System.Windows.Forms.Label lblprcad;
        private System.Windows.Forms.Button btnprcgncl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.TextBox txtbirim;
        private System.Windows.Forms.TextBox txtmvctstk;
        private System.Windows.Forms.TextBox txtstkkd;
        private System.Windows.Forms.TextBox txtprcad;
        private System.Windows.Forms.TextBox txttmnt;
    }
}

