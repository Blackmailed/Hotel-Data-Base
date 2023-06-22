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
    public partial class FormStaff : Form
    {

        private string fileImage = "";

        public FormStaff()
        {
            InitializeComponent();
        }

        private void персоналBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.персоналBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hotelDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
}

        private void персоналBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.персоналBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hotelDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

}

        private void FormStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Персонал' table. You can move, or remove it, as needed.
            this.персоналTableAdapter.Fill(this.hotelDataSet.Персонал);

        }

        private void buttonOpenPhoto_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                фотоPictureBox.Image = new
               Bitmap(openFileDialogPhoto.FileName);

            }
            else fileImage = "";
        }

        private static FormStaff f;

        public static FormStaff fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormStaff();
                return f;
            }
        }
    }
}
