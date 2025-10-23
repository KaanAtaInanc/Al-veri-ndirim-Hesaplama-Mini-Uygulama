namespace Örnek_Proje_Alışveriş_İndirim_Tutarı
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Location = new Point(182, 171);
            button1.Name = "button1";
            button1.Size = new Size(165, 53);
            button1.TabIndex = 0;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 30);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 1;
            label1.Text = "Kitap Adedi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 85);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 2;
            label2.Text = "Tutar";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(115, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 34);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(115, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 34);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(115, 120);
            textBox3.Name = "textBox3";
            textBox3.RightToLeft = RightToLeft.No;
            textBox3.ScrollBars = ScrollBars.Horizontal;
            textBox3.Size = new Size(232, 34);
            textBox3.TabIndex = 8;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.WordWrap = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 134);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 9;
            label3.Text = "İndirim Oranı";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(4, 171);
            button2.Name = "button2";
            button2.Size = new Size(126, 53);
            button2.TabIndex = 10;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(359, 285);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Hesapla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Button button2;
    }
}
