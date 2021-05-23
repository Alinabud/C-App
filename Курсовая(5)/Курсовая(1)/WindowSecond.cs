using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Курсовая_1_
{
    public partial class WindowSecond : Form
    {
        public WindowSecond()
        {
            InitializeComponent();
        }

        private void btnGoBackToEntrance_Click_1(object sender, EventArgs e)//кнопка возвращает ко входу(к WindowFirst)
        {
            WindowFirst window_first = new WindowFirst();
            window_first.Show();
            this.Hide();
        }
        //кнопка перенаправляет в новое окно(WindowAdd), которое добавляет новые данные в бд
        private void btnMenuAdd_Click(object sender, EventArgs e)
        {
            WindowAdd window_add = new WindowAdd();
            window_add.Show();
            this.Hide();
        }

        private void btnShowDB_Click(object sender, EventArgs e)
        {
            WindowDeleteAndEdit window_delete_and_edit = new WindowDeleteAndEdit();
            window_delete_and_edit.Show();
            this.Hide();
        }
    }
}
