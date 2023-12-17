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
    public partial class F5 : Form
    {
        public F5()
        {
            InitializeComponent();
        }

        private void avtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.avtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.avtoservisDataSet);

        }

        private void F5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoservisDataSet.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.avtoservisDataSet.Klient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoservisDataSet.Avto". При необходимости она может быть перемещена или удалена.
            this.avtoTableAdapter.Fill(this.avtoservisDataSet.Avto);

        }

        private void id_klientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
