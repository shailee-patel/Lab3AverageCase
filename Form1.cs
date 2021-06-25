// Shailee Patel (100800440)
// June 24, 2021
// Description - This lab is to find about the Average Weekly Cases of 3 Region.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4AverageCase
{
    public partial class formAverageCases : Form
    {
        // Declare class-level variables.
        int currentDay = 0;
        int currentRegion = 0;
        const int NumberOfRegions = 3;
        const int NumberOfDays = 7;

        // This is the 2D array of all cases recorded.
        int[,] cases = new int[NumberOfRegions, NumberOfDays];

        // These arrays are arrays of controls on the form
        TextBox[] textBoxCaseLists;
        Label[] labelAverages;

        // Initialize the forms and arrays of controls
        public formAverageCases()
        {
            InitializeComponent();

            textBoxCaseLists = new TextBox[] { textBoxRegion1List, textBoxRegion2List, textBoxRegion3List };
            labelAverages = new Label[] { labelAverage1, labelAverage2, labelAverage3 };
        }

        /// <summary>
        /// This exits the application.
        /// </summary>
        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Clears all fields and resets the form to its default state.
        /// </summary>
        private void ResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// Validates and accepts a value for a number of cases entered by the user.
        /// When it's valid, records the value and adds to a running total.
        /// Once all cases are enetered, calculates and displays an average.
        /// </summary>
        private void EnterClick(object sender, EventArgs e)
        {
            // Declare a variable to store the user's last (numeric) input.
            int enteredCases;

            // If the content of the textbox are a number...
            if (int.TryParse(textBoxCaseEntry.Text, out enteredCases))
            {
                // If the contents of the textbox are in valid range (positive)...
                if (enteredCases >= 0 && enteredCases <= int.MaxValue)
                {
                    // Add the entered cases to the array
                    cases[currentRegion, currentDay] = enteredCases;
                    // Add the entered cases to the appropriate textbox.
                    textBoxCaseLists[currentRegion].Text += enteredCases + Environment.NewLine;

                    // Increment the day.
                    currentDay++;
                    // If we are at day 7, do the calculation and go to the next region.
                    if (currentDay >= NumberOfDays)
                    {

                        // Calculate the average for the current region.
                        double totalCases = 0;
                        for (int dayCount = 0; dayCount < NumberOfDays; dayCount++)
                        {

                            // Add a running total for each day in the current region.
                            totalCases += cases[currentRegion, dayCount];
                        }
                        // Use the total to calculate and output the average.
                        labelAverages[currentRegion].Text = "Average: " + Math.Round(totalCases / NumberOfDays, 2);

                        // Go to the next Region.
                        currentDay = 0;
                        currentRegion++;

                        // If we are at Region 3, run the final calculations.
                        if (currentRegion >= NumberOfRegions)
                        {
                            // Calculate the total among all regions (similar to above)
                            double averageCases = 0;
                            for (int regionCount = 0; regionCount < NumberOfRegions; regionCount++)
                            {

                            }

                            // Use the total to calculate and output the overall average.

                            // Disable the textbox and Calculate button.
                            textBoxCaseEntry.Enabled = false;
                            buttonEnter.Enabled = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Your entry must be between 0 and " + int.MaxValue, "Entry Error!");
                    textBoxCaseEntry.SelectAll();
                    textBoxCaseEntry.Focus();
                }
            }
            // The contents are not a whole number. Report an error.
            else
            {
                MessageBox.Show("Your entry must be a whole number.", "Entry Error!");
            }
        }

        public void SetDefaults()
        {
            // Clear input and output controls.
            textBoxCaseEntry.Clear();
            textBoxRegion1List.Clear();
            textBoxRegion2List.Clear();
            textBoxRegion3List.Clear();
            labelAverage1.Text = string.Empty;
            labelAverage2.Text = string.Empty;
            labelAverage3.Text = string.Empty;
            labelAverageOutput.Text = String.Empty;

            // Re-enable any controls that could be disabled.
            textBoxCaseEntry.Enabled = true;
            buttonEnter.Enabled = true;

            // Reset the value of the class-level variables.
            currentDay = 0;
            currentRegion = 0;

            // Set the displayed day back to default.
            labelDay.Text = "Day " + currentDay + 1;

            // Set focus.
            textBoxCaseEntry.Focus();
        }
    }
}
