namespace Demo_dijckstra
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_edges = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatusPro = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnState4 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.btnState3 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btnState2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btState1 = new System.Windows.Forms.Button();
            this.btnDisplayKC = new System.Windows.Forms.Button();
            this.rtbHienThi = new System.Windows.Forms.RichTextBox();
            this.btCreateEP = new System.Windows.Forms.Button();
            this.btCreateSP = new System.Windows.Forms.Button();
            this.btCreateEs = new System.Windows.Forms.Button();
            this.btCreatePoints = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbEdges = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtSoDuong = new System.Windows.Forms.TextBox();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.txtStartPoint = new System.Windows.Forms.TextBox();
            this.txtSoDiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SanChoi = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 491);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button10);
            this.panel4.Controls.Add(this.button11);
            this.panel4.Controls.Add(this.button12);
            this.panel4.Controls.Add(this.button13);
            this.panel4.Controls.Add(this.button14);
            this.panel4.Controls.Add(this.button15);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.button16);
            this.panel4.Controls.Add(this.button17);
            this.panel4.Controls.Add(this.button18);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(306, 491);
            this.panel4.TabIndex = 1;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(192, 16);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 7;
            this.button10.Text = "Tạo lại";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(250, 167);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(44, 34);
            this.button11.TabIndex = 7;
            this.button11.Text = "Sửa";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(250, 126);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(44, 34);
            this.button12.TabIndex = 7;
            this.button12.Text = "Sửa";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(206, 47);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(44, 34);
            this.button13.TabIndex = 7;
            this.button13.Text = "Tạo";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(250, 86);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(44, 34);
            this.button14.TabIndex = 7;
            this.button14.Text = "Sửa";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(111, 16);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 7;
            this.button15.Text = "Sửa";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(17, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(280, 2);
            this.label10.TabIndex = 6;
            this.label10.Text = "__________________________________________";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(14, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(280, 2);
            this.label11.TabIndex = 6;
            this.label11.Text = "__________________________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(82, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Tối đa:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(34, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "< 20 điểm";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(22, 268);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 143);
            this.panel5.TabIndex = 3;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(197, 239);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 2;
            this.button16.Text = "Kết quả";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(111, 436);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 2;
            this.button17.Text = "Reset";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(95, 239);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(91, 23);
            this.button18.TabIndex = 2;
            this.button18.Text = "Tạo đồ thị";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 33);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 167);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 36);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 126);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 35);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(125, 47);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 34);
            this.textBox4.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 14);
            this.label15.TabIndex = 0;
            this.label15.Text = "Số đường nối";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 189);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 14);
            this.label16.TabIndex = 0;
            this.label16.Text = "Điểm kết thúc";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(21, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 14);
            this.label17.TabIndex = 0;
            this.label17.Text = "Điểm bắt đầu";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(17, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 14);
            this.label18.TabIndex = 0;
            this.label18.Text = "Số điểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điểm";
            // 
            // timer_edges
            // 
            this.timer_edges.Enabled = true;
            this.timer_edges.Interval = 2000;
            this.timer_edges.Tick += new System.EventHandler(this.timer_edges_Tick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Demo_dijckstra.Properties.Resources.b1;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblStatusPro);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.btnState4);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.btnState3);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.btnState2);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.btState1);
            this.panel2.Controls.Add(this.btnDisplayKC);
            this.panel2.Controls.Add(this.rtbHienThi);
            this.panel2.Controls.Add(this.btCreateEP);
            this.panel2.Controls.Add(this.btCreateSP);
            this.panel2.Controls.Add(this.btCreateEs);
            this.panel2.Controls.Add(this.btCreatePoints);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lbEdges);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnKetQua);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.txtSoDuong);
            this.panel2.Controls.Add(this.txtEndPoint);
            this.panel2.Controls.Add(this.txtStartPoint);
            this.panel2.Controls.Add(this.txtSoDiem);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(8, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 491);
            this.panel2.TabIndex = 1;
            // 
            // lblStatusPro
            // 
            this.lblStatusPro.AutoSize = true;
            this.lblStatusPro.ForeColor = System.Drawing.Color.Blue;
            this.lblStatusPro.Location = new System.Drawing.Point(203, 10);
            this.lblStatusPro.Name = "lblStatusPro";
            this.lblStatusPro.Size = new System.Drawing.Size(52, 15);
            this.lblStatusPro.TabIndex = 13;
            this.lblStatusPro.Text = "Khởi tạo";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(14, 11);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(182, 14);
            this.label24.TabIndex = 12;
            this.label24.Text = "Trạng thái chương trình :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(275, 177);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 15);
            this.label22.TabIndex = 11;
            this.label22.Text = "State";
            // 
            // btnState4
            // 
            this.btnState4.BackColor = System.Drawing.Color.LightGray;
            this.btnState4.Enabled = false;
            this.btnState4.Location = new System.Drawing.Point(313, 172);
            this.btnState4.Name = "btnState4";
            this.btnState4.Size = new System.Drawing.Size(24, 23);
            this.btnState4.TabIndex = 10;
            this.btnState4.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(275, 136);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 15);
            this.label21.TabIndex = 11;
            this.label21.Text = "State";
            // 
            // btnState3
            // 
            this.btnState3.BackColor = System.Drawing.Color.LightGray;
            this.btnState3.Enabled = false;
            this.btnState3.Location = new System.Drawing.Point(313, 131);
            this.btnState3.Name = "btnState3";
            this.btnState3.Size = new System.Drawing.Size(24, 23);
            this.btnState3.TabIndex = 10;
            this.btnState3.UseVisualStyleBackColor = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(275, 96);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 15);
            this.label20.TabIndex = 11;
            this.label20.Text = "State";
            // 
            // btnState2
            // 
            this.btnState2.BackColor = System.Drawing.Color.LightGray;
            this.btnState2.Enabled = false;
            this.btnState2.Location = new System.Drawing.Point(313, 91);
            this.btnState2.Name = "btnState2";
            this.btnState2.Size = new System.Drawing.Size(24, 23);
            this.btnState2.TabIndex = 10;
            this.btnState2.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(275, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 15);
            this.label19.TabIndex = 11;
            this.label19.Text = "State";
            // 
            // btState1
            // 
            this.btState1.BackColor = System.Drawing.Color.LightGray;
            this.btState1.Enabled = false;
            this.btState1.Location = new System.Drawing.Point(313, 52);
            this.btState1.Name = "btState1";
            this.btState1.Size = new System.Drawing.Size(24, 23);
            this.btState1.TabIndex = 10;
            this.btState1.UseVisualStyleBackColor = false;
            // 
            // btnDisplayKC
            // 
            this.btnDisplayKC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDisplayKC.BackgroundImage")));
            this.btnDisplayKC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisplayKC.Image = ((System.Drawing.Image)(resources.GetObject("btnDisplayKC.Image")));
            this.btnDisplayKC.Location = new System.Drawing.Point(22, 231);
            this.btnDisplayKC.Name = "btnDisplayKC";
            this.btnDisplayKC.Size = new System.Drawing.Size(86, 33);
            this.btnDisplayKC.TabIndex = 9;
            this.btnDisplayKC.Text = "Distances";
            this.btnDisplayKC.UseVisualStyleBackColor = true;
            this.btnDisplayKC.Click += new System.EventHandler(this.btnDisplayKC_Click);
            // 
            // rtbHienThi
            // 
            this.rtbHienThi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHienThi.Location = new System.Drawing.Point(14, 273);
            this.rtbHienThi.Name = "rtbHienThi";
            this.rtbHienThi.ReadOnly = true;
            this.rtbHienThi.Size = new System.Drawing.Size(323, 123);
            this.rtbHienThi.TabIndex = 8;
            this.rtbHienThi.Text = "";
            // 
            // btCreateEP
            // 
            this.btCreateEP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCreateEP.BackgroundImage")));
            this.btCreateEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCreateEP.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btCreateEP.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateEP.Location = new System.Drawing.Point(206, 167);
            this.btCreateEP.Name = "btCreateEP";
            this.btCreateEP.Size = new System.Drawing.Size(44, 34);
            this.btCreateEP.TabIndex = 7;
            this.btCreateEP.UseVisualStyleBackColor = true;
            this.btCreateEP.Click += new System.EventHandler(this.btCreateEP_Click);
            // 
            // btCreateSP
            // 
            this.btCreateSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCreateSP.BackgroundImage")));
            this.btCreateSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCreateSP.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btCreateSP.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateSP.Location = new System.Drawing.Point(206, 127);
            this.btCreateSP.Name = "btCreateSP";
            this.btCreateSP.Size = new System.Drawing.Size(44, 34);
            this.btCreateSP.TabIndex = 7;
            this.btCreateSP.UseVisualStyleBackColor = true;
            this.btCreateSP.Click += new System.EventHandler(this.btCreateSP_Click);
            // 
            // btCreateEs
            // 
            this.btCreateEs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCreateEs.BackgroundImage")));
            this.btCreateEs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCreateEs.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btCreateEs.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateEs.Location = new System.Drawing.Point(206, 87);
            this.btCreateEs.Name = "btCreateEs";
            this.btCreateEs.Size = new System.Drawing.Size(44, 34);
            this.btCreateEs.TabIndex = 7;
            this.btCreateEs.UseVisualStyleBackColor = true;
            this.btCreateEs.Click += new System.EventHandler(this.btCreateEs_Click);
            // 
            // btCreatePoints
            // 
            this.btCreatePoints.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCreatePoints.BackgroundImage")));
            this.btCreatePoints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCreatePoints.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btCreatePoints.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreatePoints.Location = new System.Drawing.Point(206, 47);
            this.btCreatePoints.Name = "btCreatePoints";
            this.btCreatePoints.Size = new System.Drawing.Size(44, 34);
            this.btCreatePoints.TabIndex = 7;
            this.btCreatePoints.UseVisualStyleBackColor = true;
            this.btCreatePoints.Click += new System.EventHandler(this.btCreatePoints_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(232, 231);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 33);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(17, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 2);
            this.label9.TabIndex = 6;
            this.label9.Text = "__________________________________________";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(14, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(280, 2);
            this.label8.TabIndex = 6;
            this.label8.Text = "__________________________________________";
            // 
            // lbEdges
            // 
            this.lbEdges.AutoSize = true;
            this.lbEdges.ForeColor = System.Drawing.Color.Blue;
            this.lbEdges.Location = new System.Drawing.Point(82, 107);
            this.lbEdges.Name = "lbEdges";
            this.lbEdges.Size = new System.Drawing.Size(14, 15);
            this.lbEdges.TabIndex = 5;
            this.lbEdges.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tối đa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "< 20 điểm";
            // 
            // btnKetQua
            // 
            this.btnKetQua.BackgroundImage = global::Demo_dijckstra.Properties.Resources.blue_square_button_icons_249482;
            this.btnKetQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKetQua.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetQua.Image = ((System.Drawing.Image)(resources.GetObject("btnKetQua.Image")));
            this.btnKetQua.Location = new System.Drawing.Point(125, 231);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(88, 33);
            this.btnKetQua.TabIndex = 2;
            this.btnKetQua.Text = "Kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = global::Demo_dijckstra.Properties.Resources.blue_square_button_icons_2494821;
            this.btnReset.Location = new System.Drawing.Point(138, 407);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 31);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSoDuong
            // 
            this.txtSoDuong.Location = new System.Drawing.Point(125, 87);
            this.txtSoDuong.Multiline = true;
            this.txtSoDuong.Name = "txtSoDuong";
            this.txtSoDuong.Size = new System.Drawing.Size(75, 33);
            this.txtSoDuong.TabIndex = 1;
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Location = new System.Drawing.Point(125, 167);
            this.txtEndPoint.Multiline = true;
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(75, 36);
            this.txtEndPoint.TabIndex = 1;
            // 
            // txtStartPoint
            // 
            this.txtStartPoint.Location = new System.Drawing.Point(125, 126);
            this.txtStartPoint.Multiline = true;
            this.txtStartPoint.Name = "txtStartPoint";
            this.txtStartPoint.Size = new System.Drawing.Size(75, 35);
            this.txtStartPoint.TabIndex = 1;
            // 
            // txtSoDiem
            // 
            this.txtSoDiem.Location = new System.Drawing.Point(125, 47);
            this.txtSoDiem.Multiline = true;
            this.txtSoDiem.Name = "txtSoDiem";
            this.txtSoDiem.Size = new System.Drawing.Size(75, 34);
            this.txtSoDiem.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số đường nối";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điểm kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điểm bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số điểm";
            // 
            // SanChoi
            // 
            this.SanChoi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SanChoi.BackgroundImage = global::Demo_dijckstra.Properties.Resources.b4;
            this.SanChoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SanChoi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SanChoi.Location = new System.Drawing.Point(380, 16);
            this.SanChoi.Name = "SanChoi";
            this.SanChoi.Size = new System.Drawing.Size(656, 491);
            this.SanChoi.TabIndex = 0;
            this.SanChoi.Paint += new System.Windows.Forms.PaintEventHandler(this.SanChoi_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SanChoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tìm đường đi ngắn nhất";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SanChoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSoDuong;
        private System.Windows.Forms.TextBox txtStartPoint;
        private System.Windows.Forms.TextBox txtSoDiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbEdges;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer_edges;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btCreateEP;
        private System.Windows.Forms.Button btCreateSP;
        private System.Windows.Forms.Button btCreateEs;
        private System.Windows.Forms.Button btCreatePoints;
        private System.Windows.Forms.RichTextBox rtbHienThi;
        private System.Windows.Forms.Button btnDisplayKC;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnState4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnState3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnState2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btState1;
        private System.Windows.Forms.Label lblStatusPro;
        private System.Windows.Forms.Label label24;
    }
}

