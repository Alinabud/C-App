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
    public partial class WindowDeleteAndEdit : Form
    {
        public WindowDeleteAndEdit()
        {
            InitializeComponent();
            ToolTip t = new ToolTip();
            t.SetToolTip(button1, "Не забудьте выбрать номер строки, которую хотите редактировать");
            textBoxDelet.Text = "Введите номер строки, которую хотите удалить";
            textBoxDelet.ForeColor = Color.Gray;
            dataGridView1.Columns.Add("id", "Номер");
            dataGridView1.Columns.Add("writer", "Автор");
            dataGridView1.Columns.Add("book", "Название");
            dataGridView1.Columns.Add("ganre", "Жанр");
            dataGridView1.Columns.Add("country", "Страна");
            dataGridView1.Columns.Add("language", "Язык");
            dataGridView1.Columns.Add("edition", "Количество изданий");
            dataGridView1.Columns.Add("publishing", "Книгоиздатель");
        }

        private void btnMenuDelete_Click(object sender, EventArgs e)
        {
            DB db = new DB(); //выделяем память под объект 

            DataTable table = new DataTable(); //табличка, в которой можно работать 

            MySqlDataAdapter adapter = new MySqlDataAdapter(); //adapter позволяет выбрать данные из базы данных

            //задаем команды по нахождению id
            MySqlCommand command = new MySqlCommand("SELECT `id` FROM `writers` WHERE `id` = @cd ", db.getConnection()); //@cd - заглушка 

            command.Parameters.Add("@cd", MySqlDbType.VarChar).Value = textBoxDelet.Text;

            //заполняем table заданной sql командой
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0 && textBoxDelet.Text != "") //если есть такой индекс
            {
                //задаем команды по id
                MySqlCommand command2 = new MySqlCommand("DELETE FROM `writers` WHERE `writers`.`id` = @cd", db.getConnection()); //@cd - заглушка 

                command2.Parameters.Add("@cd", MySqlDbType.VarChar).Value = textBoxDelet.Text;

                db.openConnection();

                if (command2.ExecuteNonQuery() == 1) //проверка на корректность работы
                {
                    MessageBox.Show("Данные были удалены из базы данных"); //проверка на корректность работы
                    textBoxDelet.Clear();
                }
                else
                    MessageBox.Show("Данные не были удалены из базы данных");


                db.CloseConnection(); //если не закрыть, будет большая нагрузка
            }
            else
                MessageBox.Show("Вы ввели неверный номер, либо его не существует.");
        }

        private void showDB_Click(object sender, EventArgs e)
        {
            DB db = new DB(); //выделяем память под объект 

            DataTable table = new DataTable(); //табличка, в которой можно работать 

            MySqlDataAdapter adapter = new MySqlDataAdapter(); //adapter позволяет выбрать данные из базы данных

            //задаем команды по нахождению id
            MySqlCommand command = new MySqlCommand("SELECT `id`,`writer`,`book`,`ganre`,`country`,`language`,`edition`,`publishing` FROM `writers`", db.getConnection());

            //заполняем table заданной sql командой
            adapter.SelectCommand = command;
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
                dataGridView1.Rows.Clear();

            foreach (DataRow row in table.Rows)
                dataGridView1.Rows.Add(row.ItemArray);

        }

        private void btnGoBackToMenu_Click(object sender, EventArgs e)
        {
            WindowSecond window_second = new WindowSecond();
            window_second.Show();
            this.Hide();
        }

        private void textBoxDelet_Enter(object sender, EventArgs e)
        {
            if (textBoxDelet.Text == "Введите номер строки, которую хотите удалить")
            {
                textBoxDelet.Text = "";
                textBoxDelet.ForeColor = Color.FromArgb(64, 0, 64);
            }
        }

        private void textBoxDelet_Leave(object sender, EventArgs e)
        {
            if (textBoxDelet.Text == "")
            {
                textBoxDelet.Text = "Введите номер строки, которую хотите удалить";
                textBoxDelet.ForeColor = Color.Gray;
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Не забудьте, запомнить номер автора, которого хотите отредактировать.");
            WindowAdd window_add = new WindowAdd();
            window_add.Show();
            this.Hide();
        }

        private void textBoxDelet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 || number == 45) //цифры и клавиши BackSpace и минус
            {
                MessageBox.Show("Введен неверный символ");
                e.Handled = true;
            }
        }
    }
}
