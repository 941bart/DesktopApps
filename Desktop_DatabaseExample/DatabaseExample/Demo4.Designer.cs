namespace DatabaseExample
{
    partial class frmDemo4
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
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsDatabaseDataSetSQLQueries = new DatabaseExample.CarsDatabaseDataSetSQLQueries();
            this.btnFillByAutomaticTransmissionTrue = new System.Windows.Forms.Button();
            this.btnFillByColorLikeWh = new System.Windows.Forms.Button();
            this.btnFillByHorsePowerDescending = new System.Windows.Forms.Button();
            this.btnFillByPriceDESC = new System.Windows.Forms.Button();
            this.btnFillByPriceASC = new System.Windows.Forms.Button();
            this.btnAverageCarPrice = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchMake = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnShowAllItems = new System.Windows.Forms.Button();
            this.tableTableAdapter = new DatabaseExample.CarsDatabaseDataSetSQLQueriesTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new DatabaseExample.CarsDatabaseDataSetSQLQueriesTableAdapters.TableAdapterManager();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDatabaseDataSetSQLQueries)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AllowUserToAddRows = false;
            this.tableDataGridView.AllowUserToDeleteRows = false;
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(7, 12);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.ReadOnly = true;
            this.tableDataGridView.Size = new System.Drawing.Size(849, 251);
            this.tableDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Make";
            this.dataGridViewTextBoxColumn1.HeaderText = "Make";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn2.HeaderText = "Model";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn4.HeaderText = "Color";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Automatic Transmission";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Automatic Transmission";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MPG";
            this.dataGridViewTextBoxColumn5.HeaderText = "MPG";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Horse power ";
            this.dataGridViewTextBoxColumn6.HeaderText = "Horse power ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Number of cylinders";
            this.dataGridViewTextBoxColumn7.HeaderText = "Number of cylinders";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.carsDatabaseDataSetSQLQueries;
            // 
            // carsDatabaseDataSetSQLQueries
            // 
            this.carsDatabaseDataSetSQLQueries.DataSetName = "CarsDatabaseDataSetSQLQueries";
            this.carsDatabaseDataSetSQLQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFillByAutomaticTransmissionTrue
            // 
            this.btnFillByAutomaticTransmissionTrue.Location = new System.Drawing.Point(205, 285);
            this.btnFillByAutomaticTransmissionTrue.Name = "btnFillByAutomaticTransmissionTrue";
            this.btnFillByAutomaticTransmissionTrue.Size = new System.Drawing.Size(187, 23);
            this.btnFillByAutomaticTransmissionTrue.TabIndex = 2;
            this.btnFillByAutomaticTransmissionTrue.Text = "FillByAutomaticTransmissionTrue";
            this.btnFillByAutomaticTransmissionTrue.UseVisualStyleBackColor = true;
            this.btnFillByAutomaticTransmissionTrue.Click += new System.EventHandler(this.btnFillByAutomaticTransmissionTrue_Click);
            // 
            // btnFillByColorLikeWh
            // 
            this.btnFillByColorLikeWh.Location = new System.Drawing.Point(205, 314);
            this.btnFillByColorLikeWh.Name = "btnFillByColorLikeWh";
            this.btnFillByColorLikeWh.Size = new System.Drawing.Size(187, 23);
            this.btnFillByColorLikeWh.TabIndex = 3;
            this.btnFillByColorLikeWh.Text = "FillByColorLikeWh";
            this.btnFillByColorLikeWh.UseVisualStyleBackColor = true;
            this.btnFillByColorLikeWh.Click += new System.EventHandler(this.btnFillByColorLikeWh_Click);
            // 
            // btnFillByHorsePowerDescending
            // 
            this.btnFillByHorsePowerDescending.Location = new System.Drawing.Point(398, 285);
            this.btnFillByHorsePowerDescending.Name = "btnFillByHorsePowerDescending";
            this.btnFillByHorsePowerDescending.Size = new System.Drawing.Size(187, 23);
            this.btnFillByHorsePowerDescending.TabIndex = 4;
            this.btnFillByHorsePowerDescending.Text = "FillByHorsePowerDescending";
            this.btnFillByHorsePowerDescending.UseVisualStyleBackColor = true;
            this.btnFillByHorsePowerDescending.Click += new System.EventHandler(this.btnFillByHorsePowerDescending_Click);
            // 
            // btnFillByPriceDESC
            // 
            this.btnFillByPriceDESC.Location = new System.Drawing.Point(12, 314);
            this.btnFillByPriceDESC.Name = "btnFillByPriceDESC";
            this.btnFillByPriceDESC.Size = new System.Drawing.Size(187, 23);
            this.btnFillByPriceDESC.TabIndex = 6;
            this.btnFillByPriceDESC.Text = "FillByPriceDescending";
            this.btnFillByPriceDESC.UseVisualStyleBackColor = true;
            this.btnFillByPriceDESC.Click += new System.EventHandler(this.btnFillByPriceDESC_Click);
            // 
            // btnFillByPriceASC
            // 
            this.btnFillByPriceASC.Location = new System.Drawing.Point(12, 285);
            this.btnFillByPriceASC.Name = "btnFillByPriceASC";
            this.btnFillByPriceASC.Size = new System.Drawing.Size(187, 23);
            this.btnFillByPriceASC.TabIndex = 7;
            this.btnFillByPriceASC.Text = "FillByPriceAscending";
            this.btnFillByPriceASC.UseVisualStyleBackColor = true;
            this.btnFillByPriceASC.Click += new System.EventHandler(this.btnFillByPriceASC_Click);
            // 
            // btnAverageCarPrice
            // 
            this.btnAverageCarPrice.Location = new System.Drawing.Point(398, 314);
            this.btnAverageCarPrice.Name = "btnAverageCarPrice";
            this.btnAverageCarPrice.Size = new System.Drawing.Size(187, 23);
            this.btnAverageCarPrice.TabIndex = 8;
            this.btnAverageCarPrice.Text = "Average Price of All Cars";
            this.btnAverageCarPrice.UseVisualStyleBackColor = true;
            this.btnAverageCarPrice.Click += new System.EventHandler(this.btnAverageCarPrice_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchMake);
            this.groupBox1.Controls.Add(this.txtBoxSearch);
            this.groupBox1.Location = new System.Drawing.Point(602, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 79);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Car Make";
            // 
            // btnSearchMake
            // 
            this.btnSearchMake.Location = new System.Drawing.Point(21, 45);
            this.btnSearchMake.Name = "btnSearchMake";
            this.btnSearchMake.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMake.TabIndex = 1;
            this.btnSearchMake.Text = "Search";
            this.btnSearchMake.UseVisualStyleBackColor = true;
            this.btnSearchMake.Click += new System.EventHandler(this.btnSearchMake_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(6, 19);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSearch.TabIndex = 0;
            // 
            // btnShowAllItems
            // 
            this.btnShowAllItems.Location = new System.Drawing.Point(723, 299);
            this.btnShowAllItems.Name = "btnShowAllItems";
            this.btnShowAllItems.Size = new System.Drawing.Size(81, 52);
            this.btnShowAllItems.TabIndex = 2;
            this.btnShowAllItems.Text = "Show All Items";
            this.btnShowAllItems.UseVisualStyleBackColor = true;
            this.btnShowAllItems.Click += new System.EventHandler(this.btnShowAllItems_Click);
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = DatabaseExample.CarsDatabaseDataSetSQLQueriesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(454, 429);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(373, 429);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 23;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // frmDemo4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 488);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnShowAllItems);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAverageCarPrice);
            this.Controls.Add(this.btnFillByPriceASC);
            this.Controls.Add(this.btnFillByPriceDESC);
            this.Controls.Add(this.btnFillByHorsePowerDescending);
            this.Controls.Add(this.btnFillByColorLikeWh);
            this.Controls.Add(this.btnFillByAutomaticTransmissionTrue);
            this.Controls.Add(this.tableDataGridView);
            this.Name = "frmDemo4";
            this.Text = "Demo4: SQL Queries";
            this.Load += new System.EventHandler(this.Demo4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDatabaseDataSetSQLQueries)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CarsDatabaseDataSetSQLQueries carsDatabaseDataSetSQLQueries;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private CarsDatabaseDataSetSQLQueriesTableAdapters.TableTableAdapter tableTableAdapter;
        private CarsDatabaseDataSetSQLQueriesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnFillByAutomaticTransmissionTrue;
        private System.Windows.Forms.Button btnFillByColorLikeWh;
        private System.Windows.Forms.Button btnFillByHorsePowerDescending;
        private System.Windows.Forms.Button btnFillByPriceDESC;
        private System.Windows.Forms.Button btnFillByPriceASC;
        private System.Windows.Forms.Button btnAverageCarPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchMake;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnShowAllItems;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGoBack;
    }
}