namespace Vertex
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            müşteriyiSilToolStripMenuItem = new ToolStripMenuItem();
            müşteriyiDüzenleToolStripMenuItem = new ToolStripMenuItem();
            add_customer = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            iŞLEMİSİLToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1177, 488);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { müşteriyiSilToolStripMenuItem, müşteriyiDüzenleToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(253, 68);
            // 
            // müşteriyiSilToolStripMenuItem
            // 
            müşteriyiSilToolStripMenuItem.Name = "müşteriyiSilToolStripMenuItem";
            müşteriyiSilToolStripMenuItem.Size = new Size(252, 32);
            müşteriyiSilToolStripMenuItem.Text = "Müşteriyi Sil";
            müşteriyiSilToolStripMenuItem.Click += müşteriyiSilToolStripMenuItem_Click;
            // 
            // müşteriyiDüzenleToolStripMenuItem
            // 
            müşteriyiDüzenleToolStripMenuItem.Name = "müşteriyiDüzenleToolStripMenuItem";
            müşteriyiDüzenleToolStripMenuItem.Size = new Size(252, 32);
            müşteriyiDüzenleToolStripMenuItem.Text = "Müşteriyi Düzenle";
            müşteriyiDüzenleToolStripMenuItem.Click += müşteriyiDüzenleToolStripMenuItem_Click;
            // 
            // add_customer
            // 
            add_customer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            add_customer.Font = new Font("Nirmala Text", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_customer.Location = new Point(961, 489);
            add_customer.Name = "add_customer";
            add_customer.Size = new Size(219, 106);
            add_customer.TabIndex = 1;
            add_customer.Text = "Müşteri Ekle";
            add_customer.UseVisualStyleBackColor = true;
            add_customer.Click += add_customer_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(add_customer);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 598);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoSize = true;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1180, 598);
            panel2.TabIndex = 2;
            panel2.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(808, 547);
            label2.Name = "label2";
            label2.Size = new Size(110, 45);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox1.BackColor = SystemColors.Highlight;
            comboBox1.DropDownHeight = 107;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 20F);
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "BORÇ EKLE", "TAHSİLAT YAP" });
            comboBox1.Location = new Point(0, 537);
            comboBox1.MinimumSize = new Size(187, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(279, 53);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Location = new Point(-3, -22);
            button1.Name = "button1";
            button1.Size = new Size(102, 88);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(91, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 67);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.ContextMenuStrip = contextMenuStrip2;
            dataGridView2.Location = new Point(0, 97);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.Size = new Size(1177, 437);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellMouseClick += dataGridView2_CellMouseClick;
            dataGridView2.CellMouseDown += dataGridView2_CellMouseDown;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { iŞLEMİSİLToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(146, 28);
            // 
            // iŞLEMİSİLToolStripMenuItem
            // 
            iŞLEMİSİLToolStripMenuItem.Name = "iŞLEMİSİLToolStripMenuItem";
            iŞLEMİSİLToolStripMenuItem.Size = new Size(145, 24);
            iŞLEMİSİLToolStripMenuItem.Text = "İŞLEMİ SİL";
            iŞLEMİSİLToolStripMenuItem.Click += iŞLEMİSİLToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1180, 598);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button add_customer;
        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBox1;
        private DataGridView dataGridView2;
        private Label label1;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem müşteriyiSilToolStripMenuItem;
        private ToolStripMenuItem müşteriyiDüzenleToolStripMenuItem;
        public Label label2;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem iŞLEMİSİLToolStripMenuItem;
    }
}
