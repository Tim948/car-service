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
    public partial class F11 : Form
    {
        public F11()
        {
            InitializeComponent();
        }

        private void rabotnikiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rabotnikiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.avtoservisDataSet);

        }

        private void F11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoservisDataSet.Filial". При необходимости она может быть перемещена или удалена.
            this.filialTableAdapter.Fill(this.avtoservisDataSet.Filial);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoservisDataSet.Rabotniki". При необходимости она может быть перемещена или удалена.
            this.rabotnikiTableAdapter.Fill(this.avtoservisDataSet.Rabotniki);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
