namespace InventorySimulation
{
    partial class MeasureForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EndingInventoryAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortageQuantityAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_measure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EndingInventoryAverage,
            this.ShortageQuantityAverage});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(78, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(237, 62);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // EndingInventoryAverage
            // 
            this.EndingInventoryAverage.HeaderText = "EndingInventoryAverage";
            this.EndingInventoryAverage.Name = "EndingInventoryAverage";
            // 
            // ShortageQuantityAverage
            // 
            this.ShortageQuantityAverage.HeaderText = "ShortageQuantityAverage";
            this.ShortageQuantityAverage.Name = "ShortageQuantityAverage";
            // 
            // button_measure
            // 
            this.button_measure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_measure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_measure.Location = new System.Drawing.Point(51, 156);
            this.button_measure.Name = "button_measure";
            this.button_measure.Size = new System.Drawing.Size(290, 41);
            this.button_measure.TabIndex = 1;
            this.button_measure.Text = "Display Performace Measure Now";
            this.button_measure.UseVisualStyleBackColor = false;
            this.button_measure.Click += new System.EventHandler(this.Button_measure_Click);
            // 
            // MeasureForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(402, 247);
            this.Controls.Add(this.button_measure);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MeasureForm";
            this.Load += new System.EventHandler(this.MeasureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndingInventoryAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortageQuantityAverage;
        private System.Windows.Forms.Button button_measure;
    }
}
