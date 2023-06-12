using KnowledgeBase.Values;

namespace KnowledgeBase
{
    public partial class Form1 : Form
    {
        List<MetalClass> classes;
        List<Control> refactorSignElem;
        List<Control> refactorClassElem;
        MetalClass tempClass;
        bool isAdding = false;
        bool isAddingClass = false;
        Sign tempSign;
        List<Sign> signList;

        /// <summary>
        /// Форма
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            signList = new List<Sign>();
            classes = new List<MetalClass>();
            chooseType.SelectedIndex = 0;
            refactorSignElem = new List<Control>
            {
                nameSignLabel,
                typeSignLabel,
                chooseType,
                nameSignText,
                valuesLabel,
                valuesTextBox,
                okSignButton
            };
            refactorClassElem = new List<Control>
            {
                nameClassLabel,
                nameClassText,
                valuesForClassLabel,
                saveClassButton,
                signsForClassView
            };
            foreach (var elem in refactorSignElem)
                elem.Enabled = false;
            foreach (var elem in refactorClassElem)
                elem.Enabled = false;
        }

        /// <summary>
        /// Обновление представления признаков
        /// </summary>
        private void updateSignView()
        {
            signsGrid.Rows.Clear();
            resultSignsView.Rows.Clear();
            foreach (var e in signList)
            {
                signsGrid.Rows.Add(e.GetName(), e.GetType(), e.GetValue());
                resultSignsView.Rows.Add(e.GetName(), "-");
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Добавить признак"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addSignButton_Click(object sender, EventArgs e)
        {
            foreach (var elem in refactorSignElem)
                elem.Enabled = true;
            isAdding = true;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Изменить признак"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeSignButton_Click(object sender, EventArgs e)
        {
            tempSign = signList[signsGrid.CurrentCell.RowIndex];
            if (tempSign == null)
            {
                MessageBox.Show("Признак не выбран");
                return;
            }
            foreach (var elem in refactorSignElem)
                elem.Enabled = true;
            nameSignText.Text = tempSign.GetName().ResponseObject;
            var signType = tempSign.GetType();
            if (signType.HasError)
            {
                MessageBox.Show(signType.Message);
                return;
            }
            chooseType.SelectedIndex = (int)tempSign.GetType().ResponseObject;
            valuesTextBox.Text = tempSign.GetValue();
            isAdding = false;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Применить" на странице признаков
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okSignButton_Click(object sender, EventArgs e)
        {
            if (nameSignText.Text == "")
            {
                MessageBox.Show("Введите название признака");
                return;
            }
            if (isAdding) // добавить новый признак
            {
                Sign sign = new Sign(nameSignText.Text, chooseType.SelectedIndex);
                if (!sign.value.IsCorrectSet(valuesTextBox.Text))
                {
                    MessageBox.Show("Неверный формат значения");
                    return;
                }
                sign.value.SetValue(valuesTextBox.Text);
                signList.Add(sign);
                signsGrid.Rows.Add(sign.GetName(), sign.GetType(), sign.GetValue());
            }
            else
            {
                if (!tempSign.value.IsCorrectSet(valuesTextBox.Text))
                {
                    MessageBox.Show("Неверный формат значения");
                    return;
                }
                tempSign.SetName(nameSignText.Text);
                tempSign.SetType(chooseType.SelectedIndex);
                tempSign.value.SetValue(valuesTextBox.Text);
            }
            updateSignView();
            nameSignText.Text = "";
            valuesTextBox.Text = "";
            foreach (var elem in refactorSignElem)
                elem.Enabled = false;
        }


        private void chooseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (chooseType.SelectedIndex)
            {
                case 0:
                    valuesLabel.Text = "Значения 'да' или 'нет' через ','";
                    break;
                case 1:
                    valuesLabel.Text = "Значения через ','";
                    break;
                case 2:
                    valuesLabel.Text = "Значения в виде a:b";
                    break;
            }
        }

        public void setClassView()
        {
            classGrid.Rows.Clear();
            string name = "";
            foreach (var e in classes)
            {
                name = e.Name;
                foreach (var t in e.ValuesForSigns)
                {
                    classGrid.Rows.Add(name, t.GetName().ResponseObject, t.GetValue());
                    if (name != "")
                        name = "";
                }
            }
        }

        private void loadClassesButton_Click(object sender, EventArgs e)
        {
            if (signList.Count == 0)
            {
                MessageBox.Show("Список признаков пуст");
                return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовый файл|*.txt";
            openFileDialog.Title = "Выберите текстовый файл";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog.FileName);
                string line;
                Sign sign;
                Sign signinlist = null;
                int indRow = 0;
                MetalClass metal = null;
                string name;
                bool flag = false;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("[")) // значит начало класса
                    {
                        if (!flag)
                            flag = true;
                        else
                            classes.Add(metal); // сохраняем предыдущий
                        name = line.Substring(1, line.Length - 2);
                        metal = new MetalClass(name);
                    }
                    else // значит начало признака
                    {
                        string[] parts = line.Split(';');
                        foreach (var elem in signList)
                        {
                            if (elem.GetName().ResponseObject == parts[0]) // находим этот признак в списке признаков
                            {
                                signinlist = elem;
                                break;
                            }
                        }
                        sign = new Sign(parts[0], signinlist.GetTypeString().ResponseObject);
                        sign.value.SetValue(parts[1]);
                        metal.ValuesForSigns.Add(sign);
                    }
                }
                classes.Add(metal);
                setClassView();
            }
        }

