namespace Vincic_Alen_PPZ02
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.rbGazirana = new System.Windows.Forms.RadioButton();
            this.cmbKolicina = new System.Windows.Forms.ComboBox();
            this.rbNegazirana = new System.Windows.Forms.RadioButton();
            this.rbAlkoholna = new System.Windows.Forms.RadioButton();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.cmbPakiranje = new System.Windows.Forms.ComboBox();
            this.lblPakiranje = new System.Windows.Forms.Label();
            this.lblPica = new System.Windows.Forms.Label();
            this.trckPostotak = new System.Windows.Forms.TrackBar();
            this.lblPostotak = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.lblAlk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trckPostotak)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(93, 53);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(121, 20);
            this.txtNaziv.TabIndex = 0;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(43, 53);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv";
            this.lblNaziv.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbGazirana
            // 
            this.rbGazirana.AutoSize = true;
            this.rbGazirana.Location = new System.Drawing.Point(93, 96);
            this.rbGazirana.Name = "rbGazirana";
            this.rbGazirana.Size = new System.Drawing.Size(67, 17);
            this.rbGazirana.TabIndex = 2;
            this.rbGazirana.TabStop = true;
            this.rbGazirana.Text = "Gazirana";
            this.rbGazirana.UseVisualStyleBackColor = true;
            // 
            // cmbKolicina
            // 
            this.cmbKolicina.FormattingEnabled = true;
            this.cmbKolicina.Items.AddRange(new object[] {
            "0.5L",
            "1L",
            "1.5L",
            "2L"});
            this.cmbKolicina.Location = new System.Drawing.Point(93, 180);
            this.cmbKolicina.Name = "cmbKolicina";
            this.cmbKolicina.Size = new System.Drawing.Size(121, 21);
            this.cmbKolicina.TabIndex = 3;
            // 
            // rbNegazirana
            // 
            this.rbNegazirana.AutoSize = true;
            this.rbNegazirana.Location = new System.Drawing.Point(93, 119);
            this.rbNegazirana.Name = "rbNegazirana";
            this.rbNegazirana.Size = new System.Drawing.Size(79, 17);
            this.rbNegazirana.TabIndex = 4;
            this.rbNegazirana.TabStop = true;
            this.rbNegazirana.Text = "Negazirana";
            this.rbNegazirana.UseVisualStyleBackColor = true;
            // 
            // rbAlkoholna
            // 
            this.rbAlkoholna.AutoSize = true;
            this.rbAlkoholna.Location = new System.Drawing.Point(93, 143);
            this.rbAlkoholna.Name = "rbAlkoholna";
            this.rbAlkoholna.Size = new System.Drawing.Size(72, 17);
            this.rbAlkoholna.TabIndex = 5;
            this.rbAlkoholna.TabStop = true;
            this.rbAlkoholna.Text = "Alkoholna";
            this.rbAlkoholna.UseVisualStyleBackColor = true;
            this.rbAlkoholna.CheckedChanged += new System.EventHandler(this.rbAlkoholna_CheckedChanged);
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(39, 180);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(44, 13);
            this.lblKolicina.TabIndex = 7;
            this.lblKolicina.Text = "Kolicina";
            // 
            // cmbPakiranje
            // 
            this.cmbPakiranje.FormattingEnabled = true;
            this.cmbPakiranje.Items.AddRange(new object[] {
            "Staklo",
            "PET",
            "Tetrapak"});
            this.cmbPakiranje.Location = new System.Drawing.Point(93, 218);
            this.cmbPakiranje.Name = "cmbPakiranje";
            this.cmbPakiranje.Size = new System.Drawing.Size(121, 21);
            this.cmbPakiranje.TabIndex = 8;
            // 
            // lblPakiranje
            // 
            this.lblPakiranje.AutoSize = true;
            this.lblPakiranje.Location = new System.Drawing.Point(39, 221);
            this.lblPakiranje.Name = "lblPakiranje";
            this.lblPakiranje.Size = new System.Drawing.Size(51, 13);
            this.lblPakiranje.TabIndex = 9;
            this.lblPakiranje.Text = "Pakiranje";
            // 
            // lblPica
            // 
            this.lblPica.AutoSize = true;
            this.lblPica.Location = new System.Drawing.Point(42, 96);
            this.lblPica.Name = "lblPica";
            this.lblPica.Size = new System.Drawing.Size(31, 13);
            this.lblPica.TabIndex = 10;
            this.lblPica.Text = "Pića:";
            // 
            // trckPostotak
            // 
            this.trckPostotak.Enabled = false;
            this.trckPostotak.Location = new System.Drawing.Point(248, 130);
            this.trckPostotak.Maximum = 75;
            this.trckPostotak.Name = "trckPostotak";
            this.trckPostotak.Size = new System.Drawing.Size(128, 45);
            this.trckPostotak.TabIndex = 11;
            this.trckPostotak.Scroll += new System.EventHandler(this.trckPostotak_Scroll);
            // 
            // lblPostotak
            // 
            this.lblPostotak.AutoSize = true;
            this.lblPostotak.Location = new System.Drawing.Point(213, 143);
            this.lblPostotak.Name = "lblPostotak";
            this.lblPostotak.Size = new System.Drawing.Size(29, 13);
            this.lblPostotak.TabIndex = 12;
            this.lblPostotak.Text = "%alk";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(93, 255);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(121, 20);
            this.txtCijena.TabIndex = 13;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(42, 255);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(36, 13);
            this.lblCijena.TabIndex = 14;
            this.lblCijena.Text = "Cijena";
            // 
            // rtbIspis
            // 
            this.rtbIspis.Location = new System.Drawing.Point(42, 291);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(728, 138);
            this.rtbIspis.TabIndex = 15;
            this.rtbIspis.Text = "";
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(452, 46);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(143, 115);
            this.btnUnos.TabIndex = 16;
            this.btnUnos.Text = "Unesi";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(617, 47);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(143, 115);
            this.btnIspis.TabIndex = 17;
            this.btnIspis.Text = "Ispiši";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // lblAlk
            // 
            this.lblAlk.AutoSize = true;
            this.lblAlk.Location = new System.Drawing.Point(383, 142);
            this.lblAlk.Name = "lblAlk";
            this.lblAlk.Size = new System.Drawing.Size(0, 13);
            this.lblAlk.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAlk);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.rtbIspis);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblPostotak);
            this.Controls.Add(this.trckPostotak);
            this.Controls.Add(this.lblPica);
            this.Controls.Add(this.lblPakiranje);
            this.Controls.Add(this.cmbPakiranje);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.rbAlkoholna);
            this.Controls.Add(this.rbNegazirana);
            this.Controls.Add(this.cmbKolicina);
            this.Controls.Add(this.rbGazirana);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trckPostotak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.RadioButton rbGazirana;
        private System.Windows.Forms.ComboBox cmbKolicina;
        private System.Windows.Forms.RadioButton rbNegazirana;
        private System.Windows.Forms.RadioButton rbAlkoholna;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.ComboBox cmbPakiranje;
        private System.Windows.Forms.Label lblPakiranje;
        private System.Windows.Forms.Label lblPica;
        private System.Windows.Forms.TrackBar trckPostotak;
        private System.Windows.Forms.Label lblPostotak;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.RichTextBox rtbIspis;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label lblAlk;
    }
}

