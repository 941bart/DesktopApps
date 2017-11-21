namespace DatabaseExample
{
    partial class frmDemo3
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
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label automatic_TransmissionLabel;
            System.Windows.Forms.Label mPGLabel;
            System.Windows.Forms.Label horse_power_Label;
            System.Windows.Forms.Label number_of_cylindersLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vinListBox = new System.Windows.Forms.ListBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsDatabaseDataSet = new DatabaseExample.CarsDatabaseDataSet();
            this.tableTableAdapter = new DatabaseExample.CarsDatabaseDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new DatabaseExample.CarsDatabaseDataSetTableAdapters.TableAdapterManager();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.automatic_TransmissionCheckBox = new System.Windows.Forms.CheckBox();
            this.mPGTextBox = new System.Windows.Forms.TextBox();
            this.horse_power_TextBox = new System.Windows.Forms.TextBox();
            this.number_of_cylindersTextBox = new System.Windows.Forms.TextBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            makeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            automatic_TransmissionLabel = new System.Windows.Forms.Label();
            mPGLabel = new System.Windows.Forms.Label();
            horse_power_Label = new System.Windows.Forms.Label();
            number_of_cylindersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(295, 113);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(37, 13);
            makeLabel.TabIndex = 3;
            makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(293, 142);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 5;
            modelLabel.Text = "Model:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(298, 174);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 7;
            priceLabel.Text = "Price:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(298, 204);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(34, 13);
            colorLabel.TabIndex = 9;
            colorLabel.Text = "Color:";
            // 
            // automatic_TransmissionLabel
            // 
            automatic_TransmissionLabel.AutoSize = true;
            automatic_TransmissionLabel.Location = new System.Drawing.Point(211, 228);
            automatic_TransmissionLabel.Name = "automatic_TransmissionLabel";
            automatic_TransmissionLabel.Size = new System.Drawing.Size(121, 13);
            automatic_TransmissionLabel.TabIndex = 11;
            automatic_TransmissionLabel.Text = "Automatic Transmission:";
            // 
            // mPGLabel
            // 
            mPGLabel.AutoSize = true;
            mPGLabel.Location = new System.Drawing.Point(295, 260);
            mPGLabel.Name = "mPGLabel";
            mPGLabel.Size = new System.Drawing.Size(34, 13);
            mPGLabel.TabIndex = 13;
            mPGLabel.Text = "MPG:";
            // 
            // horse_power_Label
            // 
            horse_power_Label.AutoSize = true;
            horse_power_Label.Location = new System.Drawing.Point(259, 286);
            horse_power_Label.Name = "horse_power_Label";
            horse_power_Label.Size = new System.Drawing.Size(73, 13);
            horse_power_Label.TabIndex = 15;
            horse_power_Label.Text = "Horse power :";
            // 
            // number_of_cylindersLabel
            // 
            number_of_cylindersLabel.AutoSize = true;
            number_of_cylindersLabel.Location = new System.Drawing.Point(229, 312);
            number_of_cylindersLabel.Name = "number_of_cylindersLabel";
            number_of_cylindersLabel.Size = new System.Drawing.Size(103, 13);
            number_of_cylindersLabel.TabIndex = 17;
            number_of_cylindersLabel.Text = "Number of cylinders:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Lookup by VIN (primary key)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select VIN to see details from the database";
            // 
            // vinListBox
            // 
            this.vinListBox.DataSource = this.tableBindingSource;
            this.vinListBox.DisplayMember = "VIN";
            this.vinListBox.FormattingEnabled = true;
            this.vinListBox.Location = new System.Drawing.Point(73, 106);
            this.vinListBox.Name = "vinListBox";
            this.vinListBox.Size = new System.Drawing.Size(120, 134);
            this.vinListBox.TabIndex = 2;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.carsDatabaseDataSet;
            // 
            // carsDatabaseDataSet
            // 
            this.carsDatabaseDataSet.DataSetName = "CarsDatabaseDataSet";
            this.carsDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = DatabaseExample.CarsDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Make", true));
            this.makeTextBox.Location = new System.Drawing.Point(338, 106);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 20);
            this.makeTextBox.TabIndex = 4;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(338, 139);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 6;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(338, 171);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 8;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(338, 197);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox.TabIndex = 10;
            // 
            // automatic_TransmissionCheckBox
            // 
            this.automatic_TransmissionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tableBindingSource, "Automatic Transmission", true));
            this.automatic_TransmissionCheckBox.Location = new System.Drawing.Point(338, 223);
            this.automatic_TransmissionCheckBox.Name = "automatic_TransmissionCheckBox";
            this.automatic_TransmissionCheckBox.Size = new System.Drawing.Size(104, 24);
            this.automatic_TransmissionCheckBox.TabIndex = 12;
            this.automatic_TransmissionCheckBox.Text = "True";
            this.automatic_TransmissionCheckBox.UseVisualStyleBackColor = true;
            // 
            // mPGTextBox
            // 
            this.mPGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "MPG", true));
            this.mPGTextBox.Location = new System.Drawing.Point(338, 253);
            this.mPGTextBox.Name = "mPGTextBox";
            this.mPGTextBox.Size = new System.Drawing.Size(100, 20);
            this.mPGTextBox.TabIndex = 14;
            // 
            // horse_power_TextBox
            // 
            this.horse_power_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Horse power ", true));
            this.horse_power_TextBox.Location = new System.Drawing.Point(338, 279);
            this.horse_power_TextBox.Name = "horse_power_TextBox";
            this.horse_power_TextBox.Size = new System.Drawing.Size(100, 20);
            this.horse_power_TextBox.TabIndex = 16;
            // 
            // number_of_cylindersTextBox
            // 
            this.number_of_cylindersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Number of cylinders", true));
            this.number_of_cylindersTextBox.Location = new System.Drawing.Point(338, 305);
            this.number_of_cylindersTextBox.Name = "number_of_cylindersTextBox";
            this.number_of_cylindersTextBox.Size = new System.Drawing.Size(100, 20);
            this.number_of_cylindersTextBox.TabIndex = 18;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(37, 286);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 19;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(118, 286);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDemo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 348);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(number_of_cylindersLabel);
            this.Controls.Add(this.number_of_cylindersTextBox);
            this.Controls.Add(horse_power_Label);
            this.Controls.Add(this.horse_power_TextBox);
            this.Controls.Add(mPGLabel);
            this.Controls.Add(this.mPGTextBox);
            this.Controls.Add(automatic_TransmissionLabel);
            this.Controls.Add(this.automatic_TransmissionCheckBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.vinListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDemo3";
            this.Text = "Demo3: Car Lookup ";
            this.Load += new System.EventHandler(this.frmDemo3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox vinListBox;
        private CarsDatabaseDataSet carsDatabaseDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private CarsDatabaseDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private CarsDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.CheckBox automatic_TransmissionCheckBox;
        private System.Windows.Forms.TextBox mPGTextBox;
        private System.Windows.Forms.TextBox horse_power_TextBox;
        private System.Windows.Forms.TextBox number_of_cylindersTextBox;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnExit;
    }
}