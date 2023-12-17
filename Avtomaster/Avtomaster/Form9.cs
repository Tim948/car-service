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
    public partial class F9 : Form
    {
        public F9()
        {
            InitializeComponent();
        }

        private void spec_po_remontuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.spec_po_remontuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.avtoservisDataSet);

        }

        private void F9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoservisDataSet.Rabotniki". При необходимости она может быть перемещена или удалена.
            this.rabotnikiTableAdapter.Fill(this.avtoservisDataSet.Rabotniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoservisDataSet.Spec_po_remontu". При необходимости она может быть перемещена или удалена.
            this.spec_po_remontuTableAdapter.Fill(this.avtoservisDataSet.Spec_po_remontu);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
