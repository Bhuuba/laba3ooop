namespace laba3ooop
{
    partial class baza
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
            dataGridView1 = new DataGridView();
            buttonOpen = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonAbout = new Button();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(338, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(404, 319);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(41, 21);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(193, 29);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Відкрити файл JSON";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(41, 132);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(193, 29);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Редагувати запис";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(41, 78);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(193, 29);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Додати запис";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(41, 187);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(193, 29);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Видалити запис";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.Location = new Point(665, 409);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(132, 29);
            buttonAbout.TabIndex = 5;
            buttonAbout.Text = "Про програму";
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 409);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(130, 29);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Зберегти файл";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // baza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(buttonAbout);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(buttonEdit);
            Controls.Add(buttonOpen);
            Controls.Add(dataGridView1);
            Name = "baza";
            Text = "baza";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonOpen;
        private Button buttonEdit;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonAbout;
        private Button buttonSave;
    }
}