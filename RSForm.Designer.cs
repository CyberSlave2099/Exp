
namespace Правильная_версия_курсовой_работы
{
    partial class RSForm
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
            System.Windows.Forms.Label knight_IDLabel;
            System.Windows.Forms.Label full_NameLabel;
            System.Windows.Forms.Label date_Of_BirthLabel;
            System.Windows.Forms.Label sityLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label knight_CategoryLabel;
            System.Windows.Forms.Label win_RateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSForm));
            this._All_Ukrainian_knightly_tournamentDataSet = new Правильная_версия_курсовой_работы._All_Ukrainian_knightly_tournamentDataSet();
            this.knightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knightTableAdapter = new Правильная_версия_курсовой_работы._All_Ukrainian_knightly_tournamentDataSetTableAdapters.KnightTableAdapter();
            this.tableAdapterManager = new Правильная_версия_курсовой_работы._All_Ukrainian_knightly_tournamentDataSetTableAdapters.TableAdapterManager();
            this.participantTableAdapter = new Правильная_версия_курсовой_работы._All_Ukrainian_knightly_tournamentDataSetTableAdapters.ParticipantTableAdapter();
            this.knightBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.knightBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.knight_IDTextBox = new System.Windows.Forms.TextBox();
            this.full_NameTextBox = new System.Windows.Forms.TextBox();
            this.date_Of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sityTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.knight_CategoryTextBox = new System.Windows.Forms.TextBox();
            this.win_RateTextBox = new System.Windows.Forms.TextBox();
            this.participantDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            knight_IDLabel = new System.Windows.Forms.Label();
            full_NameLabel = new System.Windows.Forms.Label();
            date_Of_BirthLabel = new System.Windows.Forms.Label();
            sityLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            knight_CategoryLabel = new System.Windows.Forms.Label();
            win_RateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._All_Ukrainian_knightly_tournamentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightBindingNavigator)).BeginInit();
            this.knightBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // knight_IDLabel
            // 
            knight_IDLabel.AutoSize = true;
            knight_IDLabel.Location = new System.Drawing.Point(63, 31);
            knight_IDLabel.Name = "knight_IDLabel";
            knight_IDLabel.Size = new System.Drawing.Size(69, 17);
            knight_IDLabel.TabIndex = 1;
            knight_IDLabel.Text = "Knight ID:";
            // 
            // full_NameLabel
            // 
            full_NameLabel.AutoSize = true;
            full_NameLabel.Location = new System.Drawing.Point(63, 59);
            full_NameLabel.Name = "full_NameLabel";
            full_NameLabel.Size = new System.Drawing.Size(75, 17);
            full_NameLabel.TabIndex = 3;
            full_NameLabel.Text = "Full Name:";
            // 
            // date_Of_BirthLabel
            // 
            date_Of_BirthLabel.AutoSize = true;
            date_Of_BirthLabel.Location = new System.Drawing.Point(63, 88);
            date_Of_BirthLabel.Name = "date_Of_BirthLabel";
            date_Of_BirthLabel.Size = new System.Drawing.Size(94, 17);
            date_Of_BirthLabel.TabIndex = 5;
            date_Of_BirthLabel.Text = "Date Of Birth:";
            // 
            // sityLabel
            // 
            sityLabel.AutoSize = true;
            sityLabel.Location = new System.Drawing.Point(63, 115);
            sityLabel.Name = "sityLabel";
            sityLabel.Size = new System.Drawing.Size(35, 17);
            sityLabel.TabIndex = 7;
            sityLabel.Text = "Sity:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(63, 143);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(35, 17);
            sexLabel.TabIndex = 9;
            sexLabel.Text = "Sex:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(63, 171);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(56, 17);
            weightLabel.TabIndex = 11;
            weightLabel.Text = "Weight:";
            // 
            // knight_CategoryLabel
            // 
            knight_CategoryLabel.AutoSize = true;
            knight_CategoryLabel.Location = new System.Drawing.Point(63, 199);
            knight_CategoryLabel.Name = "knight_CategoryLabel";
            knight_CategoryLabel.Size = new System.Drawing.Size(113, 17);
            knight_CategoryLabel.TabIndex = 13;
            knight_CategoryLabel.Text = "Knight Category:";
            // 
            // win_RateLabel
            // 
            win_RateLabel.AutoSize = true;
            win_RateLabel.Location = new System.Drawing.Point(63, 227);
            win_RateLabel.Name = "win_RateLabel";
            win_RateLabel.Size = new System.Drawing.Size(70, 17);
            win_RateLabel.TabIndex = 15;
            win_RateLabel.Text = "Win Rate:";
            // 
            // _All_Ukrainian_knightly_tournamentDataSet
            // 
            this._All_Ukrainian_knightly_tournamentDataSet.DataSetName = "_All_Ukrainian_knightly_tournamentDataSet";
            this._All_Ukrainian_knightly_tournamentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knightBindingSource
            // 
            this.knightBindingSource.DataMember = "Knight";
            this.knightBindingSource.DataSource = this._All_Ukrainian_knightly_tournamentDataSet;
            // 
            // knightTableAdapter
            // 
            this.knightTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Knight_CategoryTableAdapter = null;
            this.tableAdapterManager.KnightTableAdapter = this.knightTableAdapter;
            this.tableAdapterManager.ParticipantTableAdapter = this.participantTableAdapter;
            this.tableAdapterManager.TournamentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Правильная_версия_курсовой_работы._All_Ukrainian_knightly_tournamentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Weapon_TypeTableAdapter = null;
            // 
            // participantTableAdapter
            // 
            this.participantTableAdapter.ClearBeforeFill = true;
            // 
            // knightBindingNavigator
            // 
            this.knightBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.knightBindingNavigator.BindingSource = this.knightBindingSource;
            this.knightBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.knightBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.knightBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.knightBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.knightBindingNavigatorSaveItem});
            this.knightBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.knightBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.knightBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.knightBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.knightBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.knightBindingNavigator.Name = "knightBindingNavigator";
            this.knightBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.knightBindingNavigator.Size = new System.Drawing.Size(825, 31);
            this.knightBindingNavigator.TabIndex = 0;
            this.knightBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // knightBindingNavigatorSaveItem
            // 
            this.knightBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.knightBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("knightBindingNavigatorSaveItem.Image")));
            this.knightBindingNavigatorSaveItem.Name = "knightBindingNavigatorSaveItem";
            this.knightBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.knightBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.knightBindingNavigatorSaveItem.Click += new System.EventHandler(this.knightBindingNavigatorSaveItem_Click);
            // 
            // knight_IDTextBox
            // 
            this.knight_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knightBindingSource, "Knight_ID", true));
            this.knight_IDTextBox.Location = new System.Drawing.Point(182, 28);
            this.knight_IDTextBox.Name = "knight_IDTextBox";
            this.knight_IDTextBox.Size = new System.Drawing.Size(200, 22);
            this.knight_IDTextBox.TabIndex = 2;
            // 
            // full_NameTextBox
            // 
            this.full_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knightBindingSource, "Full_Name", true));
            this.full_NameTextBox.Location = new System.Drawing.Point(182, 56);
            this.full_NameTextBox.Name = "full_NameTextBox";
            this.full_NameTextBox.Size = new System.Drawing.Size(200, 22);
            this.full_NameTextBox.TabIndex = 4;
            // 
            // date_Of_BirthDateTimePicker
            // 
            this.date_Of_BirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.knightBindingSource, "Date_Of_Birth", true));
            this.date_Of_BirthDateTimePicker.Location = new System.Drawing.Point(182, 84);
            this.date_Of_BirthDateTimePicker.Name = "date_Of_BirthDateTimePicker";
            this.date_Of_BirthDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.date_Of_BirthDateTimePicker.TabIndex = 6;
            // 
            // sityTextBox
            // 
            this.sityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knightBindingSource, "Sity", true));
            this.sityTextBox.Location = new System.Drawing.Point(182, 112);
            this.sityTextBox.Name = "sityTextBox";
            this.sityTextBox.Size = new System.Drawing.Size(200, 22);
            this.sityTextBox.TabIndex = 8;
            // 
            // sexTextBox
            // 
            this.sexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knightBindingSource, "Sex", true));
            this.sexTextBox.Location = new System.Drawing.Point(182, 140);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(200, 22);
            this.sexTextBox.TabIndex = 10;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knightBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(182, 168);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(200, 22);
            this.weightTextBox.TabIndex = 12;
            // 
            // knight_CategoryTextBox
            // 
            this.knight_CategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knightBindingSource, "Knight_Category", true));
            this.knight_CategoryTextBox.Location = new System.Drawing.Point(182, 196);
            this.knight_CategoryTextBox.Name = "knight_CategoryTextBox";
            this.knight_CategoryTextBox.Size = new System.Drawing.Size(200, 22);
            this.knight_CategoryTextBox.TabIndex = 14;
            // 
            // win_RateTextBox
            // 
            this.win_RateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.knightBindingSource, "Win_Rate", true));
            this.win_RateTextBox.Location = new System.Drawing.Point(182, 224);
            this.win_RateTextBox.Name = "win_RateTextBox";
            this.win_RateTextBox.Size = new System.Drawing.Size(200, 22);
            this.win_RateTextBox.TabIndex = 16;
            // 
            // participantDataGridView
            // 
            this.participantDataGridView.AutoGenerateColumns = false;
            this.participantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.participantDataGridView.DataSource = this.participantBindingSource;
            this.participantDataGridView.Location = new System.Drawing.Point(35, 252);
            this.participantDataGridView.Name = "participantDataGridView";
            this.participantDataGridView.RowHeadersWidth = 51;
            this.participantDataGridView.RowTemplate.Height = 24;
            this.participantDataGridView.Size = new System.Drawing.Size(555, 177);
            this.participantDataGridView.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Підтвердити зміни";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Participant_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Participant_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Knight_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Knight_ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tournament_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tournament_ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ranked_Place";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ranked_Place";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // participantBindingSource
            // 
            this.participantBindingSource.DataMember = "FK_Participant";
            this.participantBindingSource.DataSource = this.knightBindingSource;
            // 
            // RSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.participantDataGridView);
            this.Controls.Add(knight_IDLabel);
            this.Controls.Add(this.knight_IDTextBox);
            this.Controls.Add(full_NameLabel);
            this.Controls.Add(this.full_NameTextBox);
            this.Controls.Add(date_Of_BirthLabel);
            this.Controls.Add(this.date_Of_BirthDateTimePicker);
            this.Controls.Add(sityLabel);
            this.Controls.Add(this.sityTextBox);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexTextBox);
            this.Controls.Add(weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(knight_CategoryLabel);
            this.Controls.Add(this.knight_CategoryTextBox);
            this.Controls.Add(win_RateLabel);
            this.Controls.Add(this.win_RateTextBox);
            this.Controls.Add(this.knightBindingNavigator);
            this.Name = "RSForm";
            this.Text = "RSForm";
            this.Load += new System.EventHandler(this.RSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._All_Ukrainian_knightly_tournamentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knightBindingNavigator)).EndInit();
            this.knightBindingNavigator.ResumeLayout(false);
            this.knightBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _All_Ukrainian_knightly_tournamentDataSet _All_Ukrainian_knightly_tournamentDataSet;
        private System.Windows.Forms.BindingSource knightBindingSource;
        private _All_Ukrainian_knightly_tournamentDataSetTableAdapters.KnightTableAdapter knightTableAdapter;
        private _All_Ukrainian_knightly_tournamentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator knightBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton knightBindingNavigatorSaveItem;
        private _All_Ukrainian_knightly_tournamentDataSetTableAdapters.ParticipantTableAdapter participantTableAdapter;
        private System.Windows.Forms.TextBox knight_IDTextBox;
        private System.Windows.Forms.TextBox full_NameTextBox;
        private System.Windows.Forms.DateTimePicker date_Of_BirthDateTimePicker;
        private System.Windows.Forms.TextBox sityTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox knight_CategoryTextBox;
        private System.Windows.Forms.TextBox win_RateTextBox;
        private System.Windows.Forms.BindingSource participantBindingSource;
        private System.Windows.Forms.DataGridView participantDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
    }
}