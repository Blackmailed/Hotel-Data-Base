
namespace HotelLab
{
    partial class FormSQL
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
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPagePrimer = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonRequest = new System.Windows.Forms.RadioButton();
            this.radioButtonNumbers = new System.Windows.Forms.RadioButton();
            this.radioButtonClients = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.buttonF_select = new System.Windows.Forms.Button();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.textBoxRooms = new System.Windows.Forms.TextBox();
            this.labelRooms = new System.Windows.Forms.Label();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.dataGridViewNumber = new System.Windows.Forms.DataGridView();
            this.buttonSelectNumber = new System.Windows.Forms.Button();
            this.panelNumber = new System.Windows.Forms.Panel();
            this.listBoxBedrooms_number = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxBreakfast_number = new System.Windows.Forms.CheckBox();
            this.labelAbout = new System.Windows.Forms.Label();
            this.labelBedrooms_number = new System.Windows.Forms.Label();
            this.textBoxAbout_number = new System.Windows.Forms.TextBox();
            this.textBoxCost_number = new System.Windows.Forms.TextBox();
            this.labelCost_number = new System.Windows.Forms.Label();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.textBoxId_number = new System.Windows.Forms.TextBox();
            this.labelId_number = new System.Windows.Forms.Label();
            this.radioButtonDelete_number = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate_number = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert_number = new System.Windows.Forms.RadioButton();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.groupBoxFSelect.SuspendLayout();
            this.tabPageSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.groupBoxSubquery.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumber)).BeginInit();
            this.panelNumber.SuspendLayout();
            this.groupBoxDML.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.tabPageSubquery);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(800, 450);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.dataGridViewSelect);
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimer.Size = new System.Drawing.Size(792, 424);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.Size = new System.Drawing.Size(786, 318);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonRequest);
            this.groupBoxSelect.Controls.Add(this.radioButtonNumbers);
            this.groupBoxSelect.Controls.Add(this.radioButtonClients);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(786, 100);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonRequest
            // 
            this.radioButtonRequest.AutoSize = true;
            this.radioButtonRequest.Location = new System.Drawing.Point(428, 55);
            this.radioButtonRequest.Name = "radioButtonRequest";
            this.radioButtonRequest.Size = new System.Drawing.Size(62, 17);
            this.radioButtonRequest.TabIndex = 2;
            this.radioButtonRequest.TabStop = true;
            this.radioButtonRequest.Text = "Заявки";
            this.radioButtonRequest.UseVisualStyleBackColor = true;
            this.radioButtonRequest.CheckedChanged += new System.EventHandler(this.radioButtonRequest_CheckedChanged);
            // 
            // radioButtonNumbers
            // 
            this.radioButtonNumbers.AutoSize = true;
            this.radioButtonNumbers.Location = new System.Drawing.Point(219, 52);
            this.radioButtonNumbers.Name = "radioButtonNumbers";
            this.radioButtonNumbers.Size = new System.Drawing.Size(65, 17);
            this.radioButtonNumbers.TabIndex = 1;
            this.radioButtonNumbers.TabStop = true;
            this.radioButtonNumbers.Text = "Номера";
            this.radioButtonNumbers.UseVisualStyleBackColor = true;
            this.radioButtonNumbers.CheckedChanged += new System.EventHandler(this.radioButtonNumbers_CheckedChanged);
            // 
            // radioButtonClients
            // 
            this.radioButtonClients.AutoSize = true;
            this.radioButtonClients.Location = new System.Drawing.Point(68, 52);
            this.radioButtonClients.Name = "radioButtonClients";
            this.radioButtonClients.Size = new System.Drawing.Size(69, 17);
            this.radioButtonClients.TabIndex = 0;
            this.radioButtonClients.TabStop = true;
            this.radioButtonClients.Text = "Клиенты";
            this.radioButtonClients.UseVisualStyleBackColor = true;
            this.radioButtonClients.CheckedChanged += new System.EventHandler(this.radioButtonClients_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridViewFSelect);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(792, 424);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(3, 188);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.Size = new System.Drawing.Size(786, 233);
            this.dataGridViewFSelect.TabIndex = 1;
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Controls.Add(this.buttonF_select);
            this.groupBoxFSelect.Controls.Add(this.checkBoxOrder);
            this.groupBoxFSelect.Controls.Add(this.textBoxMore);
            this.groupBoxFSelect.Controls.Add(this.checkBoxMore);
            this.groupBoxFSelect.Controls.Add(this.textBoxRooms);
            this.groupBoxFSelect.Controls.Add(this.labelRooms);
            this.groupBoxFSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(786, 185);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "Стоимость номера";
            // 
            // buttonF_select
            // 
            this.buttonF_select.Location = new System.Drawing.Point(314, 156);
            this.buttonF_select.Name = "buttonF_select";
            this.buttonF_select.Size = new System.Drawing.Size(114, 23);
            this.buttonF_select.TabIndex = 5;
            this.buttonF_select.Text = "Стоимость номера";
            this.buttonF_select.UseVisualStyleBackColor = true;
            this.buttonF_select.Click += new System.EventHandler(this.buttonF_select_Click);
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(24, 101);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(319, 17);
            this.checkBoxOrder.TabIndex = 4;
            this.checkBoxOrder.Text = "Включить сортировку по возрастанию стоимости номера";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(200, 66);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(100, 20);
            this.textBoxMore.TabIndex = 3;
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(24, 68);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(170, 17);
            this.checkBoxMore.TabIndex = 2;
            this.checkBoxMore.Text = "Выбрать номера не дороже:";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // textBoxRooms
            // 
            this.textBoxRooms.Location = new System.Drawing.Point(200, 30);
            this.textBoxRooms.Name = "textBoxRooms";
            this.textBoxRooms.Size = new System.Drawing.Size(100, 20);
            this.textBoxRooms.TabIndex = 1;
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Location = new System.Drawing.Point(21, 33);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(106, 13);
            this.labelRooms.TabIndex = 0;
            this.labelRooms.Text = "Количество комнат";
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubquery.Size = new System.Drawing.Size(792, 424);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Примеры подзапросов";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(3, 175);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.Size = new System.Drawing.Size(786, 246);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubquery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubquery.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(786, 172);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(275, 130);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(172, 36);
            this.buttonSubquery.TabIndex = 4;
            this.buttonSubquery.Text = "Выполнить подзапрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(451, 34);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(188, 17);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированный подзапрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(83, 34);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(175, 17);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированный подзапрос";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.dataGridViewNumber);
            this.tabPageDML.Controls.Add(this.buttonSelectNumber);
            this.tabPageDML.Controls.Add(this.panelNumber);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 22);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(792, 424);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNumber
            // 
            this.dataGridViewNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNumber.Location = new System.Drawing.Point(3, 296);
            this.dataGridViewNumber.Name = "dataGridViewNumber";
            this.dataGridViewNumber.Size = new System.Drawing.Size(786, 125);
            this.dataGridViewNumber.TabIndex = 3;
            // 
            // buttonSelectNumber
            // 
            this.buttonSelectNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSelectNumber.Location = new System.Drawing.Point(3, 255);
            this.buttonSelectNumber.Name = "buttonSelectNumber";
            this.buttonSelectNumber.Size = new System.Drawing.Size(786, 41);
            this.buttonSelectNumber.TabIndex = 2;
            this.buttonSelectNumber.Text = "Показать список номеров";
            this.buttonSelectNumber.UseVisualStyleBackColor = true;
            this.buttonSelectNumber.Click += new System.EventHandler(this.buttonSelectNumber_Click);
            // 
            // panelNumber
            // 
            this.panelNumber.Controls.Add(this.listBoxBedrooms_number);
            this.panelNumber.Controls.Add(this.label1);
            this.panelNumber.Controls.Add(this.checkBoxBreakfast_number);
            this.panelNumber.Controls.Add(this.labelAbout);
            this.panelNumber.Controls.Add(this.labelBedrooms_number);
            this.panelNumber.Controls.Add(this.textBoxAbout_number);
            this.panelNumber.Controls.Add(this.textBoxCost_number);
            this.panelNumber.Controls.Add(this.labelCost_number);
            this.panelNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNumber.Location = new System.Drawing.Point(3, 103);
            this.panelNumber.Name = "panelNumber";
            this.panelNumber.Size = new System.Drawing.Size(786, 152);
            this.panelNumber.TabIndex = 1;
            // 
            // listBoxBedrooms_number
            // 
            this.listBoxBedrooms_number.FormattingEnabled = true;
            this.listBoxBedrooms_number.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.listBoxBedrooms_number.Location = new System.Drawing.Point(158, 42);
            this.listBoxBedrooms_number.Name = "listBoxBedrooms_number";
            this.listBoxBedrooms_number.Size = new System.Drawing.Size(116, 43);
            this.listBoxBedrooms_number.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Наличие завтрака";
            // 
            // checkBoxBreakfast_number
            // 
            this.checkBoxBreakfast_number.AutoSize = true;
            this.checkBoxBreakfast_number.Location = new System.Drawing.Point(158, 131);
            this.checkBoxBreakfast_number.Name = "checkBoxBreakfast_number";
            this.checkBoxBreakfast_number.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBreakfast_number.TabIndex = 6;
            this.checkBoxBreakfast_number.UseVisualStyleBackColor = true;
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Location = new System.Drawing.Point(19, 97);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(126, 13);
            this.labelAbout.TabIndex = 5;
            this.labelAbout.Text = "Информация о номере:";
            // 
            // labelBedrooms_number
            // 
            this.labelBedrooms_number.AutoSize = true;
            this.labelBedrooms_number.Location = new System.Drawing.Point(19, 42);
            this.labelBedrooms_number.Name = "labelBedrooms_number";
            this.labelBedrooms_number.Size = new System.Drawing.Size(109, 13);
            this.labelBedrooms_number.TabIndex = 4;
            this.labelBedrooms_number.Text = "Количество комнат:";
            // 
            // textBoxAbout_number
            // 
            this.textBoxAbout_number.Location = new System.Drawing.Point(158, 94);
            this.textBoxAbout_number.Name = "textBoxAbout_number";
            this.textBoxAbout_number.Size = new System.Drawing.Size(174, 20);
            this.textBoxAbout_number.TabIndex = 3;
            // 
            // textBoxCost_number
            // 
            this.textBoxCost_number.Location = new System.Drawing.Point(158, 13);
            this.textBoxCost_number.Name = "textBoxCost_number";
            this.textBoxCost_number.Size = new System.Drawing.Size(174, 20);
            this.textBoxCost_number.TabIndex = 1;
            // 
            // labelCost_number
            // 
            this.labelCost_number.AutoSize = true;
            this.labelCost_number.Location = new System.Drawing.Point(19, 16);
            this.labelCost_number.Name = "labelCost_number";
            this.labelCost_number.Size = new System.Drawing.Size(106, 13);
            this.labelCost_number.TabIndex = 0;
            this.labelCost_number.Text = "Стоимость номера:";
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.textBoxId_number);
            this.groupBoxDML.Controls.Add(this.labelId_number);
            this.groupBoxDML.Controls.Add(this.radioButtonDelete_number);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate_number);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert_number);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(786, 100);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(438, 67);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(159, 27);
            this.buttonExecuteDML.TabIndex = 5;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // textBoxId_number
            // 
            this.textBoxId_number.Location = new System.Drawing.Point(82, 70);
            this.textBoxId_number.Name = "textBoxId_number";
            this.textBoxId_number.Size = new System.Drawing.Size(100, 20);
            this.textBoxId_number.TabIndex = 4;
            // 
            // labelId_number
            // 
            this.labelId_number.AutoSize = true;
            this.labelId_number.Location = new System.Drawing.Point(6, 73);
            this.labelId_number.Name = "labelId_number";
            this.labelId_number.Size = new System.Drawing.Size(70, 13);
            this.labelId_number.TabIndex = 3;
            this.labelId_number.Text = "Код номера:";
            // 
            // radioButtonDelete_number
            // 
            this.radioButtonDelete_number.AutoSize = true;
            this.radioButtonDelete_number.Location = new System.Drawing.Point(514, 32);
            this.radioButtonDelete_number.Name = "radioButtonDelete_number";
            this.radioButtonDelete_number.Size = new System.Drawing.Size(266, 17);
            this.radioButtonDelete_number.TabIndex = 2;
            this.radioButtonDelete_number.TabStop = true;
            this.radioButtonDelete_number.Text = " Удалить данные по номеру с заданным кодом";
            this.radioButtonDelete_number.UseVisualStyleBackColor = true;
            this.radioButtonDelete_number.CheckedChanged += new System.EventHandler(this.radioButtonDelete_number_CheckedChanged);
            // 
            // radioButtonUpdate_number
            // 
            this.radioButtonUpdate_number.AutoSize = true;
            this.radioButtonUpdate_number.Location = new System.Drawing.Point(205, 32);
            this.radioButtonUpdate_number.Name = "radioButtonUpdate_number";
            this.radioButtonUpdate_number.Size = new System.Drawing.Size(271, 17);
            this.radioButtonUpdate_number.TabIndex = 1;
            this.radioButtonUpdate_number.TabStop = true;
            this.radioButtonUpdate_number.Text = "Изменить данные по номеру с заданным кодом";
            this.radioButtonUpdate_number.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsert_number
            // 
            this.radioButtonInsert_number.AutoSize = true;
            this.radioButtonInsert_number.Location = new System.Drawing.Point(6, 32);
            this.radioButtonInsert_number.Name = "radioButtonInsert_number";
            this.radioButtonInsert_number.Size = new System.Drawing.Size(171, 17);
            this.radioButtonInsert_number.TabIndex = 0;
            this.radioButtonInsert_number.TabStop = true;
            this.radioButtonInsert_number.Text = "Добавить данные по номеру";
            this.radioButtonInsert_number.UseVisualStyleBackColor = true;
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPagePrimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            this.tabPageSubquery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumber)).EndInit();
            this.panelNumber.ResumeLayout(false);
            this.panelNumber.PerformLayout();
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonRequest;
        private System.Windows.Forms.RadioButton radioButtonNumbers;
        private System.Windows.Forms.RadioButton radioButtonClients;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
        private System.Windows.Forms.Button buttonF_select;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.TextBox textBoxRooms;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.Panel panelNumber;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.TextBox textBoxId_number;
        private System.Windows.Forms.Label labelId_number;
        private System.Windows.Forms.RadioButton radioButtonDelete_number;
        private System.Windows.Forms.RadioButton radioButtonUpdate_number;
        private System.Windows.Forms.RadioButton radioButtonInsert_number;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.DataGridView dataGridViewNumber;
        private System.Windows.Forms.Button buttonSelectNumber;
        private System.Windows.Forms.ListBox listBoxBedrooms_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxBreakfast_number;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Label labelBedrooms_number;
        private System.Windows.Forms.TextBox textBoxAbout_number;
        private System.Windows.Forms.TextBox textBoxCost_number;
        private System.Windows.Forms.Label labelCost_number;
        private System.Windows.Forms.Button buttonExecuteDML;
    }
}