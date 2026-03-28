namespace Vertex
{
    partial class loan
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
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(420, 227);
            button1.Name = "button1";
            button1.Size = new Size(102, 58);
            button1.TabIndex = 9;
            button1.Text = "TAMAM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(227, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(112, 52);
            textBox2.TabIndex = 8;
            textBox2.KeyPress += textBox2_KeyPress_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(56, 123);
            label2.Name = "label2";
            label2.Size = new Size(159, 31);
            label2.TabIndex = 7;
            label2.Text = "İŞLEM TUTAR:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(203, 31);
            label1.TabIndex = 6;
            label1.Text = "İŞLEM AÇIKLAMA:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(227, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 34);
            textBox1.TabIndex = 5;
            // 
            // loan
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 315);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "loan";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BORÇ EKLEME";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
    }
}