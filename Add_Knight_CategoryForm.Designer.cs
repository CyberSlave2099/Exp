
namespace Правильная_версия_курсовой_работы
{
    partial class Add_Knight_CategoryForm
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
            this.lb_Categoty = new System.Windows.Forms.TextBox();
            this.tb_Min_Weight = new System.Windows.Forms.TextBox();
            this.tb_Max_Weight = new System.Windows.Forms.TextBox();
            this.tb_Min_Visited_Tournaments = new System.Windows.Forms.TextBox();
            this.cb_Sex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_Ok = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._All_Ukrainian_knightly_tournamentDataSet = new Правильная_версия_курсовой_работы._All_Ukrainian_knightly_tournamentDataSet();
            this.knight_CategoryTableAdapter = new Правильная_версия_курсовой_работы._All_Ukrainian_knightly_tournamentDataSetTableAdapters.Knight_CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._All_Ukrainian_knightly_tournamentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Categoty
            // 
            this.lb_Categoty.Location = new System.Drawing.Point(271, 51);
            this.lb_Categoty.Name = "lb_Categoty";
            this.lb_Categoty.Size = new System.Drawing.Size(242, 22);
            this.lb_Categoty.TabIndex = 23;
            // 
            // tb_Min_Weight
            // 
            this.tb_Min_Weight.Location = new System.Drawing.Point(271, 91);
            this.tb_Min_Weight.Name = "tb_Min_Weight";
            this.tb_Min_Weight.Size = new System.Drawing.Size(242, 22);
            this.tb_Min_Weight.TabIndex = 22;
            // 
            // tb_Max_Weight
            // 
            this.tb_Max_Weight.Location = new System.Drawing.Point(271, 138);
            this.tb_Max_Weight.Name = "tb_Max_Weight";
            this.tb_Max_Weight.Size = new System.Drawing.Size(242, 22);
            this.tb_Max_Weight.TabIndex = 21;
            // 
            // tb_Min_Visited_Tournaments
            // 
            this.tb_Min_Visited_Tournaments.Location = new System.Drawing.Point(271, 184);
            this.tb_Min_Visited_Tournaments.Name = "tb_Min_Visited_Tournaments";
            this.tb_Min_Visited_Tournaments.Size = new System.Drawing.Size(242, 22);
            this.tb_Min_Visited_Tournaments.TabIndex = 20;
            // 
            // cb_Sex
            // 
            this.cb_Sex.AutoCompleteCustomSource.AddRange(new string[] {
            "чоловіча",
            "жіноча"});
            this.cb_Sex.FormattingEnabled = true;
            this.cb_Sex.Items.AddRange(new object[] {
            "чоловіча",
            "жіноча"});
            this.cb_Sex.Location = new System.Drawing.Point(271, 239);
            this.cb_Sex.Name = "cb_Sex";
            this.cb_Sex.Size = new System.Drawing.Size(242, 24);
            this.cb_Sex.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Min_Visited_Tournaments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Max_Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Min_Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Knight_Category";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bt_Ok
            // 
            this.bt_Ok.Location = new System.Drawing.Point(100, 320);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(117, 30);
            this.bt_Ok.TabIndex = 12;
            this.bt_Ok.Text = "OK";
            this.bt_Ok.UseVisualStyleBackColor = true;
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click_1);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Knight_Category";
            this.bindingSource1.DataSource = this._All_Ukrainian_knightly_tournamentDataSet;
            // 
            // _All_Ukrainian_knightly_tournamentDataSet
            // 
            this._All_Ukrainian_knightly_tournamentDataSet.DataSetName = "_All_Ukrainian_knightly_tournamentDataSet";
            this._All_Ukrainian_knightly_tournamentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knight_CategoryTableAdapter
            // 
            this.knight_CategoryTableAdapter.ClearBeforeFill = true;
            // 
            // Add_Knight_CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 370);
            this.Controls.Add(this.lb_Categoty);
            this.Controls.Add(this.tb_Min_Weight);
            this.Controls.Add(this.tb_Max_Weight);
            this.Controls.Add(this.tb_Min_Visited_Tournaments);
            this.Controls.Add(this.cb_Sex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_Ok);
            this.Name = "Add_Knight_CategoryForm";
            this.Text = "Add_Knight_CategoryForm";
            this.Load += new System.EventHandler(this.Add_Knight_CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._All_Ukrainian_knightly_tournamentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lb_Categoty;
        private System.Windows.Forms.TextBox tb_Min_Weight;
        private System.Windows.Forms.TextBox tb_Max_Weight;
        private System.Windows.Forms.TextBox tb_Min_Visited_Tournaments;
        private System.Windows.Forms.ComboBox cb_Sex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_Ok;
        private System.Windows.Forms.BindingSource bindingSource1;
        private _All_Ukrainian_knightly_tournamentDataSet _All_Ukrainian_knightly_tournamentDataSet;
        private _All_Ukrainian_knightly_tournamentDataSetTableAdapters.Knight_CategoryTableAdapter knight_CategoryTableAdapter;
    }
}