using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3ooop
{
    public partial class EditForm : Form
    {
        public MyData Data { get; private set; }

        public EditForm(MyData data = null)
        {
            InitializeComponent();

            // Поле ID зробити доступним тільки для читання
            textBoxID.ReadOnly = true;

            if (data != null)
            {
                textBoxID.Text = data.ID.ToString();
                textBoxName.Text = data.Name;
                textBoxDescription.Text = data.Description;
                Data = data;
            }
            else
            {
                Data = new MyData();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // ID вже встановлюється у формі baza
            Data.Name = textBoxName.Text;
            Data.Description = textBoxDescription.Text;
            DialogResult = DialogResult.OK;
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
