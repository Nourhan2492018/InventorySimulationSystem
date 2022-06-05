
using System;

using System.Windows.Forms;

namespace InventorySimulation
{
    public partial class MeasureForm :Form
    {
       InventoryModels.SimulationSystem simulationSystem;
        public MeasureForm(InventoryModels.SimulationSystem simulationSystem)
        {
            InitializeComponent();
            this.simulationSystem = simulationSystem;
        }

        private void MeasureForm_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FillRow(int i)
        {
            dataGridView1.Rows[i].Cells["EndingInventoryAverage"].Value = this.simulationSystem.PerformanceMeasures.EndingInventoryAverage;
            dataGridView1.Rows[i].Cells["ShortageQuantityAverage"].Value = this.simulationSystem.PerformanceMeasures.ShortageQuantityAverage;

        }
        private void Button_measure_Click(object sender, EventArgs e)
        {
            int index = 0;
            FillRow(index);
        }
    }
}
