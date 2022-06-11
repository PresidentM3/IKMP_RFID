namespace IKMP_RFID.Dijalog
{
    partial class FormObrisi
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
            this.pretragaPoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPretraga = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUnos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaPoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 26);
            // 
            // pretragaPoToolStripMenuItem
            // 
            this.pretragaPoToolStripMenuItem.Name = "pretragaPoToolStripMenuItem";
            this.pretragaPoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pretragaPoToolStripMenuItem.Text = "Pretraga po:";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pretraga po: ";
            // 
            // comboBoxPretraga
            // 
            this.comboBoxPretraga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPretraga.FormattingEnabled = true;
            this.comboBoxPretraga.Items.AddRange(new object[] {
            "Ime",
            "Prezime",
            "ID Kartice",
            "Tip Kartice"});
            this.comboBoxPretraga.Location = new System.Drawing.Point(187, 50);
            this.comboBoxPretraga.Name = "comboBoxPretraga";
            this.comboBoxPretraga.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPretraga.TabIndex = 3;
            this.comboBoxPretraga.DropDownClosed += new System.EventHandler(this.comboBoxPretra_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(97, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unos:";
            // 
            // textBoxUnos
            // 
            this.textBoxUnos.Location = new System.Drawing.Point(187, 119);
            this.textBoxUnos.Name = "textBoxUnos";
            this.textBoxUnos.Size = new System.Drawing.Size(121, 23);
            this.textBoxUnos.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(261, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Obrisi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(32, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Odustani";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormObrisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 249);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxUnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPretraga);
            this.Controls.Add(this.label1);
            this.Name = "FormObrisi";
            this.Text = "Obrisi korisnika";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem pretragaPoToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private Label label1;
        private ComboBox comboBoxPretraga;
        private Label label2;
        private TextBox textBoxUnos;
        private Button button1;
        private Button button2;
    }
}