namespace Avtomaster
{
    partial class F9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F9));
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label remontLabel;
            System.Windows.Forms.Label id_rabotnikaLabel;
            this.avtoservisDataSet = new Avtomaster.AvtoservisDataSet();
            this.spec_po_remontuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spec_po_remontuTableAdapter = new Avtomaster.AvtoservisDataSetTableAdapters.Spec_po_remontuTableAdapter();
            this.tableAdapterManager = new Avtomaster.AvtoservisDataSetTableAdapters.TableAdapterManager();
            this.spec_po_remontuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.spec_po_remontuBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.remontTextBox = new System.Windows.Forms.TextBox();
            this.id_rabotnikaComboBox = new System.Windows.Forms.ComboBox();
            this.rabotnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rabotnikiTableAdapter = new Avtomaster.AvtoservisDataSetTableAdapters.RabotnikiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            dateLabel = new System.Windows.Forms.Label();
            remontLabel = new System.Windows.Forms.Label();
            id_rabotnikaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avtoservisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spec_po_remontuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spec_po_remontuBindingNavigator)).BeginInit();
            this.spec_po_remontuBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rabotnikiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // avtoservisDataSet
            // 
            this.avtoservisDataSet.DataSetName = "AvtoservisDataSet";
            this.avtoservisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spec_po_remontuBindingSource
            // 
            this.spec_po_remontuBindingSource.DataMember = "Spec_po_remontu";
            this.spec_po_remontuBindingSource.DataSource = this.avtoservisDataSet;
            // 
            // spec_po_remontuTableAdapter
            // 
            this.spec_po_remontuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvtoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilialTableAdapter = null;
            this.tableAdapterManager.KlientTableAdapter = null;
            this.tableAdapterManager.RabotnikiTableAdapter = this.rabotnikiTableAdapter;
            this.tableAdapterManager.Spec_po_remontuTableAdapter = this.spec_po_remontuTableAdapter;
            this.tableAdapterManager.UpdateOrder = Avtomaster.AvtoservisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZayavkiTableAdapter = null;
            // 
            // spec_po_remontuBindingNavigator
            // 
            this.spec_po_remontuBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.spec_po_remontuBindingNavigator.BindingSource = this.spec_po_remontuBindingSource;
            this.spec_po_remontuBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.spec_po_remontuBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.spec_po_remontuBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.spec_po_remontuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.spec_po_remontuBindingNavigatorSaveItem});
            this.spec_po_remontuBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.spec_po_remontuBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.spec_po_remontuBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.spec_po_remontuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.spec_po_remontuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.spec_po_remontuBindingNavigator.Name = "spec_po_remontuBindingNavigator";
            this.spec_po_remontuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.spec_po_remontuBindingNavigator.Size = new System.Drawing.Size(364, 31);
            this.spec_po_remontuBindingNavigator.TabIndex = 0;
            this.spec_po_remontuBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
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
            // spec_po_remontuBindingNavigatorSaveItem
            // 
            this.spec_po_remontuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.spec_po_remontuBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("spec_po_remontuBindingNavigatorSaveItem.Image")));
            this.spec_po_remontuBindingNavigatorSaveItem.Name = "spec_po_remontuBindingNavigatorSaveItem";
            this.spec_po_remontuBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.spec_po_remontuBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.spec_po_remontuBindingNavigatorSaveItem.Click += new System.EventHandler(this.spec_po_remontuBindingNavigatorSaveItem_Click);
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 59);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(42, 16);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Дата:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.spec_po_remontuBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(69, 54);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(218, 22);
            this.dateDateTimePicker.TabIndex = 2;
            // 
            // remontLabel
            // 
            remontLabel.AutoSize = true;
            remontLabel.Location = new System.Drawing.Point(12, 97);
            remontLabel.Name = "remontLabel";
            remontLabel.Size = new System.Drawing.Size(59, 16);
            remontLabel.TabIndex = 3;
            remontLabel.Text = "Ремонт:";
            // 
            // remontTextBox
            // 
            this.remontTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spec_po_remontuBindingSource, "Remont", true));
            this.remontTextBox.Location = new System.Drawing.Point(90, 97);
            this.remontTextBox.Name = "remontTextBox";
            this.remontTextBox.Size = new System.Drawing.Size(197, 22);
            this.remontTextBox.TabIndex = 4;
            // 
            // id_rabotnikaLabel
            // 
            id_rabotnikaLabel.AutoSize = true;
            id_rabotnikaLabel.Location = new System.Drawing.Point(12, 137);
            id_rabotnikaLabel.Name = "id_rabotnikaLabel";
            id_rabotnikaLabel.Size = new System.Drawing.Size(126, 16);
            id_rabotnikaLabel.TabIndex = 5;
            id_rabotnikaLabel.Text = "Номер работника:";
            // 
            // id_rabotnikaComboBox
            // 
            this.id_rabotnikaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spec_po_remontuBindingSource, "Id_rabotnika", true));
            this.id_rabotnikaComboBox.DataSource = this.rabotnikiBindingSource;
            this.id_rabotnikaComboBox.DisplayMember = "Id_rabotnika";
            this.id_rabotnikaComboBox.FormattingEnabled = true;
            this.id_rabotnikaComboBox.Location = new System.Drawing.Point(148, 137);
            this.id_rabotnikaComboBox.Name = "id_rabotnikaComboBox";
            this.id_rabotnikaComboBox.Size = new System.Drawing.Size(139, 24);
            this.id_rabotnikaComboBox.TabIndex = 6;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(364, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_rabotnikaLabel);
            this.Controls.Add(this.id_rabotnikaComboBox);
            this.Controls.Add(remontLabel);
            this.Controls.Add(this.remontTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.spec_po_remontuBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F9";
            this.Text = "Добавление в архив";
            this.Load += new System.EventHandler(this.F9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avtoservisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spec_po_remontuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spec_po_remontuBindingNavigator)).EndInit();
            this.spec_po_remontuBindingNavigator.ResumeLayout(false);
            this.spec_po_remontuBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rabotnikiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AvtoservisDataSet avtoservisDataSet;
        private System.Windows.Forms.BindingSource spec_po_remontuBindingSource;
        private AvtoservisDataSetTableAdapters.Spec_po_remontuTableAdapter spec_po_remontuTableAdapter;
        private AvtoservisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator spec_po_remontuBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton spec_po_remontuBindingNavigatorSaveItem;
        private AvtoservisDataSetTableAdapters.RabotnikiTableAdapter rabotnikiTableAdapter;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox remontTextBox;
        private System.Windows.Forms.ComboBox id_rabotnikaComboBox;
        private System.Windows.Forms.BindingSource rabotnikiBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}