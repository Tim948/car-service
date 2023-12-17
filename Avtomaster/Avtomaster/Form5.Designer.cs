namespace Avtomaster
{
    partial class F5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F5));
            System.Windows.Forms.Label markaLabel;
            System.Windows.Forms.Label godLabel;
            System.Windows.Forms.Label kuzovLabel;
            System.Windows.Forms.Label id_klientLabel;
            this.avtoservisDataSet = new Avtomaster.AvtoservisDataSet();
            this.avtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtoTableAdapter = new Avtomaster.AvtoservisDataSetTableAdapters.AvtoTableAdapter();
            this.tableAdapterManager = new Avtomaster.AvtoservisDataSetTableAdapters.TableAdapterManager();
            this.avtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.avtoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.markaTextBox = new System.Windows.Forms.TextBox();
            this.godTextBox = new System.Windows.Forms.TextBox();
            this.kuzovTextBox = new System.Windows.Forms.TextBox();
            this.id_klientComboBox = new System.Windows.Forms.ComboBox();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientTableAdapter = new Avtomaster.AvtoservisDataSetTableAdapters.KlientTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            markaLabel = new System.Windows.Forms.Label();
            godLabel = new System.Windows.Forms.Label();
            kuzovLabel = new System.Windows.Forms.Label();
            id_klientLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avtoservisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingNavigator)).BeginInit();
            this.avtoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // avtoservisDataSet
            // 
            this.avtoservisDataSet.DataSetName = "AvtoservisDataSet";
            this.avtoservisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avtoBindingSource
            // 
            this.avtoBindingSource.DataMember = "Avto";
            this.avtoBindingSource.DataSource = this.avtoservisDataSet;
            // 
            // avtoTableAdapter
            // 
            this.avtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvtoTableAdapter = this.avtoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilialTableAdapter = null;
            this.tableAdapterManager.KlientTableAdapter = this.klientTableAdapter;
            this.tableAdapterManager.RabotnikiTableAdapter = null;
            this.tableAdapterManager.Spec_po_remontuTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Avtomaster.AvtoservisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZayavkiTableAdapter = null;
            // 
            // avtoBindingNavigator
            // 
            this.avtoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.avtoBindingNavigator.BindingSource = this.avtoBindingSource;
            this.avtoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.avtoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.avtoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.avtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.avtoBindingNavigatorSaveItem});
            this.avtoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.avtoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.avtoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.avtoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.avtoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.avtoBindingNavigator.Name = "avtoBindingNavigator";
            this.avtoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.avtoBindingNavigator.Size = new System.Drawing.Size(357, 31);
            this.avtoBindingNavigator.TabIndex = 0;
            this.avtoBindingNavigator.Text = "bindingNavigator1";
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
            // avtoBindingNavigatorSaveItem
            // 
            this.avtoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.avtoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("avtoBindingNavigatorSaveItem.Image")));
            this.avtoBindingNavigatorSaveItem.Name = "avtoBindingNavigatorSaveItem";
            this.avtoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.avtoBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.avtoBindingNavigatorSaveItem.Click += new System.EventHandler(this.avtoBindingNavigatorSaveItem_Click);
            // 
            // markaLabel
            // 
            markaLabel.AutoSize = true;
            markaLabel.Location = new System.Drawing.Point(28, 102);
            markaLabel.Name = "markaLabel";
            markaLabel.Size = new System.Drawing.Size(134, 16);
            markaLabel.TabIndex = 3;
            markaLabel.Text = "Марка автомобиля:";
            // 
            // markaTextBox
            // 
            this.markaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avtoBindingSource, "Marka", true));
            this.markaTextBox.Location = new System.Drawing.Point(174, 102);
            this.markaTextBox.Name = "markaTextBox";
            this.markaTextBox.Size = new System.Drawing.Size(133, 22);
            this.markaTextBox.TabIndex = 4;
            // 
            // godLabel
            // 
            godLabel.AutoSize = true;
            godLabel.Location = new System.Drawing.Point(28, 138);
            godLabel.Name = "godLabel";
            godLabel.Size = new System.Drawing.Size(130, 16);
            godLabel.TabIndex = 5;
            godLabel.Text = "Год производства:";
            // 
            // godTextBox
            // 
            this.godTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avtoBindingSource, "God", true));
            this.godTextBox.Location = new System.Drawing.Point(174, 138);
            this.godTextBox.Name = "godTextBox";
            this.godTextBox.Size = new System.Drawing.Size(133, 22);
            this.godTextBox.TabIndex = 6;
            // 
            // kuzovLabel
            // 
            kuzovLabel.AutoSize = true;
            kuzovLabel.Location = new System.Drawing.Point(28, 173);
            kuzovLabel.Name = "kuzovLabel";
            kuzovLabel.Size = new System.Drawing.Size(50, 16);
            kuzovLabel.TabIndex = 7;
            kuzovLabel.Text = "Кузов:";
            // 
            // kuzovTextBox
            // 
            this.kuzovTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avtoBindingSource, "Kuzov", true));
            this.kuzovTextBox.Location = new System.Drawing.Point(174, 173);
            this.kuzovTextBox.Name = "kuzovTextBox";
            this.kuzovTextBox.Size = new System.Drawing.Size(133, 22);
            this.kuzovTextBox.TabIndex = 8;
            // 
            // id_klientLabel
            // 
            id_klientLabel.AutoSize = true;
            id_klientLabel.Location = new System.Drawing.Point(28, 64);
            id_klientLabel.Name = "id_klientLabel";
            id_klientLabel.Size = new System.Drawing.Size(110, 16);
            id_klientLabel.TabIndex = 8;
            id_klientLabel.Text = "Номер клиента:";
            // 
            // id_klientComboBox
            // 
            this.id_klientComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avtoBindingSource, "Id_klient", true));
            this.id_klientComboBox.DataSource = this.klientBindingSource;
            this.id_klientComboBox.DisplayMember = "Id_klient";
            this.id_klientComboBox.FormattingEnabled = true;
            this.id_klientComboBox.Location = new System.Drawing.Point(174, 64);
            this.id_klientComboBox.Name = "id_klientComboBox";
            this.id_klientComboBox.Size = new System.Drawing.Size(133, 24);
            this.id_klientComboBox.TabIndex = 9;
            this.id_klientComboBox.SelectedIndexChanged += new System.EventHandler(this.id_klientComboBox_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 27);
            this.button1.TabIndex = 23;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(357, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_klientLabel);
            this.Controls.Add(this.id_klientComboBox);
            this.Controls.Add(kuzovLabel);
            this.Controls.Add(this.kuzovTextBox);
            this.Controls.Add(godLabel);
            this.Controls.Add(this.godTextBox);
            this.Controls.Add(markaLabel);
            this.Controls.Add(this.markaTextBox);
            this.Controls.Add(this.avtoBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F5";
            this.Text = "Добавление автомабиля";
            this.Load += new System.EventHandler(this.F5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avtoservisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingNavigator)).EndInit();
            this.avtoBindingNavigator.ResumeLayout(false);
            this.avtoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AvtoservisDataSet avtoservisDataSet;
        private System.Windows.Forms.BindingSource avtoBindingSource;
        private AvtoservisDataSetTableAdapters.AvtoTableAdapter avtoTableAdapter;
        private AvtoservisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator avtoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton avtoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox markaTextBox;
        private System.Windows.Forms.TextBox godTextBox;
        private System.Windows.Forms.TextBox kuzovTextBox;
        private System.Windows.Forms.ComboBox id_klientComboBox;
        private AvtoservisDataSetTableAdapters.KlientTableAdapter klientTableAdapter;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}