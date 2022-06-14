namespace IKMP_RFID.Dijalog
{
    partial class FrmDozvola
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
            this.labeldKarticeTxt = new System.Windows.Forms.Label();
            this.buttonOdkazi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Kartice:";
            // 
            // labeldKarticeTxt
            // 
            this.labeldKarticeTxt.AutoSize = true;
            this.labeldKarticeTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldKarticeTxt.Location = new System.Drawing.Point(197, 30);
            this.labeldKarticeTxt.Name = "labeldKarticeTxt";
            this.labeldKarticeTxt.Size = new System.Drawing.Size(0, 25);
            this.labeldKarticeTxt.TabIndex = 1;
            // 
            // buttonOdkazi
            // 
            this.buttonOdkazi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOdkazi.Location = new System.Drawing.Point(42, 102);
            this.buttonOdkazi.Name = "buttonOdkazi";
            this.buttonOdkazi.Size = new System.Drawing.Size(113, 49);
            this.buttonOdkazi.TabIndex = 2;
            this.buttonOdkazi.Text = "Odkazi";
            this.buttonOdkazi.UseVisualStyleBackColor = true;
            this.buttonOdkazi.Click += new System.EventHandler(this.buttonOdkazi_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(197, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Dozvoli";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmDozvola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 176);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonOdkazi);
            this.Controls.Add(this.labeldKarticeTxt);
            this.Controls.Add(this.label1);
            this.Name = "FrmDozvola";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labeldKarticeTxt;
        private Button buttonOdkazi;
        private Button button2;
    }
}