using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelLab
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        private static FormSQL f;
        public static FormSQL fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSQL();
                return f;
            }
        }

        //объявляем метод, на вход подаем строку запроса, а возвращаем объект DataTable
        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект connection класса SqlConnection для соединения с БД
            //CafeConnectionString – строка описания соединения с источником данных

            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.HotelConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
             DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        private void radioButtonClients_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Клиент"); 
        }

        private void radioButtonNumbers_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Номер");
        }

        private void radioButtonRequest_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Заявка");
        }

        private void buttonF_select_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxRooms.Text))
            {
                MessageBox.Show("Обязательно укажите количество комнат в номере." +
                    "\nДопустим ввод первых символов.", "Внимание", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (checkBoxMore.Checked && String.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show("Не указана стоимость номера в условии", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxMore.Checked = false;
                return;
            }
            
            string sqlSelect = "SELECT * FROM Номер WHERE [Количество комнат] = @rooms";
            if (checkBoxMore.Checked)
                sqlSelect += " AND Стоимость <@amount";
            if (checkBoxOrder.Checked)
                sqlSelect += " ORDER BY Стоимость ASC";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.HotelConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            //command.Parameters.AddWithValue("@amount", textBoxMore.Text);
            command.Parameters.AddWithValue("@rooms", textBoxRooms.Text);
            command.Parameters.AddWithValue("idНомера", textBoxRooms.Text + "%");
            if (checkBoxMore.Checked)
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Money).Value =
                   Double.Parse(textBoxMore.Text);
                }
                catch
                {
                    MessageBox.Show("Стоимость в условии должна быть задана " +
                        "числом", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                    checkBoxMore.Checked = false;
                    return;
                }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
           "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(textBoxNumber.Text))
            //{
            //    MessageBox.Show("Обязательно укажите номер необходимой продажи",
            //   "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            string sqlSelect = "";

            if (radioButtonCorrelated.Checked)
                sqlSelect = @"SELECT * FROM Заявка z
                WHERE EXISTS (
                SELECT 1 FROM Клиент c
                WHERE c.[id Клиента] = z.[id Клиента] AND c.[Город клиента] = 'Москва');";
            else
            if (radioButtonNoCorrelated.Checked)
                sqlSelect = @"SELECT * FROM Клиент
                WHERE [id Клиента] IN (
                SELECT [id Клиента] FROM Заявка);";
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.HotelConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            //try
            //{
            //    command.Parameters.Add("@number", SqlDbType.Int).Value =
            //   int.Parse(textBoxNumber.Text);
            //}
            //catch
            //{
            //    MessageBox.Show("Номер продажи в условии должен быть задан " +
            //        "числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //return;
            //}
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
           "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        void InsertNumber()
        {
            if (
               (String.IsNullOrEmpty(textBoxCost_number.Text) ||
               (String.IsNullOrEmpty(listBoxBedrooms_number.Text) ||
               (String.IsNullOrEmpty(textBoxAbout_number.Text)))))
            {
                MessageBox.Show("Обязательно введите стоимость номера, количество комнат и информацию о номере",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            }
            //int id;
            //if (!int.TryParse(textBoxId_number.Text, out id))
            //{
            //    MessageBox.Show("Некоректное значение кода номера!", "Внимание",
            //   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            double cost = 0;
            if (!double.TryParse(textBoxCost_number.Text, out cost))
            {
                MessageBox.Show("Некоректное значение стоимости!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlInsert = @"INSERT INTO Номер ( Стоимость, [Количество комнат], [Информация о номере], 
                    [Наличие завтрака]) VALUES ( @cost, @bedrooms, @about, @breakfast)";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.HotelConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@cost", cost);
            command.Parameters.AddWithValue("@bedrooms", listBoxBedrooms_number.Text);
            command.Parameters.AddWithValue("@about", textBoxAbout_number.Text);  
            command.Parameters.AddWithValue("@breakfast", checkBoxBreakfast_number.Checked);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
            buttonSelectNumber_Click(this, EventArgs.Empty);
        }

        void UpdateNumber()
        {
            if (String.IsNullOrEmpty(textBoxId_number.Text))
            {
                MessageBox.Show("Обязательно укажите код номера, для которого " +
                    "будете менять данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id;
            if (!int.TryParse(textBoxId_number.Text, out id))
            {
                MessageBox.Show("Некоректное значение кода номера!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double cost = 0;
            if ((!String.IsNullOrEmpty(textBoxCost_number.Text)) &&
           (!double.TryParse(textBoxCost_number.Text, out cost)))
            {
                MessageBox.Show("Некоректное значение цены!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlUpdate = "UPDATE Номер SET {0} [Наличие завтрака]=@Breakfast WHERE [id Номера] = @Id_number";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.HotelConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";
            if (!String.IsNullOrEmpty(textBoxAbout_number.Text))
                sqlValues += "[Информация о номере]=@About,";
            if (!String.IsNullOrEmpty(textBoxCost_number.Text))
                sqlValues += "[Стоимость]=@Cost,";
            if (!String.IsNullOrEmpty(listBoxBedrooms_number.Text))
                sqlValues += "[Количество комнат]=@Bedrooms,";
            command.CommandText = String.Format(sqlUpdate, sqlValues);
            //или другим способом, если необходимо явное указание типа данных
            if (!String.IsNullOrEmpty(textBoxCost_number.Text))
                command.Parameters.AddWithValue("@Costs", cost);
            if (!String.IsNullOrEmpty(listBoxBedrooms_number.Text))
                command.Parameters.AddWithValue("@Bedrooms", listBoxBedrooms_number.Text);
            command.Parameters.AddWithValue("@Breakfast", checkBoxBreakfast_number.Checked);
            command.Parameters.AddWithValue("@Id_number", id);
            command.Parameters.AddWithValue("@about", textBoxAbout_number.Text);
            command.Parameters.AddWithValue("@cost", cost);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            buttonSelectNumber_Click(this, EventArgs.Empty);
        }

        void DeleteNumber()
        {
            if (String.IsNullOrEmpty(textBoxId_number.Text))
            {
                MessageBox.Show("Обязательно укажите код номера данные которого" +
                    " необходимо удалить", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            }
            int id;
            if (!int.TryParse(textBoxId_number.Text, out id))
            {
                MessageBox.Show("Некоректное значение кода блюда!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlDelete = @"DELETE FROM Номер WHERE [id Номера]=@Id_number";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.HotelConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@Id_number", id);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            buttonSelectNumber_Click(this, EventArgs.Empty);
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert_number.Checked)
                InsertNumber();
            else
                 if (radioButtonUpdate_number.Checked)
                UpdateNumber();
            else
                     if (radioButtonDelete_number.Checked)
                DeleteNumber();
            else
                MessageBox.Show("Вы не выбрали действие", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonSelectNumber_Click(object sender, EventArgs e)
        {
            dataGridViewNumber.DataSource = FillDataGridView("SELECT * FROM Номер");
        }

        private void radioButtonDelete_number_CheckedChanged(object sender, EventArgs e)
        {
            panelNumber.Visible = !radioButtonDelete_number.Checked;
        }
    }
}
