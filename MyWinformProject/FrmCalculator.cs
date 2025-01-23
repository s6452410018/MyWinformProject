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
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();//ปิดหน้าจอตัวเอง
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer1.Start();

            //ให้รายการแรกของ ComboBox ถูกเลือก
            cbbDecimal.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ.yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void cbbDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;  // หากไม่ใช่ตัวเลขหรือลูกศรควบคุม (backspace) หรือจุด (.) จะไม่ให้พิมพ์
            }

            // ตรวจสอบว่าใน TextBox มีจุดอยู่แล้วหรือไม่
            if (e.KeyChar == '.' && tbNum1.Text.Contains("."))
            {
                e.Handled = true;  // ถ้ามีจุดแล้ว ไม่ให้พิมพ์จุดซ้ำ
            }
        }

        private void tbNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;  // หากไม่ใช่ตัวเลขหรือลูกศรควบคุม (backspace) หรือจุด (.) จะไม่ให้พิมพ์
            }

            // ตรวจสอบว่าใน TextBox มีจุดอยู่แล้วหรือไม่
            if (e.KeyChar == '.' && tbNum1.Text.Contains("."))
            {
                e.Handled = true;  // ถ้ามีจุดแล้ว ไม่ให้พิมพ์จุดซ้ำ
            }
        }

        private void calNumber(string opt)
        {
            //Validate
            if (tbNum1.Text.Length == 0 || tbNum2.Text.Length == 0)
            {
                ShareData.showWarningMSG("ป้อนช้อมูลให้ครบก่อนคำนวณ");
            }
            else
            {
                double num1 = double.Parse(tbNum1.Text);
                double num2 = double.Parse(tbNum2.Text);
                double result;
                if (opt == "+")
                {
                    result = num1 + num2;
                }
                else if (opt == "-")
                {
                    result = num1 - num2;
                }
                else if (opt == "*")
                {
                    result = num1 * num2;
                }
                else if (opt == "/")
                {
                    if(num2 == 0)
                    {
                        ShareData.showWarningMSG("ไม่สามารถหารด้วย 0 ได้");
                        return;
                    }
                    result = num1 / num2;
                }
                else
                {
                    result = Math.Pow(num1, num2);
                }
                //---------------------------------------
                if (cbbDecimal.SelectedIndex == 0)
                {
                    lbShowResult.Text = result.ToString("0.00");
                }
                else if (cbbDecimal.SelectedIndex == 1)
                {
                    lbShowResult.Text = result.ToString("0.00000");
                }
                else
                {
                    lbShowResult.Text = result.ToString("0.000000000");
                }
            }
        }
        private void btPlus_Click(object sender, EventArgs e)
        {
            calNumber("+");
        }
        private void btMinus_Click(object sender, EventArgs e)
        {
            calNumber("-");
        }

        private void btMultiply_Click(object sender, EventArgs e)
        {
            calNumber("*");
        }

        private void btDevide_Click(object sender, EventArgs e)
        {
            calNumber("/");
        }

        private void btPow_Click(object sender, EventArgs e)
        {
            //Validate
            if (tbNum1.Text.Length == 0 || tbNum2.Text.Length == 0)
            {
                ShareData.showWarningMSG("ป้อนช้อมูลให้ครบก่อนคำนวณ");
            }
            else
            {
                double num1 = double.Parse(tbNum1.Text);
                double num2 = double.Parse(tbNum2.Text);
                double result = Math.Pow(num1, num2);
                if (cbbDecimal.SelectedIndex == 0)
                {
                    lbShowResult.Text = result.ToString("0.00");
                }
                else if (cbbDecimal.SelectedIndex == 1)
                {
                    lbShowResult.Text = result.ToString("0.00000");
                }
                else
                {
                    lbShowResult.Text = result.ToString("0.000000000");
                }
            }
        }
    }
}
