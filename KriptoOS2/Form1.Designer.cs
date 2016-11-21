namespace KriptoOS2
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
            this.btnUcitajText = new System.Windows.Forms.Button();
            this.txtCisti = new System.Windows.Forms.TextBox();
            this.btnGenerirajKljuc = new System.Windows.Forms.Button();
            this.txtKljuc = new System.Windows.Forms.TextBox();
            this.txtKriptirani = new System.Windows.Forms.TextBox();
            this.BtnKripitiraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDekriptiraj = new System.Windows.Forms.Button();
            this.txtDekriptirani = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUcitajText
            // 
            this.btnUcitajText.Location = new System.Drawing.Point(374, 53);
            this.btnUcitajText.Name = "btnUcitajText";
            this.btnUcitajText.Size = new System.Drawing.Size(75, 23);
            this.btnUcitajText.TabIndex = 0;
            this.btnUcitajText.Text = "Učitaj";
            this.btnUcitajText.UseVisualStyleBackColor = true;
            this.btnUcitajText.Click += new System.EventHandler(this.btnUcitajText_Click);
            // 
            // txtCisti
            // 
            this.txtCisti.Location = new System.Drawing.Point(12, 53);
            this.txtCisti.Multiline = true;
            this.txtCisti.Name = "txtCisti";
            this.txtCisti.Size = new System.Drawing.Size(356, 60);
            this.txtCisti.TabIndex = 1;
            // 
            // btnGenerirajKljuc
            // 
            this.btnGenerirajKljuc.Location = new System.Drawing.Point(374, 144);
            this.btnGenerirajKljuc.Name = "btnGenerirajKljuc";
            this.btnGenerirajKljuc.Size = new System.Drawing.Size(75, 23);
            this.btnGenerirajKljuc.TabIndex = 2;
            this.btnGenerirajKljuc.Text = "Generiraj ključ";
            this.btnGenerirajKljuc.UseVisualStyleBackColor = true;
            this.btnGenerirajKljuc.Click += new System.EventHandler(this.btnGenerirajKljuc_Click);
            // 
            // txtKljuc
            // 
            this.txtKljuc.Location = new System.Drawing.Point(12, 147);
            this.txtKljuc.Name = "txtKljuc";
            this.txtKljuc.Size = new System.Drawing.Size(356, 20);
            this.txtKljuc.TabIndex = 3;
            // 
            // txtKriptirani
            // 
            this.txtKriptirani.Location = new System.Drawing.Point(12, 212);
            this.txtKriptirani.Multiline = true;
            this.txtKriptirani.Name = "txtKriptirani";
            this.txtKriptirani.Size = new System.Drawing.Size(356, 60);
            this.txtKriptirani.TabIndex = 4;
            // 
            // BtnKripitiraj
            // 
            this.BtnKripitiraj.Location = new System.Drawing.Point(374, 210);
            this.BtnKripitiraj.Name = "BtnKripitiraj";
            this.BtnKripitiraj.Size = new System.Drawing.Size(75, 23);
            this.BtnKripitiraj.TabIndex = 5;
            this.BtnKripitiraj.Text = "Kriptiraj";
            this.BtnKripitiraj.UseVisualStyleBackColor = true;
            this.BtnKripitiraj.Click += new System.EventHandler(this.BtnKripitiraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Čisti tekst";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ključ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kriptirani tekst";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dekriptirani tekst";
            // 
            // btnDekriptiraj
            // 
            this.btnDekriptiraj.Location = new System.Drawing.Point(374, 303);
            this.btnDekriptiraj.Name = "btnDekriptiraj";
            this.btnDekriptiraj.Size = new System.Drawing.Size(75, 23);
            this.btnDekriptiraj.TabIndex = 10;
            this.btnDekriptiraj.Text = "Dekriptiraj";
            this.btnDekriptiraj.UseVisualStyleBackColor = true;
            this.btnDekriptiraj.Click += new System.EventHandler(this.btnDekriptiraj_Click);
            // 
            // txtDekriptirani
            // 
            this.txtDekriptirani.Location = new System.Drawing.Point(12, 305);
            this.txtDekriptirani.Multiline = true;
            this.txtDekriptirani.Name = "txtDekriptirani";
            this.txtDekriptirani.Size = new System.Drawing.Size(356, 60);
            this.txtDekriptirani.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 380);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDekriptiraj);
            this.Controls.Add(this.txtDekriptirani);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnKripitiraj);
            this.Controls.Add(this.txtKriptirani);
            this.Controls.Add(this.txtKljuc);
            this.Controls.Add(this.btnGenerirajKljuc);
            this.Controls.Add(this.txtCisti);
            this.Controls.Add(this.btnUcitajText);
            this.Name = "Form1";
            this.Text = "Simetricno kriptiranje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUcitajText;
        private System.Windows.Forms.TextBox txtCisti;
        private System.Windows.Forms.Button btnGenerirajKljuc;
        private System.Windows.Forms.TextBox txtKljuc;
        private System.Windows.Forms.TextBox txtKriptirani;
        private System.Windows.Forms.Button BtnKripitiraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDekriptiraj;
        private System.Windows.Forms.TextBox txtDekriptirani;
    }
}

