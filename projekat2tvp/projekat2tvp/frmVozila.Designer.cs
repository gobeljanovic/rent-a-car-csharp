namespace projekat2tvp
{
    partial class frmVozila
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
            this.dodajVoziloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajVoziloToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgIspisVozila = new System.Windows.Forms.DataGridView();
            this.txtCenaPoSatu = new System.Windows.Forms.TextBox();
            this.txtGodProiz = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblCenaPoSatu = new System.Windows.Forms.Label();
            this.lblDodajteNovoVozilo = new System.Windows.Forms.Label();
            this.lblGodProiz = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblKat = new System.Windows.Forms.Label();
            this.cbKategorije = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIspisVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Snow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajVoziloToolStripMenuItem,
            this.dodajVoziloToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajVoziloToolStripMenuItem
            // 
            this.dodajVoziloToolStripMenuItem.Name = "dodajVoziloToolStripMenuItem";
            this.dodajVoziloToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.dodajVoziloToolStripMenuItem.Text = "Home";
            this.dodajVoziloToolStripMenuItem.Click += new System.EventHandler(this.dodajVoziloToolStripMenuItem_Click);
            // 
            // dodajVoziloToolStripMenuItem1
            // 
            this.dodajVoziloToolStripMenuItem1.Name = "dodajVoziloToolStripMenuItem1";
            this.dodajVoziloToolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.dodajVoziloToolStripMenuItem1.Text = "Add Vehicle";
            this.dodajVoziloToolStripMenuItem1.Click += new System.EventHandler(this.dodajVoziloToolStripMenuItem1_Click);
            // 
            // dgIspisVozila
            // 
            this.dgIspisVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIspisVozila.Location = new System.Drawing.Point(9, 37);
            this.dgIspisVozila.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgIspisVozila.Name = "dgIspisVozila";
            this.dgIspisVozila.RowHeadersWidth = 51;
            this.dgIspisVozila.RowTemplate.Height = 24;
            this.dgIspisVozila.Size = new System.Drawing.Size(527, 337);
            this.dgIspisVozila.TabIndex = 1;
            // 
            // txtCenaPoSatu
            // 
            this.txtCenaPoSatu.Location = new System.Drawing.Point(707, 288);
            this.txtCenaPoSatu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCenaPoSatu.Multiline = true;
            this.txtCenaPoSatu.Name = "txtCenaPoSatu";
            this.txtCenaPoSatu.Size = new System.Drawing.Size(143, 26);
            this.txtCenaPoSatu.TabIndex = 75;
            // 
            // txtGodProiz
            // 
            this.txtGodProiz.Location = new System.Drawing.Point(707, 244);
            this.txtGodProiz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGodProiz.Multiline = true;
            this.txtGodProiz.Name = "txtGodProiz";
            this.txtGodProiz.Size = new System.Drawing.Size(143, 26);
            this.txtGodProiz.TabIndex = 74;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(707, 199);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(143, 26);
            this.txtModel.TabIndex = 73;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(707, 160);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMarka.Multiline = true;
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(143, 26);
            this.txtMarka.TabIndex = 72;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(707, 120);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(143, 26);
            this.txtNaziv.TabIndex = 71;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Honeydew;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(614, 334);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(194, 40);
            this.btnDodaj.TabIndex = 69;
            this.btnDodaj.Text = "Add";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblCenaPoSatu
            // 
            this.lblCenaPoSatu.AutoSize = true;
            this.lblCenaPoSatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCenaPoSatu.Location = new System.Drawing.Point(556, 295);
            this.lblCenaPoSatu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCenaPoSatu.Name = "lblCenaPoSatu";
            this.lblCenaPoSatu.Size = new System.Drawing.Size(107, 20);
            this.lblCenaPoSatu.TabIndex = 68;
            this.lblCenaPoSatu.Text = "Price per hour";
            // 
            // lblDodajteNovoVozilo
            // 
            this.lblDodajteNovoVozilo.AutoSize = true;
            this.lblDodajteNovoVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDodajteNovoVozilo.Location = new System.Drawing.Point(622, 37);
            this.lblDodajteNovoVozilo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDodajteNovoVozilo.Name = "lblDodajteNovoVozilo";
            this.lblDodajteNovoVozilo.Size = new System.Drawing.Size(190, 26);
            this.lblDodajteNovoVozilo.TabIndex = 67;
            this.lblDodajteNovoVozilo.Text = "Add new Vehicle";
            // 
            // lblGodProiz
            // 
            this.lblGodProiz.AutoSize = true;
            this.lblGodProiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGodProiz.Location = new System.Drawing.Point(557, 250);
            this.lblGodProiz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGodProiz.Name = "lblGodProiz";
            this.lblGodProiz.Size = new System.Drawing.Size(43, 20);
            this.lblGodProiz.TabIndex = 66;
            this.lblGodProiz.Text = "Year";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblModel.Location = new System.Drawing.Point(557, 206);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(52, 20);
            this.lblModel.TabIndex = 65;
            this.lblModel.Text = "Model";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMarka.Location = new System.Drawing.Point(556, 167);
            this.lblMarka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(52, 20);
            this.lblMarka.TabIndex = 64;
            this.lblMarka.Text = "Brand";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(556, 128);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(51, 20);
            this.lblNaziv.TabIndex = 63;
            this.lblNaziv.Text = "Name";
            // 
            // lblKat
            // 
            this.lblKat.AutoSize = true;
            this.lblKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKat.Location = new System.Drawing.Point(556, 88);
            this.lblKat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKat.Name = "lblKat";
            this.lblKat.Size = new System.Drawing.Size(73, 20);
            this.lblKat.TabIndex = 62;
            this.lblKat.Text = "Category";
            // 
            // cbKategorije
            // 
            this.cbKategorije.FormattingEnabled = true;
            this.cbKategorije.Location = new System.Drawing.Point(707, 88);
            this.cbKategorije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbKategorije.Name = "cbKategorije";
            this.cbKategorije.Size = new System.Drawing.Size(143, 21);
            this.cbKategorije.TabIndex = 76;
            // 
            // frmVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(890, 421);
            this.Controls.Add(this.cbKategorije);
            this.Controls.Add(this.txtCenaPoSatu);
            this.Controls.Add(this.txtGodProiz);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblCenaPoSatu);
            this.Controls.Add(this.lblDodajteNovoVozilo);
            this.Controls.Add(this.lblGodProiz);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblKat);
            this.Controls.Add(this.dgIspisVozila);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVozila";
            this.Text = "Vozila";
            this.Load += new System.EventHandler(this.frmVozila_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIspisVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajVoziloToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgIspisVozila;
        private System.Windows.Forms.ToolStripMenuItem dodajVoziloToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtCenaPoSatu;
        private System.Windows.Forms.TextBox txtGodProiz;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblCenaPoSatu;
        private System.Windows.Forms.Label lblDodajteNovoVozilo;
        private System.Windows.Forms.Label lblGodProiz;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblKat;
        private System.Windows.Forms.ComboBox cbKategorije;
    }
}