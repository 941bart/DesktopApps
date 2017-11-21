namespace DatabaseExample
{
    partial class frmMainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDemo1 = new System.Windows.Forms.Button();
            this.btnDemo2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDemo3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDemo4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demo 1: Showing database in gridview control";
            // 
            // btnDemo1
            // 
            this.btnDemo1.Location = new System.Drawing.Point(78, 39);
            this.btnDemo1.Name = "btnDemo1";
            this.btnDemo1.Size = new System.Drawing.Size(75, 23);
            this.btnDemo1.TabIndex = 1;
            this.btnDemo1.Text = "Demo 1";
            this.btnDemo1.UseVisualStyleBackColor = true;
            this.btnDemo1.Click += new System.EventHandler(this.btnDemo1_Click);
            // 
            // btnDemo2
            // 
            this.btnDemo2.Location = new System.Drawing.Point(79, 87);
            this.btnDemo2.Name = "btnDemo2";
            this.btnDemo2.Size = new System.Drawing.Size(75, 23);
            this.btnDemo2.TabIndex = 3;
            this.btnDemo2.Text = "Demo 2";
            this.btnDemo2.UseVisualStyleBackColor = true;
            this.btnDemo2.Click += new System.EventHandler(this.btnDemo2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Demo 2: Details View";
            // 
            // btnDemo3
            // 
            this.btnDemo3.Location = new System.Drawing.Point(78, 140);
            this.btnDemo3.Name = "btnDemo3";
            this.btnDemo3.Size = new System.Drawing.Size(75, 23);
            this.btnDemo3.TabIndex = 5;
            this.btnDemo3.Text = "Demo 3";
            this.btnDemo3.UseVisualStyleBackColor = true;
            this.btnDemo3.Click += new System.EventHandler(this.btnDemo3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Demo 3: Car Lookup";
            // 
            // btnDemo4
            // 
            this.btnDemo4.Location = new System.Drawing.Point(78, 199);
            this.btnDemo4.Name = "btnDemo4";
            this.btnDemo4.Size = new System.Drawing.Size(75, 23);
            this.btnDemo4.TabIndex = 7;
            this.btnDemo4.Text = "Demo 4";
            this.btnDemo4.UseVisualStyleBackColor = true;
            this.btnDemo4.Click += new System.EventHandler(this.btnDemo4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Demo 4: SQL Queries";
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 271);
            this.Controls.Add(this.btnDemo4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDemo3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDemo2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDemo1);
            this.Controls.Add(this.label1);
            this.Name = "frmMainPage";
            this.Text = "Database tools examples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDemo1;
        private System.Windows.Forms.Button btnDemo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDemo3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDemo4;
        private System.Windows.Forms.Label label4;
    }
}

