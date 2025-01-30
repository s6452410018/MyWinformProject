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
    public partial class FrmShapeArea : Form
    {
        public FrmShapeArea()
        {
            InitializeComponent();
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();//ปิดหน้าจอตัวเอง
        }

        private void FrmShapeArea_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ.yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void keyNumberAndDotOnly(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;  // หากไม่ใช่ตัวเลขหรือลูกศรควบคุม (backspace) หรือจุด (.) จะไม่ให้พิมพ์
            }

            // ตรวจสอบว่าใน TextBox มีจุดอยู่แล้วหรือไม่
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;  // ถ้ามีจุดแล้ว ไม่ให้พิมพ์จุดซ้ำ
            }
        }

        private void tbRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void tbWidthSquare_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void tbLengthSquare_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void btCalCircle_Click(object sender, EventArgs e)
        {
            if (tbRadius.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนรัศมีด้วย...");
            }
            else
            {
                double r = double.Parse(tbRadius.Text);
                double result;
                //พร้อมคำนวณ Math.PI คือค่า π
                if (rdAreaCircle.Checked == true)
                {
                    result = Math.PI * Math.Pow(r, 2);
                }
                else
                {
                    result = 2 * Math.PI * r;
                }
                lbShowCircle.Text = result.ToString("0.00");
            }
        }

        private void btCancelCircle_Click(object sender, EventArgs e)
        {
            tbRadius.Clear();
            rdAreaCircle.Checked = true;
            lbShowCircle.Text = "0.00";
        }

        private void btCalSquare_Click(object sender, EventArgs e)
        {
            //Validate 
            if (tbWidthSquare.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนความกว้างด้วย...");
            }
            else if (tbLengthSquare.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนความยาวด้วย...");
            }
            else
            {
                double width = double.Parse(tbWidthSquare.Text);
                double length = double.Parse(tbLengthSquare.Text);
                double result;
                //พร้อมคำนวณ
                if (rdAreaSquare.Checked == true)
                {
                    result = width * length;

                }
                else
                {
                    result = 2 * (width + length);
                }
                lbShowSquare.Text = result.ToString("0.00");
            }
        }

        private void btCancelSquare_Click(object sender, EventArgs e)
        {
            tbWidthSquare.Clear();
            tbLengthSquare.Clear();
            rdAreaSquare.Checked = true;
            lbShowSquare.Text = "0.00";
        }

        private void btCalTriangle_Click(object sender, EventArgs e)
        {
            //Validate 
            if (tbBaseTriangle.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนฐานด้วย...");
            }
            else if (tbHeightTriangle.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนความสูงด้วย...");
            }
            else if (tbSideTriangle.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนด้านตรงข้ามมุมฉากด้วย...");
            }
            else
            {
                double basetriangle = double.Parse(tbBaseTriangle.Text);
                double heighttriangle = double.Parse(tbHeightTriangle.Text);
                double sidetriangle = double.Parse(tbSideTriangle.Text);
                double result;
                //พร้อมคำนวณ
                if (rdAreaSquare.Checked == true)
                {
                    result = 0.5 * (basetriangle * heighttriangle);
                }
                else
                {
                    result = basetriangle + heighttriangle + sidetriangle;
                }
                lbShowTriangle.Text = result.ToString("0.00");
            }
        }

        private void btCancelTriangle_Click(object sender, EventArgs e)
        {
            tbBaseTriangle.Clear();
            tbHeightTriangle.Clear();
            tbSideTriangle.Clear();
            rdAreaTriangle.Checked = true;
            lbShowTriangle.Text = "0.00";
        }
        private void tbBaseTriangle_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void tbHeightTriangle_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void tbSideTriangle_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }
    }
}
}
