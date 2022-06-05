namespace InventorySimulation
{
    partial class Form1
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
            System.Windows.Forms.Button buttonMeasure;
            this.comboBoxTestCase = new System.Windows.Forms.ComboBox();
            this.buttonSimulation = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayWithinCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginningInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndingInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortageQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQuantities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomLeadDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeadDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysUntilLead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            buttonMeasure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMeasure
            // 
            buttonMeasure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            buttonMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonMeasure.Location = new System.Drawing.Point(332, 513);
            buttonMeasure.Name = "buttonMeasure";
            buttonMeasure.Size = new System.Drawing.Size(381, 23);
            buttonMeasure.TabIndex = 3;
            buttonMeasure.Text = "Go To Performace Measure Now";
            buttonMeasure.UseVisualStyleBackColor = false;
            buttonMeasure.Click += new System.EventHandler(this.buttonMeasureClick);
            // 
            // comboBoxTestCase
            // 
            this.comboBoxTestCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTestCase.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTestCase.FormattingEnabled = true;
            this.comboBoxTestCase.Location = new System.Drawing.Point(251, 21);
            this.comboBoxTestCase.Name = "comboBoxTestCase";
            this.comboBoxTestCase.Size = new System.Drawing.Size(533, 21);
            this.comboBoxTestCase.TabIndex = 0;
            this.comboBoxTestCase.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTestCase_SelectedIndexChanged);
            // 
            // buttonSimulation
            // 
            this.buttonSimulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimulation.Location = new System.Drawing.Point(69, 12);
            this.buttonSimulation.Name = "buttonSimulation";
            this.buttonSimulation.Size = new System.Drawing.Size(151, 37);
            this.buttonSimulation.TabIndex = 1;
            this.buttonSimulation.Text = "Simulation Table Now";
            this.buttonSimulation.UseVisualStyleBackColor = false;
            this.buttonSimulation.Click += new System.EventHandler(this.ButtonSimulation_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.Cycle,
            this.DayWithinCycle,
            this.BeginningInventory,
            this.RandomDemand,
            this.Demand,
            this.EndingInventory,
            this.ShortageQuantity,
            this.OrderQuantities,
            this.RandomLeadDays,
            this.LeadDays,
            this.DaysUntilLead});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(1, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1043, 398);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            // 
            // Cycle
            // 
            this.Cycle.HeaderText = "Cycle";
            this.Cycle.Name = "Cycle";
            // 
            // DayWithinCycle
            // 
            this.DayWithinCycle.HeaderText = "DayWithinCycle";
            this.DayWithinCycle.Name = "DayWithinCycle";
            // 
            // BeginningInventory
            // 
            this.BeginningInventory.HeaderText = "BeginningInventory";
            this.BeginningInventory.Name = "BeginningInventory";
            // 
            // RandomDemand
            // 
            this.RandomDemand.HeaderText = "RandomDemand";
            this.RandomDemand.Name = "RandomDemand";
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.Name = "Demand";
            // 
            // EndingInventory
            // 
            this.EndingInventory.HeaderText = "EndingInventory";
            this.EndingInventory.Name = "EndingInventory";
            // 
            // ShortageQuantity
            // 
            this.ShortageQuantity.HeaderText = "ShortageQuantity";
            this.ShortageQuantity.Name = "ShortageQuantity";
            // 
            // OrderQuantities
            // 
            this.OrderQuantities.HeaderText = "OrderQuantities";
            this.OrderQuantities.Name = "OrderQuantities";
            // 
            // RandomLeadDays
            // 
            this.RandomLeadDays.HeaderText = "RandomLeadDays";
            this.RandomLeadDays.Name = "RandomLeadDays";
            // 
            // LeadDays
            // 
            this.LeadDays.HeaderText = "LeadDays";
            this.LeadDays.Name = "LeadDays";
            // 
            // DaysUntilLead
            // 
            this.DaysUntilLead.HeaderText = "DaysUntilLead";
            this.DaysUntilLead.Name = "DaysUntilLead";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 548);
            this.Controls.Add(buttonMeasure);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSimulation);
            this.Controls.Add(this.comboBoxTestCase);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Simulation Form ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTestCase;
        private System.Windows.Forms.Button buttonSimulation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayWithinCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginningInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndingInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortageQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQuantities;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomLeadDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeadDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysUntilLead;
    }
}

