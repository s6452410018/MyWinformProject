namespace MyWinformProject
{
    partial class FrmRegister
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
            this.btExit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btRemoveAll = new System.Windows.Forms.Button();
            this.btRemoveOne = new System.Windows.Forms.Button();
            this.btSelectAll = new System.Windows.Forms.Button();
            this.btSelectOne = new System.Windows.Forms.Button();
            this.lsStuSubjectSelected = new System.Windows.Forms.ListBox();
            this.cbConfirm = new System.Windows.Forms.CheckBox();
            this.lsStuSubject = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbStuLevel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btSelectPicture = new System.Windows.Forms.Button();
            this.rdStuFund = new System.Windows.Forms.RadioButton();
            this.rdStuNormal = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStuName = new System.Windows.Forms.TextBox();
            this.tbStuId = new System.Windows.Forms.TextBox();
            this.mcdRegister = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btBacktoMainMenu = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.pbStu = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Image = global::MyWinformProject.Properties.Resources.exit3;
            this.btExit.Location = new System.Drawing.Point(576, 507);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(234, 43);
            this.btExit.TabIndex = 92;
            this.btExit.Text = "ปิดโปรแกรม";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Image = global::MyWinformProject.Properties.Resources.cancel1;
            this.btCancel.Location = new System.Drawing.Point(576, 458);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(234, 43);
            this.btCancel.TabIndex = 91;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btRemoveAll
            // 
            this.btRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoveAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btRemoveAll.Location = new System.Drawing.Point(290, 520);
            this.btRemoveAll.Name = "btRemoveAll";
            this.btRemoveAll.Size = new System.Drawing.Size(76, 33);
            this.btRemoveAll.TabIndex = 89;
            this.btRemoveAll.Text = "<<";
            this.btRemoveAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btRemoveAll.UseVisualStyleBackColor = true;
            // 
            // btRemoveOne
            // 
            this.btRemoveOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoveOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btRemoveOne.Location = new System.Drawing.Point(290, 481);
            this.btRemoveOne.Name = "btRemoveOne";
            this.btRemoveOne.Size = new System.Drawing.Size(76, 33);
            this.btRemoveOne.TabIndex = 88;
            this.btRemoveOne.Text = "<";
            this.btRemoveOne.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btRemoveOne.UseVisualStyleBackColor = true;
            // 
            // btSelectAll
            // 
            this.btSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectAll.ForeColor = System.Drawing.Color.Green;
            this.btSelectAll.Location = new System.Drawing.Point(290, 442);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(76, 33);
            this.btSelectAll.TabIndex = 87;
            this.btSelectAll.Text = ">>";
            this.btSelectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSelectAll.UseVisualStyleBackColor = true;
            // 
            // btSelectOne
            // 
            this.btSelectOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectOne.ForeColor = System.Drawing.Color.Green;
            this.btSelectOne.Location = new System.Drawing.Point(290, 403);
            this.btSelectOne.Name = "btSelectOne";
            this.btSelectOne.Size = new System.Drawing.Size(76, 33);
            this.btSelectOne.TabIndex = 86;
            this.btSelectOne.Text = ">";
            this.btSelectOne.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSelectOne.UseVisualStyleBackColor = true;
            // 
            // lsStuSubjectSelected
            // 
            this.lsStuSubjectSelected.FormattingEnabled = true;
            this.lsStuSubjectSelected.Location = new System.Drawing.Point(382, 403);
            this.lsStuSubjectSelected.Name = "lsStuSubjectSelected";
            this.lsStuSubjectSelected.Size = new System.Drawing.Size(173, 147);
            this.lsStuSubjectSelected.TabIndex = 85;
            // 
            // cbConfirm
            // 
            this.cbConfirm.Location = new System.Drawing.Point(575, 413);
            this.cbConfirm.Name = "cbConfirm";
            this.cbConfirm.Size = new System.Drawing.Size(139, 24);
            this.cbConfirm.TabIndex = 84;
            this.cbConfirm.Text = "ยืนยันการลงทะเบียน";
            this.cbConfirm.UseVisualStyleBackColor = true;
            // 
            // lsStuSubject
            // 
            this.lsStuSubject.FormattingEnabled = true;
            this.lsStuSubject.Items.AddRange(new object[] {
            "ภาษาไทย",
            "ภาษาอังกฤษ",
            "ภาษาจีน",
            "ภาษาญี่ปุ่น",
            "ภาษาจีน",
            "สีงคมศึกษา",
            "คณิตศาสตร์",
            "วิทยาศาสตร์",
            "พลศึกษา",
            "ประวัติศาสตร์",
            "คอมพิวเตอร์เบื้องต้น",
            "บัญชีเบื้องต้น"});
            this.lsStuSubject.Location = new System.Drawing.Point(100, 403);
            this.lsStuSubject.Name = "lsStuSubject";
            this.lsStuSubject.Size = new System.Drawing.Size(173, 147);
            this.lsStuSubject.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 82;
            this.label7.Text = "วิชาที่ลงทะเบียน";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbStuLevel
            // 
            this.cbbStuLevel.FormattingEnabled = true;
            this.cbbStuLevel.Items.AddRange(new object[] {
            "ชั้นมัธยมศึกษาปีที่ 1",
            "ชั้นมัธยมศึกษาปีที่ 2",
            "ชั้นมัธยมศึกษาปีที่ 3",
            "ชั้นมัธยมศึกษาปีที่ 4",
            "ชั้นมัธยมศึกษาปีที่ 5",
            "ชั้นมัธยมศึกษาปีที่ 6"});
            this.cbbStuLevel.Location = new System.Drawing.Point(100, 337);
            this.cbbStuLevel.Name = "cbbStuLevel";
            this.cbbStuLevel.Size = new System.Drawing.Size(173, 21);
            this.cbbStuLevel.TabIndex = 81;
            this.cbbStuLevel.Text = "ชั้นมัธยมศึกษาปีที่ 1";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 80;
            this.label6.Text = "ระดับชั้น";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btSelectPicture
            // 
            this.btSelectPicture.Location = new System.Drawing.Point(773, 330);
            this.btSelectPicture.Name = "btSelectPicture";
            this.btSelectPicture.Size = new System.Drawing.Size(37, 28);
            this.btSelectPicture.TabIndex = 79;
            this.btSelectPicture.Text = "...";
            this.btSelectPicture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSelectPicture.UseVisualStyleBackColor = true;
            // 
            // rdStuFund
            // 
            this.rdStuFund.Location = new System.Drawing.Point(463, 257);
            this.rdStuFund.Name = "rdStuFund";
            this.rdStuFund.Size = new System.Drawing.Size(82, 32);
            this.rdStuFund.TabIndex = 77;
            this.rdStuFund.Text = "กองทุนฯ";
            this.rdStuFund.UseVisualStyleBackColor = true;
            // 
            // rdStuNormal
            // 
            this.rdStuNormal.Checked = true;
            this.rdStuNormal.Location = new System.Drawing.Point(369, 257);
            this.rdStuNormal.Name = "rdStuNormal";
            this.rdStuNormal.Size = new System.Drawing.Size(88, 32);
            this.rdStuNormal.TabIndex = 76;
            this.rdStuNormal.TabStop = true;
            this.rdStuNormal.Text = "ปกตื";
            this.rdStuNormal.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 75;
            this.label5.Text = "ประเภทนักเรียน";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbStuName
            // 
            this.tbStuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStuName.Location = new System.Drawing.Point(370, 189);
            this.tbStuName.Name = "tbStuName";
            this.tbStuName.Size = new System.Drawing.Size(175, 22);
            this.tbStuName.TabIndex = 74;
            // 
            // tbStuId
            // 
            this.tbStuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStuId.Location = new System.Drawing.Point(370, 121);
            this.tbStuId.Name = "tbStuId";
            this.tbStuId.Size = new System.Drawing.Size(175, 22);
            this.tbStuId.TabIndex = 73;
            // 
            // mcdRegister
            // 
            this.mcdRegister.Location = new System.Drawing.Point(100, 121);
            this.mcdRegister.Name = "mcdRegister";
            this.mcdRegister.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 71;
            this.label4.Text = "ชิ่อ-สกุล";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 70;
            this.label2.Text = "เลขประจำคัวนักเรียน";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 69;
            this.label1.Text = "วันที่ลงทะเบียน";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(65, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(588, 57);
            this.label3.TabIndex = 68;
            this.label3.Text = "ลงทะเบียนเรียน";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btBacktoMainMenu
            // 
            this.btBacktoMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBacktoMainMenu.Image = global::MyWinformProject.Properties.Resources.pevious1;
            this.btBacktoMainMenu.Location = new System.Drawing.Point(691, 8);
            this.btBacktoMainMenu.Name = "btBacktoMainMenu";
            this.btBacktoMainMenu.Size = new System.Drawing.Size(119, 57);
            this.btBacktoMainMenu.TabIndex = 93;
            this.btBacktoMainMenu.Text = "หน้าจอหลัก";
            this.btBacktoMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBacktoMainMenu.UseVisualStyleBackColor = true;
            // 
            // btRegister
            // 
            this.btRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.Image = global::MyWinformProject.Properties.Resources.add;
            this.btRegister.Location = new System.Drawing.Point(710, 403);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(100, 43);
            this.btRegister.TabIndex = 90;
            this.btRegister.Text = "ลงทะเบียน";
            this.btRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRegister.UseVisualStyleBackColor = true;
            // 
            // pbStu
            // 
            this.pbStu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStu.Location = new System.Drawing.Point(576, 95);
            this.pbStu.Name = "pbStu";
            this.pbStu.Size = new System.Drawing.Size(180, 263);
            this.pbStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStu.TabIndex = 78;
            this.pbStu.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 580);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(874, 25);
            this.toolStrip1.TabIndex = 94;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "name?";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "datetime?";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 605);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btBacktoMainMenu);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btRemoveAll);
            this.Controls.Add(this.btRemoveOne);
            this.Controls.Add(this.btSelectAll);
            this.Controls.Add(this.btSelectOne);
            this.Controls.Add(this.lsStuSubjectSelected);
            this.Controls.Add(this.cbConfirm);
            this.Controls.Add(this.lsStuSubject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbStuLevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btSelectPicture);
            this.Controls.Add(this.pbStu);
            this.Controls.Add(this.rdStuFund);
            this.Controls.Add(this.rdStuNormal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbStuName);
            this.Controls.Add(this.tbStuId);
            this.Controls.Add(this.mcdRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register - DTI Soft V.1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBacktoMainMenu;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btRemoveAll;
        private System.Windows.Forms.Button btRemoveOne;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.Button btSelectOne;
        private System.Windows.Forms.ListBox lsStuSubjectSelected;
        private System.Windows.Forms.CheckBox cbConfirm;
        private System.Windows.Forms.ListBox lsStuSubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbStuLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSelectPicture;
        private System.Windows.Forms.PictureBox pbStu;
        private System.Windows.Forms.RadioButton rdStuFund;
        private System.Windows.Forms.RadioButton rdStuNormal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStuName;
        private System.Windows.Forms.TextBox tbStuId;
        private System.Windows.Forms.MonthCalendar mcdRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}