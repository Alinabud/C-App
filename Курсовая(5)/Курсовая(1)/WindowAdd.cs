using MySql.Data.MySqlClient;
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
    public partial class WindowAdd : Form
    {
        public WindowAdd()
        {
            InitializeComponent();
            txtAddWriter.Text = "Введите писателя";
            txtAddWriter.ForeColor = Color.Gray;
            txtAddBook.Text = "Введите произведение";
            txtAddBook.ForeColor = Color.Gray;
            txtAddGanre.Text = "Введите жанр произведения";
            txtAddGanre.ForeColor = Color.Gray;
            txtAddCountry.Text = "Введите страну проживания писателя";
            txtAddCountry.ForeColor = Color.Gray;
            txtAddLanguage.Text = "Введите язык произведения";
            txtAddLanguage.ForeColor = Color.Gray;
            txtAddEdition.Text = "Введите тираж";
            txtAddEdition.ForeColor = Color.Gray;
            txtAddPublishing.Text = "Введите название издательства";
            txtAddPublishing.ForeColor = Color.Gray;
            textBoxEditing.Text = "Введите номер, который хотите изменить";
            textBoxEditing.ForeColor = Color.Gray;

        }


        private void btnGoBackToMenu_Click_1(object sender, EventArgs e)
        {
            WindowSecond window_second = new WindowSecond();
            window_second.Show();
            this.Hide();
        }

        private void txtAddWriter_Enter(object sender, EventArgs e)
        {
            if (txtAddWriter.Text == "Введите писателя")
            {
                txtAddWriter.Text = "";
                txtAddWriter.ForeColor = Color.FromArgb (64, 0, 64);
            }
        }

        private void txtAddWriter_Leave(object sender, EventArgs e)
        {
            if (txtAddWriter.Text == "")
            {
                txtAddWriter.Text = "Введите писателя";
                txtAddWriter.ForeColor = Color.Gray;
            }
        }

        private void txtAddBook_Enter(object sender, EventArgs e)
        {
            if (txtAddBook.Text == "Введите произведение")
            {
                txtAddBook.Text = "";
                txtAddBook.ForeColor = Color.FromArgb(64, 0, 64);
            }
        }

        private void txtAddBook_Leave(object sender, EventArgs e)
        {
            if (txtAddBook.Text == "")
            {
                txtAddBook.Text = "Введите произведение";
                txtAddBook.ForeColor = Color.Gray;
            }
        }

        private void txtAddGanre_Enter(object sender, EventArgs e)
        {
            if (txtAddGanre.Text == "Введите жанр произведения")
            {
                txtAddGanre.Text = "";
                txtAddGanre.ForeColor = Color.FromArgb(64, 0, 64);
            }
        }

        private void txtAddGanre_Leave(object sender, EventArgs e)
        {
            if (txtAddGanre.Text == "")
            {
                txtAddGanre.Text = "Введите жанр произведения";
                txtAddGanre.ForeColor = Color.Gray;
            }
        }

        private void txtAddCountry_Enter(object sender, EventArgs e)
        {
            if (txtAddCountry.Text == "Введите страну проживания писателя")
            {
                txtAddCountry.Text = "";
                txtAddCountry.ForeColor = Color.FromArgb(64, 0, 64);
            }
        }

        private void txtAddCountry_Leave(object sender, EventArgs e)
        {
            if (txtAddCountry.Text == "")
            {
                txtAddCountry.Text = "Введите страну проживания писателя";
                txtAddCountry.ForeColor = Color.Gray;
            }
        }

        private void txtAddLanguage_Enter(object sender, EventArgs e)
        {
            if (txtAddLanguage.Text == "Введите язык произведения")
            {
                txtAddLanguage.Text = "";
                txtAddLanguage.ForeColor = Color.FromArgb(64, 0, 64);
            }
        }

        private void txtAddLanguage_Leave(object sender, EventArgs e)
        {
            if (txtAddLanguage.Text == "")
            {
                txtAddLanguage.Text = "Введите язык произведения";
                txtAddLanguage.ForeColor = Color.Gray;
            }
        }

        private void txtAddEdition_Enter(object sender, EventArgs e)
        {
            if (txtAddEdition.Text == "Введите тираж")
            {
                txtAddEdition.Text = "";
                txtAddEdition.ForeColor = Color.FromArgb(64, 0, 64);
            }
        }

        private void txtAddEdition_Leave(object sender, EventArgs e)
        {
            if (txtAddEdition.Text == "")
            {
                txtAddEdition.Text = "Введите тираж";
                txtAddEdition.ForeColor = Color.Gray;
            }
        }

        private void txtAddPublishing_Enter(object sender, EventArgs e)
        {
            if (txtAddPublishing.Text == "Введите название издательства")
            {
                txtAddPublishing.Text = "";
                txtAddPublishing.ForeColor = Color.FromArgb(64, 0, 64);
            }
        }

        private void txtAddPublishing_Leave(object sender, EventArgs e)
        {
            if (txtAddPublishing.Text == "")
            {
                txtAddPublishing.Text = "Введите название издательства";
                txtAddPublishing.ForeColor = Color.Gray;
            }
        }
        private void textBoxEditing_Enter(object sender, EventArgs e)
        {
            if (textBoxEditing.Text == "Введите номер, который хотите изменить")
            {
                textBoxEditing.Text = "";
                textBoxEditing.ForeColor = Color.FromArgb(64, 0, 64);
            }
        }

        private void textBoxEditing_Leave(object sender, EventArgs e)
        {
            if (textBoxEditing.Text == "")
            {
                textBoxEditing.Text = "Введите номер, который хотите изменить";
                textBoxEditing.ForeColor = Color.Gray;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)//Кнопка добавляет новую запись в Базу данных 
        {
            if(txtAddWriter.Text== "Введите писателя"|| txtAddBook.Text == "Введите произведение" || txtAddGanre.Text == "Введите жанр произведения"
                || txtAddCountry.Text == "Введите страну проживания писателя"|| txtAddLanguage.Text == "Введите язык произведения"||txtAddEdition.Text
                == "Введите тираж"|| txtAddPublishing.Text == "Введите название издательства")
            {
                MessageBox.Show("Введены не все данные");
                return;
            }
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `writers`(`writer`,`book`,`ganre`,`country`,`language`,`edition`,`publishing`)" +
                "VALUES(@writer, @book, @ganre, @country, @language, @edition, @publishing)",db.getConnection());
            //устанавливаем параметры
            command.Parameters.Add("@writer", MySqlDbType.VarChar).Value = txtAddWriter.Text;
            command.Parameters.Add("@book", MySqlDbType.VarChar).Value = txtAddBook.Text;
            command.Parameters.Add("@ganre", MySqlDbType.VarChar).Value = txtAddGanre.Text;
            command.Parameters.Add("@country", MySqlDbType.VarChar).Value = txtAddCountry.Text;
            command.Parameters.Add("@language", MySqlDbType.VarChar).Value = txtAddLanguage.Text;
            command.Parameters.Add("@edition", MySqlDbType.Int32).Value = txtAddEdition.Text;
            command.Parameters.Add("@publishing", MySqlDbType.VarChar).Value = txtAddPublishing.Text;
            //подключаемся к базе данных
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Новая запись была добавлена");
            else
                MessageBox.Show("Новая запись не была добавлена");
            db.CloseConnection();
            WindowSecond window_second = new WindowSecond();
            window_second.Show();
            this.Hide();
        }

        private void editing_Click(object sender, EventArgs e)
        {
            if (txtAddWriter.Text == "Введите писателя" || txtAddBook.Text == "Введите произведение" || txtAddGanre.Text == "Введите жанр произведения"
                || txtAddCountry.Text == "Введите страну проживания писателя" || txtAddLanguage.Text == "Введите язык произведения" || txtAddEdition.Text
                == "Введите тираж" || txtAddPublishing.Text == "Введите название издательства")
            {
                MessageBox.Show("Введены не все данные");
                return;
            }
            DB db = new DB(); //выделяем память под объект 

            DataTable table = new DataTable(); //табличка, в которой можно работать 

            MySqlDataAdapter adapter = new MySqlDataAdapter(); //adapter позволяет выбрать данные из базы данных

            //задаем команды по нахождению id
            MySqlCommand command = new MySqlCommand("SELECT `id` FROM `writers` WHERE `id` = @cd", db.getConnection()); //@cd - заглушка 

            command.Parameters.Add("@cd", MySqlDbType.VarChar).Value = textBoxEditing.Text;


            //заполняем table заданной sql командой
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0 && (textBoxEditing.Text != ""))  //если такой есть
            {
                MySqlCommand command2 = new MySqlCommand("UPDATE `writers` SET `book`=@Book, `ganre`=@Ganre, `country`=@Country, `language`=@Language, " +
                    "`edition`=@Edition, `publishing`=@Publishing,`writer` =@Write WHERE `id`=@ID  ", db.getConnection());
                //автор
                command2.Parameters.Add("@Write", MySqlDbType.VarChar).Value = txtAddWriter.Text;
                //произведения
                command2.Parameters.Add("@Book", MySqlDbType.VarChar).Value = txtAddBook.Text;
                command2.Parameters.Add("@Ganre", MySqlDbType.VarChar).Value = txtAddGanre.Text;
                //страна
                command2.Parameters.Add("@Country", MySqlDbType.VarChar).Value = txtAddCountry.Text;
                //язык
                command2.Parameters.Add("@Language", MySqlDbType.VarChar).Value = txtAddLanguage.Text;
                command2.Parameters.Add("@Edition", MySqlDbType.VarChar).Value = txtAddEdition.Text;
                command2.Parameters.Add("@Publishing", MySqlDbType.VarChar).Value = txtAddPublishing.Text;
                //номер в базе данных
                command2.Parameters.Add("@ID", MySqlDbType.VarChar).Value = textBoxEditing.Text;

                db.openConnection();

                if (command2.ExecuteNonQuery() == 1) //проверка на корректность работы
                {
                    MessageBox.Show("Строка была изменена.");

                    txtAddWriter.Clear();
                    txtAddBook.Clear();
                    txtAddGanre.Clear();
                    txtAddCountry.Clear();
                    txtAddLanguage.Clear();
                    txtAddEdition.Clear();
                    txtAddPublishing.Clear();
                    textBoxEditing.Clear();
                }
                else
                    MessageBox.Show("Строка была не изменена.");

                db.CloseConnection(); //если не закрыть, будет большая нагрузка
                WindowSecond window_second = new WindowSecond();
                window_second.Show();
                this.Hide();
            }
            else // если нет
            {
                MessageBox.Show("Вы ввели неверный номер, либо его не существует.");
            }
        }

        private void txtAddEdition_KeyPress(object sender, KeyPressEventArgs e) //запрет на ввод букв
        {
            char number = e.KeyChar;

            if(!Char.IsDigit(number) && number !=8 || number == 45) //цифры и клавиши BackSpace и минус
            {
                MessageBox.Show("Введен неверный символ");
                e.Handled = true;
            }
        }

        private void textBoxEditing_KeyPress(object sender, KeyPressEventArgs e) //запрет на ввод букв
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 || number == 45) //цифры и клавиши BackSpace и минус
            {
                MessageBox.Show("Введен неверный символ");
                e.Handled = true;
            }
        }

        private void txtAddWriter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar >= 'А') && (e.KeyChar <= 'Я'))   
                return;
            if ((e.KeyChar >= 'а') && (e.KeyChar <= 'я'))
                return;
            if (e.KeyChar >= ' ')
                return;
            if (Char.IsControl(e.KeyChar))
                return;
            else
                MessageBox.Show("Введен неверный символ");
            e.Handled = true;
        }

        private void txtAddBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar >= 'А') && (e.KeyChar <= 'Я'))
                return;
            if ((e.KeyChar >= 'а') && (e.KeyChar <= 'я'))
                return;
            if (e.KeyChar >= ' ')
                return;
            if (Char.IsControl(e.KeyChar))
                return;
            else
                MessageBox.Show("Введен неверный символ");
            e.Handled = true;
        }

        private void txtAddGanre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar >= 'А') && (e.KeyChar <= 'Я'))
                return;
            if ((e.KeyChar >= 'а') && (e.KeyChar <= 'я'))
                return;
            if (e.KeyChar >= ' ')
                return;
            if (Char.IsControl(e.KeyChar))
                return;
            else
                MessageBox.Show("Введен неверный символ");
            e.Handled = true;
        }

        private void txtAddCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar >= 'А') && (e.KeyChar <= 'Я'))
                return;
            if ((e.KeyChar >= 'а') && (e.KeyChar <= 'я'))
                return;
            if (e.KeyChar >= ' ')
                return;
            if (Char.IsControl(e.KeyChar))
                return;
            else
                MessageBox.Show("Введен неверный символ");
            e.Handled = true;
        }

        private void txtAddLanguage_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar >= 'А') && (e.KeyChar <= 'Я'))
                return;
            if ((e.KeyChar >= 'а') && (e.KeyChar <= 'я'))
                return;
            if (e.KeyChar >= ' ')
                return;
            if (Char.IsControl(e.KeyChar))
                return;
            else
                MessageBox.Show("Введен неверный символ");
            e.Handled = true;
        }

        private void txtAddPublishing_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar >= 'А') && (e.KeyChar <= 'Я'))
                return;
            if ((e.KeyChar >= 'а') && (e.KeyChar <= 'я'))
                return;
            if (e.KeyChar >= ' ')
                return;
            if (Char.IsControl(e.KeyChar))
                return;
            else
                MessageBox.Show("Введен неверный символ");
            e.Handled = true;
        }
    }
}
