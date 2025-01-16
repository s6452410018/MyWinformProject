namespace MyWinformProject
{
    partial class FrmShapeArea
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btCancelCircle = new System.Windows.Forms.Button();
            this.lbShowCircle = new System.Windows.Forms.Label();
            this.btCalCircle = new System.Windows.Forms.Button();
            this.rdAreaCircle = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tabpage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btCancelSquare = new System.Windows.Forms.Button();
            this.btCalSquare = new System.Windows.Forms.Button();
            this.lbShowSquare = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.rdAreaSquare = new System.Windows.Forms.RadioButton();
            this.tbLengthSquare = new System.Windows.Forms.TextBox();
            this.tbWidthSquare = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbHypotenuse = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btCancelTriangle = new System.Windows.Forms.Button();
            this.btCalTriangle = new System.Windows.Forms.Button();
            this.lbShowTriangle = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rdAreaTriangle = new System.Windows.Forms.RadioButton();
            this.tbHeightTriangle = new System.Windows.Forms.TextBox();
            this.tbBaseTriangle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabpage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabpage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(35, 108);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 327);
            this.tabControl1.TabIndex = 68;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btCancelCircle);
            this.tabPage1.Controls.Add(this.lbShowCircle);
            this.tabPage1.Controls.Add(this.btCalCircle);
            this.tabPage1.Controls.Add(this.rdAreaCircle);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbRadius);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "วงกลม";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btCancelCircle
            // 
            this.btCancelCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelCircle.Image = global::MyWinformProject.Properties.Resources.cancel;
            this.btCancelCircle.Location = new System.Drawing.Point(359, 152);
            this.btCancelCircle.Name = "btCancelCircle";
            this.btCancelCircle.Size = new System.Drawing.Size(94, 43);
            this.btCancelCircle.TabIndex = 89;
            this.btCancelCircle.Text = "ยกเลิก";
            this.btCancelCircle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancelCircle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancelCircle.UseVisualStyleBackColor = true;
            // 
            // lbShowCircle
            // 
            this.lbShowCircle.BackColor = System.Drawing.Color.Yellow;
            this.lbShowCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowCircle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbShowCircle.Location = new System.Drawing.Point(14, 224);
            this.lbShowCircle.Name = "lbShowCircle";
            this.lbShowCircle.Size = new System.Drawing.Size(270, 35);
            this.lbShowCircle.TabIndex = 91;
            this.lbShowCircle.Text = "0.00";
            this.lbShowCircle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCalCircle
            // 
            this.btCalCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalCircle.Image = global::MyWinformProject.Properties.Resources.calculator21;
            this.btCalCircle.Location = new System.Drawing.Point(359, 91);
            this.btCalCircle.Name = "btCalCircle";
            this.btCalCircle.Size = new System.Drawing.Size(94, 43);
            this.btCalCircle.TabIndex = 88;
            this.btCalCircle.Text = "คำนวณ";
            this.btCalCircle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCalCircle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCalCircle.UseVisualStyleBackColor = true;
            // 
            // rdAreaCircle
            // 
            this.rdAreaCircle.Checked = true;
            this.rdAreaCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAreaCircle.Location = new System.Drawing.Point(18, 102);
            this.rdAreaCircle.Name = "rdAreaCircle";
            this.rdAreaCircle.Size = new System.Drawing.Size(88, 32);
            this.rdAreaCircle.TabIndex = 86;
            this.rdAreaCircle.TabStop = true;
            this.rdAreaCircle.Text = "พื้นที่วงกลม";
            this.rdAreaCircle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 90;
            this.label1.Text = "ผลลัพธ์";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 84;
            this.label4.Text = "ป้อนรัศมี";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbRadius
            // 
            this.tbRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRadius.Location = new System.Drawing.Point(18, 65);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(266, 22);
            this.tbRadius.TabIndex = 85;
            // 
            // radioButton2
            // 
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(18, 140);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 32);
            this.radioButton2.TabIndex = 87;
            this.radioButton2.Text = "เส้นรอบวงกลม";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tabpage2
            // 
            this.tabpage2.Controls.Add(this.label6);
            this.tabpage2.Controls.Add(this.btCancelSquare);
            this.tabpage2.Controls.Add(this.btCalSquare);
            this.tabpage2.Controls.Add(this.lbShowSquare);
            this.tabpage2.Controls.Add(this.radioButton4);
            this.tabpage2.Controls.Add(this.rdAreaSquare);
            this.tabpage2.Controls.Add(this.tbLengthSquare);
            this.tabpage2.Controls.Add(this.tbWidthSquare);
            this.tabpage2.Controls.Add(this.label5);
            this.tabpage2.Controls.Add(this.label2);
            this.tabpage2.Location = new System.Drawing.Point(4, 22);
            this.tabpage2.Name = "tabpage2";
            this.tabpage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage2.Size = new System.Drawing.Size(576, 301);
            this.tabpage2.TabIndex = 1;
            this.tabpage2.Text = "สี่เหลี่ยม";
            this.tabpage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 91;
            this.label6.Text = "ผลลัพธ์";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btCancelSquare
            // 
            this.btCancelSquare.Image = global::MyWinformProject.Properties.Resources.cancel;
            this.btCancelSquare.Location = new System.Drawing.Point(402, 162);
            this.btCancelSquare.Name = "btCancelSquare";
            this.btCancelSquare.Size = new System.Drawing.Size(95, 44);
            this.btCancelSquare.TabIndex = 69;
            this.btCancelSquare.Text = "ยกเลิก";
            this.btCancelSquare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancelSquare.UseVisualStyleBackColor = true;
            // 
            // btCalSquare
            // 
            this.btCalSquare.Image = global::MyWinformProject.Properties.Resources.calculator2;
            this.btCalSquare.Location = new System.Drawing.Point(402, 112);
            this.btCalSquare.Name = "btCalSquare";
            this.btCalSquare.Size = new System.Drawing.Size(95, 44);
            this.btCalSquare.TabIndex = 68;
            this.btCalSquare.Text = "คำนวณ";
            this.btCalSquare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCalSquare.UseVisualStyleBackColor = true;
            // 
            // lbShowSquare
            // 
            this.lbShowSquare.BackColor = System.Drawing.Color.Yellow;
            this.lbShowSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowSquare.ForeColor = System.Drawing.Color.Red;
            this.lbShowSquare.Location = new System.Drawing.Point(69, 232);
            this.lbShowSquare.Name = "lbShowSquare";
            this.lbShowSquare.Size = new System.Drawing.Size(233, 33);
            this.lbShowSquare.TabIndex = 67;
            this.lbShowSquare.Text = "0.00";
            this.lbShowSquare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(73, 160);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(101, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.Text = "เส้นรอบสี่เหลี่ยม";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // rdAreaSquare
            // 
            this.rdAreaSquare.AutoSize = true;
            this.rdAreaSquare.Checked = true;
            this.rdAreaSquare.Location = new System.Drawing.Point(73, 124);
            this.rdAreaSquare.Name = "rdAreaSquare";
            this.rdAreaSquare.Size = new System.Drawing.Size(86, 17);
            this.rdAreaSquare.TabIndex = 4;
            this.rdAreaSquare.TabStop = true;
            this.rdAreaSquare.Text = "พี้นที่สี่เหลี่ยม";
            this.rdAreaSquare.UseVisualStyleBackColor = true;
            // 
            // tbLengthSquare
            // 
            this.tbLengthSquare.Location = new System.Drawing.Point(208, 64);
            this.tbLengthSquare.Name = "tbLengthSquare";
            this.tbLengthSquare.Size = new System.Drawing.Size(100, 20);
            this.tbLengthSquare.TabIndex = 3;
            // 
            // tbWidthSquare
            // 
            this.tbWidthSquare.Location = new System.Drawing.Point(79, 64);
            this.tbWidthSquare.Name = "tbWidthSquare";
            this.tbWidthSquare.Size = new System.Drawing.Size(100, 20);
            this.tbWidthSquare.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(205, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "ป้อนความยาว";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(76, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ป้อนความกว้าง";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbHypotenuse);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btCancelTriangle);
            this.tabPage3.Controls.Add(this.btCalTriangle);
            this.tabPage3.Controls.Add(this.lbShowTriangle);
            this.tabPage3.Controls.Add(this.radioButton3);
            this.tabPage3.Controls.Add(this.rdAreaTriangle);
            this.tabPage3.Controls.Add(this.tbHeightTriangle);
            this.tabPage3.Controls.Add(this.tbBaseTriangle);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(576, 301);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "สามเหลี่ยมมุมฉาก";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbHypotenuse
            // 
            this.tbHypotenuse.Location = new System.Drawing.Point(345, 64);
            this.tbHypotenuse.Name = "tbHypotenuse";
            this.tbHypotenuse.Size = new System.Drawing.Size(100, 20);
            this.tbHypotenuse.TabIndex = 103;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(342, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 25);
            this.label12.TabIndex = 102;
            this.label12.Text = "ป้อนด้านตรงข้ามมุมฉาก";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 101;
            this.label8.Text = "ผลลัพธ์";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btCancelTriangle
            // 
            this.btCancelTriangle.Image = global::MyWinformProject.Properties.Resources.cancel;
            this.btCancelTriangle.Location = new System.Drawing.Point(407, 162);
            this.btCancelTriangle.Name = "btCancelTriangle";
            this.btCancelTriangle.Size = new System.Drawing.Size(95, 44);
            this.btCancelTriangle.TabIndex = 100;
            this.btCancelTriangle.Text = "ยกเลิก";
            this.btCancelTriangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancelTriangle.UseVisualStyleBackColor = true;
            // 
            // btCalTriangle
            // 
            this.btCalTriangle.Image = global::MyWinformProject.Properties.Resources.calculator21;
            this.btCalTriangle.Location = new System.Drawing.Point(407, 112);
            this.btCalTriangle.Name = "btCalTriangle";
            this.btCalTriangle.Size = new System.Drawing.Size(95, 44);
            this.btCalTriangle.TabIndex = 99;
            this.btCalTriangle.Text = "คำนวณ";
            this.btCalTriangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCalTriangle.UseVisualStyleBackColor = true;
            // 
            // lbShowTriangle
            // 
            this.lbShowTriangle.BackColor = System.Drawing.Color.Yellow;
            this.lbShowTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowTriangle.ForeColor = System.Drawing.Color.Red;
            this.lbShowTriangle.Location = new System.Drawing.Point(74, 232);
            this.lbShowTriangle.Name = "lbShowTriangle";
            this.lbShowTriangle.Size = new System.Drawing.Size(233, 33);
            this.lbShowTriangle.TabIndex = 98;
            this.lbShowTriangle.Text = "0.00";
            this.lbShowTriangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(78, 160);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(113, 17);
            this.radioButton3.TabIndex = 97;
            this.radioButton3.Text = "เส้นรอบสามเหลี่ยม";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rdAreaTriangle
            // 
            this.rdAreaTriangle.AutoSize = true;
            this.rdAreaTriangle.Checked = true;
            this.rdAreaTriangle.Location = new System.Drawing.Point(78, 124);
            this.rdAreaTriangle.Name = "rdAreaTriangle";
            this.rdAreaTriangle.Size = new System.Drawing.Size(98, 17);
            this.rdAreaTriangle.TabIndex = 96;
            this.rdAreaTriangle.TabStop = true;
            this.rdAreaTriangle.Text = "พี้นที่สามเหลี่ยม";
            this.rdAreaTriangle.UseVisualStyleBackColor = true;
            // 
            // tbHeightTriangle
            // 
            this.tbHeightTriangle.Location = new System.Drawing.Point(213, 64);
            this.tbHeightTriangle.Name = "tbHeightTriangle";
            this.tbHeightTriangle.Size = new System.Drawing.Size(100, 20);
            this.tbHeightTriangle.TabIndex = 95;
            // 
            // tbBaseTriangle
            // 
            this.tbBaseTriangle.Location = new System.Drawing.Point(84, 64);
            this.tbBaseTriangle.Name = "tbBaseTriangle";
            this.tbBaseTriangle.Size = new System.Drawing.Size(100, 20);
            this.tbBaseTriangle.TabIndex = 94;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(210, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 25);
            this.label10.TabIndex = 93;
            this.label10.Text = "ป้อนความสูง";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(81, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 25);
            this.label11.TabIndex = 92;
            this.label11.Text = "ป้อนฐาน";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(31, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(588, 57);
            this.label3.TabIndex = 67;
            this.label3.Text = "คำนวณรูปทรง";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btMainMenu
            // 
            this.btMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.Image = global::MyWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(650, 18);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(119, 57);
            this.btMainMenu.TabIndex = 69;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = true;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 457);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 70;
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
            // FrmShapeArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "FrmShapeArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShapArea - DTI V.1.0";
            this.Load += new System.EventHandler(this.FrmShapeArea_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabpage2.ResumeLayout(false);
            this.tabpage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btCancelCircle;
        private System.Windows.Forms.Label lbShowCircle;
        private System.Windows.Forms.Button btCalCircle;
        private System.Windows.Forms.RadioButton rdAreaCircle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TabPage tabpage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btCancelSquare;
        private System.Windows.Forms.Button btCalSquare;
        private System.Windows.Forms.Label lbShowSquare;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton rdAreaSquare;
        private System.Windows.Forms.TextBox tbLengthSquare;
        private System.Windows.Forms.TextBox tbWidthSquare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbHypotenuse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btCancelTriangle;
        private System.Windows.Forms.Button btCalTriangle;
        private System.Windows.Forms.Label lbShowTriangle;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rdAreaTriangle;
        private System.Windows.Forms.TextBox tbHeightTriangle;
        private System.Windows.Forms.TextBox tbBaseTriangle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}