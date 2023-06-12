namespace KnowledgeBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkIntegrity_button = new System.Windows.Forms.Button();
            this.saveClassesButton = new System.Windows.Forms.Button();
            this.saveSignsButton = new System.Windows.Forms.Button();
            this.loadClassesButton = new System.Windows.Forms.Button();
            this.addSignsButton = new System.Windows.Forms.Button();
            this.maintabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.delete_sign_button = new System.Windows.Forms.Button();
            this.okSignButton = new System.Windows.Forms.Button();
            this.valuesTextBox = new System.Windows.Forms.TextBox();
            this.valuesLabel = new System.Windows.Forms.Label();
            this.chooseType = new System.Windows.Forms.ComboBox();
            this.typeSignLabel = new System.Windows.Forms.Label();
            this.nameSignText = new System.Windows.Forms.TextBox();
            this.nameSignLabel = new System.Windows.Forms.Label();
            this.changeSignButton = new System.Windows.Forms.Button();
            this.addSignButton = new System.Windows.Forms.Button();
            this.signsGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.delete_class_button = new System.Windows.Forms.Button();
            this.signsForClassView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveClassButton = new System.Windows.Forms.Button();
            this.valuesForClassLabel = new System.Windows.Forms.Label();
            this.nameClassText = new System.Windows.Forms.TextBox();
            this.nameClassLabel = new System.Windows.Forms.Label();
            this.changeClassButton = new System.Windows.Forms.Button();
            this.addClassButton = new System.Windows.Forms.Button();
            this.classGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.resultProbabilityText = new System.Windows.Forms.TextBox();
            this.resultDeterminateText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            this.resultSignsView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signsGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signsForClassView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultSignsView)).BeginInit();
            this.SuspendLayout();
            // 
            // checkIntegrity_button
            // 
            this.checkIntegrity_button.Location = new System.Drawing.Point(381, 11);
            this.checkIntegrity_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkIntegrity_button.Name = "checkIntegrity_button";
            this.checkIntegrity_button.Size = new System.Drawing.Size(178, 50);
            this.checkIntegrity_button.TabIndex = 11;
            this.checkIntegrity_button.Text = "Проверка целостоности";
            this.checkIntegrity_button.UseVisualStyleBackColor = true;
            // 
            // saveClassesButton
            // 
            this.saveClassesButton.Location = new System.Drawing.Point(757, 11);
            this.saveClassesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveClassesButton.Name = "saveClassesButton";
            this.saveClassesButton.Size = new System.Drawing.Size(166, 50);
            this.saveClassesButton.TabIndex = 10;
            this.saveClassesButton.Text = "Сохранить классы";
            this.saveClassesButton.UseVisualStyleBackColor = true;
            // 
            // saveSignsButton
            // 
            this.saveSignsButton.Location = new System.Drawing.Point(585, 11);
            this.saveSignsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveSignsButton.Name = "saveSignsButton";
            this.saveSignsButton.Size = new System.Drawing.Size(159, 50);
            this.saveSignsButton.TabIndex = 9;
            this.saveSignsButton.Text = "Сохранить признаки";
            this.saveSignsButton.UseVisualStyleBackColor = true;
            // 
            // loadClassesButton
            // 
            this.loadClassesButton.Location = new System.Drawing.Point(212, 11);
            this.loadClassesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadClassesButton.Name = "loadClassesButton";
            this.loadClassesButton.Size = new System.Drawing.Size(144, 50);
            this.loadClassesButton.TabIndex = 8;
            this.loadClassesButton.Text = "Загрузить классы";
            this.loadClassesButton.UseVisualStyleBackColor = true;
            this.loadClassesButton.Click += new System.EventHandler(this.loadClassesButton_Click);
            // 
            // addSignsButton
            // 
            this.addSignsButton.Location = new System.Drawing.Point(42, 11);
            this.addSignsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addSignsButton.Name = "addSignsButton";
            this.addSignsButton.Size = new System.Drawing.Size(153, 50);
            this.addSignsButton.TabIndex = 7;
            this.addSignsButton.Text = "Загрузить признаки";
            this.addSignsButton.UseVisualStyleBackColor = true;
            // 
            // maintabControl
            // 
            this.maintabControl.Controls.Add(this.tabPage1);
            this.maintabControl.Controls.Add(this.tabPage2);
            this.maintabControl.Controls.Add(this.tabPage3);
            this.maintabControl.Location = new System.Drawing.Point(12, 69);
            this.maintabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maintabControl.Name = "maintabControl";
            this.maintabControl.SelectedIndex = 0;
            this.maintabControl.Size = new System.Drawing.Size(915, 552);
            this.maintabControl.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.delete_sign_button);
            this.tabPage1.Controls.Add(this.okSignButton);
            this.tabPage1.Controls.Add(this.valuesTextBox);
            this.tabPage1.Controls.Add(this.valuesLabel);
            this.tabPage1.Controls.Add(this.chooseType);
            this.tabPage1.Controls.Add(this.typeSignLabel);
            this.tabPage1.Controls.Add(this.nameSignText);
            this.tabPage1.Controls.Add(this.nameSignLabel);
            this.tabPage1.Controls.Add(this.changeSignButton);
            this.tabPage1.Controls.Add(this.addSignButton);
            this.tabPage1.Controls.Add(this.signsGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(907, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Признаки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // delete_sign_button
            // 
            this.delete_sign_button.Location = new System.Drawing.Point(648, 37);
            this.delete_sign_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_sign_button.Name = "delete_sign_button";
            this.delete_sign_button.Size = new System.Drawing.Size(113, 31);
            this.delete_sign_button.TabIndex = 9;
            this.delete_sign_button.Text = "Удалить";
            this.delete_sign_button.UseVisualStyleBackColor = true;
            // 
            // okSignButton
            // 
            this.okSignButton.Location = new System.Drawing.Point(722, 411);
            this.okSignButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.okSignButton.Name = "okSignButton";
            this.okSignButton.Size = new System.Drawing.Size(99, 31);
            this.okSignButton.TabIndex = 8;
            this.okSignButton.Text = "Применить";
            this.okSignButton.UseVisualStyleBackColor = true;
            // 
            // valuesTextBox
            // 
            this.valuesTextBox.Location = new System.Drawing.Point(667, 307);
            this.valuesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valuesTextBox.Multiline = true;
            this.valuesTextBox.Name = "valuesTextBox";
            this.valuesTextBox.Size = new System.Drawing.Size(211, 72);
            this.valuesTextBox.TabIndex = 7;
            // 
            // valuesLabel
            // 
            this.valuesLabel.AutoSize = true;
            this.valuesLabel.Location = new System.Drawing.Point(646, 275);
            this.valuesLabel.Name = "valuesLabel";
            this.valuesLabel.Size = new System.Drawing.Size(79, 20);
            this.valuesLabel.TabIndex = 0;
            this.valuesLabel.Text = "Значения:";
            // 
            // chooseType
            // 
            this.chooseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseType.FormattingEnabled = true;
            this.chooseType.ImeMode = System.Windows.Forms.ImeMode.On;
            this.chooseType.Items.AddRange(new object[] {
            "бинарный",
            "перечислимый",
            "интервальный"});
            this.chooseType.Location = new System.Drawing.Point(722, 215);
            this.chooseType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chooseType.Name = "chooseType";
            this.chooseType.Size = new System.Drawing.Size(156, 28);
            this.chooseType.TabIndex = 6;
            // 
            // typeSignLabel
            // 
            this.typeSignLabel.AutoSize = true;
            this.typeSignLabel.Location = new System.Drawing.Point(670, 223);
            this.typeSignLabel.Name = "typeSignLabel";
            this.typeSignLabel.Size = new System.Drawing.Size(35, 20);
            this.typeSignLabel.TabIndex = 5;
            this.typeSignLabel.Text = "Тип";
            // 
            // nameSignText
            // 
            this.nameSignText.Location = new System.Drawing.Point(722, 153);
            this.nameSignText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameSignText.Name = "nameSignText";
            this.nameSignText.Size = new System.Drawing.Size(156, 27);
            this.nameSignText.TabIndex = 4;
            // 
            // nameSignLabel
            // 
            this.nameSignLabel.AutoSize = true;
            this.nameSignLabel.Location = new System.Drawing.Point(651, 161);
            this.nameSignLabel.Name = "nameSignLabel";
            this.nameSignLabel.Size = new System.Drawing.Size(77, 20);
            this.nameSignLabel.TabIndex = 3;
            this.nameSignLabel.Text = "Название";
            // 
            // changeSignButton
            // 
            this.changeSignButton.Location = new System.Drawing.Point(768, 93);
            this.changeSignButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeSignButton.Name = "changeSignButton";
            this.changeSignButton.Size = new System.Drawing.Size(113, 35);
            this.changeSignButton.TabIndex = 2;
            this.changeSignButton.Text = "Изменить";
            this.changeSignButton.UseVisualStyleBackColor = true;
            // 
            // addSignButton
            // 
            this.addSignButton.Location = new System.Drawing.Point(648, 93);
            this.addSignButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addSignButton.Name = "addSignButton";
            this.addSignButton.Size = new System.Drawing.Size(113, 35);
            this.addSignButton.TabIndex = 1;
            this.addSignButton.Text = "Добавить";
            this.addSignButton.UseVisualStyleBackColor = true;
            // 
            // signsGrid
            // 
            this.signsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.signsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.signsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.type,
            this.value});
            this.signsGrid.EnableHeadersVisualStyles = false;
            this.signsGrid.Location = new System.Drawing.Point(9, 37);
            this.signsGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signsGrid.Name = "signsGrid";
            this.signsGrid.RowHeadersWidth = 51;
            this.signsGrid.RowTemplate.Height = 25;
            this.signsGrid.Size = new System.Drawing.Size(611, 405);
            this.signsGrid.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Название";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.HeaderText = "Тип";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            // 
            // value
            // 
            this.value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value.HeaderText = "Возможные значения";
            this.value.MinimumWidth = 6;
            this.value.Name = "value";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.delete_class_button);
            this.tabPage2.Controls.Add(this.signsForClassView);
            this.tabPage2.Controls.Add(this.saveClassButton);
            this.tabPage2.Controls.Add(this.valuesForClassLabel);
            this.tabPage2.Controls.Add(this.nameClassText);
            this.tabPage2.Controls.Add(this.nameClassLabel);
            this.tabPage2.Controls.Add(this.changeClassButton);
            this.tabPage2.Controls.Add(this.addClassButton);
            this.tabPage2.Controls.Add(this.classGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(907, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Классы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // delete_class_button
            // 
            this.delete_class_button.Location = new System.Drawing.Point(790, 48);
            this.delete_class_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_class_button.Name = "delete_class_button";
            this.delete_class_button.Size = new System.Drawing.Size(104, 36);
            this.delete_class_button.TabIndex = 11;
            this.delete_class_button.Text = "Удалить ";
            this.delete_class_button.UseVisualStyleBackColor = true;
            // 
            // signsForClassView
            // 
            this.signsForClassView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.signsForClassView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.signValue});
            this.signsForClassView.Location = new System.Drawing.Point(581, 201);
            this.signsForClassView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signsForClassView.Name = "signsForClassView";
            this.signsForClassView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.signsForClassView.RowHeadersVisible = false;
            this.signsForClassView.RowHeadersWidth = 51;
            this.signsForClassView.RowTemplate.Height = 25;
            this.signsForClassView.Size = new System.Drawing.Size(291, 235);
            this.signsForClassView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Признак";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // signValue
            // 
            this.signValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.signValue.HeaderText = "Значение";
            this.signValue.MinimumWidth = 6;
            this.signValue.Name = "signValue";
            // 
            // saveClassButton
            // 
            this.saveClassButton.Location = new System.Drawing.Point(670, 457);
            this.saveClassButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveClassButton.Name = "saveClassButton";
            this.saveClassButton.Size = new System.Drawing.Size(101, 32);
            this.saveClassButton.TabIndex = 9;
            this.saveClassButton.Text = "Сохранить";
            this.saveClassButton.UseVisualStyleBackColor = true;
            // 
            // valuesForClassLabel
            // 
            this.valuesForClassLabel.AutoSize = true;
            this.valuesForClassLabel.Location = new System.Drawing.Point(636, 167);
            this.valuesForClassLabel.Name = "valuesForClassLabel";
            this.valuesForClassLabel.Size = new System.Drawing.Size(187, 20);
            this.valuesForClassLabel.TabIndex = 7;
            this.valuesForClassLabel.Text = " Значения для признаков";
            // 
            // nameClassText
            // 
            this.nameClassText.Location = new System.Drawing.Point(698, 107);
            this.nameClassText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameClassText.Name = "nameClassText";
            this.nameClassText.Size = new System.Drawing.Size(164, 27);
            this.nameClassText.TabIndex = 4;
            // 
            // nameClassLabel
            // 
            this.nameClassLabel.AutoSize = true;
            this.nameClassLabel.Location = new System.Drawing.Point(581, 115);
            this.nameClassLabel.Name = "nameClassLabel";
            this.nameClassLabel.Size = new System.Drawing.Size(126, 20);
            this.nameClassLabel.TabIndex = 3;
            this.nameClassLabel.Text = "Название класса";
            // 
            // changeClassButton
            // 
            this.changeClassButton.Location = new System.Drawing.Point(670, 48);
            this.changeClassButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeClassButton.Name = "changeClassButton";
            this.changeClassButton.Size = new System.Drawing.Size(103, 36);
            this.changeClassButton.TabIndex = 2;
            this.changeClassButton.Text = "Изменить";
            this.changeClassButton.UseVisualStyleBackColor = true;
            // 
            // addClassButton
            // 
            this.addClassButton.Location = new System.Drawing.Point(550, 48);
            this.addClassButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(111, 36);
            this.addClassButton.TabIndex = 1;
            this.addClassButton.Text = "Добавить";
            this.addClassButton.UseVisualStyleBackColor = true;
            // 
            // classGrid
            // 
            this.classGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.sign,
            this.dataGridViewTextBoxColumn2});
            this.classGrid.Location = new System.Drawing.Point(9, 36);
            this.classGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.classGrid.Name = "classGrid";
            this.classGrid.RowHeadersWidth = 51;
            this.classGrid.RowTemplate.Height = 25;
            this.classGrid.Size = new System.Drawing.Size(534, 421);
            this.classGrid.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // sign
            // 
            this.sign.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sign.HeaderText = "Признак";
            this.sign.MinimumWidth = 6;
            this.sign.Name = "sign";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Значения";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.resultProbabilityText);
            this.tabPage3.Controls.Add(this.resultDeterminateText);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.resultButton);
            this.tabPage3.Controls.Add(this.resultSignsView);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(907, 506);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Вывод";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // resultProbabilityText
            // 
            this.resultProbabilityText.Location = new System.Drawing.Point(631, 85);
            this.resultProbabilityText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultProbabilityText.Multiline = true;
            this.resultProbabilityText.Name = "resultProbabilityText";
            this.resultProbabilityText.ReadOnly = true;
            this.resultProbabilityText.Size = new System.Drawing.Size(253, 380);
            this.resultProbabilityText.TabIndex = 5;
            // 
            // resultDeterminateText
            // 
            this.resultDeterminateText.Location = new System.Drawing.Point(359, 85);
            this.resultDeterminateText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultDeterminateText.Multiline = true;
            this.resultDeterminateText.Name = "resultDeterminateText";
            this.resultDeterminateText.ReadOnly = true;
            this.resultDeterminateText.Size = new System.Drawing.Size(253, 380);
            this.resultDeterminateText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(710, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вероятностный";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Детерминированный";
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(80, 436);
            this.resultButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(153, 31);
            this.resultButton.TabIndex = 1;
            this.resultButton.Text = "Получить класс";
            this.resultButton.UseVisualStyleBackColor = true;
            // 
            // resultSignsView
            // 
            this.resultSignsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultSignsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.resultSignsView.Location = new System.Drawing.Point(31, 48);
            this.resultSignsView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultSignsView.Name = "resultSignsView";
            this.resultSignsView.RowHeadersVisible = false;
            this.resultSignsView.RowHeadersWidth = 51;
            this.resultSignsView.RowTemplate.Height = 25;
            this.resultSignsView.Size = new System.Drawing.Size(274, 363);
            this.resultSignsView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Признак";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Значение";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 640);
            this.Controls.Add(this.checkIntegrity_button);
            this.Controls.Add(this.saveClassesButton);
            this.Controls.Add(this.saveSignsButton);
            this.Controls.Add(this.loadClassesButton);
            this.Controls.Add(this.addSignsButton);
            this.Controls.Add(this.maintabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.maintabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signsGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signsForClassView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultSignsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button checkIntegrity_button;
        private Button saveClassesButton;
        private Button saveSignsButton;
        private Button loadClassesButton;
        private Button addSignsButton;
        private TabControl maintabControl;
        private TabPage tabPage1;
        private Button delete_sign_button;
        private Button okSignButton;
        private TextBox valuesTextBox;
        private Label valuesLabel;
        private ComboBox chooseType;
        private Label typeSignLabel;
        private TextBox nameSignText;
        private Label nameSignLabel;
        private Button changeSignButton;
        private Button addSignButton;
        private DataGridView signsGrid;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn value;
        private TabPage tabPage2;
        private Button delete_class_button;
        private DataGridView signsForClassView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn signValue;
        private Button saveClassButton;
        private Label valuesForClassLabel;
        private TextBox nameClassText;
        private Label nameClassLabel;
        private Button changeClassButton;
        private Button addClassButton;
        private DataGridView classGrid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sign;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private TabPage tabPage3;
        private TextBox resultProbabilityText;
        private TextBox resultDeterminateText;
        private Label label2;
        private Label label1;
        private Button resultButton;
        private DataGridView resultSignsView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}