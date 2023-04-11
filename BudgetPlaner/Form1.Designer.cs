
namespace BudgetPlaner
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.importButton = new System.Windows.Forms.Button();
            this.saveToFile = new System.Windows.Forms.Button();
            this.AddShop = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.valueTo = new System.Windows.Forms.NumericUpDown();
            this.valueFrom = new System.Windows.Forms.NumericUpDown();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueFrom)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 102);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(576, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 436);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(293, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Budget Planner";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.importButton);
            this.panel2.Controls.Add(this.saveToFile);
            this.panel2.Controls.Add(this.AddShop);
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.resetButton);
            this.panel2.Controls.Add(this.filterButton);
            this.panel2.Controls.Add(this.valueTo);
            this.panel2.Controls.Add(this.valueFrom);
            this.panel2.Controls.Add(this.dateTo);
            this.panel2.Controls.Add(this.dateFrom);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(12, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 436);
            this.panel2.TabIndex = 1;
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.Color.White;
            this.importButton.Location = new System.Drawing.Point(192, 187);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(87, 45);
            this.importButton.TabIndex = 12;
            this.importButton.Text = "Import from file";
            this.importButton.UseVisualStyleBackColor = false;
            this.importButton.Click += new System.EventHandler(this.importButtonClick);
            // 
            // saveToFile
            // 
            this.saveToFile.BackColor = System.Drawing.Color.White;
            this.saveToFile.Location = new System.Drawing.Point(285, 187);
            this.saveToFile.Name = "saveToFile";
            this.saveToFile.Size = new System.Drawing.Size(87, 45);
            this.saveToFile.TabIndex = 11;
            this.saveToFile.Text = "Save To File";
            this.saveToFile.UseVisualStyleBackColor = false;
            this.saveToFile.Click += new System.EventHandler(this.saveToFile_Click);
            // 
            // AddShop
            // 
            this.AddShop.BackColor = System.Drawing.Color.White;
            this.AddShop.Location = new System.Drawing.Point(378, 187);
            this.AddShop.Name = "AddShop";
            this.AddShop.Size = new System.Drawing.Size(87, 45);
            this.AddShop.TabIndex = 10;
            this.AddShop.Text = "Add Shop";
            this.AddShop.UseVisualStyleBackColor = false;
            this.AddShop.Click += new System.EventHandler(this.AddShop_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(378, 126);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(87, 45);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButtonClick);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.White;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetButton.Location = new System.Drawing.Point(252, 126);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(120, 45);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButtonClick);
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.White;
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filterButton.Location = new System.Drawing.Point(126, 126);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(120, 45);
            this.filterButton.TabIndex = 7;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButtonClick);
            // 
            // valueTo
            // 
            this.valueTo.DecimalPlaces = 2;
            this.valueTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valueTo.Location = new System.Drawing.Point(345, 91);
            this.valueTo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.valueTo.Name = "valueTo";
            this.valueTo.Size = new System.Drawing.Size(120, 29);
            this.valueTo.TabIndex = 6;
            this.valueTo.Value = new decimal(new int[] {
            99990,
            0,
            0,
            65536});
            // 
            // valueFrom
            // 
            this.valueFrom.DecimalPlaces = 2;
            this.valueFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valueFrom.Location = new System.Drawing.Point(126, 91);
            this.valueFrom.Name = "valueFrom";
            this.valueFrom.Size = new System.Drawing.Size(120, 29);
            this.valueFrom.TabIndex = 5;
            // 
            // dateTo
            // 
            this.dateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTo.Location = new System.Drawing.Point(126, 56);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(339, 29);
            this.dateTo.TabIndex = 4;
            this.dateTo.Value = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            // 
            // dateFrom
            // 
            this.dateFrom.CalendarTitleBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateFrom.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateFrom.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateFrom.Location = new System.Drawing.Point(126, 7);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(339, 29);
            this.dateFrom.TabIndex = 3;
            this.dateFrom.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(576, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(584, 436);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(597, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(575, 436);
            this.panel5.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 436);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::BudgetPlaner.Properties.Resources.bggrey1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.valueTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueFrom)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.NumericUpDown valueTo;
        private System.Windows.Forms.NumericUpDown valueFrom;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddShop;
        private System.Windows.Forms.Button saveToFile;
        private System.Windows.Forms.Button importButton;
    }
}

