using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidateInput(string hoten, DateTimePickerK birthdayPicker, string classname, string gender)
        {
            if (string.IsNullOrEmpty(hoten))
            {
                MessageBox.Show(
                "Vui lòng nhập họ và tên",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;

            }
            else if (int.Parse(DateTime.UtcNow.ToString("yyyy")) - birthdayPicker.Value.Year < 18)
            {
                MessageBox.Show(
                "Vui lòng chọn ngày sinh chính xác",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;

            }
            else if (string.IsNullOrEmpty(classname))
            {
                MessageBox.Show(
                "Vui lòng chọn tên lớp",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;

            }
            else if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show(
                "Vui lòng chọn giới tính ?",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return false;

            }
            else
            {
                return true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string hoten = txtboxName.Text;
            string birthday = birthdayPicker.Text;
            string gender = radioGender.Text;
            string classname = ComboboxLop.Text; 
            string a2check = checkboxA2.Checked ? "Có" : "Không";
            //MessageBox.Show(a2check);
            if(ValidateInput(hoten,birthdayPicker,classname,gender))
            {
                ListViewItem lvi = new ListViewItem(hoten);
                lvi.SubItems.Add(birthday);
                lvi.SubItems.Add(gender);
                lvi.SubItems.Add(classname);
                lvi.SubItems.Add(a2check);
                listViewInfo.Items.Add(lvi);


                txtboxName.Text = "";
                txtboxName.Text = "";
                birthdayPicker.Text = "";
                radioGender.Text = "";
                ComboboxLop.SelectedIndex = -1;
                checkboxA2.Checked = false;

                MessageBox.Show(
                "Nhập thông tin thành công !!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            btnDeleteInfo.Visible = false;
            btnEditInfo.Visible = false;
        }
        private ListViewItem item;
        private void listViewInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewInfo.SelectedItems.Count > 0)
            {
                item = listViewInfo.SelectedItems[0];
                txtboxName.Text = item.SubItems[0].Text;
                birthdayPicker.Text = item.SubItems[1].Text;
                radioGender.Text = item.SubItems[2].Text;
                ComboboxLop.Text = item.SubItems[3].Text;
                checkboxA2.Checked = true ? item.SubItems[4].Text == "Có" :false;
            }
            btnEditInfo.Visible = true;
            btnDeleteInfo.Visible = true;
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            string hoten = txtboxName.Text;
            string birthday = birthdayPicker.Text;
            string gender = radioGender.Text;
            string classname = ComboboxLop.Text;
            string a2check = checkboxA2.Checked ? "Có" : "Không";
            if (ValidateInput(hoten, birthdayPicker, classname, gender))
            {
                item.SubItems[0].Text = hoten;
                item.SubItems[1].Text = birthday;
                item.SubItems[2].Text = gender;
                item.SubItems[3].Text = classname;
                item.SubItems[4].Text = a2check;

                txtboxName.Text = "";
                txtboxName.Text = "";
                birthdayPicker.Text = "";
                radioGender.Text = "";
                ComboboxLop.SelectedIndex = -1;
                checkboxA2.Checked = false;

                MessageBox.Show(
                "Sửa thông tin thành công !!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void btnDeleteInfo_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Có chắc chăn xóa ","Thông báo", MessageBoxButtons.OKCancel);
            if(res == DialogResult.OK)
            {
                item.Remove();
            }
        }
        private void btnAddClassName_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox.Image = new Bitmap(open.FileName);
                // image file path  

            }
           
        }
    }
}
