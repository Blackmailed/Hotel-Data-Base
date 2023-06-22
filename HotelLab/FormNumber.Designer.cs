
namespace HotelLab
{
    partial class FormNumber
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
            System.Windows.Forms.Label id_НомераLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label количество_комнатLabel;
            System.Windows.Forms.Label информация_о_номереLabel;
            System.Windows.Forms.Label наличие_завтракаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNumber));
            this.номерBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.номерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new HotelLab.HotelDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.номерBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_НомераTextBox = new System.Windows.Forms.TextBox();
            this.количество_комнатComboBox = new System.Windows.Forms.ComboBox();
            this.информация_о_номереTextBox = new System.Windows.Forms.TextBox();
            this.наличие_завтракаCheckBox = new System.Windows.Forms.CheckBox();
            this.номерTableAdapter = new HotelLab.HotelDataSetTableAdapters.НомерTableAdapter();
            this.tableAdapterManager = new HotelLab.HotelDataSetTableAdapters.TableAdapterManager();
            this.стоимостьNumericUpDown = new System.Windows.Forms.NumericUpDown();
            id_НомераLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            количество_комнатLabel = new System.Windows.Forms.Label();
            информация_о_номереLabel = new System.Windows.Forms.Label();
            наличие_завтракаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.номерBindingNavigator)).BeginInit();
            this.номерBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.номерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоимостьNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // id_НомераLabel
            // 
            id_НомераLabel.AutoSize = true;
            id_НомераLabel.Location = new System.Drawing.Point(12, 39);
            id_НомераLabel.Name = "id_НомераLabel";
            id_НомераLabel.Size = new System.Drawing.Size(61, 13);
            id_НомераLabel.TabIndex = 1;
            id_НомераLabel.Text = "id Номера:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(12, 65);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 3;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // количество_комнатLabel
            // 
            количество_комнатLabel.AutoSize = true;
            количество_комнатLabel.Location = new System.Drawing.Point(12, 91);
            количество_комнатLabel.Name = "количество_комнатLabel";
            количество_комнатLabel.Size = new System.Drawing.Size(109, 13);
            количество_комнатLabel.TabIndex = 5;
            количество_комнатLabel.Text = "Количество комнат:";
            // 
            // информация_о_номереLabel
            // 
            информация_о_номереLabel.AutoSize = true;
            информация_о_номереLabel.Location = new System.Drawing.Point(12, 118);
            информация_о_номереLabel.Name = "информация_о_номереLabel";
            информация_о_номереLabel.Size = new System.Drawing.Size(126, 13);
            информация_о_номереLabel.TabIndex = 7;
            информация_о_номереLabel.Text = "Информация о номере:";
            // 
            // наличие_завтракаLabel
            // 
            наличие_завтракаLabel.AutoSize = true;
            наличие_завтракаLabel.Location = new System.Drawing.Point(12, 146);
            наличие_завтракаLabel.Name = "наличие_завтракаLabel";
            наличие_завтракаLabel.Size = new System.Drawing.Size(103, 13);
            наличие_завтракаLabel.TabIndex = 9;
            наличие_завтракаLabel.Text = "Наличие завтрака:";
            // 
            // номерBindingNavigator
            // 
            this.номерBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.номерBindingNavigator.BindingSource = this.номерBindingSource;
            this.номерBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.номерBindingNavigator.CountItemFormat = "из {0}";
            this.номерBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.номерBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.номерBindingNavigatorSaveItem});
            this.номерBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.номерBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.номерBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.номерBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.номерBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.номерBindingNavigator.Name = "номерBindingNavigator";
            this.номерBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.номерBindingNavigator.Size = new System.Drawing.Size(413, 25);
            this.номерBindingNavigator.TabIndex = 0;
            this.номерBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить запись";
            // 
            // номерBindingSource
            // 
            this.номерBindingSource.DataMember = "Номер";
            this.номерBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить запись";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Первая запись, в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Предыдущая запись";
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
            this.bindingNavigatorMoveNextItem.Text = "Следующая запись";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Последняя запись, в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // номерBindingNavigatorSaveItem
            // 
            this.номерBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.номерBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("номерBindingNavigatorSaveItem.Image")));
            this.номерBindingNavigatorSaveItem.Name = "номерBindingNavigatorSaveItem";
            this.номерBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.номерBindingNavigatorSaveItem.Text = "Сохранить";
            this.номерBindingNavigatorSaveItem.Click += new System.EventHandler(this.номерBindingNavigatorSaveItem_Click);
            // 
            // id_НомераTextBox
            // 
            this.id_НомераTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номерBindingSource, "id Номера", true));
            this.id_НомераTextBox.Location = new System.Drawing.Point(144, 36);
            this.id_НомераTextBox.Name = "id_НомераTextBox";
            this.id_НомераTextBox.Size = new System.Drawing.Size(121, 20);
            this.id_НомераTextBox.TabIndex = 2;
            // 
            // количество_комнатComboBox
            // 
            this.количество_комнатComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номерBindingSource, "Количество комнат", true));
            this.количество_комнатComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.количество_комнатComboBox.FormattingEnabled = true;
            this.количество_комнатComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.количество_комнатComboBox.Location = new System.Drawing.Point(144, 88);
            this.количество_комнатComboBox.Name = "количество_комнатComboBox";
            this.количество_комнатComboBox.Size = new System.Drawing.Size(121, 21);
            this.количество_комнатComboBox.TabIndex = 6;
            // 
            // информация_о_номереTextBox
            // 
            this.информация_о_номереTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номерBindingSource, "Информация о номере", true));
            this.информация_о_номереTextBox.Location = new System.Drawing.Point(144, 115);
            this.информация_о_номереTextBox.Name = "информация_о_номереTextBox";
            this.информация_о_номереTextBox.Size = new System.Drawing.Size(121, 20);
            this.информация_о_номереTextBox.TabIndex = 8;
            // 
            // наличие_завтракаCheckBox
            // 
            this.наличие_завтракаCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.номерBindingSource, "Наличие завтрака", true));
            this.наличие_завтракаCheckBox.Location = new System.Drawing.Point(144, 141);
            this.наличие_завтракаCheckBox.Name = "наличие_завтракаCheckBox";
            this.наличие_завтракаCheckBox.Size = new System.Drawing.Size(121, 24);
            this.наличие_завтракаCheckBox.TabIndex = 10;
            this.наличие_завтракаCheckBox.UseVisualStyleBackColor = true;
            // 
            // номерTableAdapter
            // 
            this.номерTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = HotelLab.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АдминистраторTableAdapter = null;
            this.tableAdapterManager.ЗаявкаTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.НомерTableAdapter = this.номерTableAdapter;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            // 
            // стоимостьNumericUpDown
            // 
            this.стоимостьNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.номерBindingSource, "Стоимость", true));
            this.стоимостьNumericUpDown.DecimalPlaces = 2;
            this.стоимостьNumericUpDown.Location = new System.Drawing.Point(144, 62);
            this.стоимостьNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.стоимостьNumericUpDown.Name = "стоимостьNumericUpDown";
            this.стоимостьNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.стоимостьNumericUpDown.TabIndex = 12;
            this.стоимостьNumericUpDown.ThousandsSeparator = true;
            // 
            // FormNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 237);
            this.Controls.Add(this.стоимостьNumericUpDown);
            this.Controls.Add(id_НомераLabel);
            this.Controls.Add(this.id_НомераTextBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(количество_комнатLabel);
            this.Controls.Add(this.количество_комнатComboBox);
            this.Controls.Add(информация_о_номереLabel);
            this.Controls.Add(this.информация_о_номереTextBox);
            this.Controls.Add(наличие_завтракаLabel);
            this.Controls.Add(this.наличие_завтракаCheckBox);
            this.Controls.Add(this.номерBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNumber";
            this.Text = "Номер";
            this.Load += new System.EventHandler(this.Номер_Load);
            ((System.ComponentModel.ISupportInitialize)(this.номерBindingNavigator)).EndInit();
            this.номерBindingNavigator.ResumeLayout(false);
            this.номерBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.номерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоимостьNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource номерBindingSource;
        private HotelDataSetTableAdapters.НомерTableAdapter номерTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator номерBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton номерBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_НомераTextBox;
        private System.Windows.Forms.ComboBox количество_комнатComboBox;
        private System.Windows.Forms.TextBox информация_о_номереTextBox;
        private System.Windows.Forms.CheckBox наличие_завтракаCheckBox;
        private System.Windows.Forms.NumericUpDown стоимостьNumericUpDown;
    }
}