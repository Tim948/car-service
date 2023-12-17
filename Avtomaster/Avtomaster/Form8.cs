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
    public partial class F8 : Form
    {
        public F8()
        {
            InitializeComponent();
        }

        private void spec_po_remontuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.spec_po_remontuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.avtoservisDataSet);

        }

        private void F8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoservisDataSet.Spec_po_remontu". При необходимости она может быть перемещена или удалена.
            this.spec_po_remontuTableAdapter.Fill(this.avtoservisDataSet.Spec_po_remontu);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < spec_po_remontuDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < spec_po_remontuDataGridView.RowCount - 1; j++)
                {
                    spec_po_remontuDataGridView[i, j].Style.BackColor = Color.White;
                    spec_po_remontuDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < spec_po_remontuDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < spec_po_remontuDataGridView.RowCount - 1; j++)
                {
                    if (spec_po_remontuDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        spec_po_remontuDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        spec_po_remontuDataGridView[i, j].Style.ForeColor = Color.Blue;
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
                    COL = dataGridViewTextBoxColumn1;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn2;
                    break;

            }
            //Блок If выполняет следующую операцию: если включён

            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать
            //таблицу по полю, заданному в переменной Col по возрастанию
            //(studentsDataGridView.Sort (Col, System.ComponentModel.ListSortDirection.
            //Ascending)), иначе по убыванию (studentsDataGridView.Sort (Col, System.
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked) spec_po_remontuDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else spec_po_remontuDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            spec_po_remontuBindingSource.Filter = "Id_remont='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            spec_po_remontuBindingSource.Filter = "";
        }
        private F8 avto;
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            avto = new F8();
            avto.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private F9 avt;
        private void button6_Click(object sender, EventArgs e)
        {
            avt = new F9();
            avt.Visible = true;
        }
    }
}
