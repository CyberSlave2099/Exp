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
    public partial class Knight_CategoryEditForm : Form
    {
        private readonly string PK;
        readonly bool edit;
        public Knight_CategoryEditForm()
        {
            InitializeComponent();
            knight_CategoryTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Knight_Category);
            edit = false;
        }

        public Knight_CategoryEditForm( string Knight_Category, int Min_Weight, int Max_Weight, int Min_Visited_Tourniments, string Sex) : this()
        {
            knight_CategoryTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Knight_Category);

            edit = true;
            PK = Knight_Category;
            lb_Categoty.Text = Knight_Category;
            tb_Min_Weight.Text = Convert.ToString(Min_Weight);
            tb_Max_Weight.Text = Convert.ToString(Max_Weight);
            tb_Min_Visited_Tournaments.Text = Convert.ToString(Min_Visited_Tourniments);
            //cb_Sex.Text = Sex;

            switch (Sex.ToUpper())
            {
                case "ЧОЛОВІЧА  ":
                    cb_Sex.SelectedIndex = 0;
                    break;
                case "ЖІНОЧА    ":
                    cb_Sex.SelectedIndex = 1;
                    break;
                default:
                    cb_Sex.SelectedIndex = 0;
                    break;
            }

        }

        private void Knight_CategoryEditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_All_Ukrainian_knightly_tournamentDataSet.Knight_Category". При необходимости она может быть перемещена или удалена.
            this.knight_CategoryTableAdapter.Fill(this._All_Ukrainian_knightly_tournamentDataSet.Knight_Category);

        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (cb_Sex.SelectedIndex == 0)
            {
                sex = "чоловіча  ";
            }
            else if (cb_Sex.SelectedIndex == 1)
            {
                sex = "жіноча    ";
            }
            if (edit)
            {
                knight_CategoryTableAdapter.UpdateQuery(lb_Categoty.Text, Convert.ToInt32(tb_Min_Weight.Text), Convert.ToInt32(tb_Max_Weight.Text), Convert.ToInt32(tb_Min_Visited_Tournaments.Text), sex);
                Close();
            }
            else
            {
                knight_CategoryTableAdapter.InsertQuery(lb_Categoty.Text, Convert.ToInt32(tb_Min_Weight.Text), Convert.ToInt32(tb_Max_Weight.Text), Convert.ToInt32(tb_Min_Visited_Tournaments.Text), sex);
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
