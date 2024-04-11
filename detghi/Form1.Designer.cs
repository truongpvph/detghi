namespace detghi
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
            groupBox1 = new GroupBox();
            cbbluachon = new ComboBox();
            btnloatcau1 = new Button();
            btnthongbao = new Button();
            txtthongdiep = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnGhi = new Button();
            btndoc = new Button();
            txtdoc_ghi = new TextBox();
            cau3 = new GroupBox();
            btnclear = new Button();
            btnload = new Button();
            dataGridView1 = new DataGridView();
            rdonu = new RadioButton();
            rdonam = new RadioButton();
            txtnganh = new TextBox();
            txtten = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            cau3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbbluachon);
            groupBox1.Controls.Add(btnloatcau1);
            groupBox1.Controls.Add(btnthongbao);
            groupBox1.Controls.Add(txtthongdiep);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(519, 284);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Câu 1 ";
            // 
            // cbbluachon
            // 
            cbbluachon.FormattingEnabled = true;
            cbbluachon.Location = new Point(8, 176);
            cbbluachon.Name = "cbbluachon";
            cbbluachon.Size = new Size(401, 28);
            cbbluachon.TabIndex = 6;
            // 
            // btnloatcau1
            // 
            btnloatcau1.Location = new Point(299, 26);
            btnloatcau1.Name = "btnloatcau1";
            btnloatcau1.Size = new Size(94, 29);
            btnloatcau1.TabIndex = 5;
            btnloatcau1.Text = "Load";
            btnloatcau1.UseVisualStyleBackColor = true;
            btnloatcau1.Click += btnloatcau1_Click;
            // 
            // btnthongbao
            // 
            btnthongbao.Location = new Point(152, 26);
            btnthongbao.Name = "btnthongbao";
            btnthongbao.Size = new Size(94, 29);
            btnthongbao.TabIndex = 4;
            btnthongbao.Text = "Thong Bao";
            btnthongbao.UseVisualStyleBackColor = true;
            btnthongbao.Click += btnthongbao_Click;
            // 
            // txtthongdiep
            // 
            txtthongdiep.Location = new Point(0, 98);
            txtthongdiep.Name = "txtthongdiep";
            txtthongdiep.Size = new Size(409, 27);
            txtthongdiep.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 140);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Lua Chon ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 64);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "ThongDiep ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGhi);
            groupBox2.Controls.Add(btndoc);
            groupBox2.Controls.Add(txtdoc_ghi);
            groupBox2.Location = new Point(12, 316);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(519, 261);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Câu 2 ";
            // 
            // btnGhi
            // 
            btnGhi.Location = new Point(266, 26);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(94, 29);
            btnGhi.TabIndex = 6;
            btnGhi.Text = "Ghi";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // btndoc
            // 
            btndoc.Location = new Point(91, 26);
            btndoc.Name = "btndoc";
            btndoc.Size = new Size(94, 29);
            btndoc.TabIndex = 7;
            btndoc.Text = "Doc";
            btndoc.UseVisualStyleBackColor = true;
            btndoc.Click += btndoc_Click;
            // 
            // txtdoc_ghi
            // 
            txtdoc_ghi.Location = new Point(6, 75);
            txtdoc_ghi.Multiline = true;
            txtdoc_ghi.Name = "txtdoc_ghi";
            txtdoc_ghi.Size = new Size(507, 180);
            txtdoc_ghi.TabIndex = 7;
            // 
            // cau3
            // 
            cau3.Controls.Add(btnclear);
            cau3.Controls.Add(btnload);
            cau3.Controls.Add(dataGridView1);
            cau3.Controls.Add(rdonu);
            cau3.Controls.Add(rdonam);
            cau3.Controls.Add(txtnganh);
            cau3.Controls.Add(txtten);
            cau3.Controls.Add(label4);
            cau3.Controls.Add(label5);
            cau3.Controls.Add(label6);
            cau3.Location = new Point(569, 12);
            cau3.Name = "cau3";
            cau3.Size = new Size(512, 565);
            cau3.TabIndex = 1;
            cau3.TabStop = false;
            cau3.Text = "Câu 3";
            // 
            // btnclear
            // 
            btnclear.Location = new Point(365, 26);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(94, 29);
            btnclear.TabIndex = 8;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnload
            // 
            btnload.Location = new Point(131, 26);
            btnload.Name = "btnload";
            btnload.Size = new Size(94, 29);
            btnload.TabIndex = 9;
            btnload.Text = "Load";
            btnload.UseVisualStyleBackColor = true;
            btnload.Click += btnload_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 285);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(490, 274);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // rdonu
            // 
            rdonu.AutoSize = true;
            rdonu.Location = new Point(324, 217);
            rdonu.Name = "rdonu";
            rdonu.Size = new Size(49, 24);
            rdonu.TabIndex = 8;
            rdonu.TabStop = true;
            rdonu.Text = "Nu";
            rdonu.UseVisualStyleBackColor = true;
            // 
            // rdonam
            // 
            rdonam.AutoSize = true;
            rdonam.Location = new Point(131, 217);
            rdonam.Name = "rdonam";
            rdonam.Size = new Size(62, 24);
            rdonam.TabIndex = 7;
            rdonam.TabStop = true;
            rdonam.Text = "Nam";
            rdonam.UseVisualStyleBackColor = true;
            // 
            // txtnganh
            // 
            txtnganh.Location = new Point(26, 164);
            txtnganh.Name = "txtnganh";
            txtnganh.Size = new Size(347, 27);
            txtnganh.TabIndex = 6;
            // 
            // txtten
            // 
            txtten.Location = new Point(26, 98);
            txtten.Name = "txtten";
            txtten.Size = new Size(347, 27);
            txtten.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 75);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 3;
            label4.Text = "Ten";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 140);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 4;
            label5.Text = "Nganh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 221);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Gioi tinh ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 589);
            Controls.Add(groupBox2);
            Controls.Add(cau3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            cau3.ResumeLayout(false);
            cau3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox cau3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtthongdiep;
        private TextBox txtdoc_ghi;
        private TextBox txtnganh;
        private TextBox txtten;
        private RadioButton rdonu;
        private RadioButton rdonam;
        private Button btnloatcau1;
        private Button btnthongbao;
        private Button btnGhi;
        private Button btndoc;
        private Button btnclear;
        private Button btnload;
        private DataGridView dataGridView1;
        private ComboBox cbbluachon;
    }
}
