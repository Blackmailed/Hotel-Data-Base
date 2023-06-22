
namespace HotelLab
{
    partial class FormAdministrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_АдминистратораLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label id_ЗаявкиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrator));
            this.hotelDataSet = new HotelLab.HotelDataSet();
            this.администраторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.администраторTableAdapter = new HotelLab.HotelDataSetTableAdapters.АдминистраторTableAdapter();
            this.tableAdapterManager = new HotelLab.HotelDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.администраторBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.администраторBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.id_АдминистратораTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.полComboBox = new System.Windows.Forms.ComboBox();
            this.id_ЗаявкиTextBox = new System.Windows.Forms.TextBox();
            id_АдминистратораLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            id_ЗаявкиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.администраторBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.администраторBindingNavigator)).BeginInit();
            this.администраторBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_АдминистратораLabel
            // 
            id_АдминистратораLabel.AutoSize = true;
            id_АдминистратораLabel.Location = new System.Drawing.Point(12, 34);
            id_АдминистратораLabel.Name = "id_АдминистратораLabel";
            id_АдминистратораLabel.Size = new System.Drawing.Size(106, 13);
            id_АдминистратораLabel.TabIndex = 1;
            id_АдминистратораLabel.Text = "id Администратора:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(12, 60);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(12, 86);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(30, 13);
            полLabel.TabIndex = 5;
            полLabel.Text = "Пол:";
            // 
            // id_ЗаявкиLabel
            // 
            id_ЗаявкиLabel.AutoSize = true;
            id_ЗаявкиLabel.Location = new System.Drawing.Point(12, 113);
            id_ЗаявкиLabel.Name = "id_ЗаявкиLabel";
            id_ЗаявкиLabel.Size = new System.Drawing.Size(58, 13);
            id_ЗаявкиLabel.TabIndex = 7;
            id_ЗаявкиLabel.Text = "id Заявки:";
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // администраторBindingSource
            // 
            this.администраторBindingSource.DataMember = "Администратор";
            this.администраторBindingSource.DataSource = this.hotelDataSet;
            // 
            // администраторTableAdapter
            // 
            this.администраторTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = HotelLab.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АдминистраторTableAdapter = this.администраторTableAdapter;
            this.tableAdapterManager.ЗаявкаTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.НомерTableAdapter = null;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // администраторBindingNavigatorSaveItem
            // 
            this.администраторBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.администраторBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("администраторBindingNavigatorSaveItem.Image")));
            this.администраторBindingNavigatorSaveItem.Name = "администраторBindingNavigatorSaveItem";
            this.администраторBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.администраторBindingNavigatorSaveItem.Text = "Save Data";
            this.администраторBindingNavigatorSaveItem.Click += new System.EventHandler(this.администраторBindingNavigatorSaveItem_Click);
            // 
            // администраторBindingNavigator
            // 
            this.администраторBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.администраторBindingNavigator.BindingSource = this.администраторBindingSource;
            this.администраторBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.администраторBindingNavigator.CountItemFormat = "из {0}";
            this.администраторBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.администраторBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.администраторBindingNavigatorSaveItem});
            this.администраторBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.администраторBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.администраторBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.администраторBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.администраторBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.администраторBindingNavigator.Name = "администраторBindingNavigator";
            this.администраторBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.администраторBindingNavigator.Size = new System.Drawing.Size(384, 25);
            this.администраторBindingNavigator.TabIndex = 0;
            this.администраторBindingNavigator.Text = "bindingNavigator1";
            // 
            // id_АдминистратораTextBox
            // 
            this.id_АдминистратораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.администраторBindingSource, "id Администратора", true));
            this.id_АдминистратораTextBox.Location = new System.Drawing.Point(124, 31);
            this.id_АдминистратораTextBox.Name = "id_АдминистратораTextBox";
            this.id_АдминистратораTextBox.Size = new System.Drawing.Size(121, 20);
            this.id_АдминистратораTextBox.TabIndex = 2;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.администраторBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(124, 57);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(121, 20);
            this.фИОTextBox.TabIndex = 4;
            // 
            // полComboBox
            // 
            this.полComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.администраторBindingSource, "Пол", true));
            this.полComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.полComboBox.FormattingEnabled = true;
            this.полComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.полComboBox.Location = new System.Drawing.Point(124, 83);
            this.полComboBox.Name = "полComboBox";
            this.полComboBox.Size = new System.Drawing.Size(121, 21);
            this.полComboBox.TabIndex = 6;
            // 
            // id_ЗаявкиTextBox
            // 
            this.id_ЗаявкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.администраторBindingSource, "id Заявки", true));
            this.id_ЗаявкиTextBox.Location = new System.Drawing.Point(124, 110);
            this.id_ЗаявкиTextBox.Name = "id_ЗаявкиTextBox";
            this.id_ЗаявкиTextBox.Size = new System.Drawing.Size(121, 20);
            this.id_ЗаявкиTextBox.TabIndex = 8;
            // 
            // FormAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 231);
            this.Controls.Add(id_АдминистратораLabel);
            this.Controls.Add(this.id_АдминистратораTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полComboBox);
            this.Controls.Add(id_ЗаявкиLabel);
            this.Controls.Add(this.id_ЗаявкиTextBox);
            this.Controls.Add(this.администраторBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdministrator";
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.FormAdministrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.администраторBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.администраторBindingNavigator)).EndInit();
            this.администраторBindingNavigator.ResumeLayout(false);
            this.администраторBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource администраторBindingSource;
        private HotelDataSetTableAdapters.АдминистраторTableAdapter администраторTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton администраторBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator администраторBindingNavigator;
        private System.Windows.Forms.TextBox id_АдминистратораTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.ComboBox полComboBox;
        private System.Windows.Forms.TextBox id_ЗаявкиTextBox;
    }
}