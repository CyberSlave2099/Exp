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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void knightBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.knightBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._All_Ukrainian_knightly_tournamentDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_All_Ukrainian_knightly_tournamentDataSet.Knight_Category". При необходимости она может быть перемещена или удалена.
            this.knight_CategoryTableAdapter.Fill(this._All_Ukrainian_knightly_tournamentDataSet.Knight_Category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_All_Ukrainian_knightly_tournamentDataSet.Tournament". При необходимости она может быть перемещена или удалена.
            this.tournamentTableAdapter.Fill(this._All_Ukrainian_knightly_tournamentDataSet.Tournament);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_All_Ukrainian_knightly_tournamentDataSet.Participant". При необходимости она может быть перемещена или удалена.
            this.participantTableAdapter.Fill(this._All_Ukrainian_knightly_tournamentDataSet.Participant);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_All_Ukrainian_knightly_tournamentDataSet.Knight". При необходимости она может быть перемещена или удалена.
            this.knightTableAdapter.Fill(this._All_Ukrainian_knightly_tournamentDataSet.Knight);
            dataGridView1.AutoGenerateColumns = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            knightTableAdapter.Update(_All_Ukrainian_knightly_tournamentDataSet);
            participantTableAdapter.Update(_All_Ukrainian_knightly_tournamentDataSet);
            tournamentTableAdapter.Update(_All_Ukrainian_knightly_tournamentDataSet);

        }

        private void knightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = knightBindingSource;
            dataGridView1.DataSource = knightBindingSource;
            label1.Text = "Knight";
        }

        private void participantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = participantBindingSource;
            dataGridView1.DataSource = participantBindingSource;
            label1.Text = "Participant";
        }

        private void tournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = tournamentBindingSource;
            dataGridView1.DataSource = tournamentBindingSource;
            label1.Text = "Tournament";
        }

        private void списокУчасниківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new RSForm();
            rs.ShowDialog();
            knightTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Knight);
            participantTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Participant);
            tournamentTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Tournament);
        }

        private void queryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qe = new QueryEdit();
            qe.Show();

        }

        private bool edit;





        private void knightCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = knight_CategoryBindingSource;
            dataGridView1.DataSource = knight_CategoryBindingSource;
            label1.Text = "Knight Category";
        }

        private void updateKnightCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit);
            var kc = new _All_Ukrainian_knightly_tournamentDataSet.Knight_CategoryDataTable();
            knight_CategoryTableAdapter.FillBy(kc, Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value));
            object[] row = kc.Rows[0].ItemArray;
            var edt = new Knight_CategoryEditForm(row[0].ToString(), Convert.ToInt32(row[1]), Convert.ToInt32(row[2]), Convert.ToInt32(row[3]), row[4].ToString());
            edt.ShowDialog();
            knight_CategoryTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Knight_Category);
            _All_Ukrainian_knightly_tournamentDataSet.AcceptChanges();
        }

        private void updateKnightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) ;
            var st = new _All_Ukrainian_knightly_tournamentDataSet.KnightDataTable();

            knightTableAdapter.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new Knight_EditForm(Convert.ToInt32(row[0]), row[1].ToString(), row[4].ToString(), row[3].ToString(), Convert.ToInt32(row[5]), row[6].ToString(), Convert.ToDouble(row[7]), Convert.ToDateTime(row[2]));
            edt.ShowDialog();
            knightTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Knight);
            _All_Ukrainian_knightly_tournamentDataSet.AcceptChanges();
        }

        private void knightCategoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!edit) ;
            knight_CategoryTableAdapter.DeleteQuery(Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value));
            knight_CategoryTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Knight_Category);
            _All_Ukrainian_knightly_tournamentDataSet.AcceptChanges();
            knight_CategoryTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Knight_Category);
            knightTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Knight);
        }

        private void knightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!edit) ;
            knightTableAdapter.DeleteQuery1(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            knightTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Knight);
            _All_Ukrainian_knightly_tournamentDataSet.AcceptChanges();
            knightTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Knight);
        }

        private void addKnightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) ;
            var edt = new Knight_EditForm();
            edt.ShowDialog();
            knightTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Knight);
            _All_Ukrainian_knightly_tournamentDataSet.AcceptChanges();
        }

        private void addKnightCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) ;
            var edt = new Add_Knight_CategoryForm();
            edt.ShowDialog();
            knight_CategoryTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Knight_Category);
            _All_Ukrainian_knightly_tournamentDataSet.AcceptChanges();
        }
    }
}
