namespace IKMP_RFID.Dijalog
{
    partial class FrmSerial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxUlaz = new System.Windows.Forms.ComboBox();
            this.comboBoxIzlaz = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonOdkazi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ulaz com port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izlaz com port:";
            // 
            // comboBoxUlaz
            // 
            this.comboBoxUlaz.FormattingEnabled = true;
            this.comboBoxUlaz.Location = new System.Drawing.Point(225, 21);
            this.comboBoxUlaz.Name = "comboBoxUlaz";
            this.comboBoxUlaz.Size = new System.Drawing.Size(121, 23);
            this.comboBoxUlaz.TabIndex = 2;
            // 
            // comboBoxIzlaz
            // 
            this.comboBoxIzlaz.FormattingEnabled = true;
            this.comboBoxIzlaz.Location = new System.Drawing.Point(225, 59);
            this.comboBoxIzlaz.Name = "comboBoxIzlaz";
            this.comboBoxIzlaz.Size = new System.Drawing.Size(121, 23);
            this.comboBoxIzlaz.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOK.Location = new System.Drawing.Point(317, 134);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(95, 32);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonOdkazi
            // 
            this.buttonOdkazi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOdkazi.Location = new System.Drawing.Point(91, 134);
            this.buttonOdkazi.Name = "buttonOdkazi";
            this.buttonOdkazi.Size = new System.Drawing.Size(96, 32);
            this.buttonOdkazi.TabIndex = 5;
            this.buttonOdkazi.Text = "Odkazi";
            this.buttonOdkazi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(52, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "TCP/IP:";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIP.Location = new System.Drawing.Point(225, 91);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(121, 29);
            this.textBoxIP.TabIndex = 7;
            this.textBoxIP.Text = "127.0.0.1";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPort.Location = new System.Drawing.Point(362, 91);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(50, 29);
            this.textBoxPort.TabIndex = 8;
            this.textBoxPort.Text = "8080";
            // 
            // FrmSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 186);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonOdkazi);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxIzlaz);
            this.Controls.Add(this.comboBoxUlaz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSerial";
            this.Text = "SERIAL";
            this.Load += new System.EventHandler(this.FrmSerial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxUlaz;
        private ComboBox comboBoxIzlaz;
        private Button buttonOK;
        private Button buttonOdkazi;
        private Label label3;
        private TextBox textBoxIP;
        private TextBox textBoxPort;
    }
}