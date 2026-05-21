namespace projekat2tvp
{
    partial class frmKategorija
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pocetnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKategorijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgKategorije = new System.Windows.Forms.DataGridView();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblDodajKat = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKategorije)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pocetnaToolStripMenuItem,
            this.dodajKategorijuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pocetnaToolStripMenuItem
            // 
            this.pocetnaToolStripMenuItem.Name = "pocetnaToolStripMenuItem";
            this.pocetnaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.pocetnaToolStripMenuItem.Text = "Home";
            this.pocetnaToolStripMenuItem.Click += new System.EventHandler(this.pocetnaToolStripMenuItem_Click);
            // 
            // dodajKategorijuToolStripMenuItem
            // 
            this.dodajKategorijuToolStripMenuItem.Name = "dodajKategorijuToolStripMenuItem";
            this.dodajKategorijuToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.dodajKategorijuToolStripMenuItem.Text = "Add Category";
            this.dodajKategorijuToolStripMenuItem.Click += new System.EventHandler(this.dodajKategorijuToolStripMenuItem_Click);
            // 
            // dgKategorije
            // 
            this.dgKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKategorije.Location = new System.Drawing.Point(12, 52);
            this.dgKategorije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgKategorije.Name = "dgKategorije";
            this.dgKategorije.RowHeadersWidth = 51;
            this.dgKategorije.RowTemplate.Height = 24;
            this.dgKategorije.Size = new System.Drawing.Size(418, 280);
            this.dgKategorije.TabIndex = 2;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(643, 165);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(148, 106);
            this.txtOpis.TabIndex = 111;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(643, 134);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(148, 26);
            this.txtNaziv.TabIndex = 110;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(531, 291);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(192, 41);
            this.btnDodaj.TabIndex = 109;
            this.btnDodaj.Text = "Add";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblDodajKat
            // 
            this.lblDodajKat.AutoSize = true;
            this.lblDodajKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDodajKat.Location = new System.Drawing.Point(486, 52);
            this.lblDodajKat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDodajKat.Name = "lblDodajKat";
            this.lblDodajKat.Size = new System.Drawing.Size(207, 26);
            this.lblDodajKat.TabIndex = 108;
            this.lblDodajKat.Text = "Add new Category";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.Location = new System.Drawing.Point(474, 213);
            this.lblOpis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(83, 18);
            this.lblOpis.TabIndex = 107;
            this.lblOpis.Text = "Description";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(474, 141);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(48, 18);
            this.lblNaziv.TabIndex = 106;
            this.lblNaziv.Text = "Name";
            // 
            // frmKategorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(809, 366);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblDodajKat);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.dgKategorije);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmKategorija";
            this.Text = "Kategorija";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKategorije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pocetnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKategorijuToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgKategorije;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblDodajKat;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblNaziv;
    }
}