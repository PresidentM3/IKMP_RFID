using Npgsql;

namespace IKMP_RFID.Dijalog
{
    partial class FrmIzmjeni
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
        /// 

        

        private void InitializeComponent()
        {
            this.comboBoxKorisnik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKorisnik = new System.Windows.Forms.Label();
            this.buttonOdkazi = new System.Windows.Forms.Button();
            this.buttonIzmjeni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxIzmjena = new System.Windows.Forms.ComboBox();
            this.labelUnozIzmjene = new System.Windows.Forms.Label();
            this.textBoxUnos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxKorisnik
            // 
            this.comboBoxKorisnik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxKorisnik.FormattingEnabled = true;
            this.comboBoxKorisnik.Location = new System.Drawing.Point(234, 21);
            this.comboBoxKorisnik.Name = "comboBoxKorisnik";
            this.comboBoxKorisnik.Size = new System.Drawing.Size(142, 29);
            this.comboBoxKorisnik.TabIndex = 0;
            this.comboBoxKorisnik.DropDownClosed += new System.EventHandler(this.comboBoxKorisnik_DropDownClosed);
            this.comboBoxKorisnik.Click += new System.EventHandler(this.comboBoxKorisnik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisnik";
            // 
            // labelKorisnik
            // 
            this.labelKorisnik.AutoSize = true;
            this.labelKorisnik.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKorisnik.Location = new System.Drawing.Point(34, 68);
            this.labelKorisnik.Name = "labelKorisnik";
            this.labelKorisnik.Size = new System.Drawing.Size(0, 25);
            this.labelKorisnik.TabIndex = 2;
            // 
            // buttonOdkazi
            // 
            this.buttonOdkazi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOdkazi.Location = new System.Drawing.Point(34, 262);
            this.buttonOdkazi.Name = "buttonOdkazi";
            this.buttonOdkazi.Size = new System.Drawing.Size(146, 44);
            this.buttonOdkazi.TabIndex = 3;
            this.buttonOdkazi.Text = "Odkazi";
            this.buttonOdkazi.UseVisualStyleBackColor = true;
            this.buttonOdkazi.Click += new System.EventHandler(this.buttonOdkazi_Click);
            // 
            // buttonIzmjeni
            // 
            this.buttonIzmjeni.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIzmjeni.Location = new System.Drawing.Point(250, 262);
            this.buttonIzmjeni.Name = "buttonIzmjeni";
            this.buttonIzmjeni.Size = new System.Drawing.Size(126, 44);
            this.buttonIzmjeni.TabIndex = 4;
            this.buttonIzmjeni.Text = "Izmjeni";
            this.buttonIzmjeni.UseVisualStyleBackColor = true;
            this.buttonIzmjeni.Click += new System.EventHandler(this.buttonIzmjeni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parametar za izmejnu:";
            // 
            // comboBoxIzmjena
            // 
            this.comboBoxIzmjena.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxIzmjena.FormattingEnabled = true;
            this.comboBoxIzmjena.Items.AddRange(new object[] {
            "ime",
            "prezime",
            "id_kartice",
            "tip_kartice",
            "vazi_do"});
            this.comboBoxIzmjena.Location = new System.Drawing.Point(234, 120);
            this.comboBoxIzmjena.Name = "comboBoxIzmjena";
            this.comboBoxIzmjena.Size = new System.Drawing.Size(142, 29);
            this.comboBoxIzmjena.TabIndex = 6;
            // 
            // labelUnozIzmjene
            // 
            this.labelUnozIzmjene.AutoSize = true;
            this.labelUnozIzmjene.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnozIzmjene.Location = new System.Drawing.Point(151, 178);
            this.labelUnozIzmjene.Name = "labelUnozIzmjene";
            this.labelUnozIzmjene.Size = new System.Drawing.Size(59, 25);
            this.labelUnozIzmjene.TabIndex = 7;
            this.labelUnozIzmjene.Text = "Unos:";
            // 
            // textBoxUnos
            // 
            this.textBoxUnos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUnos.Location = new System.Drawing.Point(234, 174);
            this.textBoxUnos.Name = "textBoxUnos";
            this.textBoxUnos.Size = new System.Drawing.Size(142, 29);
            this.textBoxUnos.TabIndex = 8;
            this.textBoxUnos.TextChanged += new System.EventHandler(this.textBoxUnos_TextChanged);
            // 
            // FrmIzmjeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 334);
            this.Controls.Add(this.textBoxUnos);
            this.Controls.Add(this.labelUnozIzmjene);
            this.Controls.Add(this.comboBoxIzmjena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonIzmjeni);
            this.Controls.Add(this.buttonOdkazi);
            this.Controls.Add(this.labelKorisnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKorisnik);
            this.Name = "FrmIzmjeni";
            this.Text = "IZMJENA";
            this.Load += new System.EventHandler(this.FrmIzmjeni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxKorisnik;
        private Label label1;
        private Label labelKorisnik;
        private Button buttonOdkazi;
        private Button buttonIzmjeni;
        private Label label2;
        private ComboBox comboBoxIzmjena;
        private Label labelUnozIzmjene;
        private TextBox textBoxUnos;
    }
}