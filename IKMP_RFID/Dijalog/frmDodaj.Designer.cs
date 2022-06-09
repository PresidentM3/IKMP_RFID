namespace IKMP_RFID.Dijalog
{
    partial class FrmDodaj
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
            this.lblme = new System.Windows.Forms.Label();
            this.lblIDKartice = new System.Windows.Forms.Label();
            this.lblTipKorisnika = new System.Windows.Forms.Label();
            this.lblVaziDo = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxIDKartice = new System.Windows.Forms.TextBox();
            this.textBoxTipKorisnika = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.dateTimePickerVaziDo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblme
            // 
            this.lblme.AutoSize = true;
            this.lblme.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblme.Location = new System.Drawing.Point(111, 24);
            this.lblme.Name = "lblme";
            this.lblme.Size = new System.Drawing.Size(71, 40);
            this.lblme.TabIndex = 0;
            this.lblme.Text = "Ime:";
            // 
            // lblIDKartice
            // 
            this.lblIDKartice.AutoSize = true;
            this.lblIDKartice.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIDKartice.Location = new System.Drawing.Point(52, 127);
            this.lblIDKartice.Name = "lblIDKartice";
            this.lblIDKartice.Size = new System.Drawing.Size(143, 40);
            this.lblIDKartice.TabIndex = 1;
            this.lblIDKartice.Text = "ID kartice:";
            // 
            // lblTipKorisnika
            // 
            this.lblTipKorisnika.AutoSize = true;
            this.lblTipKorisnika.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipKorisnika.Location = new System.Drawing.Point(20, 187);
            this.lblTipKorisnika.Name = "lblTipKorisnika";
            this.lblTipKorisnika.Size = new System.Drawing.Size(175, 40);
            this.lblTipKorisnika.TabIndex = 2;
            this.lblTipKorisnika.Text = "Tip korsnika:";
            // 
            // lblVaziDo
            // 
            this.lblVaziDo.AutoSize = true;
            this.lblVaziDo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVaziDo.Location = new System.Drawing.Point(79, 246);
            this.lblVaziDo.Name = "lblVaziDo";
            this.lblVaziDo.Size = new System.Drawing.Size(116, 40);
            this.lblVaziDo.TabIndex = 3;
            this.lblVaziDo.Text = "Vazi do:";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(222, 41);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(205, 23);
            this.textBoxIme.TabIndex = 4;
            // 
            // textBoxIDKartice
            // 
            this.textBoxIDKartice.Location = new System.Drawing.Point(222, 144);
            this.textBoxIDKartice.Name = "textBoxIDKartice";
            this.textBoxIDKartice.Size = new System.Drawing.Size(205, 23);
            this.textBoxIDKartice.TabIndex = 5;
            // 
            // textBoxTipKorisnika
            // 
            this.textBoxTipKorisnika.Location = new System.Drawing.Point(222, 204);
            this.textBoxTipKorisnika.Name = "textBoxTipKorisnika";
            this.textBoxTipKorisnika.Size = new System.Drawing.Size(205, 23);
            this.textBoxTipKorisnika.TabIndex = 6;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOdustani.Location = new System.Drawing.Point(43, 326);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(139, 51);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDodaj.Location = new System.Drawing.Point(235, 326);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(139, 51);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrezime.Location = new System.Drawing.Point(71, 77);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(124, 40);
            this.labelPrezime.TabIndex = 10;
            this.labelPrezime.Text = "Prezime:";
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(222, 94);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(205, 23);
            this.textBoxPrezime.TabIndex = 11;
            // 
            // dateTimePickerVaziDo
            // 
            this.dateTimePickerVaziDo.Location = new System.Drawing.Point(222, 260);
            this.dateTimePickerVaziDo.Name = "dateTimePickerVaziDo";
            this.dateTimePickerVaziDo.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerVaziDo.TabIndex = 12;
            // 
            // frmDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 398);
            this.Controls.Add(this.dateTimePickerVaziDo);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.textBoxTipKorisnika);
            this.Controls.Add(this.textBoxIDKartice);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.lblVaziDo);
            this.Controls.Add(this.lblTipKorisnika);
            this.Controls.Add(this.lblIDKartice);
            this.Controls.Add(this.lblme);
            this.Name = "frmDodaj";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblme;
        private Label lblIDKartice;
        private Label lblTipKorisnika;
        private Label lblVaziDo;
        private TextBox textBoxIme;
        private TextBox textBoxIDKartice;
        private TextBox textBoxTipKorisnika;
        private Button btnOdustani;
        private Button btnDodaj;
        private Label labelPrezime;
        private TextBox textBoxPrezime;
        private DateTimePicker dateTimePickerVaziDo;
    }
}