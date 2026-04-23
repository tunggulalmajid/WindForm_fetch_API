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
            label4 = new Label();
            TbIdRead = new TextBox();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(411, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(568, 373);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Fetch
            // 
            Fetch.BackColor = SystemColors.Highlight;
            Fetch.ForeColor = SystemColors.ActiveCaptionText;
            Fetch.Location = new Point(764, 423);
            Fetch.Name = "Fetch";
            Fetch.Size = new Size(215, 53);
            Fetch.TabIndex = 1;
            Fetch.Text = "Fetch";
            Fetch.UseVisualStyleBackColor = false;
            Fetch.Click += Fetch_Click;
            // 
            // Tb1
            // 
            Tb1.Location = new Point(30, 88);
            Tb1.Name = "Tb1";
            Tb1.Size = new Size(193, 23);
            Tb1.TabIndex = 2;
            // 
            // Tb2
            // 
            Tb2.Location = new Point(30, 149);
            Tb2.Name = "Tb2";
            Tb2.Size = new Size(193, 23);
            Tb2.TabIndex = 3;
            // 
            // Tb3
            // 
            Tb3.Location = new Point(30, 205);
            Tb3.Name = "Tb3";
            Tb3.Size = new Size(193, 23);
            Tb3.TabIndex = 4;
            // 
            // Nama
            // 
            Nama.AutoSize = true;
            Nama.Location = new Point(30, 70);
            Nama.Name = "Nama";
            Nama.Size = new Size(39, 15);
            Nama.TabIndex = 5;
            Nama.Text = "Nama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 131);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 6;
            label1.Text = "Saldo";
            // 
            // Hutang
            // 
            Hutang.AutoSize = true;
            Hutang.Location = new Point(33, 187);
            Hutang.Name = "Hutang";
            Hutang.Size = new Size(47, 15);
            Hutang.TabIndex = 7;
            Hutang.Text = "Hutang";
            // 
            // BtnPost
            // 
            BtnPost.BackColor = Color.MediumSpringGreen;
            BtnPost.Location = new Point(30, 306);
            BtnPost.Name = "BtnPost";
            BtnPost.Size = new Size(193, 48);
            BtnPost.TabIndex = 8;
            BtnPost.Text = "Post";
            BtnPost.UseVisualStyleBackColor = false;
            BtnPost.Click += BtnPost_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 244);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 10;
            label2.Text = "Networks";
            // 
            // Tb4
            // 
            Tb4.Location = new Point(31, 262);
            Tb4.Name = "Tb4";
            Tb4.Size = new Size(192, 23);
            Tb4.TabIndex = 9;
            Tb4.TextChanged += textBox1_TextChanged;
            // 
            // TbId
            // 
            TbId.Location = new Point(247, 37);
            TbId.Name = "TbId";
            TbId.Size = new Size(147, 23);
            TbId.TabIndex = 11;
            // 
            // BtnCari
            // 
            BtnCari.BackColor = Color.Teal;
            BtnCari.ForeColor = SystemColors.ActiveCaptionText;
            BtnCari.Location = new Point(247, 78);
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
            label3.Location = new Point(247, 19);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 13;
            label3.Text = "Cari Dengan Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 15);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 15;
            label4.Text = "Id";
            // 
            // TbIdRead
            // 
            TbIdRead.Location = new Point(30, 33);
            TbIdRead.Name = "TbIdRead";
            TbIdRead.Size = new Size(193, 23);
            TbIdRead.TabIndex = 14;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.Red;
            BtnDelete.ForeColor = SystemColors.ActiveCaptionText;
            BtnDelete.Location = new Point(30, 360);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(193, 46);
            BtnDelete.TabIndex = 16;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = Color.FromArgb(192, 192, 0);
            BtnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            BtnUpdate.Location = new Point(30, 412);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(193, 46);
            BtnUpdate.TabIndex = 17;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 539);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnDelete);
            Controls.Add(label4);
            Controls.Add(TbIdRead);
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
        private Label label4;
        private TextBox TbIdRead;
        private Button BtnDelete;
        private Button BtnUpdate;
    }
}
