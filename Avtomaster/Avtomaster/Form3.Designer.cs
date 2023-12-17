namespace Avtomaster
{
    partial class F3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F3));
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label imLabel;
            System.Windows.Forms.Label otLabel;
            System.Windows.Forms.Label data_rLabel;
            System.Windows.Forms.Label skidkaLabel;
            System.Windows.Forms.Label telefonLabel;
            this.avtoservisDataSet = new Avtomaster.AvtoservisDataSet();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientTableAdapter = new Avtomaster.AvtoservisDataSetTableAdapters.KlientTableAdapter();
            this.tableAdapterManager = new Avtomaster.AvtoservisDataSetTableAdapters.TableAdapterManager();
            this.klientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.klientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.famTextBox = new System.Windows.Forms.TextBox();
            this.imTextBox = new System.Windows.Forms.TextBox();
            this.otTextBox = new System.Windows.Forms.TextBox();
            this.data_rDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.skidkaTextBox = new System.Windows.Forms.TextBox();
            this.telefonMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            famLabel = new System.Windows.Forms.Label();
            imLabel = new System.Windows.Forms.Label();
            otLabel = new System.Windows.Forms.Label();
            data_rLabel = new System.Windows.Forms.Label();
            skidkaLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avtoservisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingNavigator)).BeginInit();
            this.klientBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // avtoservisDataSet
            // 
            this.avtoservisDataSet.DataSetName = "AvtoservisDataSet";
            this.avtoservisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvtoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilialTableAdapter = null;
            this.tableAdapterManager.KlientTableAdapter = this.klientTableAdapter;
            this.tableAdapterManager.RabotnikiTableAdapter = null;
            this.tableAdapterManager.Spec_po_remontuTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Avtomaster.AvtoservisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZayavkiTableAdapter = null;
            // 
            // klientBindingNavigator
            // 
            this.klientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.klientBindingNavigator.BindingSource = this.klientBindingSource;
            this.klientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.klientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.klientBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.klientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.klientBindingNavigatorSaveItem});
            this.klientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.klientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.klientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.klientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.klientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.klientBindingNavigator.Name = "klientBindingNavigator";
            this.klientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.klientBindingNavigator.Size = new System.Drawing.Size(356, 31);
            this.klientBindingNavigator.TabIndex = 0;
            this.klientBindingNavigator.Text = "bindingNavigator1";
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
            // klientBindingNavigatorSaveItem
            // 
            this.klientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.klientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("klientBindingNavigatorSaveItem.Image")));
            this.klientBindingNavigatorSaveItem.Name = "klientBindingNavigatorSaveItem";
            this.klientBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.klientBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.klientBindingNavigatorSaveItem.Click += new System.EventHandler(this.klientBindingNavigatorSaveItem_Click);
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(12, 48);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(69, 16);
            famLabel.TabIndex = 1;
            famLabel.Text = "Фамилия:";
            // 
            // famTextBox
            // 
            this.famTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "fam", true));
            this.famTextBox.Location = new System.Drawing.Point(119, 48);
            this.famTextBox.Name = "famTextBox";
            this.famTextBox.Size = new System.Drawing.Size(217, 22);
            this.famTextBox.TabIndex = 2;
            this.famTextBox.TextChanged += new System.EventHandler(this.famTextBox_TextChanged);
            // 
            // imLabel
            // 
            imLabel.AutoSize = true;
            imLabel.Location = new System.Drawing.Point(12, 79);
            imLabel.Name = "imLabel";
            imLabel.Size = new System.Drawing.Size(36, 16);
            imLabel.TabIndex = 3;
            imLabel.Text = "Имя:";
            // 
            // imTextBox
            // 
            this.imTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "Im", true));
            this.imTextBox.Location = new System.Drawing.Point(119, 79);
            this.imTextBox.Name = "imTextBox";
            this.imTextBox.Size = new System.Drawing.Size(217, 22);
            this.imTextBox.TabIndex = 4;
            // 
            // otLabel
            // 
            otLabel.AutoSize = true;
            otLabel.Location = new System.Drawing.Point(12, 117);
            otLabel.Name = "otLabel";
            otLabel.Size = new System.Drawing.Size(73, 16);
            otLabel.TabIndex = 5;
            otLabel.Text = "Отчество:";
            // 
            // otTextBox
            // 
            this.otTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "Ot", true));
            this.otTextBox.Location = new System.Drawing.Point(119, 117);
            this.otTextBox.Name = "otTextBox";
            this.otTextBox.Size = new System.Drawing.Size(217, 22);
            this.otTextBox.TabIndex = 6;
            // 
            // data_rLabel
            // 
            data_rLabel.AutoSize = true;
            data_rLabel.Location = new System.Drawing.Point(12, 156);
            data_rLabel.Name = "data_rLabel";
            data_rLabel.Size = new System.Drawing.Size(109, 16);
            data_rLabel.TabIndex = 7;
            data_rLabel.Text = "Дата рождения:";
            // 
            // data_rDateTimePicker
            // 
            this.data_rDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.klientBindingSource, "Data_r", true));
            this.data_rDateTimePicker.Location = new System.Drawing.Point(136, 151);
            this.data_rDateTimePicker.Name = "data_rDateTimePicker";
            this.data_rDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.data_rDateTimePicker.TabIndex = 8;
            // 
            // skidkaLabel
            // 
            skidkaLabel.AutoSize = true;
            skidkaLabel.Location = new System.Drawing.Point(12, 222);
            skidkaLabel.Name = "skidkaLabel";
            skidkaLabel.Size = new System.Drawing.Size(57, 16);
            skidkaLabel.TabIndex = 11;
            skidkaLabel.Text = "Скидка:";
            // 
            // skidkaTextBox
            // 
            this.skidkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "Skidka", true));
            this.skidkaTextBox.Location = new System.Drawing.Point(119, 222);
            this.skidkaTextBox.Name = "skidkaTextBox";
            this.skidkaTextBox.Size = new System.Drawing.Size(217, 22);
            this.skidkaTextBox.TabIndex = 12;
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(12, 190);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(70, 16);
            telefonLabel.TabIndex = 12;
            telefonLabel.Text = "Телефон:";
            // 
            // telefonMaskedTextBox
            // 
            this.telefonMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "Telefon", true));
            this.telefonMaskedTextBox.Location = new System.Drawing.Point(119, 187);
            this.telefonMaskedTextBox.Mask = "00000000000";
            this.telefonMaskedTextBox.Name = "telefonMaskedTextBox";
            this.telefonMaskedTextBox.Size = new System.Drawing.Size(217, 22);
            this.telefonMaskedTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 27);
            this.button1.TabIndex = 21;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(356, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonMaskedTextBox);
            this.Controls.Add(skidkaLabel);
            this.Controls.Add(this.skidkaTextBox);
            this.Controls.Add(data_rLabel);
            this.Controls.Add(this.data_rDateTimePicker);
            this.Controls.Add(otLabel);
            this.Controls.Add(this.otTextBox);
            this.Controls.Add(imLabel);
            this.Controls.Add(this.imTextBox);
            this.Controls.Add(famLabel);
            this.Controls.Add(this.famTextBox);
            this.Controls.Add(this.klientBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F3";
            this.Text = "Добавление клиента";
            this.Load += new System.EventHandler(this.F3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avtoservisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingNavigator)).EndInit();
            this.klientBindingNavigator.ResumeLayout(false);
            this.klientBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AvtoservisDataSet avtoservisDataSet;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private AvtoservisDataSetTableAdapters.KlientTableAdapter klientTableAdapter;
        private AvtoservisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator klientBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton klientBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox famTextBox;
        private System.Windows.Forms.TextBox imTextBox;
        private System.Windows.Forms.TextBox otTextBox;
        private System.Windows.Forms.DateTimePicker data_rDateTimePicker;
        private System.Windows.Forms.TextBox skidkaTextBox;
        private System.Windows.Forms.MaskedTextBox telefonMaskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}