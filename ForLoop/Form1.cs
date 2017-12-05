using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult opt = MessageBox.Show("I will miss you", "Are you sure :<", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opt == DialogResult.OK)
                Application.Exit();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtKetQua.Clear();
            if (!Int32.TryParse(txtNhap.Text, out int a) || string.IsNullOrEmpty(txtNhap.Text))
            {
                errorProvider1.SetError(txtNhap, "Vui lòng nhập đúng");
            }
            else if (string.IsNullOrEmpty(cbKieu.Text))
            {
                errorProvider1.SetError(cbKieu, "Vui lòng chọn kiểu");
            }
            else if (cbKieu.Text.Equals("Chẵn"))
            {
                for (int i = 0; i <= a; i+=2)
                {
                    txtKetQua.Text += i + "  ";
                }
            }
            else if (cbKieu.Text.Equals("Lẻ"))
            {
                for (int i = 1; i <= a; i += 2)
                {
                    txtKetQua.Text += i + "  ";
                }
            }
        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            //e.KeyChar != (Char)8 : khác backspace
            //if (!Char.IsNumber(e.KeyChar) && !e.KeyChar.Equals((Char)8))
            //Nhập nhanh giữa số và chữ sẽ xóa số??????????????????????????
            if (!Char.IsNumber(e.KeyChar) && !e.KeyChar.Equals((Char)Keys.Back))
            {
                errorProvider1.SetError(txtNhap, "Vui lòng nhập đúng số");
                e.Handled = true;
            }
        }
    }
}
