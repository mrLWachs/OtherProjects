using ComputerScience40S.computerscience40s.testing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScience40S.computerscience30s
{
    public partial class ComputerScience30S : Form
    {

        private Random randomizer = new Random();

        public ComputerScience30S()
        {
            InitializeComponent();
        }

        private void ComputerScience30S_Load(object sender, EventArgs e)
        {
            Tester.outputList = outputList;
            Tester.print("Computer Science 30S Example started...");
            unit1();    // introduction to C# programming
            unit2();    // methods in C#
            unit3();    // arrays in C#
            unit4();    // classes in C#
            Tester.print("Computer Science 30S Example completed!");
            outputList.SelectedIndex = outputList.Items.Count - 1;
        }

        /// <summary>
        /// The example code for this unit
        /// </summary>
        private void unit1()
        {
            Tester.print("Java basics started...");

            //////////////////////////////////////////////////////////////////////
            // C# BASICS:
            //////////////////////////////////////////////////////////////////////

            // This is a comment, anything after // is a comment

            /* 
                This is another way to comment, but it opens a multiple line 
                comment that continues until a star and a slash is reached
            */

            Tester.print("Hello World...");
            Tester.print("Goodbye world");

            // examples of "special" output characters:        
            Console.WriteLine("Make a quote, \" is a quote");
            Console.WriteLine("Make a tab, \t is a tab");
            Console.WriteLine("Make a slash, \\ is a slash");
            Console.WriteLine("Make a new line, \n is newline");

            // fancy dialog boxes for outputs ........ 

            // message dialog (shows user a message)    
            MessageBox.Show("Message 1");

            // variations on the message dialog (not needed for assignments)   

            MessageBox.Show("Message 2", "Title 2");

            MessageBox.Show("Message 3",
                            "Title 3",
                            MessageBoxButtons.YesNo);

            MessageBox.Show("Message 4",
                            "Title 4",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

            MessageBox.Show("Message 5",
                            "Title 5",
                            MessageBoxButtons.RetryCancel,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button2);

            MessageBox.Show("Message 6",
                            "Title 6",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign,
                            true);

            //////////////////////////////////////////////////////////////////////
            // VARIABLES:
            //////////////////////////////////////////////////////////////////////

            // simpliest variable
            bool a = true;                      // declares the variable
            a = false;                          // changes (varies) the variable
                                                // booleans store only true or false

            // number data types:
            int b = 0;                          // whole #s, no decimals
            double c = 0.0;                     // allows for decimals

            // character data type:
            char d = '$';

            // more complex data type:
            string e1 = "words";

            // output the variables:
            Tester.print("a = " + a);
            Tester.print("b = " + b);
            Tester.print("c = " + c);
            Tester.print("d = " + d);
            Tester.print("e = " + e1);

            // manipluate (change) variabes
            int x = 10;
            Tester.print("x = " + x);
            x = 20;
            Tester.print("x = " + x);
            int y = x + 10;
            Tester.print("y = " + y);
            // shorthand (not needed)
            y++;                                // same as y = y + 1
            Tester.print("y = " + y);
            y--;                                // same as y = y - 1
            Tester.print("y = " + y);
            y = y + 10;
            Tester.print("y = " + y);

            // more shorthand, really not needed
            y += 10;                            // same as y = y + 10
            y -= 10;                            // same as y = y - 10
            y *= 2;                             // same as y = y * 2
            y /= 10;                            // same as y = y / 10;        
            Tester.print("y = " + y);

            // modulus division, gives the remainder
            x = 28;
            y = x % 5;
            Tester.print("y = " + y);

            // constants, variables that never change typed in ALL CAPITAL LETTERS
            const double PI = 3.14;
            const int PROBLEMS = 99;
            const char YES = 'y';
            const bool FOUND = true;
            const String TEACHER_NAME = "Wachs";
            // underscore seperates words in constants        
            Tester.print(PI + " and " +
                    PROBLEMS + " and " +
                    YES + " and " +
                    FOUND + " and " +
                    TEACHER_NAME);

            // converting between data types:        
            int f = 15;
            double g = f;
            g = 15.8;
            int h = (int)g;
            // casting means it "pretends" to be an int this just ignores 
            // (truncates or cuts off) the decimal part
            double k = 2.99999999999;
            int l = (int)k;
            double m = (double)l;
            Tester.print("f = " + f);
            Tester.print("g = " + g);
            Tester.print("h = " + h);
            Tester.print("k = " + k);
            Tester.print("l = " + l);
            Tester.print("m = " + m);

            // cast characters into numbers:
            char n = 'a';
            int o = (int)n;
            Tester.print("o = " + o);
            o++;
            char p = (char)o;
            Tester.print("p = " + p);
            // stores the values in the ASCII table

            // use input dialog with a string   
            new InputBox("Enter something").ShowDialog();
            string q = Storage.data;
            MessageBox.Show(q);

            // convert strings into numbers use parsing (reading)
            new InputBox("Enter int").ShowDialog();
            string r = Storage.data;
            int s = Convert.ToInt32(r);
            MessageBox.Show("" + s);

            // with a double
            new InputBox("Enter double").ShowDialog();
            string t = Storage.data;
            double u = Convert.ToDouble(t);
            MessageBox.Show("" + u);

            // built-in string actions (functions, methods)        
            string word = "superman";
            int count = word.Length;
            // the length of the characters in the string
            char letter = word[3];
            Tester.print("Letter at 3 is " + letter);
            // gets 1 character from the string at the specified index number, 
            // which starts at zero

            // in C# words that start with a capital letter have built-in 
            // actions because they are powerful, because they are "classes" 
            // (covered in more detail in a later unit)

            // built-in Math library of code:        
            double answer1 = Math.Abs(-1);      // absolute value
            double answer2 = Math.PI;           // the value of Pi
            double answer3 = Math.Cos(0.5);     // cosine (sin, tan, and arcs also)
            double answer4 = Math.Log(0.5);     // logarithms
            double answer5 = Math.Pow(5, 3);    // 5 to the power of 3
            double answer6 = Math.Sqrt(9);      // square root
            Tester.print("answer 1 = " + answer1);
            Tester.print("answer 2 = " + answer2);
            Tester.print("answer 3 = " + answer3);
            Tester.print("answer 4 = " + answer4);
            Tester.print("answer 5 = " + answer5);
            Tester.print("answer 6 = " + answer6);

            // the Math library and random numbers:
            Random randomGenerator = new Random();
            double seed = randomGenerator.NextDouble();
            double low = 1.0;
            double high = 10.0;
            double random = (high - low + 1.0) * seed + low;
            // random number formula 
            Tester.print("Random = " + random);
            // then convert the number
            int value = (int)random;
            Tester.print("Value = " + value);

            //////////////////////////////////////////////////////////////////////
            // CONDITIONAL STATEMENTS:
            //////////////////////////////////////////////////////////////////////

            int value1 = 10, value2 = 10;
            // a option for making 2 variables on 1 line

            // simple if statement, when something is true, it checks 1 thing
            if (value1 == value2)
            {
                Tester.print("Equal");
            }

            // if with an else, when something is both true and false, it 
            // checks 2 things        
            double value3 = 1.45, value4 = 1.5;
            if (value3 < value4)
            {
                Tester.print("Less than");
            }
            else
            {
                Tester.print("Greater than, or equal");
            }

            // use chars and some shorthand for conditional statements (not 
            // recommended), means when the code is one line, you don't need 
            // the { } brackets        
            char value5 = 'A', value6 = 'a';
            if (value5 != value6) Tester.print("Not equal");

            // use the else if for multiple cases of more than 2 things. Same as 
            // a switch statement (which I do not recommend) using strings        
            String word1 = "cat";
            String word2 = "cAt";
            // equals is more complicated with strings
            if (word1 == word2)
            {
                Tester.print("Equal, same case");
            }
            else if (word1 == word2)
            {
                Tester.print("Equal, different cases");
            }
            else
            {
                Tester.print("Not equal");
            }

            // optional (shorthand) for combining logic using "and" "or"        
            int age = 20;
            double iq = 0.6;
            if (age >= 15 && iq >= 0.5)
            {       // && means "and"
                Tester.print("Get in");
            }
            else if (age >= 15 || iq >= 0.5)
            {  // || means "or"
                Tester.print("Try again later");
            }
            else
            {
                Tester.print("Get out");
            }

            //////////////////////////////////////////////////////////////////////
            // LOOPING:
            //////////////////////////////////////////////////////////////////////

            // simple "while" loop
            int counter = 1;
            while (counter <= 50)
            {
                Tester.print("counter = " + counter);
                counter++;
            }

            // while loop with a string
            new InputBox("Enter password").ShowDialog();
            string password = Storage.data;
            while (password == "1234")
            {
                Tester.print("Cannot use this!");
                new InputBox("Enter password").ShowDialog();
                password = Storage.data;
            }

            // second version of the while loop, very rarely used, tests at the 
            // bottom of the loop, this loop always runs at least once        
            do
            {
                new InputBox("Enter password").ShowDialog();
                password = Storage.data;
            } while (password != "qwerty");

            // the "for" loop, designed for counting        
            for (int i = 0; i < 10; i++)
            {
                Tester.print("i = " + i);
            }

            // second loop with variations
            for (int j = 10; j <= 100; j = j + 5)
            {
                Tester.print("j = " + j);
            }

            // for loop that counts down
            for (int i = 100; i >= 0; i--)
            {
                Tester.print("i = " + i);
            }

            //////////////////////////////////////////////////////////////////////
            // ASSIGNMENT EXAMPLE:
            //////////////////////////////////////////////////////////////////////

            // show a starting screen to welcome the user
            MessageBox.Show("Welcome to the"
                    + " dog age convertor!");
            // get the human age from the user (ask them)
            new InputBox("Enter your human age:").ShowDialog();
            string userInput = Storage.data;
            // convert that string into a number
            int humanAge = Convert.ToInt32(userInput);
            // use a math formula to change it to dog years
            int dogAge = humanAge * 7;
            // show the answer to the user
            MessageBox.Show("Your dog age is " + dogAge);
            // show a ending screen (dialog)
            MessageBox.Show("Thanks for using the"
                    + " dog age convertor!");

            Tester.print("Java basics completed!");
        }

        /// <summary>
        /// The example code for this unit
        /// </summary>
        private void unit2()
        {
            Tester.print("Methods unit started...");
            // code to "jump" to our method, "calling" the method 
            drawStar();         // calling a method with no parameters        
                                // In NetBeans, you can write the call to a method first and NetBeans 
                                // will help you write the method signature 
            draw("$");          // calling a method with 1 parameter
            draw("@");          // calling same method, with a different argument        
            draws("dalmations", 101);            // multiple arguments
            draws("problems", 99);               // seperate with commas        
            int number = giveMeNumber();        // method returning       
            draw("number is " + number);
            output("Hello");            // overloaded methods are methods with the
            output("Hi", "Example");     // same name but different parameters
            Tester.print("Methods unit completed!");
        }

        /// <summary>
        /// Draws a star
        /// </summary>
        private void drawStar()
        {
            draw("*");
        }

        /// <summary>
        /// Draws an item 
        /// </summary>
        /// <param name="item">the item to draw</param>
        private void draw(String item)
        {
            Tester.print(item);
        }

        /// <summary>
        /// Draws an item on the screen multiple times
        /// </summary>
        /// <param name="item">the item to draw</param>
        /// <param name="times">the number of times to draw the item</param>
        private void draws(String item, int times)
        {
            for (int i = 0; i < times; i++)
            {
                draw(item);
            }
        }

        /// <summary>
        /// Gives a random number
        /// </summary>
        /// <returns>a random number between 1 - 100</returns>
        private int giveMeNumber()
        {
            return random(random(1, 10), random(10, 100));
        }

        /// <summary>
        /// Generates a random number
        /// </summary>
        /// <param name="low">the lowest number in the range</param>
        /// <param name="high">the highest number in the range</param>
        /// <returns>the generated number</returns>
        private int random(int low, int high)
        {
            double seed = randomizer.NextDouble();
            double L = (double)low;
            double H = (double)high;
            double number = (H - L + 1) * seed + L;
            int answer = (int)number;
            return answer;
        }

        /// <summary>
        /// Display the text in a dialog box
        /// </summary>
        /// <param name="text">the text to display</param>
        private void output(String text)
        {
            MessageBox.Show(text);
        }

        /// <summary>
        /// Display the text in a dialog box with a title
        /// </summary>
        /// <param name="text">the text to display</param>
        /// <param name="title">the title at the top of the dialog</param>
        private void output(String text, String title)
        {
            MessageBox.Show(text,title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
               
        /// <summary>
        /// The example code for this unit
        /// </summary>
        private void unit3()
        {
            Tester.print("Arrays example started");

            // creating a variable for comparison
            int size = 5;

            // create an array with 10 spots and it automatically indexes each spot
            // starting with index 0, and each spot has undefined contents
            int[] array = new int[size];

            // put content into the individual elements:        
            array[0] = 5;
            array[1] = -5;
            array[2] = 0;
            array[3] = 55;
            array[4] = 555;
            // intentional errors, outside the bounds of the array
            // array[6] = 5555;        
            // array[-1] = 5555;

            // create an array with no size
            double[] a;
            // then give it a size
            a = new double[3];
            // put in some content
            a[1] = 3.14;
            // you can keep resizing (de-dimensioning) the array        
            a = new double[5];
            // every time the array is resized, the content
            // is destroyed (lost)

            // create "pre-filled" arrays        
            double[] coins = { 0.05, 0.10, 0.25, 1.00, 2.00 };

            //// arrays can also be constants
            string[] OPTIONS = {
                "New Game",
                "Save game",
                "Quit"
            };

            // create an emtpy array
            int[] numbers = new int[100];
            // go through the entire array 
            // using a for loop
            for (int i = 0; i < 100; i++)
            {
                numbers[i] = 25;
            }

            // change indivual indices of an array
            // just regular variables
            numbers[49] = 13;
            Tester.print(numbers[77]);

            // loop again (traverse), and using
            // a built in feature of arrays
            // called the length        
            for (int i = 0; i < numbers.Length; i++)
            {
                Tester.print(i + " = " +
                        numbers[i]);
            }

            // arrays working with methods:

            // method that takes a array as a parameter        
            output(coins);
            // tested with a different array
            double[] percents = { 0.0, 0.25, 0.50, 0.75, 1.00 };
            output(percents);
            // this array is a different type, so the method needs to be overloaded
            output(numbers);
            // returning arrays from methods
            int[] cards = random(2, 14, 52);
            output(cards);

            // create a 2 dimensional (2D) array also known as a matrix using some 
            // constants to help "visualize" the array in memory
            const int ROWS = 35;
            const int COLUMNS = 60;
            // create matrix
            char[,] matrix = new char[ROWS,COLUMNS];
            // now fill the matrix with values        
            for (int row = 0; row < ROWS; row++)
            {
                for (int column = 0; column < COLUMNS; column++)
                {
                    matrix[row, column] = random('!', '~');
                }
            }
            // create a method for 2D matrix
            output(matrix);

            Tester.print("Arrays example complete!");
        }
        
        /// <summary>
        /// Display the array in a dialog box
        /// </summary>
        /// <param name="a">the array to display</param>
        private void output(double[] a)
        {
            String text = "Array: \n";
            for (int i = 0; i < a.Length; i++)
            {
                text += "(" + i + ")    " + a[i] + "\n";
            }
            output(text);
        }

        /// <summary>
        /// Display the array in a dialog box
        /// </summary>
        /// <param name="a">the array to display</param>
        private void output(int[] a)
        {
            double[] array = convertTo(a);
            output(array);
        }

        /// <summary>
        /// Converts an array of integers into a array of doubles
        /// </summary>
        /// <param name="a">the array to convert</param>
        /// <returns>an array of doubles</returns>
        private double[] convertTo(int[] a)
        {
            double[] array = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                array[i] = (double)a[i];
            }
            return array;
        }
        
        /// <summary>
        /// Generates a random double
        /// </summary>
        /// <param name="low">the lowest double in the range</param>
        /// <param name="high">the highest double in the range</param>
        /// <returns>the generated number</returns>
        private double random(double low, double high)
        {
            return (high - low + 1) * randomizer.NextDouble() + low;
        }

        /// <summary>
        /// Generates a random character
        /// </summary>
        /// <param name="low">the lowest character in the range</param>
        /// <param name="high">the highest character in the range</param>
        /// <returns>the generated character</returns>
        private char random(char low, char high)
        {
            return (char)(random((int)low, (int)high));
        }

        /// <summary>
        /// Generates a random array of integers
        /// </summary>
        /// <param name="low">the lowest number in the range</param>
        /// <param name="high">the highest number in the range</param>
        /// <param name="size">the size of the array to generate</param>
        /// <returns>the generated array of integers</returns>
        private int[] random(int low, int high, int size)
        {
            int[] a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = random(low, high);
            }
            return a;
        }

        /// <summary>
        /// Display the matrix in a dialog box
        /// </summary>
        /// <param name="matrix">the matrix to display</param>
        private static void output(char[,] matrix)
        {
            string text = "";
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    text += matrix[r,c] + " ";
                }
                text += "\n";
            }
            display(text);
        }

        /// <summary>
        /// Displays text in a fancy dialog box with formatting
        /// </summary>
        /// <param name="text">the text to display</param>
        private static void display(string text)
        {
            new frmMessageBoxPlus(text, "Custom Message Box...", null,"Consolas");
        }

        /// <summary>
        /// The example code for this unit
        /// </summary>
        private static void unit4()
        {
            Tester.print("Classes example started...");

            // create (instantiate) an object for the class
            Person bobby = new Person();
            bobby.Talk();                   // call a class method

            Tester.print("Classes example complete!");
        }

    }
}
