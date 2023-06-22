
namespace HotelLab
{
    partial class FormRequest
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
            System.Windows.Forms.Label id_ЗаявкиLabel;
            System.Windows.Forms.Label номер_заявкиLabel;
            System.Windows.Forms.Label время_создания_заявкиLabel;
            System.Windows.Forms.Label id_КлиентаLabel;
            System.Windows.Forms.Label id_НомераLabel;
            System.Windows.Forms.Label id_СотрудникаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRequest));
            this.заявкаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.заявкаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_ЗаявкиTextBox = new System.Windows.Forms.TextBox();
            this.номер_заявкиTextBox = new System.Windows.Forms.TextBox();
            this.время_создания_заявкиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_КлиентаTextBox = new System.Windows.Forms.TextBox();
            this.id_НомераTextBox = new System.Windows.Forms.TextBox();
            this.id_СотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxAdministrator = new System.Windows.Forms.GroupBox();
            this.administratorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.администраторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.administratorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.администраторDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonClient = new System.Windows.Forms.Button();
            this.заявкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new HotelLab.HotelDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заявкаTableAdapter = new HotelLab.HotelDataSetTableAdapters.ЗаявкаTableAdapter();
            this.tableAdapterManager = new HotelLab.HotelDataSetTableAdapters.TableAdapterManager();
            this.администраторTableAdapter = new HotelLab.HotelDataSetTableAdapters.АдминистраторTableAdapter();
            id_ЗаявкиLabel = new System.Windows.Forms.Label();
            номер_заявкиLabel = new System.Windows.Forms.Label();
            время_создания_заявкиLabel = new System.Windows.Forms.Label();
            id_КлиентаLabel = new System.Windows.Forms.Label();
            id_НомераLabel = new System.Windows.Forms.Label();
            id_СотрудникаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingNavigator)).BeginInit();
            this.заявкаBindingNavigator.SuspendLayout();
            this.groupBoxAdministrator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.administratorBindingNavigator)).BeginInit();
            this.administratorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.администраторBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.администраторDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // id_ЗаявкиLabel
            // 
            id_ЗаявкиLabel.AutoSize = true;
            id_ЗаявкиLabel.Location = new System.Drawing.Point(12, 45);
            id_ЗаявкиLabel.Name = "id_ЗаявкиLabel";
            id_ЗаявкиLabel.Size = new System.Drawing.Size(58, 13);
            id_ЗаявкиLabel.TabIndex = 1;
            id_ЗаявкиLabel.Text = "id Заявки:";
            // 
            // номер_заявкиLabel
            // 
            номер_заявкиLabel.AutoSize = true;
            номер_заявкиLabel.Location = new System.Drawing.Point(12, 71);
            номер_заявкиLabel.Name = "номер_заявкиLabel";
            номер_заявкиLabel.Size = new System.Drawing.Size(83, 13);
            номер_заявкиLabel.TabIndex = 3;
            номер_заявкиLabel.Text = "Номер заявки:";
            // 
            // время_создания_заявкиLabel
            // 
            время_создания_заявкиLabel.AutoSize = true;
            время_создания_заявкиLabel.Location = new System.Drawing.Point(12, 98);
            время_создания_заявкиLabel.Name = "время_создания_заявкиLabel";
            время_создания_заявкиLabel.Size = new System.Drawing.Size(133, 13);
            время_создания_заявкиLabel.TabIndex = 5;
            время_создания_заявкиLabel.Text = "Время создания заявки:";
            // 
            // id_КлиентаLabel
            // 
            id_КлиентаLabel.AutoSize = true;
            id_КлиентаLabel.Location = new System.Drawing.Point(12, 123);
            id_КлиентаLabel.Name = "id_КлиентаLabel";
            id_КлиентаLabel.Size = new System.Drawing.Size(63, 13);
            id_КлиентаLabel.TabIndex = 7;
            id_КлиентаLabel.Text = "id Клиента:";
            // 
            // id_НомераLabel
            // 
            id_НомераLabel.AutoSize = true;
            id_НомераLabel.Location = new System.Drawing.Point(12, 149);
            id_НомераLabel.Name = "id_НомераLabel";
            id_НомераLabel.Size = new System.Drawing.Size(61, 13);
            id_НомераLabel.TabIndex = 9;
            id_НомераLabel.Text = "id Номера:";
            // 
            // id_СотрудникаLabel
            // 
            id_СотрудникаLabel.AutoSize = true;
            id_СотрудникаLabel.Location = new System.Drawing.Point(12, 175);
            id_СотрудникаLabel.Name = "id_СотрудникаLabel";
            id_СотрудникаLabel.Size = new System.Drawing.Size(80, 13);
            id_СотрудникаLabel.TabIndex = 11;
            id_СотрудникаLabel.Text = "id Сотрудника:";
            // 
            // заявкаBindingNavigator
            // 
            this.заявкаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заявкаBindingNavigator.BindingSource = this.заявкаBindingSource;
            this.заявкаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заявкаBindingNavigator.CountItemFormat = "из {0}";
            this.заявкаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заявкаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.заявкаBindingNavigatorSaveItem});
            this.заявкаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заявкаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заявкаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заявкаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заявкаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заявкаBindingNavigator.Name = "заявкаBindingNavigator";
            this.заявкаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заявкаBindingNavigator.Size = new System.Drawing.Size(570, 25);
            this.заявкаBindingNavigator.TabIndex = 0;
            this.заявкаBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // заявкаBindingNavigatorSaveItem
            // 
            this.заявкаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заявкаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заявкаBindingNavigatorSaveItem.Image")));
            this.заявкаBindingNavigatorSaveItem.Name = "заявкаBindingNavigatorSaveItem";
            this.заявкаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.заявкаBindingNavigatorSaveItem.Text = "Save Data";
            this.заявкаBindingNavigatorSaveItem.Click += new System.EventHandler(this.заявкаBindingNavigatorSaveItem_Click);
            // 
            // id_ЗаявкиTextBox
            // 
            this.id_ЗаявкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкаBindingSource, "id Заявки", true));
            this.id_ЗаявкиTextBox.Location = new System.Drawing.Point(151, 42);
            this.id_ЗаявкиTextBox.Name = "id_ЗаявкиTextBox";
            this.id_ЗаявкиTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_ЗаявкиTextBox.TabIndex = 2;
            // 
            // номер_заявкиTextBox
            // 
            this.номер_заявкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкаBindingSource, "Номер заявки", true));
            this.номер_заявкиTextBox.Location = new System.Drawing.Point(151, 68);
            this.номер_заявкиTextBox.Name = "номер_заявкиTextBox";
            this.номер_заявкиTextBox.Size = new System.Drawing.Size(200, 20);
            this.номер_заявкиTextBox.TabIndex = 4;
            // 
            // время_создания_заявкиDateTimePicker
            // 
            this.время_создания_заявкиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заявкаBindingSource, "Время создания заявки", true));
            this.время_создания_заявкиDateTimePicker.Location = new System.Drawing.Point(151, 94);
            this.время_создания_заявкиDateTimePicker.Name = "время_создания_заявкиDateTimePicker";
            this.время_создания_заявкиDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.время_создания_заявкиDateTimePicker.TabIndex = 6;
            // 
            // id_КлиентаTextBox
            // 
            this.id_КлиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкаBindingSource, "id Клиента", true));
            this.id_КлиентаTextBox.Location = new System.Drawing.Point(151, 120);
            this.id_КлиентаTextBox.Name = "id_КлиентаTextBox";
            this.id_КлиентаTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_КлиентаTextBox.TabIndex = 8;
            // 
            // id_НомераTextBox
            // 
            this.id_НомераTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкаBindingSource, "id Номера", true));
            this.id_НомераTextBox.Location = new System.Drawing.Point(151, 146);
            this.id_НомераTextBox.Name = "id_НомераTextBox";
            this.id_НомераTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_НомераTextBox.TabIndex = 10;
            // 
            // id_СотрудникаTextBox
            // 
            this.id_СотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкаBindingSource, "id Сотрудника", true));
            this.id_СотрудникаTextBox.Location = new System.Drawing.Point(151, 172);
            this.id_СотрудникаTextBox.Name = "id_СотрудникаTextBox";
            this.id_СотрудникаTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_СотрудникаTextBox.TabIndex = 12;
            // 
            // groupBoxAdministrator
            // 
            this.groupBoxAdministrator.Controls.Add(this.administratorBindingNavigator);
            this.groupBoxAdministrator.Controls.Add(this.администраторDataGridView);
            this.groupBoxAdministrator.Location = new System.Drawing.Point(15, 198);
            this.groupBoxAdministrator.Name = "groupBoxAdministrator";
            this.groupBoxAdministrator.Size = new System.Drawing.Size(543, 229);
            this.groupBoxAdministrator.TabIndex = 13;
            this.groupBoxAdministrator.TabStop = false;
            this.groupBoxAdministrator.Text = "Администратор";
            // 
            // administratorBindingNavigator
            // 
            this.administratorBindingNavigator.AddNewItem = this.toolStripButton1;
            this.administratorBindingNavigator.BindingSource = this.администраторBindingSource;
            this.administratorBindingNavigator.CountItem = this.toolStripLabel1;
            this.administratorBindingNavigator.CountItemFormat = "из {0}";
            this.administratorBindingNavigator.DeleteItem = this.toolStripButton2;
            this.administratorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.administratorBindingNavigatorSaveItem});
            this.administratorBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.administratorBindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.administratorBindingNavigator.MoveLastItem = this.toolStripButton6;
            this.administratorBindingNavigator.MoveNextItem = this.toolStripButton5;
            this.administratorBindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.administratorBindingNavigator.Name = "administratorBindingNavigator";
            this.administratorBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.administratorBindingNavigator.Size = new System.Drawing.Size(537, 25);
            this.administratorBindingNavigator.TabIndex = 1;
            this.administratorBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Add new";
            // 
            // администраторBindingSource
            // 
            this.администраторBindingSource.DataMember = "FK_Администратор_Заявка";
            this.администраторBindingSource.DataSource = this.заявкаBindingSource;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel1.Text = "из {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Delete";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // administratorBindingNavigatorSaveItem
            // 
            this.administratorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.administratorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("administratorBindingNavigatorSaveItem.Image")));
            this.administratorBindingNavigatorSaveItem.Name = "administratorBindingNavigatorSaveItem";
            this.administratorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.administratorBindingNavigatorSaveItem.Text = "Save Data";
            this.administratorBindingNavigatorSaveItem.Click += new System.EventHandler(this.administratorBindingNavigatorSaveItem_Click);
            // 
            // администраторDataGridView
            // 
            this.администраторDataGridView.AutoGenerateColumns = false;
            this.администраторDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.администраторDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.администраторDataGridView.DataSource = this.администраторBindingSource;
            this.администраторDataGridView.Location = new System.Drawing.Point(3, 42);
            this.администраторDataGridView.Name = "администраторDataGridView";
            this.администраторDataGridView.Size = new System.Drawing.Size(537, 181);
            this.администраторDataGridView.TabIndex = 0;
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(399, 118);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(75, 23);
            this.buttonClient.TabIndex = 14;
            this.buttonClient.Text = "Клиенты";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // заявкаBindingSource
            // 
            this.заявкаBindingSource.DataMember = "Заявка";
            this.заявкаBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id Администратора";
            this.dataGridViewTextBoxColumn1.HeaderText = "id Администратора";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Пол";
            this.dataGridViewTextBoxColumn3.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn3.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id Заявки";
            this.dataGridViewTextBoxColumn4.HeaderText = "id Заявки";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // заявкаTableAdapter
            // 
            this.заявкаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = HotelLab.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АдминистраторTableAdapter = this.администраторTableAdapter;
            this.tableAdapterManager.ЗаявкаTableAdapter = this.заявкаTableAdapter;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.НомерTableAdapter = null;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            // 
            // администраторTableAdapter
            // 
            this.администраторTableAdapter.ClearBeforeFill = true;
            // 
            // FormRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 433);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.groupBoxAdministrator);
            this.Controls.Add(id_ЗаявкиLabel);
            this.Controls.Add(this.id_ЗаявкиTextBox);
            this.Controls.Add(номер_заявкиLabel);
            this.Controls.Add(this.номер_заявкиTextBox);
            this.Controls.Add(время_создания_заявкиLabel);
            this.Controls.Add(this.время_создания_заявкиDateTimePicker);
            this.Controls.Add(id_КлиентаLabel);
            this.Controls.Add(this.id_КлиентаTextBox);
            this.Controls.Add(id_НомераLabel);
            this.Controls.Add(this.id_НомераTextBox);
            this.Controls.Add(id_СотрудникаLabel);
            this.Controls.Add(this.id_СотрудникаTextBox);
            this.Controls.Add(this.заявкаBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRequest";
            this.Text = "Заявка";
            this.Load += new System.EventHandler(this.FormRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingNavigator)).EndInit();
            this.заявкаBindingNavigator.ResumeLayout(false);
            this.заявкаBindingNavigator.PerformLayout();
            this.groupBoxAdministrator.ResumeLayout(false);
            this.groupBoxAdministrator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.administratorBindingNavigator)).EndInit();
            this.administratorBindingNavigator.ResumeLayout(false);
            this.administratorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.администраторBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.администраторDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource заявкаBindingSource;
        private HotelDataSetTableAdapters.ЗаявкаTableAdapter заявкаTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заявкаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton заявкаBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_ЗаявкиTextBox;
        private System.Windows.Forms.TextBox номер_заявкиTextBox;
        private System.Windows.Forms.DateTimePicker время_создания_заявкиDateTimePicker;
        private System.Windows.Forms.TextBox id_КлиентаTextBox;
        private System.Windows.Forms.TextBox id_НомераTextBox;
        private System.Windows.Forms.TextBox id_СотрудникаTextBox;
        private System.Windows.Forms.GroupBox groupBoxAdministrator;
        private System.Windows.Forms.BindingSource администраторBindingSource;
        private HotelDataSetTableAdapters.АдминистраторTableAdapter администраторTableAdapter;
        private System.Windows.Forms.DataGridView администраторDataGridView;
        private System.Windows.Forms.BindingNavigator administratorBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton administratorBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button buttonClient;
    }
}