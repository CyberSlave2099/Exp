
namespace Правильная_версия_курсовой_работы
{
    partial class Knight_EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.dateTimePicker_Birth_Date = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Knight_Category = new System.Windows.Forms.ComboBox();
            this.knightCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._All_Ukrainian_knightly_tournamentDataSet = new Правильная_версия_курсовой_работы._All_Ukrainian_knightly_tournamentDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_Sex = new System.Windows.Forms.ComboBox();
            this.knightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_Sity = new System.Windows.Forms.ComboBox();
            this.tb_Win_Rate = new System.Windows.Forms.TextBox();
            this.tb_Weight = new System.Windows.Forms.TextBox();
            this.tb_Full_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.knightTableAdapter = new Правильная_версия_курсовой_работы._All_Ukrainian_knightly_tournamentDataSetTableAdapters.KnightTableAdapter();
            this.knight_CategoryTableAdapter = new Правильная_версия_курсовой_работы._All_Ukrainian_knightly_tournamentDataSetTableAdapters.Knight_CategoryTableAdapter();
            this.participantTableAdapter = new Правильная_версия_курсовой_работы._All_Ukrainian_knightly_tournamentDataSetTableAdapters.ParticipantTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.knightCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._All_Ukrainian_knightly_tournamentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(267, 364);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(135, 39);
            this.bt_Cancel.TabIndex = 53;
            this.bt_Cancel.Text = "Отмена";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(59, 364);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(135, 39);
            this.bt_OK.TabIndex = 52;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // dateTimePicker_Birth_Date
            // 
            this.dateTimePicker_Birth_Date.Location = new System.Drawing.Point(222, 64);
            this.dateTimePicker_Birth_Date.Name = "dateTimePicker_Birth_Date";
            this.dateTimePicker_Birth_Date.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_Birth_Date.TabIndex = 51;
            // 
            // comboBox_Knight_Category
            // 
            this.comboBox_Knight_Category.DataSource = this.knightCategoryBindingSource;
            this.comboBox_Knight_Category.DisplayMember = "Knight_Category";
            this.comboBox_Knight_Category.FormattingEnabled = true;
            this.comboBox_Knight_Category.Location = new System.Drawing.Point(222, 251);
            this.comboBox_Knight_Category.Name = "comboBox_Knight_Category";
            this.comboBox_Knight_Category.Size = new System.Drawing.Size(200, 24);
            this.comboBox_Knight_Category.TabIndex = 50;
            this.comboBox_Knight_Category.ValueMember = "Knight_Category";
            // 
            // knightCategoryBindingSource
            // 
            this.knightCategoryBindingSource.DataMember = "Knight_Category";
            this.knightCategoryBindingSource.DataSource = this._All_Ukrainian_knightly_tournamentDataSet;
            // 
            // _All_Ukrainian_knightly_tournamentDataSet
            // 
            this._All_Ukrainian_knightly_tournamentDataSet.DataSetName = "_All_Ukrainian_knightly_tournamentDataSet";
            this._All_Ukrainian_knightly_tournamentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Knight_Category";
            this.bindingSource1.DataSource = this._All_Ukrainian_knightly_tournamentDataSet;
            // 
            // comboBox_Sex
            // 
            this.comboBox_Sex.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.knightBindingSource, "Sex", true));
            this.comboBox_Sex.FormattingEnabled = true;
            this.comboBox_Sex.Items.AddRange(new object[] {
            "чоловіча",
            "жіноча"});
            this.comboBox_Sex.Location = new System.Drawing.Point(222, 151);
            this.comboBox_Sex.Name = "comboBox_Sex";
            this.comboBox_Sex.Size = new System.Drawing.Size(200, 24);
            this.comboBox_Sex.TabIndex = 49;
            // 
            // knightBindingSource
            // 
            this.knightBindingSource.DataMember = "Knight";
            this.knightBindingSource.DataSource = this._All_Ukrainian_knightly_tournamentDataSet;
            // 
            // comboBox_Sity
            // 
            this.comboBox_Sity.FormattingEnabled = true;
            this.comboBox_Sity.Items.AddRange(new object[] {
            "харків",
            "київ",
            "одеса",
            "дніпро",
            "черкаси",
            "тернопіль",
            "чернівці"});
            this.comboBox_Sity.Location = new System.Drawing.Point(222, 103);
            this.comboBox_Sity.Name = "comboBox_Sity";
            this.comboBox_Sity.Size = new System.Drawing.Size(200, 24);
            this.comboBox_Sity.TabIndex = 48;
            // 
            // tb_Win_Rate
            // 
            this.tb_Win_Rate.Location = new System.Drawing.Point(222, 300);
            this.tb_Win_Rate.Name = "tb_Win_Rate";
            this.tb_Win_Rate.Size = new System.Drawing.Size(200, 22);
            this.tb_Win_Rate.TabIndex = 47;
            // 
            // tb_Weight
            // 
            this.tb_Weight.Location = new System.Drawing.Point(222, 199);
            this.tb_Weight.Name = "tb_Weight";
            this.tb_Weight.Size = new System.Drawing.Size(200, 22);
            this.tb_Weight.TabIndex = 46;
            // 
            // tb_Full_Name
            // 
            this.tb_Full_Name.Location = new System.Drawing.Point(222, 25);
            this.tb_Full_Name.Name = "tb_Full_Name";
            this.tb_Full_Name.Size = new System.Drawing.Size(200, 22);
            this.tb_Full_Name.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Win_Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Knight_Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Sity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Date_Of_Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Full_Name";
            // 
            // knightTableAdapter
            // 
            this.knightTableAdapter.ClearBeforeFill = true;
            // 
            // knight_CategoryTableAdapter
            // 
            this.knight_CategoryTableAdapter.ClearBeforeFill = true;
            // 
            // participantTableAdapter
            // 
            this.participantTableAdapter.ClearBeforeFill = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 417);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.dateTimePicker_Birth_Date);
            this.Controls.Add(this.comboBox_Knight_Category);
            this.Controls.Add(this.comboBox_Sex);
            this.Controls.Add(this.comboBox_Sity);
            this.Controls.Add(this.tb_Win_Rate);
            this.Controls.Add(this.tb_Weight);
            this.Controls.Add(this.tb_Full_Name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.knightCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._All_Ukrainian_knightly_tournamentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Birth_Date;
        private System.Windows.Forms.ComboBox comboBox_Knight_Category;
        private System.Windows.Forms.ComboBox comboBox_Sex;
        private System.Windows.Forms.ComboBox comboBox_Sity;
        private System.Windows.Forms.TextBox tb_Win_Rate;
        private System.Windows.Forms.TextBox tb_Weight;
        private System.Windows.Forms.TextBox tb_Full_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private _All_Ukrainian_knightly_tournamentDataSet _All_Ukrainian_knightly_tournamentDataSet;
        private _All_Ukrainian_knightly_tournamentDataSetTableAdapters.KnightTableAdapter knightTableAdapter;
        private _All_Ukrainian_knightly_tournamentDataSetTableAdapters.Knight_CategoryTableAdapter knight_CategoryTableAdapter;
        private System.Windows.Forms.BindingSource knightBindingSource;
        private _All_Ukrainian_knightly_tournamentDataSetTableAdapters.ParticipantTableAdapter participantTableAdapter;
        private System.Windows.Forms.BindingSource knightCategoryBindingSource;
    }
}