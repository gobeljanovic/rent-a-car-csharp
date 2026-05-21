namespace projekat2tvp
{
    partial class Main
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
            this.dgIspis = new System.Windows.Forms.DataGridView();
            this.cbKategorije = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCenaDo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNajpopularnije = new System.Windows.Forms.Label();
            this.btnKategorija = new System.Windows.Forms.Button();
            this.dtimeKraj = new System.Windows.Forms.DateTimePicker();
            this.dtimePocetak = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltrirajCena = new System.Windows.Forms.Button();
            this.txtCenaOd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVozila = new System.Windows.Forms.Button();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblNajpopularnijee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgIspis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgIspis
            // 
            this.dgIspis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIspis.Location = new System.Drawing.Point(16, 21);
            this.dgIspis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgIspis.Name = "dgIspis";
            this.dgIspis.RowHeadersWidth = 51;
            this.dgIspis.RowTemplate.Height = 24;
            this.dgIspis.Size = new System.Drawing.Size(672, 239);
            this.dgIspis.TabIndex = 0;
            // 
            // cbKategorije
            // 
            this.cbKategorije.FormattingEnabled = true;
            this.cbKategorije.Location = new System.Drawing.Point(16, 301);
            this.cbKategorije.Name = "cbKategorije";
            this.cbKategorije.Size = new System.Drawing.Size(135, 21);
            this.cbKategorije.TabIndex = 35;
            this.cbKategorije.SelectedIndexChanged += new System.EventHandler(this.cbKategorije_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(18, 399);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "to";
            // 
            // txtCenaDo
            // 
            this.txtCenaDo.Location = new System.Drawing.Point(70, 396);
            this.txtCenaDo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCenaDo.Multiline = true;
            this.txtCenaDo.Name = "txtCenaDo";
            this.txtCenaDo.Size = new System.Drawing.Size(114, 21);
            this.txtCenaDo.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "from";
            // 
            // lblNajpopularnije
            // 
            this.lblNajpopularnije.AutoSize = true;
            this.lblNajpopularnije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNajpopularnije.ForeColor = System.Drawing.Color.Red;
            this.lblNajpopularnije.Location = new System.Drawing.Point(599, 308);
            this.lblNajpopularnije.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNajpopularnije.Name = "lblNajpopularnije";
            this.lblNajpopularnije.Size = new System.Drawing.Size(0, 18);
            this.lblNajpopularnije.TabIndex = 31;
            // 
            // btnKategorija
            // 
            this.btnKategorija.BackColor = System.Drawing.Color.SeaShell;
            this.btnKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategorija.Location = new System.Drawing.Point(484, 385);
            this.btnKategorija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKategorija.Name = "btnKategorija";
            this.btnKategorija.Size = new System.Drawing.Size(203, 39);
            this.btnKategorija.TabIndex = 30;
            this.btnKategorija.Text = "Category";
            this.btnKategorija.UseVisualStyleBackColor = false;
            this.btnKategorija.Click += new System.EventHandler(this.btnKategorija_Click);
            // 
            // dtimeKraj
            // 
            this.dtimeKraj.Location = new System.Drawing.Point(220, 345);
            this.dtimeKraj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtimeKraj.Name = "dtimeKraj";
            this.dtimeKraj.Size = new System.Drawing.Size(179, 20);
            this.dtimeKraj.TabIndex = 27;
            this.dtimeKraj.Value = new System.DateTime(2025, 9, 15, 12, 50, 29, 0);
            // 
            // dtimePocetak
            // 
            this.dtimePocetak.Location = new System.Drawing.Point(220, 308);
            this.dtimePocetak.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtimePocetak.Name = "dtimePocetak";
            this.dtimePocetak.Size = new System.Drawing.Size(179, 20);
            this.dtimePocetak.TabIndex = 26;
            this.dtimePocetak.Value = new System.DateTime(2025, 9, 15, 12, 50, 29, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(204, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Choose time interval for renting";
            // 
            // btnFiltrirajCena
            // 
            this.btnFiltrirajCena.BackColor = System.Drawing.Color.Snow;
            this.btnFiltrirajCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrirajCena.Location = new System.Drawing.Point(220, 380);
            this.btnFiltrirajCena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrirajCena.Name = "btnFiltrirajCena";
            this.btnFiltrirajCena.Size = new System.Drawing.Size(178, 37);
            this.btnFiltrirajCena.TabIndex = 24;
            this.btnFiltrirajCena.Text = "Show";
            this.btnFiltrirajCena.UseVisualStyleBackColor = false;
            this.btnFiltrirajCena.Click += new System.EventHandler(this.btnFiltrirajCena_Click);
            // 
            // txtCenaOd
            // 
            this.txtCenaOd.Location = new System.Drawing.Point(70, 366);
            this.txtCenaOd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCenaOd.Multiline = true;
            this.txtCenaOd.Name = "txtCenaOd";
            this.txtCenaOd.Size = new System.Drawing.Size(114, 21);
            this.txtCenaOd.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 339);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Insert price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Choose category";
            // 
            // btnVozila
            // 
            this.btnVozila.BackColor = System.Drawing.Color.SeaShell;
            this.btnVozila.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVozila.Location = new System.Drawing.Point(484, 292);
            this.btnVozila.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVozila.Name = "btnVozila";
            this.btnVozila.Size = new System.Drawing.Size(203, 39);
            this.btnVozila.TabIndex = 36;
            this.btnVozila.Text = "Vehicles";
            this.btnVozila.UseVisualStyleBackColor = false;
            this.btnVozila.Click += new System.EventHandler(this.btnVozila_Click);
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.BackColor = System.Drawing.Color.SeaShell;
            this.btnRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervacije.Location = new System.Drawing.Point(484, 339);
            this.btnRezervacije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(202, 39);
            this.btnRezervacije.TabIndex = 37;
            this.btnRezervacije.Text = "Reservations";
            this.btnRezervacije.UseVisualStyleBackColor = false;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblNajpopularnijee
            // 
            this.lblNajpopularnijee.AutoSize = true;
            this.lblNajpopularnijee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNajpopularnijee.ForeColor = System.Drawing.Color.Peru;
            this.lblNajpopularnijee.Location = new System.Drawing.Point(25, 453);
            this.lblNajpopularnijee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNajpopularnijee.Name = "lblNajpopularnijee";
            this.lblNajpopularnijee.Size = new System.Drawing.Size(51, 20);
            this.lblNajpopularnijee.TabIndex = 38;
            this.lblNajpopularnijee.Text = "label6";
            this.lblNajpopularnijee.Click += new System.EventHandler(this.lblNajpopularnijee_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(696, 533);
            this.Controls.Add(this.lblNajpopularnijee);
            this.Controls.Add(this.btnRezervacije);
            this.Controls.Add(this.btnVozila);
            this.Controls.Add(this.cbKategorije);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCenaDo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNajpopularnije);
            this.Controls.Add(this.btnKategorija);
            this.Controls.Add(this.dtimeKraj);
            this.Controls.Add(this.dtimePocetak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFiltrirajCena);
            this.Controls.Add(this.txtCenaOd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgIspis);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Rent a car - GOBA";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgIspis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgIspis;
        private System.Windows.Forms.ComboBox cbKategorije;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCenaDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNajpopularnije;
        private System.Windows.Forms.Button btnKategorija;
        private System.Windows.Forms.DateTimePicker dtimeKraj;
        private System.Windows.Forms.DateTimePicker dtimePocetak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltrirajCena;
        private System.Windows.Forms.TextBox txtCenaOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVozila;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblNajpopularnijee;
    }
}

