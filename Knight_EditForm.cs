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
    public partial class Knight_EditForm : Form
    {
        private string sex, sity, knight_Category;
        private readonly int id;
        readonly bool edit;
        public Knight_EditForm()
        {
            InitializeComponent();
            knightTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Knight);
            knight_CategoryTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Knight_Category);
            edit = false;
        }
        /// <param name="name">ФИО</param>
        /// <param name="birthDate">Дата рождения</param>
        /// <param name="sex">Пол</param>
        /// <param name="sity">Город</param>
        /// <param name="weight">Вес</param>
        /// <param name="knight_Category">Категория</param>
        /// <param name="win_Rate">винрейт</param>
        /// <param name="id">ID рыцаря</param>
        public Knight_EditForm(int id, String name, string sex, string sity, int weight, string knight_Category, double win_Rate, DateTime birthDate) : this()
        {
            knightTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Knight);
            knight_CategoryTableAdapter.Fill(_All_Ukrainian_knightly_tournamentDataSet.Knight_Category);

            edit = true;
            this.id = id; /// под вопросом
            tb_Full_Name.Text = name;
            dateTimePicker_Birth_Date.Value = birthDate;
            switch (sex.ToUpper())
            {
                case "ЧОЛОВІЧА  ":
                    comboBox_Sex.SelectedIndex = 0;
                    break;
                case "ЖІНОЧА    ":
                    comboBox_Sex.SelectedIndex = 1;
                    break;
                default:
                    comboBox_Sex.SelectedIndex = 0;
                    break;
            }
            comboBox_Sity.Text = sity;
            tb_Weight.Text = Convert.ToString(weight);
            comboBox_Knight_Category.SelectedValue = knight_Category;
            ///double winrate = Convert.ToDouble(win_RateTextBox.Text);
            tb_Win_Rate.Text = Convert.ToString(win_Rate);
        }
        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_All_Ukrainian_knightly_tournamentDataSet.Participant". При необходимости она может быть перемещена или удалена.
            this.participantTableAdapter.Fill(this._All_Ukrainian_knightly_tournamentDataSet.Participant);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_All_Ukrainian_knightly_tournamentDataSet.Knight_Category". При необходимости она может быть перемещена или удалена.
            //this.knight_CategoryTableAdapter.Fill(this._All_Ukrainian_knightly_tournamentDataSet.Knight_Category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_All_Ukrainian_knightly_tournamentDataSet.Knight". При необходимости она может быть перемещена или удалена.
            //this.knightTableAdapter.Fill(this._All_Ukrainian_knightly_tournamentDataSet.Knight);
            //comboBox_Knight_Category.SelectedItem = this.knight_Category;
            //comboBox_Sex.SelectedItem = this.sex;
            //comboBox_Sity.SelectedValue = this.sity;
            

        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (comboBox_Sex.SelectedIndex == 0)
            {
                sex = "чоловіча  ";
            }
            else if (comboBox_Sex.SelectedIndex == 1)
            {
                sex = "жіноча    ";
            }

            string sity = "";
            if (comboBox_Sity.SelectedIndex == 0)
            {
                sity = "харків";
            }
            if (comboBox_Sity.SelectedIndex == 1)
            {
                sity = "київ";
            }
            if (comboBox_Sity.SelectedIndex == 2)
            {
                sity = "одеса";
            }
            if (comboBox_Sity.SelectedIndex == 3)
            {
                sity = "дніпро";
            }
            if (comboBox_Sity.SelectedIndex == 4)
            {
                sity = "черкаси";
            }
            if (comboBox_Sity.SelectedIndex == 5)
            {
                sity = "тернопіль";
            }
            if (comboBox_Sity.SelectedIndex == 6)
            {
                sity = "чернівці";
            }
            if (edit)
            {
                knightTableAdapter.UpdateQuery1(tb_Full_Name.Text, dateTimePicker_Birth_Date.Value.ToString(), sity, sex, Convert.ToInt32(tb_Weight.Text), comboBox_Knight_Category.Text, Convert.ToDouble(tb_Win_Rate.Text), id);
                Close();
            }
            else
            {
                knightTableAdapter.InsertQuery(tb_Full_Name.Text, dateTimePicker_Birth_Date.Value.ToString(), sity, sex, Convert.ToInt32(tb_Weight.Text), comboBox_Knight_Category.Text, Convert.ToDouble(tb_Win_Rate.Text), id);
                Close();
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
