namespace WindForm_fetch_API
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
            dataGridView1 = new DataGridView();
            Fetch = new Button();
            Tb1 = new TextBox();
            Tb2 = new TextBox();
            Tb3 = new TextBox();
            Nama = new Label();
            label1 = new Label();
            Hutang = new Label();
            BtnPost = new Button();
            label2 = new Label();
            Tb4 = new TextBox();
            TbId = new TextBox();
            BtnCari = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(238, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(330, 263);
            dataGridView1.TabIndex = 0;
            // 
            // Fetch
            // 
            Fetch.BackColor = SystemColors.Highlight;
            Fetch.ForeColor = SystemColors.ButtonHighlight;
            Fetch.Location = new Point(323, 324);
            Fetch.Name = "Fetch";
            Fetch.Size = new Size(154, 41);
            Fetch.TabIndex = 1;
            Fetch.Text = "Fetch";
            Fetch.UseVisualStyleBackColor = false;
            Fetch.Click += Fetch_Click;
            // 
            // Tb1
            // 
            Tb1.Location = new Point(29, 33);
            Tb1.Name = "Tb1";
            Tb1.Size = new Size(176, 23);
            Tb1.TabIndex = 2;
            // 
            // Tb2
            // 
            Tb2.Location = new Point(29, 94);
            Tb2.Name = "Tb2";
            Tb2.Size = new Size(176, 23);
            Tb2.TabIndex = 3;
            // 
            // Tb3
            // 
            Tb3.Location = new Point(29, 150);
            Tb3.Name = "Tb3";
            Tb3.Size = new Size(176, 23);
            Tb3.TabIndex = 4;
            // 
            // Nama
            // 
            Nama.AutoSize = true;
            Nama.Location = new Point(29, 15);
            Nama.Name = "Nama";
            Nama.Size = new Size(39, 15);
            Nama.TabIndex = 5;
            Nama.Text = "Nama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 76);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 6;
            label1.Text = "Saldo";
            // 
            // Hutang
            // 
            Hutang.AutoSize = true;
            Hutang.Location = new Point(32, 132);
            Hutang.Name = "Hutang";
            Hutang.Size = new Size(47, 15);
            Hutang.TabIndex = 7;
            Hutang.Text = "Hutang";
            // 
            // BtnPost
            // 
            BtnPost.BackColor = Color.Lime;
            BtnPost.Location = new Point(30, 255);
            BtnPost.Name = "BtnPost";
            BtnPost.Size = new Size(175, 41);
            BtnPost.TabIndex = 8;
            BtnPost.Text = "Post";
            BtnPost.UseVisualStyleBackColor = false;
            BtnPost.Click += BtnPost_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 189);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 10;
            label2.Text = "Networks";
            // 
            // Tb4
            // 
            Tb4.Location = new Point(30, 207);
            Tb4.Name = "Tb4";
            Tb4.Size = new Size(176, 23);
            Tb4.TabIndex = 9;
            Tb4.TextChanged += textBox1_TextChanged;
            // 
            // TbId
            // 
            TbId.Location = new Point(589, 46);
            TbId.Name = "TbId";
            TbId.Size = new Size(147, 23);
            TbId.TabIndex = 11;
            // 
            // BtnCari
            // 
            BtnCari.BackColor = Color.Teal;
            BtnCari.ForeColor = SystemColors.ButtonHighlight;
            BtnCari.Location = new Point(589, 76);
            BtnCari.Name = "BtnCari";
            BtnCari.Size = new Size(147, 41);
            BtnCari.TabIndex = 12;
            BtnCari.Text = "Cari";
            BtnCari.UseVisualStyleBackColor = false;
            BtnCari.Click += BtnCari_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(589, 28);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 13;
            label3.Text = "Cari Dengan Id";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(BtnCari);
            Controls.Add(TbId);
            Controls.Add(label2);
            Controls.Add(Tb4);
            Controls.Add(BtnPost);
            Controls.Add(Hutang);
            Controls.Add(label1);
            Controls.Add(Nama);
            Controls.Add(Tb3);
            Controls.Add(Tb2);
            Controls.Add(Tb1);
            Controls.Add(Fetch);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Fetch;
        private TextBox Tb1;
        private TextBox Tb2;
        private TextBox Tb3;
        private Label Nama;
        private Label label1;
        private Label Hutang;
        private Button BtnPost;
        private Label label2;
        private TextBox Tb4;
        private TextBox TbId;
        private Button BtnCari;
        private Label label3;
    }
}
