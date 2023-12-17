using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avtomaster
{
    public partial class F6 : Form
    {
        public F6()
        {
            InitializeComponent();
        }

        private void zayavkiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zayavkiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.avtoservisDataSet);

        }

        private void F6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoservisDataSet.Zayavki". При необходимости она может быть перемещена или удалена.
            this.zayavkiTableAdapter.Fill(this.avtoservisDataSet.Zayavki);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < zayavkiDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < zayavkiDataGridView.RowCount - 1; j++)
                {
                    zayavkiDataGridView[i, j].Style.BackColor = Color.White;
                    zayavkiDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < zayavkiDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < zayavkiDataGridView.RowCount - 1; j++)
                {
                    if (zayavkiDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        zayavkiDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        zayavkiDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
        private System.Windows.Forms.DataGridViewColumn COL;

        private void button2_Click(object sender, EventArgs e)
        {
            //создает переменную COL для хранения имени выбранного столбца таблицы
            COL = new System.Windows.Forms.DataGridViewColumn();
            //блок switch, записывающий в
            //переменную Col имя выбранного столбца таблицы в зависимости от номера
            //выбранного пункта списка (ListBox1.SelectedIndex).
            //Нумерация пунктов списка начинается с нуля, а нумерация столбцов с единицы.
            //Первый столбец в списке ListBox1 - «Фамилия» носит в таблице имя
            // DataGridViewTextBoxColumn3, указанное в свойствах полей
            //в Меню действий таблицы.
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn5;
                    break;

            }
            //Блок If выполняет следующую операцию: если включён

            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать
            //таблицу по полю, заданному в переменной Col по возрастанию
            //(studentsDataGridView.Sort (Col, System.ComponentModel.ListSortDirection.
            //Ascending)), иначе по убыванию (studentsDataGridView.Sort (Col, System.
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked) zayavkiDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else zayavkiDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zayavkiBindingSource.Filter = "Nomer_klienta='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zayavkiBindingSource.Filter = "";
        }
        private F6 avto;
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            avto = new F6();
            avto.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private F7 avt;
        private void button6_Click(object sender, EventArgs e)
        {
            avt = new F7();
            avt.Visible = true;
        }
    }
}
