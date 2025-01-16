namespace MyWinformProject
{
    partial class FrmDooDung
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbResultDung = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.lbIdCard = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.nudHeigth = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mtbIdCard = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.btDooDung = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeigth)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbResultDung);
            this.groupBox2.Controls.Add(this.lbHeight);
            this.groupBox2.Controls.Add(this.lbWeight);
            this.groupBox2.Controls.Add(this.lbAge);
            this.groupBox2.Controls.Add(this.lbBirthDate);
            this.groupBox2.Controls.Add(this.lbFullname);
            this.groupBox2.Controls.Add(this.lbIdCard);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(417, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 326);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ผลดวงของคุณ";
            // 
            // lbResultDung
            // 
            this.lbResultDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResultDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultDung.ForeColor = System.Drawing.Color.Purple;
            this.lbResultDung.Location = new System.Drawing.Point(55, 233);
            this.lbResultDung.Name = "lbResultDung";
            this.lbResultDung.Size = new System.Drawing.Size(285, 71);
            this.lbResultDung.TabIndex = 41;
            this.lbResultDung.Text = "ผลดวง";
            this.lbResultDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHeight
            // 
            this.lbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeight.ForeColor = System.Drawing.Color.Green;
            this.lbHeight.Location = new System.Drawing.Point(132, 198);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(208, 23);
            this.lbHeight.TabIndex = 39;
            this.lbHeight.Text = "XXXXXX";
            this.lbHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWeight
            // 
            this.lbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeight.ForeColor = System.Drawing.Color.Green;
            this.lbWeight.Location = new System.Drawing.Point(132, 168);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(208, 23);
            this.lbWeight.TabIndex = 38;
            this.lbWeight.Text = "XXXXXX";
            this.lbWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAge
            // 
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.ForeColor = System.Drawing.Color.Green;
            this.lbAge.Location = new System.Drawing.Point(132, 135);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(208, 23);
            this.lbAge.TabIndex = 37;
            this.lbAge.Text = "XXXXXX";
            this.lbAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthDate.ForeColor = System.Drawing.Color.Green;
            this.lbBirthDate.Location = new System.Drawing.Point(132, 102);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(208, 23);
            this.lbBirthDate.TabIndex = 36;
            this.lbBirthDate.Text = "XXXXXX";
            this.lbBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFullname
            // 
            this.lbFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullname.ForeColor = System.Drawing.Color.Green;
            this.lbFullname.Location = new System.Drawing.Point(132, 68);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(208, 23);
            this.lbFullname.TabIndex = 35;
            this.lbFullname.Text = "XXXXXX";
            this.lbFullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIdCard
            // 
            this.lbIdCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdCard.ForeColor = System.Drawing.Color.Green;
            this.lbIdCard.Location = new System.Drawing.Point(132, 36);
            this.lbIdCard.Name = "lbIdCard";
            this.lbIdCard.Size = new System.Drawing.Size(208, 23);
            this.lbIdCard.TabIndex = 34;
            this.lbIdCard.Text = "XXXXXX";
            this.lbIdCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(26, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 33;
            this.label16.Text = "อายุ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 32;
            this.label11.Text = "ส่วนสูง";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 31;
            this.label12.Text = "น้ำหนัก";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 30;
            this.label13.Text = "ว/ด/ป เกิด";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 29;
            this.label14.Text = "ชิ่อ-สกุล";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(26, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 28;
            this.label15.Text = "ID Card";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbPicture);
            this.panel1.Location = new System.Drawing.Point(213, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 162);
            this.panel1.TabIndex = 61;
            // 
            // pbPicture
            // 
            this.pbPicture.ErrorImage = null;
            this.pbPicture.Image = global::MyWinformProject.Properties.Resources.marvel1;
            this.pbPicture.InitialImage = null;
            this.pbPicture.Location = new System.Drawing.Point(36, 18);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(117, 124);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 26;
            this.pbPicture.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.nudWeight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpBirthDate);
            this.groupBox1.Controls.Add(this.tbFullname);
            this.groupBox1.Controls.Add(this.nudHeigth);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.mtbIdCard);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(37, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 198);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลส่วนตัว";
            // 
            // nudWeight
            // 
            this.nudWeight.DecimalPlaces = 2;
            this.nudWeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudWeight.Location = new System.Drawing.Point(124, 132);
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(120, 21);
            this.nudWeight.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID Card";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "ชิ่อ-สกุล";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "ว/ด/ป เกิด";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "น้ำหนัก";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "ส่วนสูง";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(124, 99);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(222, 21);
            this.dtpBirthDate.TabIndex = 15;
            // 
            // tbFullname
            // 
            this.tbFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFullname.Location = new System.Drawing.Point(124, 66);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Size = new System.Drawing.Size(222, 22);
            this.tbFullname.TabIndex = 17;
            // 
            // nudHeigth
            // 
            this.nudHeigth.DecimalPlaces = 2;
            this.nudHeigth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudHeigth.Location = new System.Drawing.Point(124, 168);
            this.nudHeigth.Name = "nudHeigth";
            this.nudHeigth.Size = new System.Drawing.Size(120, 21);
            this.nudHeigth.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(250, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "กิโลกร้ม";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(250, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "เซนติเมตร";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbIdCard
            // 
            this.mtbIdCard.Location = new System.Drawing.Point(124, 36);
            this.mtbIdCard.Mask = "0-0000-00000-00-0";
            this.mtbIdCard.Name = "mtbIdCard";
            this.mtbIdCard.Size = new System.Drawing.Size(221, 21);
            this.mtbIdCard.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(27, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(588, 57);
            this.label3.TabIndex = 56;
            this.label3.Text = "ดูดวงแม่นๆ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btMainMenu
            // 
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.Image = global::MyWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(638, 25);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(119, 57);
            this.btMainMenu.TabIndex = 63;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = true;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // btEnd
            // 
            this.btEnd.Image = global::MyWinformProject.Properties.Resources.exit1;
            this.btEnd.Location = new System.Drawing.Point(58, 417);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(112, 41);
            this.btEnd.TabIndex = 59;
            this.btEnd.Text = "จบโปรแกรม";
            this.btEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEnd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEnd.UseVisualStyleBackColor = true;
            // 
            // btDooDung
            // 
            this.btDooDung.Image = global::MyWinformProject.Properties.Resources.find1;
            this.btDooDung.Location = new System.Drawing.Point(58, 365);
            this.btDooDung.Name = "btDooDung";
            this.btDooDung.Size = new System.Drawing.Size(112, 41);
            this.btDooDung.TabIndex = 58;
            this.btDooDung.Text = "ดูดวง";
            this.btDooDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDooDung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDooDung.UseVisualStyleBackColor = true;
            // 
            // btNew
            // 
            this.btNew.Image = global::MyWinformProject.Properties.Resources.new1;
            this.btNew.Location = new System.Drawing.Point(58, 315);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(112, 41);
            this.btNew.TabIndex = 57;
            this.btNew.Text = "ใหม่";
            this.btNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNew.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 504);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(813, 25);
            this.toolStrip1.TabIndex = 64;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslbUsername
            // 
            this.tslbUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslbUsername.ForeColor = System.Drawing.Color.Blue;
            this.tslbUsername.Name = "tslbUsername";
            this.tslbUsername.Size = new System.Drawing.Size(43, 22);
            this.tslbUsername.Text = "name?";
            // 
            // tslbDateTime
            // 
            this.tslbDateTime.Name = "tslbDateTime";
            this.tslbDateTime.Size = new System.Drawing.Size(59, 22);
            this.tslbDateTime.Text = "datetime?";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDooDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 529);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btDooDung);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "FrmDooDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DooDung - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmDooDung_Load);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeigth)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbResultDung;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.Label lbIdCard;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.NumericUpDown nudHeigth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtbIdCard;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.Button btDooDung;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}