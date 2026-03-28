namespace Vertex
{
    partial class nega
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(227, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 34);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(203, 31);
            label1.TabIndex = 1;
            label1.Text = "İŞLEM AÇIKLAMA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(56, 141);
            label2.Name = "label2";
            label2.Size = new Size(159, 31);
            label2.TabIndex = 2;
            label2.Text = "İŞLEM TUTAR:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(227, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(112, 52);
            textBox2.TabIndex = 3;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(420, 245);
            button1.Name = "button1";
            button1.Size = new Size(102, 58);
            button1.TabIndex = 4;
            button1.Text = "TAMAM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nega
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
            Name = "nega";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TAHSİLAT YAPMA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
    }
}