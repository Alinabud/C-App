using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_1_
{
    public partial class WindowFirst : Form
    {
        public WindowFirst()
        {
            InitializeComponent();
        }

        private void btnEnterToSystem_Click(object sender, EventArgs e)//переход с первого окна на второе
        {
            WindowSecond window_second = new WindowSecond();
            window_second.Show();
            this.Hide();
        }

        private void infoProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа разбработана для сбора произведений о разных писателях.\nСоздатели: Казаков Р.А, Будиловская А.В");
        }
    }
}
