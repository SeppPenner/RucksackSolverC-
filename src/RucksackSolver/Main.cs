// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Main.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The main form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RucksackSolver;

/// <summary>
/// The main form.
/// </summary>
public partial class Main : Form
{
    /// <summary>
    /// The configuration loader.
    /// </summary>
    private readonly IConfigLoader configLoader = new ConfigLoader();

    /// <summary>
    /// The rucksack solver.
    /// </summary>
    private readonly IRucksackSolver rucksackSolver = new Implementation.RucksackSolver();

    /// <summary>
    /// The configuration.
    /// </summary>
    private Config config = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="Main"/> class.
    /// </summary>
    public Main()
    {
        this.InitializeComponent();
        this.SetTitle();
        this.comboBoxChooseType.SelectedIndex = 0;
    }

    /// <summary>
    /// Shows the solved message.
    /// </summary>
    private static void ShowSolvedMessage()
    {
        MessageBox.Show(@"Please check the application directory for the files 'Solution.txt' and 'Table.csv'", @"Finished solving the rucksack problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Sets the title.
    /// </summary>
    private void SetTitle()
    {
        this.Text = Application.ProductName + @" " + Application.ProductVersion;
    }

    /// <summary>
    /// Handles the button click to load the configuration.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void ButtonLoadConfigClick(object sender, EventArgs e)
    {
        var dialog = new OpenFileDialog { Filter = @"XML (*.xml)|*.xml" };
        var result = dialog.ShowDialog();

        if (result == DialogResult.OK)
        {
            this.config = this.configLoader.LoadConfiguration("RucksackObjects.xml");
        }
    }

    /// <summary>
    /// Handles the button click to calculate the solution.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void ButtonCalculateClick(object sender, EventArgs e)
    {
        try
        {
            if (this.config == null)
            {
                throw new ConfigNotProperlyLoadedException("The configuration wasn't loaded properly");
            }

            switch (this.comboBoxChooseType.SelectedIndex)
            {
                case 0:
                    this.rucksackSolver.Solve(this.config.RucksackObjects, (int)this.numericUpDownB.Value);
                    ShowSolvedMessage();
                    break;
                case 1:
                    this.rucksackSolver.SolveFptas(this.config.RucksackObjects, (int)this.numericUpDownB.Value, (int)this.numericUpDownK.Value);
                    ShowSolvedMessage();
                    break;
                default:
                    this.rucksackSolver.Solve(this.config.RucksackObjects, (int)this.numericUpDownB.Value);
                    ShowSolvedMessage();
                    break;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.StackTrace, ex.Message);
        }
    }

    /// <summary>
    /// Handles the language changed event.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void ComboBoxChooseTypeSelectedIndexChanged(object sender, EventArgs e)
    {
        this.numericUpDownK.Enabled = this.comboBoxChooseType.SelectedIndex == 1;
    }
}
