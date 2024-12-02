using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace laba3ooop
{
    public partial class baza : Form
    {
        // Список для зберігання даних
        private List<MyData> dataList = new List<MyData>();

        // Прапорець для відстеження змін
        private bool isDataChanged = false;

        public baza()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (isDataChanged)
            {
                DialogResult result = MessageBox.Show(
                    "Дані були змінені. Бажаєте зберегти перед відкриттям нового файлу?",
                    "Попередження",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    buttonSave_Click(sender, e); // Виклик збереження
                }
                else if (result == DialogResult.Cancel)
                {
                    return; // Скасувати відкриття
                }
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string jsonContent = File.ReadAllText(openFileDialog.FileName);
                        dataList = JsonConvert.DeserializeObject<List<MyData>>(jsonContent);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = dataList;
                        isDataChanged = false; // Скинути прапорець після відкриття
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка при відкритті файлу: " + ex.Message);
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string jsonContent = JsonConvert.SerializeObject(dataList, Formatting.Indented);
                        File.WriteAllText(saveFileDialog.FileName, jsonContent);
                        isDataChanged = false; // Скинути прапорець після збереження
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка при збереженні файлу: " + ex.Message);
                    }
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Знайти максимальний ID в списку і додати 1
            int newId = dataList.Count > 0 ? dataList.Max(d => d.ID) + 1 : 1;

            // Створити новий об'єкт з автоматичним ID
            MyData newData = new MyData { ID = newId };

            EditForm editForm = new EditForm(newData);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                dataList.Add(editForm.Data);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dataList;
                isDataChanged = true; // Дані змінено
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                MyData selectedData = dataGridView1.CurrentRow.DataBoundItem as MyData;
                if (selectedData != null)
                {
                    EditForm editForm = new EditForm(selectedData);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = dataList;
                        isDataChanged = true; // Дані змінено
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                MyData selectedData = dataGridView1.CurrentRow.DataBoundItem as MyData;
                if (selectedData != null)
                {
                    // Показати підтвердження
                    DialogResult result = MessageBox.Show(
                        $"Ви дійсно хочете видалити елемент \"{selectedData.Name}\" (ID: {selectedData.ID})?",
                        "Підтвердження видалення",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        // Видалити елемент, якщо користувач підтвердив
                        dataList.Remove(selectedData);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = dataList;
                        isDataChanged = true; // Дані змінено
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть елемент для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Шпараговський Влад\nКурс: 2\nГрупа: к23\nРік: 2024", "Про програму");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class MyData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
