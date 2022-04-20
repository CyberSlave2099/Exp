
namespace Правильная_версия_курсовой_работы
{
    partial class Knight_CategoryEditForm
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
            this.bt_Ok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Sex = new System.Windows.Forms.ComboBox();
            this.tb_Min_Visited_Tournaments = new System.Windows.Forms.TextBox();
            this.tb_Max_Weight = new System.Windows.Forms.TextBox();
            this.tb_Min_Weight = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._All_Ukrainian_knightly_tournamentDataSet = new Правильная_версия_курсовой_работы._All_Ukrainian_knightly_tournamentDataSet();
            this.knight_CategoryTableAdapter = new Правильная_версия_курсовой_работы._All_Ukrainian_knightly_tournamentDataSetTableAdapters.Knight_CategoryTableAdapter();
            this.lb_Categoty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._All_Ukrainian_knightly_tournamentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Ok
            // 
            this.bt_Ok.Location = new System.Drawing.Point(111, 339);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(117, 30);
            this.bt_Ok.TabIndex = 0;
            this.bt_Ok.Text = "OK";
            this.bt_Ok.UseVisualStyleBackColor = true;
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Knight_Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Min_Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max_Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Min_Visited_Tournaments";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sex";
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
            this.cb_Sex.Location = new System.Drawing.Point(282, 258);
            this.cb_Sex.Name = "cb_Sex";
            this.cb_Sex.Size = new System.Drawing.Size(242, 24);
            this.cb_Sex.TabIndex = 7;
            // 
            // tb_Min_Visited_Tournaments
            // 
            this.tb_Min_Visited_Tournaments.Location = new System.Drawing.Point(282, 203);
            this.tb_Min_Visited_Tournaments.Name = "tb_Min_Visited_Tournaments";
            this.tb_Min_Visited_Tournaments.Size = new System.Drawing.Size(242, 22);
            this.tb_Min_Visited_Tournaments.TabIndex = 8;
            // 
            // tb_Max_Weight
            // 
            this.tb_Max_Weight.Location = new System.Drawing.Point(282, 157);
            this.tb_Max_Weight.Name = "tb_Max_Weight";
            this.tb_Max_Weight.Size = new System.Drawing.Size(242, 22);
            this.tb_Max_Weight.TabIndex = 9;
            // 
            // tb_Min_Weight
            // 
            this.tb_Min_Weight.Location = new System.Drawing.Point(282, 110);
            this.tb_Min_Weight.Name = "tb_Min_Weight";
            this.tb_Min_Weight.Size = new System.Drawing.Size(242, 22);
            this.tb_Min_Weight.TabIndex = 10;
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
            // lb_Categoty
            // 
            this.lb_Categoty.AutoSize = true;
            this.lb_Categoty.Location = new System.Drawing.Point(282, 69);
            this.lb_Categoty.Name = "lb_Categoty";
            this.lb_Categoty.Size = new System.Drawing.Size(46, 17);
            this.lb_Categoty.TabIndex = 11;
            this.lb_Categoty.Text = "label6";
            // 
            // Knight_CategoryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 381);
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
            this.Name = "Knight_CategoryEditForm";
            this.Text = "Knight_CategoryEditForm";
            this.Load += new System.EventHandler(this.Knight_CategoryEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._All_Ukrainian_knightly_tournamentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Ok;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Sex;
        private System.Windows.Forms.TextBox tb_Min_Visited_Tournaments;
        private System.Windows.Forms.TextBox tb_Max_Weight;
        private System.Windows.Forms.TextBox tb_Min_Weight;
        private System.Windows.Forms.BindingSource bindingSource1;
        private _All_Ukrainian_knightly_tournamentDataSet _All_Ukrainian_knightly_tournamentDataSet;
        private _All_Ukrainian_knightly_tournamentDataSetTableAdapters.Knight_CategoryTableAdapter knight_CategoryTableAdapter;
        private System.Windows.Forms.Label lb_Categoty;
    }
}