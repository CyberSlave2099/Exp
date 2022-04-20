using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Правильная_версия_курсовой_работы
{
    public partial class RSForm : Form
    {
        public RSForm()
        {
            InitializeComponent();
        }

        private void knightBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.knightBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._All_Ukrainian_knightly_tournamentDataSet);

        }

        private void RSForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_All_Ukrainian_knightly_tournamentDataSet.Participant". При необходимости она может быть перемещена или удалена.
            this.participantTableAdapter.Fill(this._All_Ukrainian_knightly_tournamentDataSet.Participant);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_All_Ukrainian_knightly_tournamentDataSet.Knight". При необходимости она может быть перемещена или удалена.
            this.knightTableAdapter.Fill(this._All_Ukrainian_knightly_tournamentDataSet.Knight);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
 {
                knightBindingSource.EndEdit();
                knightTableAdapter.Update(_All_Ukrainian_knightly_tournamentDataSet);
                participantTableAdapter.Update(_All_Ukrainian_knightly_tournamentDataSet);
                Close();
            }

        }
    }
}
