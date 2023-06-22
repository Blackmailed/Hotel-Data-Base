﻿using System;
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
    public partial class FormClient : System.Windows.Forms.Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try 
            {
                this.Validate();
                this.клиентBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hotelDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Клиент_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Клиент' table. You can move, or remove it, as needed.
            this.клиентTableAdapter.Fill(this.hotelDataSet.Клиент);

        }

        private static FormClient f;
        public static FormClient fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormClient();
                return f;
            }
        }

        string GetSelectedFieldName()
        {
            return
           клиентDataGridView.Columns[клиентDataGridView.CurrentCell.ColumnIndex
           ].DataPropertyName;
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
               клиентBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                клиентBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Клиента с такими данными не существует", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                клиентBindingSource.Position = 0;
            }

        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        клиентBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                клиентBindingSource.Filter = "";
            if (клиентBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                клиентBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }

        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
               (int)((DataRowView)клиентBindingSource.Current)["id Клиента"];
            else
                return -1;
        }
    }
}
