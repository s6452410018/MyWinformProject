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
    public partial class FrmLotto : Form
    {
        public FrmLotto()
        {
            InitializeComponent();
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();//ปิดหน้าจอตัวเอง
        }

        private void FrmLotto_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer1.Start();

            rdClose.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ.yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void rdClose_Click(object sender, EventArgs e)
        {

        }

        private void rdOpen_Click(object sender, EventArgs e)
        {
            if (rdOpen.Checked == true)
            {
                btLotto1.Enabled = true;
                btLotto3Top.Enabled = true;
                btLotto3Bottom.Enabled = true;
                btLotto2Bottom.Enabled = true;
            }
        }

        private void btLotto1_Click(object sender, EventArgs e)
        {
            //Validate ว่าเป็นวันที่ 1 หรือ 16 หรือไม่
            if (dtpLotto.Value.Date.Day != 1 && dtpLotto.Value.Date.Day != 16)
            {
                ShareData.showWarningMSG("หวยจะออกแค่วันที่ 1 กับ 16 กรุณาตรวจสอบวัน เดือน ปีที่เลือก...");
            }
            else
            {
                //ออกหวยได้ สร้างเลขสุ่ม 6 ตัว
                Random random = new Random();
                //สุ่มเลข 0-999999
                lbLotto1.Text = random.Next(1000000).ToString("000000");
                btLotto1.Enabled = false;
            }
        }

        private void btLotto3Top_Click(object sender, EventArgs e)
        {
            //Validate ว่าเป็นวันที่ 1 หรือ 16 หรือไม่
            if (dtpLotto.Value.Date.Day != 1 && dtpLotto.Value.Date.Day != 16)
            {
                ShareData.showWarningMSG("หวยจะออกแค่วันที่ 1 กับ 16 กรุณาตรวจสอบวัน เดือน ปีที่เลือก...");
            }
            else
            {
                //ออกหวยได้ สร้างเลขสุ่ม 6 ตัว
                Random random = new Random();
                //สุ่มเลข 0-999999
                lbLotto3Top01.Text = random.Next(1000).ToString("000");
                lbLotto3Top02.Text = random.Next(1000).ToString("000");
                btLotto3Top.Enabled = false;
            }
        }

        private void btLotto3Bottom_Click(object sender, EventArgs e)
        {
            //Validate ว่าเป็นวันที่ 1 หรือ 16 หรือไม่
            if (dtpLotto.Value.Date.Day != 1 && dtpLotto.Value.Date.Day != 16)
            {
                ShareData.showWarningMSG("หวยจะออกแค่วันที่ 1 กับ 16 กรุณาตรวจสอบวัน เดือน ปีที่เลือก...");
            }
            else
            {
                //ออกหวยได้ สร้างเลขสุ่ม 6 ตัว
                Random random = new Random();
                //สุ่มเลข 0-999999
                lbLotto3Bottom01.Text = random.Next(1000).ToString("000");
                lbLotto3Bottom02.Text = random.Next(1000).ToString("000");

                btLotto3Bottom.Enabled = false;
            }
        }

        private void btLotto2Bottom_Click(object sender, EventArgs e)
        {
            //Validate ว่าเป็นวันที่ 1 หรือ 16 หรือไม่
            if (dtpLotto.Value.Date.Day != 1 && dtpLotto.Value.Date.Day != 16)
            {
                ShareData.showWarningMSG("หวยจะออกแค่วันที่ 1 กับ 16 กรุณาตรวจสอบวัน เดือน ปีที่เลือก...");
            }
            else
            {
                //ออกหวยได้ สร้างเลขสุ่ม 6 ตัว
                Random random = new Random();
                //สุ่มเลข 0-999999
                lbLotto2Bottom.Text = random.Next(100).ToString("00");
                btLotto2Bottom.Enabled = false;
            }
        }
    }
}
