using ComputerScience40S.computerscience40s.testing.advancedclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// The unit testing class that drives the various unit tests
/// </summary>
namespace ComputerScience40S.computerscience40s.testing
{
    class Tester
    {

        public static ListBox outputList;

        /// <summary>
        /// Starts all the project testing
        /// </summary>
        public static void Start()
        {
            print("\nTesting begins.....\n");
            RecursionTest unit1 = new RecursionTest();
            AdvancedClassesTest unit2 = new AdvancedClassesTest();
            print("\nTesting complete!\n");
        }

        /// <summary>
        /// Updates the listbox showing all the outputs
        /// </summary>
        /// <param name="item">the item to 'print' in the listbox</param>
        public static void print(Object item)
        {
            string text = item.ToString();
            int lineCount = 1;
            // get all the lines
            for (int i = 0; i < text.Length; i++)
            {
                char character = text[i];
                if (character == '\n')
                {
                    lineCount++;                    
                }
            }
            // go through text again and create new lines in an array
            string[] lines = new string[lineCount];
            int count = 0;
            string line = "";
            for (int i = 0; i < text.Length; i++)
            {
                char character = text[i];
                if (character == '\n')
                {
                    lines[count] = line;
                    line = "";
                    count++;
                }
                else
                {
                    line += character;
                }
            }
            lines[count] = line;
            // put all lines in the listbox
            for (int i = 0; i < lines.Length; i++)
            {
                outputList.Items.Add(lines[i]);
            }
        }

    }
}
