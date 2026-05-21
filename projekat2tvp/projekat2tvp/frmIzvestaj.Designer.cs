namespace projekat2tvp
{
    partial class frmIzvestaj
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvIzvestaj = new System.Windows.Forms.DataGridView();
            this.btnIzvestaj = new System.Windows.Forms.Button();
            this.pocetniDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.krajnjiDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvestaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(27, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Listing";
            // 
            // dgvIzvestaj
            // 
            this.dgvIzvestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvestaj.Location = new System.Drawing.Point(20, 54);
            this.dgvIzvestaj.Name = "dgvIzvestaj";
            this.dgvIzvestaj.RowHeadersWidth = 51;
            this.dgvIzvestaj.Size = new System.Drawing.Size(575, 284);
            this.dgvIzvestaj.TabIndex = 17;
            // 
            // btnIzvestaj
            // 
            this.btnIzvestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzvestaj.Location = new System.Drawing.Point(216, 375);
            this.btnIzvestaj.Name = "btnIzvestaj";
            this.btnIzvestaj.Size = new System.Drawing.Size(158, 61);
            this.btnIzvestaj.TabIndex = 16;
            this.btnIzvestaj.Text = "Show";
            this.btnIzvestaj.UseVisualStyleBackColor = true;
            this.btnIzvestaj.Click += new System.EventHandler(this.btnIzvestaj_Click);
            // 
            // pocetniDatumPicker
            // 
            this.pocetniDatumPicker.Location = new System.Drawing.Point(70, 375);
            this.pocetniDatumPicker.Name = "pocetniDatumPicker";
            this.pocetniDatumPicker.Size = new System.Drawing.Size(120, 20);
            this.pocetniDatumPicker.TabIndex = 15;
            // 
            // krajnjiDatumPicker
            // 
            this.krajnjiDatumPicker.Location = new System.Drawing.Point(70, 418);
            this.krajnjiDatumPicker.Name = "krajnjiDatumPicker";
            this.krajnjiDatumPicker.Size = new System.Drawing.Size(120, 20);
            this.krajnjiDatumPicker.TabIndex = 21;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(613, 54);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(309, 284);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // frmIzvestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 486);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.krajnjiDatumPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIzvestaj);
            this.Controls.Add(this.btnIzvestaj);
            this.Controls.Add(this.pocetniDatumPicker);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmIzvestaj";
            this.Text = "Izvestaj";
            this.Load += new System.EventHandler(this.frmIzvestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvestaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvIzvestaj;
        private System.Windows.Forms.Button btnIzvestaj;
        private System.Windows.Forms.DateTimePicker pocetniDatumPicker;
        private System.Windows.Forms.DateTimePicker krajnjiDatumPicker;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}