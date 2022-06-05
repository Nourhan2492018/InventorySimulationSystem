using System;
using System.Windows.Forms;

namespace InventorySimulation
{
    public partial class Form1 : Form
    {
        string pathTestCaseFile="";
        InventoryModels.SimulationSystem simulationSystem;
        public Form1(InventoryModels.SimulationSystem simulationSystem)
        {
            InitializeComponent();
            comboBoxTestCase.Items.Add("Test Case One");
            //comboBoxTestCase.Items.Add("Test Case Two");
            //comboBoxTestCase.Items.Add("Test Case Three");
            this.simulationSystem = simulationSystem;
         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShowResultTestCaseOne()
        {
            pathTestCaseFile = "C:\\Users\\Norhan\\Desktop\\moodeling\\[students]_template\\inventorysimulation\\InventorySimulation\\TestCases\\TestCase1.txt";
            MessageBox.Show("Now You Run Test Case One .........");
            InventoryModels.SystemReadTestCaseFile.ReadInputsFromFile(this.simulationSystem, this.pathTestCaseFile);
            this.simulationSystem.BulidSimulationTable();
            this.simulationSystem.buildPerformanceMEasures();
            string result = InventoryTesting.TestingManager.Test(this.simulationSystem, InventoryTesting.Constants.FileNames.TestCase1);
            MessageBox.Show(result);
        }
        private void ComboBoxTestCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTestCase.SelectedItem.ToString()== "Test Case One")
            {
                ShowResultTestCaseOne();
            }
            else
            {
                MessageBox.Show("Please Select test Case Wont Run Now.........");
            }
        }

        private void buttonMeasureClick(object sender, EventArgs e)
        {
            if (pathTestCaseFile.Equals(""))
            {
                MessageBox.Show("Please Select test Case Wont Run Now.........");

            }
            else
            {
                MeasureForm measureForm = new MeasureForm(this.simulationSystem);
                measureForm.Show();
                this.Hide();
            }
        }

        private void InitialGridView()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(this.simulationSystem.NumberOfDays);
        }
        private void ButtonSimulation_Click(object sender, EventArgs e)
        {
            if (pathTestCaseFile.Equals(""))
            {
                MessageBox.Show("Please Enter Simulation Button.........");

            }
            else
            {
                InitialGridView();
                FillTale();
            }

            /*SystemReadFile.ReadInputsFromFile(this.simulationSystem, this.Path);
             this.simulationSystem.BuildSimulationTable();
             this.simulationSystem.buildPerformanceMEasures();
             string result = TestingManager.Test(this.simulationSystem, Constants.FileNames.TestCase1);
             MessageBox.Show(result);
             Form2 f = new Form2(this.simulationSystem);
             f.Show();
             this.Hide();*/
        }
        private void FillTale()
        {
            int i = 0;
            while (i < this.simulationSystem.NumberOfDays)
            {
                /*
                dataGridView1.Rows[i].Cells["Day"].Value = this.simulationSystem.SimulationCases[i].Day;
                dataGridView1.Rows[i].Cells["Cycle"].Value = this.simulationSystem.SimulationCases[i].Cycle;
                dataGridView1.Rows[i].Cells["DayWithinCycle"].Value = this.simulationSystem.SimulationCases[i].DayWithinCycle;
                dataGridView1.Rows[i].Cells["BeginningInventory"].Value = this.simulationSystem.SimulationCases[i].BeginningInventory;
                dataGridView1.Rows[i].Cells["RandomDemand"].Value = this.simulationSystem.SimulationCases[i].RandomDemand;
                dataGridView1.Rows[i].Cells["Demand"].Value = this.simulationSystem.SimulationCases[i].Demand;
                dataGridView1.Rows[i].Cells["EndingInventory"].Value = this.simulationSystem.SimulationCases[i].EndingInventory;
                dataGridView1.Rows[i].Cells["ShortageQuantity"].Value = this.simulationSystem.SimulationCases[i].ShortageQuantity;
                dataGridView1.Rows[i].Cells["OrderQuantities"].Value = this.simulationSystem.SimulationCases[i].OrderQuantity;
                dataGridView1.Rows[i].Cells["RandomLeadDays"].Value = this.simulationSystem.SimulationCases[i].RandomLeadDays;
                dataGridView1.Rows[i].Cells["LeadDays"].Value = this.simulationSystem.SimulationCases[i].LeadDays;
                dataGridView1.Rows[i].Cells["DaysUntilLead"].Value = this.simulationSystem.SimulationCases[i].DaysUntilLead;
                */
                FillRow(i);
                i++;
            }
        }
        private void FillRow(int index)
        {
            dataGridView1.Rows[index].Cells["Day"].Value = this.simulationSystem.SimulationCases[index].Day;
            dataGridView1.Rows[index].Cells["Cycle"].Value = this.simulationSystem.SimulationCases[index].Cycle;
            dataGridView1.Rows[index].Cells["DayWithinCycle"].Value = this.simulationSystem.SimulationCases[index].DayWithinCycle;
            dataGridView1.Rows[index].Cells["BeginningInventory"].Value = this.simulationSystem.SimulationCases[index].BeginningInventory;
            dataGridView1.Rows[index].Cells["RandomDemand"].Value = this.simulationSystem.SimulationCases[index].RandomDemand;
            dataGridView1.Rows[index].Cells["Demand"].Value = this.simulationSystem.SimulationCases[index].Demand;
            dataGridView1.Rows[index].Cells["EndingInventory"].Value = this.simulationSystem.SimulationCases[index].EndingInventory;
            dataGridView1.Rows[index].Cells["ShortageQuantity"].Value = this.simulationSystem.SimulationCases[index].ShortageQuantity;
            dataGridView1.Rows[index].Cells["OrderQuantities"].Value = this.simulationSystem.SimulationCases[index].OrderQuantity;
            dataGridView1.Rows[index].Cells["RandomLeadDays"].Value = this.simulationSystem.SimulationCases[index].RandomLeadDays;
            dataGridView1.Rows[index].Cells["LeadDays"].Value = this.simulationSystem.SimulationCases[index].LeadDays;
            dataGridView1.Rows[index].Cells["DaysUntilLead"].Value = this.simulationSystem.SimulationCases[index].DaysWaitingOrderArrive;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
