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
    public partial class FrmSAUShop : Form
    {
        public FrmSAUShop()
        {
            InitializeComponent();
        }

        private void FrmSAUShop_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer1.Start();

            btCancel.PerformClick();
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

        private void btCancel_Click(object sender, EventArgs e)
        {
            cbPen.Checked = false;
            cbPencil.Checked = false;
            cbRubber.Checked = false;
            cbRuler.Checked = false;
            cbBook.Checked = false;

            tbPen.Clear();
            tbPencil.Clear();
            tbRubber.Clear();
            tbRuler.Clear();
            tbBook.Clear();

            lbPen.Text = "0.00";
            lbPencil.Text = "0.00";
            lbRubber.Text = "0.00";
            lbRuler.Text = "0.00";
            lbBook.Text = "0.00";

            lbShowResult.Text = "0.00";
        }

        private void cbPen_Click(object sender, EventArgs e)
        {
            if (cbPen.Checked == true)
            {
                tbPen.Enabled = true;
            }
            else
            {
                tbPen.Clear();
                tbPen.Enabled = false;
                lbPen.Text = "0.00";
            }
        }

        private void cbPencil_Click(object sender, EventArgs e)
        {
            if (cbPencil.Checked == true)
            {
                tbPencil.Enabled = true;
            }
            else
            {
                tbPencil.Clear();
                tbPencil.Enabled = false;
                lbPencil.Text = "0.00";
            }
        }

        private void cbRubber_Click(object sender, EventArgs e)
        {
            if (cbRubber.Checked == true)
            {
                tbRubber.Enabled = true;
            }
            else
            {
                tbRubber.Clear();
                tbRubber.Enabled = false;
                lbRubber.Text = "0.00";
            }
        }
        private void cbRuler_Click(object sender, EventArgs e)
        {
            if (cbRuler.Checked == true)
            {
                tbRuler.Enabled = true;
            }
            else
            {
                tbRuler.Clear();
                tbRuler.Enabled = false;
                lbRuler.Text = "0.00";
            }
        }
        private void cbBook_Click(object sender, EventArgs e)
        {
            if (cbBook.Checked == true)
            {
                tbBook.Enabled = true;
            }
            else
            {
                tbBook.Clear();
                tbBook.Enabled = false;
                lbBook.Text = "0.00";
            }
        }

        private void tbPen_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // หากไม่ใช่ตัวเลขหรือลูกศรควบคุม (backspace) หรือจุด (.) จะไม่ให้พิมพ์
                e.Handled = true;
            }
        }

        private void tbPencil_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // หากไม่ใช่ตัวเลขหรือลูกศรควบคุม (backspace) หรือจุด (.) จะไม่ให้พิมพ์
                e.Handled = true;
            }
        }
        private void tbRubber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // หากไม่ใช่ตัวเลขหรือลูกศรควบคุม (backspace) หรือจุด (.) จะไม่ให้พิมพ์
                e.Handled = true;
            }
        }
        private void tbRuler_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // หากไม่ใช่ตัวเลขหรือลูกศรควบคุม (backspace) หรือจุด (.) จะไม่ให้พิมพ์
                e.Handled = true;
            }
        }
        private void tbBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // หากไม่ใช่ตัวเลขหรือลูกศรควบคุม (backspace) หรือจุด (.) จะไม่ให้พิมพ์
                e.Handled = true;
            }
        }
        private void tbPen_KeyUp(object sender, KeyEventArgs e)
        {
            //if (tbPen.Text.Trim().Length > 0)
            //{
            //    int quanlity = int.Parse(tbPen.Text);
            //    double price = 5 * quanlity;
            //    lbPen.Text = price.ToString("0.00");
            //}
            //else
            //{
            //    tbPen.Text = "0.00";
            //}
            if (tbPen.Text.Trim().Length > 0)
            {
                lbPen.Text = (int.Parse(tbPen.Text) * 5).ToString("0.00");
            }
            else
            {
                lbPen.Text = "0";
            }
        }

        private void tbPencil_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbPencil.Text.Length > 0)
            {
                int quanlity = int.Parse(tbPencil.Text);
                double price = 1.50 * quanlity;
                lbPencil.Text = price.ToString("0.00");
            }
            else
            {
                tbPencil.Text = "";
            }
        }

        private void tbRubber_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbRubber.Text.Length > 0)
            {
                int quanlity = int.Parse(tbRubber.Text);
                double price = 2.50 * quanlity;
                lbRubber.Text = price.ToString("0.00");
            }
            else
            {
                tbRubber.Text = "0.00";
            }
        }

        private void tbRuler_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbRuler.Text.Length > 0)
            {
                int quanlity = int.Parse(tbRuler.Text);
                double price = 2 * quanlity;
                lbRuler.Text = price.ToString("0.00");
            }
            else
            {
                tbRuler.Text = "0.00";
            }
        }

        private void tbBook_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbBook.Text.Length > 0)
            {
                int quanlity = int.Parse(tbBook.Text);
                double price = 10.25 * quanlity;
                lbBook.Text = price.ToString("0.00");
            }
            else
            {
                tbBook.Text = "0.00";
            }
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            double totalpay = Double.Parse(lbPen.Text) +
                Double.Parse(lbPencil.Text) +
                Double.Parse(lbRubber.Text) +
                Double.Parse(lbRuler.Text) +
                Double.Parse(lbBook.Text);
            //ตรวจสอบส่วนลด
            if (cbbDiscount.SelectedIndex == 0)
            {
                totalpay = totalpay - (totalpay * 5 / 100);
            }
            else if (cbbDiscount.SelectedIndex == 1)
            {
                totalpay = totalpay - (totalpay * 10 / 100);
            }
            else if (cbbDiscount.SelectedIndex == 2)
            {
                totalpay = totalpay - (totalpay * 15 / 100);
            }
            lbShowResult.Text = totalpay.ToString("#,###,##0.00 ");
        }
    }
}
