using System;
using System.Windows.Forms;
using RucksackSolver.Exceptions;
using RucksackSolver.Implementation;
using RucksackSolver.Interfaces;

namespace RucksackSolver
{
    public partial class Main : Form
    {
        private readonly IConfigLoader _configLoader = new ConfigLoader();
        private readonly IRucksackSolver _rucksackSolver = new RucksackSolver();
        private Config _config;

        public Main()
        {
            InitializeComponent();
            SetTitle();
            comboBoxChooseType.SelectedIndex = 0;
        }

        private void SetTitle()
        {
            Text = Application.ProductName + @" " + Application.ProductVersion;
        }

        private void buttonLoadConfig_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog {Filter = @"XML (*.xml)|*.xml"};
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
                _config = _configLoader.LoadConfiguration("RucksackObjects.xml");
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_config == null)
                    throw new ConfigNotProperlyLoadedException("The configuration wasn't loaded properly");
                switch (comboBoxChooseType.SelectedIndex)
                {
                    case 0:
                        _rucksackSolver.Solve(_config.RucksackObjects, (int) numericUpDownB.Value);
                        ShowSolvedMessage();
                        break;
                    case 1:
                        _rucksackSolver.SolveFptas(_config.RucksackObjects, (int) numericUpDownB.Value,
                            (int) numericUpDownK.Value);
                        ShowSolvedMessage();
                        break;
                    default:
                        _rucksackSolver.Solve(_config.RucksackObjects, (int) numericUpDownB.Value);
                        ShowSolvedMessage();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
        }

        private void ShowSolvedMessage()
        {
            MessageBox.Show(
                @"Please check the application directory for the files 'Solution.txt' and 'Table.csv'",
                @"Finished solving the rucksack problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxChooseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownK.Enabled = comboBoxChooseType.SelectedIndex == 1;
        }
    }
}