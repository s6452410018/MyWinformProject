using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinformProject
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();//ปิดหน้าจอตัวเอง
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ.yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer1.Start();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            //Validate
            if (tbName.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนชื่อด้วย...");
            }
            else if (dtpBirthDate.Value.Year >= DateTime.Now.Year)
            {
                ShareData.showWarningMSG("ปีเกิดต้องน้อยกว่าวันปัจจุบัน...");
            }
            else
            {
                //นำข้อมูลไปแสดงผล โดนคำนวณอายุด้วย แล้ววันเดือนปีเกิดต้องแสดงเป็นวันที่ไทย
                int age = DateTime.Now.Year -dtpBirthDate.Value.Year;

                string birthDate = dtpBirthDate.Value.ToString("วันที่ d เดือน MMMM พ.ศ.yyyy", new CultureInfo("th-TH"));

                string gender = rdMale.Checked == true ? "ชาย" : "หญืง";

                string datashow = "ชื่อ : " + tbName.Text + "\n" +
                                  "วันเกิด : " + birthDate + "\n" +
                                  "อายุ : " + age + " ปี\n" +
                                  "เพศ : " + gender;

                lbShowResult.Text = datashow;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            // Clear UI
            tbName.Clear();
            dtpBirthDate.Value = DateTime.Now;
            rdFemale.Checked = true;

            lbShowResult.Text = "Welcome";
            tbName.Focus();
        }
    }
}
