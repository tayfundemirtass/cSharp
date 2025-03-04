namespace Arac_Kullanimi_Odev
{
    partial class Form1
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
            txtad = new TextBox();
            txtsoyad = new TextBox();
            txtmeslek = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            lblname = new Label();
            lblsoyad = new Label();
            lblmeslek = new Label();
            SuspendLayout();
            // 
            // txtad
            // 
            txtad.Location = new Point(135, 50);
            txtad.Name = "txtad";
            txtad.Size = new Size(100, 23);
            txtad.TabIndex = 0;
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(135, 79);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(100, 23);
            txtsoyad.TabIndex = 1;
            // 
            // txtmeslek
            // 
            txtmeslek.Location = new Point(135, 108);
            txtmeslek.Name = "txtmeslek";
            txtmeslek.Size = new Size(100, 23);
            txtmeslek.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 49);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Adınız:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 81);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Soyadınız:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 116);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Meslek:";
            // 
            // button1
            // 
            button1.Location = new Point(135, 151);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 6;
            button1.Text = "Gönder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(282, 53);
            lblname.Name = "lblname";
            lblname.Size = new Size(38, 15);
            lblname.TabIndex = 7;
            lblname.Text = "label4";
            lblname.Visible = false;
            // 
            // lblsoyad
            // 
            lblsoyad.AutoSize = true;
            lblsoyad.Location = new Point(282, 82);
            lblsoyad.Name = "lblsoyad";
            lblsoyad.Size = new Size(38, 15);
            lblsoyad.TabIndex = 8;
            lblsoyad.Text = "label4";
            lblsoyad.Visible = false;
            // 
            // lblmeslek
            // 
            lblmeslek.AutoSize = true;
            lblmeslek.Location = new Point(282, 111);
            lblmeslek.Name = "lblmeslek";
            lblmeslek.Size = new Size(38, 15);
            lblmeslek.TabIndex = 9;
            lblmeslek.Text = "label4";
            lblmeslek.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(lblmeslek);
            Controls.Add(lblsoyad);
            Controls.Add(lblname);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtmeslek);
            Controls.Add(txtsoyad);
            Controls.Add(txtad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtad;
        private TextBox txtsoyad;
        private TextBox txtmeslek;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label lblname;
        private Label lblsoyad;
        private Label lblmeslek;
    }
}
