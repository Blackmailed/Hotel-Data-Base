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
    public partial class FormAdministrator : Form
    {
        public FormAdministrator()
        {
            InitializeComponent();
        }

        private void администраторBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.администраторBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hotelDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
}

        private void FormAdministrator_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'hotelDataSet.Администратор' table. You can move, or remove it, as needed.
            this.администраторTableAdapter.Fill(this.hotelDataSet.Администратор);

        }

        static FormAdministrator f;

            public static FormAdministrator fd
            {
                get
                {
                    if (f == null || f.IsDisposed) f = new FormAdministrator();
                    return f;
                }
            }
    }
}
