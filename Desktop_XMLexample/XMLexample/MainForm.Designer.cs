namespace XMLexample
{
    partial class frmMainForm
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
            this.txtBoxCarMake = new System.Windows.Forms.TextBox();
            this.txtBoxCarModel = new System.Windows.Forms.TextBox();
            this.txtBoxCarPrice = new System.Windows.Forms.TextBox();
            this.txtBoxCarColor = new System.Windows.Forms.TextBox();
            this.txtBoxCarNumberOfDoors = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblCarMake = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblCarPrice = new System.Windows.Forms.Label();
            this.lblCarColor = new System.Windows.Forms.Label();
            this.lblCarNumberOfDoors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxCarMake
            // 
            this.txtBoxCarMake.Location = new System.Drawing.Point(105, 18);
            this.txtBoxCarMake.Name = "txtBoxCarMake";
            this.txtBoxCarMake.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCarMake.TabIndex = 0;
            // 
            // txtBoxCarModel
            // 
            this.txtBoxCarModel.Location = new System.Drawing.Point(105, 44);
            this.txtBoxCarModel.Name = "txtBoxCarModel";
            this.txtBoxCarModel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCarModel.TabIndex = 1;
            // 
            // txtBoxCarPrice
            // 
            this.txtBoxCarPrice.Location = new System.Drawing.Point(105, 70);
            this.txtBoxCarPrice.Name = "txtBoxCarPrice";
            this.txtBoxCarPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCarPrice.TabIndex = 2;
            // 
            // txtBoxCarColor
            // 
            this.txtBoxCarColor.Location = new System.Drawing.Point(105, 96);
            this.txtBoxCarColor.Name = "txtBoxCarColor";
            this.txtBoxCarColor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCarColor.TabIndex = 3;
            // 
            // txtBoxCarNumberOfDoors
            // 
            this.txtBoxCarNumberOfDoors.Location = new System.Drawing.Point(105, 122);
            this.txtBoxCarNumberOfDoors.Name = "txtBoxCarNumberOfDoors";
            this.txtBoxCarNumberOfDoors.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCarNumberOfDoors.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number of doors";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(211, 162);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblCarMake
            // 
            this.lblCarMake.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCarMake.Location = new System.Drawing.Point(211, 15);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(100, 23);
            this.lblCarMake.TabIndex = 17;
            // 
            // lblCarModel
            // 
            this.lblCarModel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCarModel.Location = new System.Drawing.Point(211, 43);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(100, 23);
            this.lblCarModel.TabIndex = 18;
            // 
            // lblCarPrice
            // 
            this.lblCarPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCarPrice.Location = new System.Drawing.Point(211, 67);
            this.lblCarPrice.Name = "lblCarPrice";
            this.lblCarPrice.Size = new System.Drawing.Size(100, 23);
            this.lblCarPrice.TabIndex = 19;
            // 
            // lblCarColor
            // 
            this.lblCarColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCarColor.Location = new System.Drawing.Point(211, 93);
            this.lblCarColor.Name = "lblCarColor";
            this.lblCarColor.Size = new System.Drawing.Size(100, 23);
            this.lblCarColor.TabIndex = 20;
            // 
            // lblCarNumberOfDoors
            // 
            this.lblCarNumberOfDoors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCarNumberOfDoors.Location = new System.Drawing.Point(211, 124);
            this.lblCarNumberOfDoors.Name = "lblCarNumberOfDoors";
            this.lblCarNumberOfDoors.Size = new System.Drawing.Size(100, 23);
            this.lblCarNumberOfDoors.TabIndex = 21;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 594);
            this.Controls.Add(this.lblCarNumberOfDoors);
            this.Controls.Add(this.lblCarColor);
            this.Controls.Add(this.lblCarPrice);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.lblCarMake);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCarNumberOfDoors);
            this.Controls.Add(this.txtBoxCarColor);
            this.Controls.Add(this.txtBoxCarPrice);
            this.Controls.Add(this.txtBoxCarModel);
            this.Controls.Add(this.txtBoxCarMake);
            this.Name = "frmMainForm";
            this.Text = "XML Save and Load";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCarMake;
        private System.Windows.Forms.TextBox txtBoxCarModel;
        private System.Windows.Forms.TextBox txtBoxCarPrice;
        private System.Windows.Forms.TextBox txtBoxCarColor;
        private System.Windows.Forms.TextBox txtBoxCarNumberOfDoors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblCarMake;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label lblCarPrice;
        private System.Windows.Forms.Label lblCarColor;
        private System.Windows.Forms.Label lblCarNumberOfDoors;
    }
}

