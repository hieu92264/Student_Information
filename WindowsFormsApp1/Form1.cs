using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class information_student : Form
    {
        public information_student()
        {
            InitializeComponent();
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập chữ số!");
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập chữ cái!");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_search.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập dữ liệu tìm kiếm!");
                } else
                {

                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void information_student_Load(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text != null) btn_insert.Enabled = true;
                if (dgv_information_source.DataSource != null)
                {
                    txt_id.DataBindings.Add(new Binding("Text", dgv_information_source.DataSource, "Id"));
                    txt_name.DataBindings.Add(new Binding("Text", dgv_information_source.DataSource, "Name"));
                    txt_class.DataBindings.Add(new Binding("Text", dgv_information_source.DataSource, "Class"));
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
        }
    }
}
