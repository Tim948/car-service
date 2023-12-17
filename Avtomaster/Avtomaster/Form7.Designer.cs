namespace Avtomaster
{
    partial class F7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F7));
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label nomer_klientaLabel;
            System.Windows.Forms.Label srokLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label komentLabel;
            System.Windows.Forms.Label id_rabotnikLabel;
            this.avtoservisDataSet = new Avtomaster.AvtoservisDataSet();
            this.zayavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zayavkiTableAdapter = new Avtomaster.AvtoservisDataSetTableAdapters.ZayavkiTableAdapter();
            this.tableAdapterManager = new Avtomaster.AvtoservisDataSetTableAdapters.TableAdapterManager();
            this.zayavkiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.zayavkiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.srokTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.komentTextBox = new System.Windows.Forms.TextBox();
            this.id_rabotnikComboBox = new System.Windows.Forms.ComboBox();
            this.nomer_klientaComboBox = new System.Windows.Forms.ComboBox();
            this.avtoservisDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientTableAdapter = new Avtomaster.AvtoservisDataSetTableAdapters.KlientTableAdapter();
            this.rabotnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rabotnikiTableAdapter = new Avtomaster.AvtoservisDataSetTableAdapters.RabotnikiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            dateLabel = new System.Windows.Forms.Label();
            nomer_klientaLabel = new System.Windows.Forms.Label();
            srokLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            komentLabel = new System.Windows.Forms.Label();
            id_rabotnikLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avtoservisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavkiBindingNavigator)).BeginInit();
            this.zayavkiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avtoservisDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotnikiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // avtoservisDataSet
            // 
            this.avtoservisDataSet.DataSetName = "AvtoservisDataSet";
            this.avtoservisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zayavkiBindingSource
            // 
            this.zayavkiBindingSource.DataMember = "Zayavki";
            this.zayavkiBindingSource.DataSource = this.avtoservisDataSet;
            // 
            // zayavkiTableAdapter
            // 
            this.zayavkiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvtoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilialTableAdapter = null;
            this.tableAdapterManager.KlientTableAdapter = this.klientTableAdapter;
            this.tableAdapterManager.RabotnikiTableAdapter = this.rabotnikiTableAdapter;
            this.tableAdapterManager.Spec_po_remontuTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Avtomaster.AvtoservisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZayavkiTableAdapter = this.zayavkiTableAdapter;
            // 
            // zayavkiBindingNavigator
            // 
            this.zayavkiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.zayavkiBindingNavigator.BindingSource = this.zayavkiBindingSource;
            this.zayavkiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zayavkiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zayavkiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.zayavkiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.zayavkiBindingNavigatorSaveItem});
            this.zayavkiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.zayavkiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zayavkiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zayavkiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zayavkiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zayavkiBindingNavigator.Name = "zayavkiBindingNavigator";
            this.zayavkiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.zayavkiBindingNavigator.Size = new System.Drawing.Size(358, 31);
            this.zayavkiBindingNavigator.TabIndex = 0;
            this.zayavkiBindingNavigator.Text = "bindingNavigator1";
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
            // zayavkiBindingNavigatorSaveItem
            // 
            this.zayavkiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zayavkiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("zayavkiBindingNavigatorSaveItem.Image")));
            this.zayavkiBindingNavigatorSaveItem.Name = "zayavkiBindingNavigatorSaveItem";
            this.zayavkiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.zayavkiBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.zayavkiBindingNavigatorSaveItem.Click += new System.EventHandler(this.zayavkiBindingNavigatorSaveItem_Click);
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 53);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(42, 16);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Дата:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zayavkiBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(81, 53);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateDateTimePicker.TabIndex = 2;
            // 
            // nomer_klientaLabel
            // 
            nomer_klientaLabel.AutoSize = true;
            nomer_klientaLabel.Location = new System.Drawing.Point(12, 94);
            nomer_klientaLabel.Name = "nomer_klientaLabel";
            nomer_klientaLabel.Size = new System.Drawing.Size(110, 16);
            nomer_klientaLabel.TabIndex = 3;
            nomer_klientaLabel.Text = "Номер клиента:";
            // 
            // srokLabel
            // 
            srokLabel.AutoSize = true;
            srokLabel.Location = new System.Drawing.Point(12, 134);
            srokLabel.Name = "srokLabel";
            srokLabel.Size = new System.Drawing.Size(42, 16);
            srokLabel.TabIndex = 5;
            srokLabel.Text = "Срок:";
            // 
            // srokTextBox
            // 
            this.srokTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zayavkiBindingSource, "Srok", true));
            this.srokTextBox.Location = new System.Drawing.Point(142, 134);
            this.srokTextBox.Name = "srokTextBox";
            this.srokTextBox.Size = new System.Drawing.Size(139, 22);
            this.srokTextBox.TabIndex = 6;
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(11, 170);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(43, 16);
            cenaLabel.TabIndex = 7;
            cenaLabel.Text = "Цена:";
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zayavkiBindingSource, "Cena", true));
            this.cenaTextBox.Location = new System.Drawing.Point(142, 170);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(139, 22);
            this.cenaTextBox.TabIndex = 8;
            // 
            // komentLabel
            // 
            komentLabel.AutoSize = true;
            komentLabel.Location = new System.Drawing.Point(11, 203);
            komentLabel.Name = "komentLabel";
            komentLabel.Size = new System.Drawing.Size(99, 16);
            komentLabel.TabIndex = 9;
            komentLabel.Text = "Комментарий:";
            // 
            // komentTextBox
            // 
            this.komentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zayavkiBindingSource, "koment", true));
            this.komentTextBox.Location = new System.Drawing.Point(142, 203);
            this.komentTextBox.Name = "komentTextBox";
            this.komentTextBox.Size = new System.Drawing.Size(139, 22);
            this.komentTextBox.TabIndex = 10;
            // 
            // id_rabotnikLabel
            // 
            id_rabotnikLabel.AutoSize = true;
            id_rabotnikLabel.Location = new System.Drawing.Point(10, 238);
            id_rabotnikLabel.Name = "id_rabotnikLabel";
            id_rabotnikLabel.Size = new System.Drawing.Size(126, 16);
            id_rabotnikLabel.TabIndex = 11;
            id_rabotnikLabel.Text = "Номер работника:";
            // 
            // id_rabotnikComboBox
            // 
            this.id_rabotnikComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zayavkiBindingSource, "id_rabotnik", true));
            this.id_rabotnikComboBox.DataSource = this.rabotnikiBindingSource;
            this.id_rabotnikComboBox.DisplayMember = "Id_rabotnika";
            this.id_rabotnikComboBox.FormattingEnabled = true;
            this.id_rabotnikComboBox.Location = new System.Drawing.Point(142, 238);
            this.id_rabotnikComboBox.Name = "id_rabotnikComboBox";
            this.id_rabotnikComboBox.Size = new System.Drawing.Size(139, 24);
            this.id_rabotnikComboBox.TabIndex = 12;
            // 
            // nomer_klientaComboBox
            // 
            this.nomer_klientaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zayavkiBindingSource, "Nomer_klienta", true));
            this.nomer_klientaComboBox.DataSource = this.klientBindingSource;
            this.nomer_klientaComboBox.DisplayMember = "Id_klient";
            this.nomer_klientaComboBox.FormattingEnabled = true;
            this.nomer_klientaComboBox.Location = new System.Drawing.Point(142, 94);
            this.nomer_klientaComboBox.Name = "nomer_klientaComboBox";
            this.nomer_klientaComboBox.Size = new System.Drawing.Size(139, 24);
            this.nomer_klientaComboBox.TabIndex = 13;
            // 
            // avtoservisDataSetBindingSource
            // 
            this.avtoservisDataSetBindingSource.DataSource = this.avtoservisDataSet;
            this.avtoservisDataSetBindingSource.Position = 0;
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "Klient";
            this.klientBindingSource.DataSource = this.avtoservisDataSet;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
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
            this.label1.Location = new System.Drawing.Point(6, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(358, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nomer_klientaComboBox);
            this.Controls.Add(id_rabotnikLabel);
            this.Controls.Add(this.id_rabotnikComboBox);
            this.Controls.Add(komentLabel);
            this.Controls.Add(this.komentTextBox);
            this.Controls.Add(cenaLabel);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(srokLabel);
            this.Controls.Add(this.srokTextBox);
            this.Controls.Add(nomer_klientaLabel);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.zayavkiBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F7";
            this.Text = "Добавление заявки";
            this.Load += new System.EventHandler(this.F7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avtoservisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayavkiBindingNavigator)).EndInit();
            this.zayavkiBindingNavigator.ResumeLayout(false);
            this.zayavkiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avtoservisDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotnikiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AvtoservisDataSet avtoservisDataSet;
        private System.Windows.Forms.BindingSource zayavkiBindingSource;
        private AvtoservisDataSetTableAdapters.ZayavkiTableAdapter zayavkiTableAdapter;
        private AvtoservisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator zayavkiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton zayavkiBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private AvtoservisDataSetTableAdapters.KlientTableAdapter klientTableAdapter;
        private System.Windows.Forms.TextBox srokTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.TextBox komentTextBox;
        private System.Windows.Forms.ComboBox id_rabotnikComboBox;
        private System.Windows.Forms.ComboBox nomer_klientaComboBox;
        private System.Windows.Forms.BindingSource avtoservisDataSetBindingSource;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private AvtoservisDataSetTableAdapters.RabotnikiTableAdapter rabotnikiTableAdapter;
        private System.Windows.Forms.BindingSource rabotnikiBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}