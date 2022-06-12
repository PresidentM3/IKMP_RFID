namespace IKMP_RFID
{
    partial class RFIDKontolaPristupa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.bntPrikazi = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnDozvola = new System.Windows.Forms.Button();
            this.bntKraj = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERIALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(3, 3);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(117, 40);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(3, 49);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(117, 40);
            this.btnObrisi.TabIndex = 1;
            this.btnObrisi.Text = "OBRISI";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // bntPrikazi
            // 
            this.bntPrikazi.Location = new System.Drawing.Point(3, 95);
            this.bntPrikazi.Name = "bntPrikazi";
            this.bntPrikazi.Size = new System.Drawing.Size(117, 40);
            this.bntPrikazi.TabIndex = 2;
            this.bntPrikazi.Text = "PRIKAZI";
            this.bntPrikazi.UseVisualStyleBackColor = true;
            this.bntPrikazi.Click += new System.EventHandler(this.bntPrikazi_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(3, 141);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(117, 40);
            this.btnIzmjeni.TabIndex = 3;
            this.btnIzmjeni.Text = "IZMJENI";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // btnDozvola
            // 
            this.btnDozvola.Location = new System.Drawing.Point(3, 233);
            this.btnDozvola.Name = "btnDozvola";
            this.btnDozvola.Size = new System.Drawing.Size(117, 40);
            this.btnDozvola.TabIndex = 4;
            this.btnDozvola.Text = "DOZVOLA";
            this.btnDozvola.UseVisualStyleBackColor = true;
            // 
            // bntKraj
            // 
            this.bntKraj.Location = new System.Drawing.Point(15, 354);
            this.bntKraj.Name = "bntKraj";
            this.bntKraj.Size = new System.Drawing.Size(180, 40);
            this.bntKraj.TabIndex = 5;
            this.bntKraj.Text = "Kraj";
            this.bntKraj.UseVisualStyleBackColor = true;
            this.bntKraj.Click += new System.EventHandler(this.bntKraj_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sERIALToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 29);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // sERIALToolStripMenuItem
            // 
            this.sERIALToolStripMenuItem.Name = "sERIALToolStripMenuItem";
            this.sERIALToolStripMenuItem.Size = new System.Drawing.Size(47, 25);
            this.sERIALToolStripMenuItem.Text = "Serial";
            this.sERIALToolStripMenuItem.Click += new System.EventHandler(this.sERIALToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(201, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(559, 394);
            this.listBox1.TabIndex = 8;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.labelTime);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.buttonObrisi);
            this.panelMain.Controls.Add(this.bntKraj);
            this.panelMain.Controls.Add(this.listBox1);
            this.panelMain.Controls.Add(this.btnDodaj);
            this.panelMain.Controls.Add(this.btnObrisi);
            this.panelMain.Controls.Add(this.bntPrikazi);
            this.panelMain.Controls.Add(this.btnDozvola);
            this.panelMain.Controls.Add(this.btnIzmjeni);
            this.panelMain.Location = new System.Drawing.Point(12, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(760, 433);
            this.panelMain.TabIndex = 9;
            this.panelMain.Visible = false;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(374, 411);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(55, 15);
            this.labelTime.TabIndex = 11;
            this.labelTime.Text = "xx:xx:xxx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(241, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Time now:";
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(651, 407);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(106, 23);
            this.buttonObrisi.TabIndex = 9;
            this.buttonObrisi.Text = "Obrisi prikaz";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // RFIDKontolaPristupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 474);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RFIDKontolaPristupa";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDodaj;
        private Button btnObrisi;
        private Button bntPrikazi;
        private Button btnIzmjeni;
        private Button btnDozvola;
        private Button bntKraj;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ListBox listBox1;
        private Panel panelMain;
        private Button buttonObrisi;
        private Label labelTime;
        private Label label1;
        private ToolStripMenuItem sERIALToolStripMenuItem;
    }
}