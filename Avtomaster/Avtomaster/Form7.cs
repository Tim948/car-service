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
    public partial class F7 : Form
    {
        public F7()
        {
            InitializeComponent();
        }

        private void zayavkiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zayavkiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.avtoservisDataSet);

        }

        private void F7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoservisDataSet.Rabotniki". При необходимости она может быть перемещена или удалена.
            this.rabotnikiTableAdapter.Fill(this.avtoservisDataSet.Rabotniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoservisDataSet.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.avtoservisDataSet.Klient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoservisDataSet.Zayavki". При необходимости она может быть перемещена или удалена.
            this.zayavkiTableAdapter.Fill(this.avtoservisDataSet.Zayavki);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
