namespace MyWinformProject
{
    partial class FrmCalculator
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
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btDevide = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btMultiply = new System.Windows.Forms.Button();
            this.btPow = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbShowResult = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslbDateTime = new System.Windows.Forms.ToolStripLabel();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.cbbDecimal = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(272, 129);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(296, 20);
            this.tbNum2.TabIndex = 8;
            this.tbNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNum2_KeyPress);
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(272, 93);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(296, 20);
            this.tbNum1.TabIndex = 7;
            this.tbNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNum1_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(176, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "ป้อนตัวเลข";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(173, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "ป้อนตัวเลข";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 63);
            this.label1.TabIndex = 9;
            this.label1.Text = "Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btDevide
            // 
            this.btDevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDevide.ForeColor = System.Drawing.Color.Blue;
            this.btDevide.Location = new System.Drawing.Point(473, 168);
            this.btDevide.Name = "btDevide";
            this.btDevide.Size = new System.Drawing.Size(89, 72);
            this.btDevide.TabIndex = 10;
            this.btDevide.Text = "÷";
            this.btDevide.UseVisualStyleBackColor = true;
            this.btDevide.Click += new System.EventHandler(this.btDevide_Click);
            // 
            // btPlus
            // 
            this.btPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlus.ForeColor = System.Drawing.Color.Blue;
            this.btPlus.Location = new System.Drawing.Point(128, 168);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(89, 72);
            this.btPlus.TabIndex = 11;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btMinus
            // 
            this.btMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinus.ForeColor = System.Drawing.Color.Blue;
            this.btMinus.Location = new System.Drawing.Point(239, 168);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(89, 72);
            this.btMinus.TabIndex = 12;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btMultiply
            // 
            this.btMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiply.ForeColor = System.Drawing.Color.Blue;
            this.btMultiply.Location = new System.Drawing.Point(357, 168);
            this.btMultiply.Name = "btMultiply";
            this.btMultiply.Size = new System.Drawing.Size(89, 72);
            this.btMultiply.TabIndex = 13;
            this.btMultiply.Text = "x";
            this.btMultiply.UseVisualStyleBackColor = true;
            this.btMultiply.Click += new System.EventHandler(this.btMultiply_Click);
            // 
            // btPow
            // 
            this.btPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPow.ForeColor = System.Drawing.Color.Blue;
            this.btPow.Location = new System.Drawing.Point(585, 168);
            this.btPow.Name = "btPow";
            this.btPow.Size = new System.Drawing.Size(89, 72);
            this.btPow.TabIndex = 14;
            this.btPow.Text = "^";
            this.btPow.UseVisualStyleBackColor = true;
            this.btPow.Click += new System.EventHandler(this.btPow_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 62);
            this.label4.TabIndex = 15;
            this.label4.Text = "ผลลัพธ์";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbShowResult
            // 
            this.lbShowResult.BackColor = System.Drawing.Color.Yellow;
            this.lbShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowResult.ForeColor = System.Drawing.Color.Red;
            this.lbShowResult.Location = new System.Drawing.Point(182, 315);
            this.lbShowResult.Name = "lbShowResult";
            this.lbShowResult.Size = new System.Drawing.Size(429, 63);
            this.lbShowResult.TabIndex = 16;
            this.lbShowResult.Text = "?????";
            this.lbShowResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbUsername,
            this.tslbDateTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 425);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 17;
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
            // btMainMenu
            // 
            this.btMainMenu.Image = global::MyWinformProject.Properties.Resources.pevious1;
            this.btMainMenu.Location = new System.Drawing.Point(630, 9);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(148, 63);
            this.btMainMenu.TabIndex = 18;
            this.btMainMenu.Text = "หน้าจอหลัก";
            this.btMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainMenu.UseVisualStyleBackColor = true;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // cbbDecimal
            // 
            this.cbbDecimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDecimal.FormattingEnabled = true;
            this.cbbDecimal.Items.AddRange(new object[] {
            "ทศนิยม 2 ตำแหน่ง",
            "ทศนิยม 4 ตำแหน่ง",
            "ทศนิยม 6 ตำแหน่ง"});
            this.cbbDecimal.Location = new System.Drawing.Point(272, 269);
            this.cbbDecimal.Name = "cbbDecimal";
            this.cbbDecimal.Size = new System.Drawing.Size(296, 21);
            this.cbbDecimal.TabIndex = 19;
            this.cbbDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbDecimal_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbDecimal);
            this.Controls.Add(this.btMainMenu);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbShowResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btPow);
            this.Controls.Add(this.btMultiply);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.btDevide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator - DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmCalculator_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDevide;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btMultiply;
        private System.Windows.Forms.Button btPow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbShowResult;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbUsername;
        private System.Windows.Forms.ToolStripLabel tslbDateTime;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.ComboBox cbbDecimal;
        private System.Windows.Forms.Timer timer1;
    }
}