using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР_19
{
    public partial class General_Form : Form
    {
        public General_Form()
        {
            InitializeComponent();
        }

        // Кнопка "Справка"

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        // Кнопка "Выход"

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Кнопка "Отзыв"

        private void отзывToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("С отзывами и предложениями сюда: \n https://github.com/eeeevans", "Отзыв о программе");
        }
    }
}
