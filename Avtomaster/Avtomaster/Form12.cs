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
    public partial class F12 : Form
    {
        public F12()
        {
            InitializeComponent();
        }

        private void filialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.avtoservisDataSet);

        }

        private void F12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoservisDataSet.Filial". При необходимости она может быть перемещена или удалена.
            this.filialTableAdapter.Fill(this.avtoservisDataSet.Filial);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < filialDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < filialDataGridView.RowCount - 1; j++)
                {
                    filialDataGridView[i, j].Style.BackColor = Color.White;
                    filialDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < filialDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < filialDataGridView.RowCount - 1; j++)
                {
                    if (filialDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        filialDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        filialDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }
        private F12 avto;

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            avto = new F12();
            avto.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
