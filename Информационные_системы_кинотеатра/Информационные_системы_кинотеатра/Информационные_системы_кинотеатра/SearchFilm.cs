using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Информационные_системы_кинотеатра
{
    public partial class SearchFilm : Form
    {
        public SearchFilm()
        {
            InitializeComponent();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void SearchFilm_Load(object sender, EventArgs e)
        {

        }
    }
}
