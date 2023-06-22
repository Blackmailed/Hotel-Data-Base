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
    

    public partial class FormNumber : System.Windows.Forms.Form
    {
        public FormNumber()
        {
            InitializeComponent();
        }

        private void номерBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.номерBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hotelDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
}

        private void Номер_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Номер' table. You can move, or remove it, as needed.
            this.номерTableAdapter.Fill(this.hotelDataSet.Номер);

        }

        private static FormNumber f;
        public static FormNumber fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormNumber();
                return f;
            }
        }
    }
}
