using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelLab.Properties;

namespace HotelLab
{

    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
               "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
               DialogResult.Yes;
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, ФВС, Судаков Даниил Владимирович, 571-2, 2023", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, ФВС, Судаков Даниил Владимирович, 571-2, 2023", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, ФВС, Судаков Даниил Владимирович, 571-2, 2023", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void номерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNumber fd = new FormNumber();
            FormNumber.fd.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClient fd = new FormClient();
            FormClient.fd.Show();
        }

        private void заявкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRequest fd = new FormRequest();
            FormRequest.fd.Show();
        }

        private void персоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStaff fd = new FormStaff();
            FormStaff.fd.Show();
        }

        private void администраторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdministrator fd = new FormAdministrator();
            FormAdministrator.fd.Show();
        }

        private void toolStripButtonSql_Click(object sender, EventArgs e)
        {
            FormSQL fd = new FormSQL();
            FormSQL.fd.Show();
        }
    }
}
