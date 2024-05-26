namespace WinFormsApp1
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
            bindingSource1 = new BindingSource(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            Hoten = new DataGridViewTextBoxColumn();
            sdt = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            Matkhau = new DataGridViewTextBoxColumn();
            Nhaplaimatkhau = new DataGridViewTextBoxColumn();
            splitContainer1 = new SplitContainer();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            Suahoten = new DataGridViewTextBoxColumn();
            Suasdt = new DataGridViewTextBoxColumn();
            Suaemail = new DataGridViewTextBoxColumn();
            Suamatkhau = new DataGridViewTextBoxColumn();
            splitContainer2 = new SplitContainer();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            label11 = new Label();
            label12 = new Label();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(778, 524);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(770, 491);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thêm tài khoản ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Hoten, sdt, email, Matkhau, Nhaplaimatkhau });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(764, 230);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Hoten
            // 
            Hoten.HeaderText = "Họ tên";
            Hoten.MinimumWidth = 6;
            Hoten.Name = "Hoten";
            // 
            // sdt
            // 
            sdt.HeaderText = "Số điện thoại ";
            sdt.MinimumWidth = 6;
            sdt.Name = "sdt";
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            // 
            // Matkhau
            // 
            Matkhau.HeaderText = "Mật khẩu";
            Matkhau.MinimumWidth = 6;
            Matkhau.Name = "Matkhau";
            // 
            // Nhaplaimatkhau
            // 
            Nhaplaimatkhau.HeaderText = "Nhập lại mật khẩu";
            Nhaplaimatkhau.MinimumWidth = 6;
            Nhaplaimatkhau.Name = "Nhaplaimatkhau";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Top;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Zoom;
            splitContainer1.Panel1.Controls.Add(pictureBox2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBox5);
            splitContainer1.Panel2.Controls.Add(textBox4);
            splitContainer1.Panel2.Controls.Add(textBox3);
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(764, 255);
            splitContainer1.SplitterDistance = 238;
            splitContainer1.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(184, 173);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(168, 27);
            textBox5.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(184, 134);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(168, 27);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(184, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(184, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 27);
            textBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 180);
            label5.Name = "label5";
            label5.Size = new Size(130, 20);
            label5.TabIndex = 4;
            label5.Text = "Nhập lại mật khẩu";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(184, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(373, 210);
            button1.Name = "button1";
            button1.Size = new Size(130, 42);
            button1.TabIndex = 1;
            button1.Text = "Thêm tài khoản";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 137);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 94);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 55);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(splitContainer2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(770, 491);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sửa xóa tài khoản";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Suahoten, Suasdt, Suaemail, Suamatkhau });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 325);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(764, 163);
            dataGridView2.TabIndex = 2;
            // 
            // Suahoten
            // 
            Suahoten.HeaderText = "Họ tên";
            Suahoten.MinimumWidth = 6;
            Suahoten.Name = "Suahoten";
            // 
            // Suasdt
            // 
            Suasdt.HeaderText = "Số điện thoại ";
            Suasdt.MinimumWidth = 6;
            Suasdt.Name = "Suasdt";
            // 
            // Suaemail
            // 
            Suaemail.HeaderText = "Email";
            Suaemail.MinimumWidth = 6;
            Suaemail.Name = "Suaemail";
            // 
            // Suamatkhau
            // 
            Suamatkhau.HeaderText = "Mật khẩu";
            Suamatkhau.MinimumWidth = 6;
            Suamatkhau.Name = "Suamatkhau";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Top;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(radioButton2);
            splitContainer2.Panel2.Controls.Add(radioButton1);
            splitContainer2.Panel2.Controls.Add(dateTimePicker1);
            splitContainer2.Panel2.Controls.Add(label11);
            splitContainer2.Panel2.Controls.Add(label12);
            splitContainer2.Panel2.Controls.Add(textBox10);
            splitContainer2.Panel2.Controls.Add(textBox9);
            splitContainer2.Panel2.Controls.Add(textBox8);
            splitContainer2.Panel2.Controls.Add(textBox7);
            splitContainer2.Panel2.Controls.Add(textBox6);
            splitContainer2.Panel2.Controls.Add(button3);
            splitContainer2.Panel2.Controls.Add(button2);
            splitContainer2.Panel2.Controls.Add(label10);
            splitContainer2.Panel2.Controls.Add(label9);
            splitContainer2.Panel2.Controls.Add(label8);
            splitContainer2.Panel2.Controls.Add(label7);
            splitContainer2.Panel2.Controls.Add(label6);
            splitContainer2.Size = new Size(764, 322);
            splitContainer2.SplitterDistance = 254;
            splitContainer2.TabIndex = 0;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(308, 86);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(193, 86);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(193, 53);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(165, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 53);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 3;
            label11.Text = "Ngày sinh";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 92);
            label12.Name = "label12";
            label12.Size = new Size(65, 20);
            label12.TabIndex = 4;
            label12.Text = "Giới tính";
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox10.Location = new Point(193, 228);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(165, 27);
            textBox10.TabIndex = 11;
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox9.Location = new Point(193, 195);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(165, 27);
            textBox9.TabIndex = 10;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox8.Location = new Point(193, 157);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(165, 27);
            textBox8.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Location = new Point(193, 124);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(165, 27);
            textBox7.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Location = new Point(193, 11);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(165, 27);
            textBox6.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(345, 261);
            button3.Name = "button3";
            button3.Size = new Size(117, 44);
            button3.TabIndex = 6;
            button3.Text = "Xóa tài khoản";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(78, 261);
            button2.Name = "button2";
            button2.Size = new Size(113, 44);
            button2.TabIndex = 5;
            button2.Text = "Sửa tài khoản";
            button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 238);
            label10.Name = "label10";
            label10.Size = new Size(130, 20);
            label10.TabIndex = 4;
            label10.Text = "Nhập lại mật khẩu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 203);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 3;
            label9.Text = "Mật khẩu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 164);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 2;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 129);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 1;
            label7.Text = "Số điện thoại ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 14);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 0;
            label6.Text = "Họ tên";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._06888e665da5fc28bdac697bee700fc0;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.ErrorImage = Properties.Resources._06888e665da5fc28bdac697bee700fc0;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 322);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources._0f5c65b0112e210173c4cbe21d658142;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(238, 255);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 524);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private DataGridViewTextBoxColumn Hoten;
        private DataGridViewTextBoxColumn sdt;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn Matkhau;
        private DataGridViewTextBoxColumn Nhaplaimatkhau;
        private SplitContainer splitContainer2;
        private DataGridView dataGridView2;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private Button button3;
        private Button button2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private DataGridViewTextBoxColumn Suahoten;
        private DataGridViewTextBoxColumn Suasdt;
        private DataGridViewTextBoxColumn Suaemail;
        private DataGridViewTextBoxColumn Suamatkhau;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
