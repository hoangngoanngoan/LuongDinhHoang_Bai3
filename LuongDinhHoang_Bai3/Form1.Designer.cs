namespace LuongDinhHoang_Bai3
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
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            txtmadonhang = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txttensp = new TextBox();
            label6 = new Label();
            btnThem = new Button();
            txtdongia = new TextBox();
            txtsoluong = new TextBox();
            txtngaydat = new TextBox();
            txttenkh = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dt1 = new DataGridView();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dt1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1547, 10);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(dt1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(1547, 342);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(txtmadonhang);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(387, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 342);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Xóa đơn hàng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(134, 81);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtmadonhang
            // 
            txtmadonhang.Location = new Point(134, 40);
            txtmadonhang.Name = "txtmadonhang";
            txtmadonhang.Size = new Size(125, 27);
            txtmadonhang.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 40);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã đơn hàng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txttensp);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtdongia);
            groupBox1.Controls.Add(txtsoluong);
            groupBox1.Controls.Add(txtngaydat);
            groupBox1.Controls.Add(txttenkh);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 342);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm đơn hàng";
            // 
            // txttensp
            // 
            txttensp.Location = new Point(155, 37);
            txttensp.Name = "txttensp";
            txttensp.Size = new Size(125, 27);
            txttensp.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 40);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 9;
            label6.Text = "Tên sản phẩm";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(155, 255);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtdongia
            // 
            txtdongia.Location = new Point(155, 201);
            txtdongia.Name = "txtdongia";
            txtdongia.Size = new Size(125, 27);
            txtdongia.TabIndex = 7;
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(155, 162);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(125, 27);
            txtsoluong.TabIndex = 6;
            // 
            // txtngaydat
            // 
            txtngaydat.Location = new Point(155, 118);
            txtngaydat.Name = "txtngaydat";
            txtngaydat.Size = new Size(125, 27);
            txtngaydat.TabIndex = 5;
            // 
            // txttenkh
            // 
            txttenkh.Location = new Point(155, 78);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(125, 27);
            txttenkh.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 204);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 3;
            label5.Text = "Đơn giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 165);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 2;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 121);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 1;
            label3.Text = "Ngày đặt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 81);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên Khách hàng";
            // 
            // dt1
            // 
            dt1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt1.Dock = DockStyle.Right;
            dt1.Location = new Point(759, 0);
            dt1.Name = "dt1";
            dt1.RowHeadersWidth = 51;
            dt1.Size = new Size(788, 342);
            dt1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 352);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Chương trình quản lý đơn hàng 2024";
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dt1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private DataGridView dt1;
        private Button btnXoa;
        private TextBox txtmadonhang;
        private Label label1;
        private Button btnThem;
        private TextBox txtdongia;
        private TextBox txtsoluong;
        private TextBox txtngaydat;
        private TextBox txttenkh;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txttensp;
        private Label label6;
    }
}
