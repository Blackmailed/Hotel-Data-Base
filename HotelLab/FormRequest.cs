using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelLab
{
    public partial class FormRequest : Form
    {
        public FormRequest()
        {
            InitializeComponent();
        }

        private void заявкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.заявкаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hotelDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void FormRequest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Администратор' table. You can move, or remove it, as needed.
            this.администраторTableAdapter.Fill(this.hotelDataSet.Администратор);
            // TODO: This line of code loads data into the 'hotelDataSet.Заявка' table. You can move, or remove it, as needed.
            this.заявкаTableAdapter.Fill(this.hotelDataSet.Заявка);
            //hotelDataSet.Заявка.Columns["Время создания заявки:"].DefaultValue = DateTime.Now;

        }

        private static FormRequest f;

        public static FormRequest fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormRequest();
                return f;
            }
        }

        private void administratorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.администраторBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            int id = -1;
            if
           (((DataRowView)заявкаBindingSource.Current)["id Клиента"].ToString() !=
           "")
            {
                id =
               (int)(((DataRowView)заявкаBindingSource.Current)["id Клиента"]);
            }
            id = FormClient.fd.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)заявкаBindingSource.Current)["id Клиента"]
               = id;
                заявкаBindingSource.EndEdit();
            }
        }
    }
}
