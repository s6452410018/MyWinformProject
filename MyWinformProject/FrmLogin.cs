using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinformProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void showWarningMSG(string msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("ต้องการออกจากโปรแกรมหรือไม่","ยืนยัน",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
            rdStudent.Checked = true;

            tbUsername.Focus();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //Validate
            if(tbUsername.Text.Trim().Length == 0)
            {
                //MessageBox.Show("ป้อนชื่อผู้ใช้ด้วย","คำเตือน",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                showWarningMSG("ป้อนชื่อผู้ใช้ด้วย");
            }
            else if(tbPassword.Text.Trim().Length == 0 )
            {
                //MessageBox.Show("ป้อนรหัสผ่านด้วย", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showWarningMSG("ป้อนรหัสผ่านด้วย");

            }
            else if (tbPassword.Text.Trim().Length < 6)
            {
                //MessageBox.Show("ป้อนรหัสผ่านต้อง 6 ตัวขึ้นไป", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showWarningMSG("ป้อนรหัสผ่านต้อง 6 ตัวขึ้นไป");
            }
            else
            {
                //ตรวจสอบฃื่อผู็ใช้/รหัสผ่าน (sau/123456789, dti/987654321) เพิ่อเข้า FrmMainMenu
                if((tbUsername.Text.Trim().ToLower() != "sau" || tbPassword.Text.Trim().ToLower() != "123456789") &&
                   (tbUsername.Text.Trim().ToLower() != "dti" || tbPassword.Text.Trim().ToLower() != "987654321"))
                {
                    showWarningMSG("ชื่อผู้ใช้ รหัสผ่านไม่ถูกต้อง");
                }
                else
                {
                    //ชื้อผู้ใช้รหัสถูกต้อง เปิด FrmMainMenu พร้อมส่งชื่อผู้ใช้ไปแสดงด้วย
                    ShareData.loginName = tbUsername.Text.Trim();

                    if (rdStudent.Checked == true)
                    {
                        ShareData.loginType = "student";
                    }
                    else 
                    {
                        ShareData.loginType = "teacher";
                    }

                    FrmMainMenu frmMainMenu = new FrmMainMenu();
                    frmMainMenu.Show();
                    Hide();//ปิดหน้าจอตัวเอง
                }
            }
        }
    }
}
