namespace Avtomaster
{
    partial class F11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F11));
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label imLabel;
            System.Windows.Forms.Label otLabel;
            System.Windows.Forms.Label date_rLabel;
            System.Windows.Forms.Label stazhLabel;
            System.Windows.Forms.Label dolzhnostLabel;
            System.Windows.Forms.Label id_filialaLabel;
            this.avtoservisDataSet = new Avtomaster.AvtoservisDataSet();
            this.rabotnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rabotnikiTableAdapter = new Avtomaster.AvtoservisDataSetTableAdapters.RabotnikiTableAdapter();
            this.tableAdapterManager = new Avtomaster.AvtoservisDataSetTableAdapters.TableAdapterManager();
            this.rabotnikiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.rabotnikiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.famTextBox = new System.Windows.Forms.TextBox();
            this.imTextBox = new System.Windows.Forms.TextBox();
            this.otTextBox = new System.Windows.Forms.TextBox();
            this.date_rDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stazhTextBox = new System.Windows.Forms.TextBox();
            this.dolzhnostTextBox = new System.Windows.Forms.TextBox();
            this.id_filialaComboBox = new System.Windows.Forms.ComboBox();
            this.filialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filialTableAdapter = new Avtomaster.AvtoservisDataSetTableAdapters.FilialTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            famLabel = new System.Windows.Forms.Label();
            imLabel = new System.Windows.Forms.Label();
            otLabel = new System.Windows.Forms.Label();
            date_rLabel = new System.Windows.Forms.Label();
            stazhLabel = new System.Windows.Forms.Label();
            dolzhnostLabel = new System.Windows.Forms.Label();
            id_filialaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avtoservisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotnikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotnikiBindingNavigator)).BeginInit();
            this.rabotnikiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // avtoservisDataSet
            // 
            this.avtoservisDataSet.DataSetName = "AvtoservisDataSet";
            this.avtoservisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rabotnikiBindingSource
            // 
            this.rabotnikiBindingSource.DataMember = "Rabotniki";
            this.rabotnikiBindingSource.DataSource = this.avtoservisDataSet;
            // 
            // rabotnikiTableAdapter
            // 
            this.rabotnikiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvtoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilialTableAdapter = this.filialTableAdapter;
            this.tableAdapterManager.KlientTableAdapter = null;
            this.tableAdapterManager.RabotnikiTableAdapter = this.rabotnikiTableAdapter;
            this.tableAdapterManager.Spec_po_remontuTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Avtomaster.AvtoservisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZayavkiTableAdapter = null;
            // 
            // rabotnikiBindingNavigator
            // 
            this.rabotnikiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rabotnikiBindingNavigator.BindingSource = this.rabotnikiBindingSource;
            this.rabotnikiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rabotnikiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rabotnikiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rabotnikiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rabotnikiBindingNavigatorSaveItem});
            this.rabotnikiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rabotnikiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rabotnikiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rabotnikiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rabotnikiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rabotnikiBindingNavigator.Name = "rabotnikiBindingNavigator";
            this.rabotnikiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rabotnikiBindingNavigator.Size = new System.Drawing.Size(385, 27);
            this.rabotnikiBindingNavigator.TabIndex = 0;
            this.rabotnikiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
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
            // rabotnikiBindingNavigatorSaveItem
            // 
            this.rabotnikiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rabotnikiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rabotnikiBindingNavigatorSaveItem.Image")));
            this.rabotnikiBindingNavigatorSaveItem.Name = "rabotnikiBindingNavigatorSaveItem";
            this.rabotnikiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.rabotnikiBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.rabotnikiBindingNavigatorSaveItem.Click += new System.EventHandler(this.rabotnikiBindingNavigatorSaveItem_Click);
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(14, 57);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(69, 16);
            famLabel.TabIndex = 1;
            famLabel.Text = "Фамилия:";
            // 
            // famTextBox
            // 
            this.famTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rabotnikiBindingSource, "Fam", true));
            this.famTextBox.Location = new System.Drawing.Point(115, 57);
            this.famTextBox.Name = "famTextBox";
            this.famTextBox.Size = new System.Drawing.Size(237, 22);
            this.famTextBox.TabIndex = 2;
            // 
            // imLabel
            // 
            imLabel.AutoSize = true;
            imLabel.Location = new System.Drawing.Point(14, 88);
            imLabel.Name = "imLabel";
            imLabel.Size = new System.Drawing.Size(36, 16);
            imLabel.TabIndex = 3;
            imLabel.Text = "Имя:";
            // 
            // imTextBox
            // 
            this.imTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rabotnikiBindingSource, "Im", true));
            this.imTextBox.Location = new System.Drawing.Point(115, 88);
            this.imTextBox.Name = "imTextBox";
            this.imTextBox.Size = new System.Drawing.Size(237, 22);
            this.imTextBox.TabIndex = 4;
            // 
            // otLabel
            // 
            otLabel.AutoSize = true;
            otLabel.Location = new System.Drawing.Point(14, 121);
            otLabel.Name = "otLabel";
            otLabel.Size = new System.Drawing.Size(73, 16);
            otLabel.TabIndex = 5;
            otLabel.Text = "Отчество:";
            // 
            // otTextBox
            // 
            this.otTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rabotnikiBindingSource, "Ot", true));
            this.otTextBox.Location = new System.Drawing.Point(115, 121);
            this.otTextBox.Name = "otTextBox";
            this.otTextBox.Size = new System.Drawing.Size(237, 22);
            this.otTextBox.TabIndex = 6;
            // 
            // date_rLabel
            // 
            date_rLabel.AutoSize = true;
            date_rLabel.Location = new System.Drawing.Point(14, 155);
            date_rLabel.Name = "date_rLabel";
            date_rLabel.Size = new System.Drawing.Size(109, 16);
            date_rLabel.TabIndex = 7;
            date_rLabel.Text = "Дата рождения:";
            // 
            // date_rDateTimePicker
            // 
            this.date_rDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rabotnikiBindingSource, "Date_r", true));
            this.date_rDateTimePicker.Location = new System.Drawing.Point(134, 150);
            this.date_rDateTimePicker.Name = "date_rDateTimePicker";
            this.date_rDateTimePicker.Size = new System.Drawing.Size(218, 22);
            this.date_rDateTimePicker.TabIndex = 8;
            // 
            // stazhLabel
            // 
            stazhLabel.AutoSize = true;
            stazhLabel.Location = new System.Drawing.Point(14, 187);
            stazhLabel.Name = "stazhLabel";
            stazhLabel.Size = new System.Drawing.Size(94, 16);
            stazhLabel.TabIndex = 9;
            stazhLabel.Text = "Стаж работы:";
            // 
            // stazhTextBox
            // 
            this.stazhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rabotnikiBindingSource, "Stazh", true));
            this.stazhTextBox.Location = new System.Drawing.Point(115, 181);
            this.stazhTextBox.Name = "stazhTextBox";
            this.stazhTextBox.Size = new System.Drawing.Size(237, 22);
            this.stazhTextBox.TabIndex = 10;
            // 
            // dolzhnostLabel
            // 
            dolzhnostLabel.AutoSize = true;
            dolzhnostLabel.Location = new System.Drawing.Point(14, 218);
            dolzhnostLabel.Name = "dolzhnostLabel";
            dolzhnostLabel.Size = new System.Drawing.Size(165, 16);
            dolzhnostLabel.TabIndex = 11;
            dolzhnostLabel.Text = "Занимаемая должность:";
            // 
            // dolzhnostTextBox
            // 
            this.dolzhnostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rabotnikiBindingSource, "Dolzhnost", true));
            this.dolzhnostTextBox.Location = new System.Drawing.Point(203, 215);
            this.dolzhnostTextBox.Name = "dolzhnostTextBox";
            this.dolzhnostTextBox.Size = new System.Drawing.Size(149, 22);
            this.dolzhnostTextBox.TabIndex = 12;
            // 
            // id_filialaLabel
            // 
            id_filialaLabel.AutoSize = true;
            id_filialaLabel.Location = new System.Drawing.Point(14, 257);
            id_filialaLabel.Name = "id_filialaLabel";
            id_filialaLabel.Size = new System.Drawing.Size(115, 16);
            id_filialaLabel.TabIndex = 13;
            id_filialaLabel.Text = "Номер филиала:";
            // 
            // id_filialaComboBox
            // 
            this.id_filialaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rabotnikiBindingSource, "id_filiala", true));
            this.id_filialaComboBox.DataSource = this.filialBindingSource;
            this.id_filialaComboBox.DisplayMember = "id_filial";
            this.id_filialaComboBox.FormattingEnabled = true;
            this.id_filialaComboBox.Location = new System.Drawing.Point(151, 249);
            this.id_filialaComboBox.Name = "id_filialaComboBox";
            this.id_filialaComboBox.Size = new System.Drawing.Size(201, 24);
            this.id_filialaComboBox.TabIndex = 14;
            // 
            // filialBindingSource
            // 
            this.filialBindingSource.DataMember = "Filial";
            this.filialBindingSource.DataSource = this.avtoservisDataSet;
            // 
            // filialTableAdapter
            // 
            this.filialTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(385, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_filialaLabel);
            this.Controls.Add(this.id_filialaComboBox);
            this.Controls.Add(dolzhnostLabel);
            this.Controls.Add(this.dolzhnostTextBox);
            this.Controls.Add(stazhLabel);
            this.Controls.Add(this.stazhTextBox);
            this.Controls.Add(date_rLabel);
            this.Controls.Add(this.date_rDateTimePicker);
            this.Controls.Add(otLabel);
            this.Controls.Add(this.otTextBox);
            this.Controls.Add(imLabel);
            this.Controls.Add(this.imTextBox);
            this.Controls.Add(famLabel);
            this.Controls.Add(this.famTextBox);
            this.Controls.Add(this.rabotnikiBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F11";
            this.Text = "Добавление сотрудника";
            this.Load += new System.EventHandler(this.F11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avtoservisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotnikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotnikiBindingNavigator)).EndInit();
            this.rabotnikiBindingNavigator.ResumeLayout(false);
            this.rabotnikiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AvtoservisDataSet avtoservisDataSet;
        private System.Windows.Forms.BindingSource rabotnikiBindingSource;
        private AvtoservisDataSetTableAdapters.RabotnikiTableAdapter rabotnikiTableAdapter;
        private AvtoservisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rabotnikiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rabotnikiBindingNavigatorSaveItem;
        private AvtoservisDataSetTableAdapters.FilialTableAdapter filialTableAdapter;
        private System.Windows.Forms.TextBox famTextBox;
        private System.Windows.Forms.TextBox imTextBox;
        private System.Windows.Forms.TextBox otTextBox;
        private System.Windows.Forms.DateTimePicker date_rDateTimePicker;
        private System.Windows.Forms.TextBox stazhTextBox;
        private System.Windows.Forms.TextBox dolzhnostTextBox;
        private System.Windows.Forms.ComboBox id_filialaComboBox;
        private System.Windows.Forms.BindingSource filialBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}