        private void loadSigns(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовый файл|*.txt";
            openFileDialog.Title = "Выберите текстовый файл";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog.FileName);
                string line;
                Sign sign;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    sign = new Sign(parts[0], parts[1]);
                    sign.value.SetValue(parts[2]);
                    signList.Add(sign);
                }
                updateSignView();
            }
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            isAddingClass = true;
            signsForClassView.Rows.Clear();
            nameClassText.Text = "";
            foreach (var elem in refactorClassElem)
                elem.Enabled = true;
            foreach (var elem in signList)
                signsForClassView.Rows.Add(elem.GetName().ResponseObject, "-");
        }

        private void changeClassButton_Click(object sender, EventArgs e)
        {
            signsForClassView.Rows.Clear();
            int rowInd = classGrid.CurrentCell.RowIndex;
            string nameClass = classGrid.Rows[rowInd].Cells[0].Value.ToString();
            if (nameClass == "")
            {
                MessageBox.Show("Выберите ячейку класса");
                return;
            }
            isAddingClass = false;
            foreach (var m in classes) // ищем класс для редактирования в списке
            {
                if (nameClass == m.Name)
                {
                    tempClass = m;
                    break;
                }
            }
            foreach (var elem in refactorClassElem)
                elem.Enabled = true;
            // ставим в таблицу классов значения из tempClass
            foreach (Sign s in tempClass.ValuesForSigns)
                signsForClassView.Rows.Add(s.GetName().ResponseObject, s.GetValue());
            nameClassText.Text = tempClass.Name;
        }

        private void saveClassButton_Click(object sender, EventArgs e)
        {
            if (nameClassText.Text == "")
            {
                MessageBox.Show("Введите имя признака");
                return;
            }
            string nameSign;
            Sign sign;
            int type = -1;
            if (isAddingClass)
            {
                MetalClass metal = new MetalClass(nameClassText.Text);
                bool checkFlag = false;
                foreach (DataGridViewRow row in signsForClassView.Rows)
                {
                    if (row.Cells[1].Value == null)
                        continue;
                    if (row.Cells[1].Value.ToString() != "-")
                        checkFlag = true;
                }
                if (!checkFlag)
                {
                    MessageBox.Show("Не заполнен ни один признак");
                    return;
                }
                // доделать
                foreach (DataGridViewRow row in signsForClassView.Rows) // добавляем к классу значения признаков
                {
                    if (row.Cells[1].Value == null)
                        break;
                    if (row.Cells[1].Value.ToString() == "-") // если значения в признаке нет пропускаем
                        continue;

                    nameSign = row.Cells[0].Value.ToString();
                    foreach (var s in signList) // ищем признак в списке признаков чтобы определить тип
                    {
                        if (nameSign == s.GetName().ResponseObject)
                        {
                            type = (int)s.GetType().ResponseObject;
                            break;
                        }
                    }
                    sign = new Sign(nameSign, type);
                    if (!sign.value.IsCorrectSet(row.Cells[1].Value.ToString()))
                    {
                        MessageBox.Show("Неверный формат значения");
                        return;
                    }
                    sign.value.SetValue(row.Cells[1].Value.ToString());
                    metal.ValuesForSigns.Add(sign);
                }
                classes.Add(metal);
            }
            else
            {
                tempClass.ValuesForSigns.Clear();
                foreach (DataGridViewRow row in signsForClassView.Rows) // добавляем к классу значения признаков
                {
                    if (row.Cells[1].Value == null)
                        break;
                    if (row.Cells[1].Value.ToString() == "-") // если значения в признаке нет пропускаем
                        continue;

                    nameSign = row.Cells[0].Value.ToString();
                    foreach (var s in signList) // ищем признак в списке признаков чтобы определить тип
                    {
                        if (nameSign == s.GetName().ResponseObject)
                        {
                            type = (int)s.GetType().ResponseObject;
                            break;
                        }
                    }
                    sign = new Sign(nameSign, type);
                    if (!sign.value.IsCorrectSet(row.Cells[1].Value.ToString()))
                    {
                        MessageBox.Show("Неверный формат значения");
                        return;
                    }
                    sign.value.SetValue(row.Cells[1].Value.ToString());
                    tempClass.ValuesForSigns.Add(sign);
                }
                tempClass.Name = nameClassText.Text;
            }
            foreach (var elem in refactorClassElem)
                elem.Enabled = false;
            setClassView();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            if (classes.Count == 0 || signList.Count == 0)
            {
                MessageBox.Show("Не загружены классы или признаки");
                return;
            }
            bool flag = true;
            bool searchFlag = false;
            List<MetalClass> resultclasses = new List<MetalClass>();
            int searchInd = -1;
            resultDeterminateText.Text = "";
            resultProbabilityText.Text = "";
            string newLine = Environment.NewLine;
            foreach (MetalClass metal in classes)
            {
                metal.Rating = 0;
                flag = true;
                foreach (Sign sign in metal.ValuesForSigns)
                {
                    // находим каждый признак из каждого металла в списках введенных значений (непустых)
                    searchFlag = false;
                    for (int i = 0; i < resultSignsView.Rows.Count; i++)
                    {
                        if (resultSignsView.Rows[i].Cells[0].Value == null)
                            continue;
                        if (resultSignsView.Rows[i].Cells[0].Value.ToString() == sign.GetName().ResponseObject && resultSignsView.Rows[i].Cells[1].Value.ToString() != "-")
                        {
                            searchFlag = true;
                            searchInd = i;
                            break;
                        }
                    }
                    if (searchFlag) // если признак найден то проверка, подходит ли класс под значения
                    {
                        if (!sign.value.IsFit(resultSignsView.Rows[searchInd].Cells[1].Value.ToString()))
                        {
                            flag = false;
                            metal.Rating--;
                        }
                        else
                            metal.Rating++;
                    }
                }
                if (flag) // если проверка пройдена добавляем этот класс в список подходящих
                {
                    resultclasses.Add(metal);
                }
            }
            if (resultclasses.Count == 0)
                resultDeterminateText.Text = "Классов не найдено";
            else
                foreach (MetalClass m in resultclasses)
                {
                    resultDeterminateText.Text += m.Name + newLine;
                }

            // теперь вероятности
            IEnumerable<MetalClass> results = from m in classes
                                              orderby m.Rating descending
                                              select m;
            foreach (MetalClass m in results)
                resultProbabilityText.Text += m.Name + " : " + m.Rating + newLine;

        }

        private void saveSignsButton_Click(object sender, EventArgs e)
        {
            if (signList.Count == 0)
            {
                MessageBox.Show("Список признаков пуст");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый файл|*.txt";
            saveFileDialog.Title = "Выберите текстовый файл";

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string newLine = Environment.NewLine;
                string outputString = "";
                foreach (Sign sign in signList)
                {
                    outputString += sign.GetName().ResponseObject + ";" + sign.GetTypeString() + ";" + sign.GetValue() + newLine;
                }
                System.IO.File.WriteAllText(saveFileDialog.FileName, outputString);
            }
        }

        private void saveClassesButton_Click(object sender, EventArgs e)
        {
            if (classes.Count == 0)
            {
                MessageBox.Show("Список классов пуст");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый файл|*.txt";
            saveFileDialog.Title = "Выберите текстовый файл";

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string newLine = Environment.NewLine;
                string outputString = "";
                foreach (MetalClass metal in classes)
                {
                    outputString += "[" + metal.Name + "]" + newLine;
                    foreach (Sign sign in metal.ValuesForSigns)
                        outputString += sign.GetTypeString().ResponseObject + ";" + sign.GetValue() + newLine;
                }
                System.IO.File.WriteAllText(saveFileDialog.FileName, outputString);
            }
        }

        private void checkIntegrity_button_Click(object sender, EventArgs e)
        {
            Sign signInList = null;
            string message = "";
            string newLine = Environment.NewLine;

            foreach (MetalClass metal in classes)
            {
                foreach (Sign sign in metal.ValuesForSigns)
                {
                    foreach (Sign s in signList)
                    {
                        if (sign.GetName().ResponseObject == s.GetName().ResponseObject)
                        {
                            signInList = s;
                            break;
                        }
                    }

                    switch (sign.GetType().ResponseObject)
                    {
                        case Enums.SignTypes.Binary:
                            if (!ValueBinary.CheckIntegrity((ValueBinary)signInList.value, (ValueBinary)sign.value))
                                message += metal.Name + ", " + sign.GetName().ResponseObject + newLine;
                            break;
                        case Enums.SignTypes.Enumeration:
                            if (!ValueEnum.CheckIntegrity((ValueEnum)signInList.value, (ValueEnum)sign.value))
                                message += metal.Name + ", " + sign.GetName().ResponseObject + newLine;
                            break;
                        case Enums.SignTypes.Interval:
                            if (!ValueInterval.CheckIntegrity((ValueInterval)signInList.value, (ValueInterval)sign.value))
                                message += metal.Name + ", " + sign.GetName().ResponseObject + newLine;
                            break;
                    }
                }
            }

            if (message == "")
                MessageBox.Show("Целостность не нарушена");
            else
                MessageBox.Show("Нарушена целостность в:" + newLine + message);
        }

        private void delete_sign_button_Click(object sender, EventArgs e)
        {
            tempSign = signList[signsGrid.CurrentCell.RowIndex];
            if (tempSign == null)
            {
                MessageBox.Show("Признак не выбран");
                return;
            }
            signList.Remove(tempSign);
            updateSignView();
        }

        private void delete_class_button_Click(object sender, EventArgs e)
        {
            int rowInd = classGrid.CurrentCell.RowIndex;
            string nameClass = classGrid.Rows[rowInd].Cells[0].Value.ToString();
            if (nameClass == "")
            {
                MessageBox.Show("Выберите ячейку класса");
                return;
            }
            foreach (var m in classes) // ищем класс для редактирования в списке
            {
                if (nameClass == m.Name)
                {
                    tempClass = m;
                    break;
                }
            }
            classes.Remove(tempClass);
            setClassView();
        }
    }
}
