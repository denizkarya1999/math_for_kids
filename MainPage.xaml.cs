using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Input.Inking;
using Windows.UI.Input.Inking.Analysis;
using Windows.UI.Xaml.Shapes;
using Windows.Storage.Streams;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace arithmetic_for_children
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static IDictionary<string, double> word_problems = new Dictionary<string, double>();
        List<double> Numbers = new List<double>();
        double result;
        bool first_round = true;
        string action = " ";
        string btn_clcked = "no";
        string repeated = "no";
        int question_number_int = 1;
        Random random;
        int random_question;
        double answer = 0.0;
        int corresponding_question;
        int scores = 0;
        public MainPage()
        {
            this.InitializeComponent();
            inkCanvas.InkPresenter.InputDeviceTypes =
    Windows.UI.Core.CoreInputDeviceTypes.Mouse |
    Windows.UI.Core.CoreInputDeviceTypes.Touch |
    Windows.UI.Core.CoreInputDeviceTypes.Pen;
            add_questions_and_answers();
            question_number.Text = question_number_int.ToString();
            word_problem.Text = generate_new_questions();
        }
        private void add_questions_and_answers()
        {
            word_problems.Add("The rabbit ate 2 bananas for breakfast, the monkey 4 bananas, and the elephant 6 bananas," +
                " how many bananas did the animals eat for breakfast", 12);
            word_problems.Add("There were 9 toys in the store. In the afternoon, 6 of them were bought. How many toys are left in the store ?", 3);
            word_problems.Add("Zack blinded 6 snowballs and Emma 2 more than Jack.How many snowballs did Emma make ?", 8);
            word_problems.Add("The distance between Mike's house and school is 9 mile. Mike left his house to school and had already " +
                "cycled 5 mile. How long he still has to cycle to school ?", 4);
            word_problems.Add("Natalie has $ 5 and Alex has $ 3. What`s the average of both?", 4);
            word_problems.Add("There were 4 balls in the basket, 5 more balls were put there. how many balls are in the basket?", 9);
            word_problems.Add("There were 8 candies on the table, Michael ate 4 of them how many candies were left on the table ?", 4);
            word_problems.Add("James had 5 toy cars and Mark had 9 toy cars. Who has more and how much ?", 4);
            word_problems.Add("In two days Tom read 9 pages, the first day he read 7 pages, how many pages did he read on the second day ?", 2);
            word_problems.Add("Max has 6 books, Audrey has 4 fewer. How many books do they have together ?", 8);
        }
        private string generate_new_questions()
        {

            random = new Random();
            random_question = random.Next(10);
            switch (random_question)
            {
                case 1:
                    corresponding_question = 1;
                    return word_problems.ElementAt(1).Key;
                case 2:
                    corresponding_question = 2;
                    return word_problems.ElementAt(2).Key;
                case 3:
                    corresponding_question = 3;
                    return word_problems.ElementAt(3).Key;
                case 4:
                    corresponding_question = 4;
                    return word_problems.ElementAt(4).Key;
                case 5:
                    corresponding_question = 5;
                    return word_problems.ElementAt(5).Key;
                case 6:
                    corresponding_question = 6;
                    return word_problems.ElementAt(6).Key;
                case 7:
                    corresponding_question = 7;
                    return word_problems.ElementAt(7).Key;
                case 8:
                    corresponding_question = 8;
                    return word_problems.ElementAt(8).Key;
                case 9:
                    corresponding_question = 9;
                    return word_problems.ElementAt(9).Key;
                case 10:
                    corresponding_question = 10;
                    return word_problems.ElementAt(10).Key;

            }
            return word_problems.ElementAt(random_question).Key; ;
        }

        private void number_assigner(string number_in_text)
        {
            Numbers.Add(Double.Parse(number_in_text));
        }

        private void one_button_Click(object sender, RoutedEventArgs e)
        {
            if (calculator_type_label.Text.Equals("0") || calculator_type_label.Text.Equals("Second number!"))
            {
                calculator_type_label.Text = "1";
            }
            else
            {
                calculator_type_label.Text = calculator_type_label.Text + "1";
            }
        }

        private void two_button_Click(object sender, RoutedEventArgs e)
        {
            if (calculator_type_label.Text.Equals("0") || calculator_type_label.Text.Equals("Second number!"))
            {
                calculator_type_label.Text = "2";
            }
            else
            {
                calculator_type_label.Text = calculator_type_label.Text + "2";
            }
        }

        private void three_button_Click(object sender, RoutedEventArgs e)
        {
            if (calculator_type_label.Text.Equals("0") || calculator_type_label.Text.Equals("Second number!"))
            {
                calculator_type_label.Text = "3";
            }
            else
            {
                calculator_type_label.Text = calculator_type_label.Text + "3";
            }
        }

        private void four_button_Click(object sender, RoutedEventArgs e)
        {
            if (calculator_type_label.Text.Equals("0") || calculator_type_label.Text.Equals("Second number!"))
            {
                calculator_type_label.Text = "4";
            }
            else
            {
                calculator_type_label.Text = calculator_type_label.Text + "4";
            }
        }

        private void five_button_Click(object sender, RoutedEventArgs e)
        {
            if (calculator_type_label.Text.Equals("0") || calculator_type_label.Text.Equals("Second number!"))
            {
                calculator_type_label.Text = "5";
            }
            else
            {
                calculator_type_label.Text = calculator_type_label.Text + "5";
            }
        }

        private void six_button_Click(object sender, RoutedEventArgs e)
        {
            if (calculator_type_label.Text.Equals("0") || calculator_type_label.Text.Equals("Second number!"))
            {
                calculator_type_label.Text = "6";
            }
            else
            {
                calculator_type_label.Text = calculator_type_label.Text + "6";
            }
        }

        private void seven_button_Click(object sender, RoutedEventArgs e)
        {
            if (calculator_type_label.Text.Equals("0") || calculator_type_label.Text.Equals("Second number!"))
            {
                calculator_type_label.Text = "7";
            }
            else
            {
                calculator_type_label.Text = calculator_type_label.Text + "7";
            }
        }

        private void eight_button_Click(object sender, RoutedEventArgs e)
        {
            if (calculator_type_label.Text.Equals("0") || calculator_type_label.Text.Equals("Second number!"))
            {
                calculator_type_label.Text = "8";
            }
            else
            {
                calculator_type_label.Text = calculator_type_label.Text + "8";
            }
        }

        private void nine_button_Click(object sender, RoutedEventArgs e)
        {
            if (calculator_type_label.Text.Equals("0") || calculator_type_label.Text.Equals("Second number!"))
            {
                calculator_type_label.Text = "9";
            }
            else
            {
                calculator_type_label.Text = calculator_type_label.Text + "9";
            }
        }

        private void dot_button_Click(object sender, RoutedEventArgs e)
        {
            if (calculator_type_label.Text.Equals("0") || calculator_type_label.Text.Equals(calculator_type_label.Text) && repeated == "no")
            {
                calculator_type_label.Text = calculator_type_label.Text + ".";
                repeated = "yes";
            }
        }

        private void equal_button_Click(object sender, RoutedEventArgs e)
        {
            number_assigner(calculator_type_label.Text);
            double result = 0.0;
            if (action.Equals("add"))
            {
                double max = Numbers.Max();
                double min = Numbers.Min();
                result = max + min;
            }
            if (action.Equals("substract"))
            {
                double max = Numbers.Max();
                double min = Numbers.Min();
                result = max - min;
            }
            if (action.Equals("divide"))
            {
                double max = Numbers.Max();
                double min = Numbers.Min();
                result = max / min;
            }
            if (action.Equals("multiply"))
            {
                double max = Numbers.Max();
                double min = Numbers.Min();
                result = max * min;
            }
            if (action.Equals("modulus"))
            {
                double max = Numbers.Max();
                double min = Numbers.Min();
                result = max % min;
            }
            calculator_type_label.Text = result.ToString();
            calculator_type_label_2.Text = "";
            Numbers.Clear();
            btn_clcked = "no";
        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            number_assigner(calculator_type_label.Text);
            calculator_type_label_2.Text = "Add";
            calculator_type_label.Text = "Second number!";
            btn_clcked = "yes";
            action = "add";
            repeated = "no";
        }

        private void clear_button_Click(object sender, RoutedEventArgs e)
        {
            calculator_type_label.Text = "0";
            calculator_type_label_2.Text = "Enter your answer or do calculation!";
            repeated = "yes";
            repeated = "no";
            Numbers.Clear();
        }

        private void substract_button_Click(object sender, RoutedEventArgs e)
        {
            number_assigner(calculator_type_label.Text);
            calculator_type_label_2.Text = "Substract";
            calculator_type_label.Text = "Second number!";
            btn_clcked = "yes";
            action = "substract";
            repeated = "no";
        }

        private void multiply_button_Click(object sender, RoutedEventArgs e)
        {
            number_assigner(calculator_type_label.Text);
            calculator_type_label_2.Text = "Multiply";
            calculator_type_label.Text = "Second number!";
            btn_clcked = "yes";
            action = "multiply";
            repeated = "no";
        }

        private void divide_button_Click(object sender, RoutedEventArgs e)
        {
            number_assigner(calculator_type_label.Text);
            calculator_type_label_2.Text = "Divide";
            calculator_type_label.Text = "Second number!";
            btn_clcked = "yes";
            action = "divide";
            repeated = "no";
        }

        private void modulus_button_Click(object sender, RoutedEventArgs e)
        {
            number_assigner(calculator_type_label.Text);
            calculator_type_label_2.Text = "Modulus";
            calculator_type_label.Text = "Second number!";
            btn_clcked = "yes";
            action = "modulus";
            repeated = "no";
        }

        private void square_root_button_Click(object sender, RoutedEventArgs e)
        {
            square_root_of_number(calculator_type_label.Text);
            repeated = "no";
        }

        private void square_root_of_number(string number)
        {
            double result = 0.0;
            result = Math.Sqrt(Double.Parse(number));
            calculator_type_label.Text = result.ToString();
            calculator_type_label_2.Text = "";
            Numbers.Clear();
            btn_clcked = "no";
        }

        private void generate_button_Click(object sender, RoutedEventArgs e)
        {
            if (question_number_int >= 10)
            {
                question_number_int = 1;
            }
            else
            {
                question_number_int++;
            }
            question_number.Text = question_number_int.ToString();
            word_problem.Text = generate_new_questions();
        }

        private void check_button_Click(object sender, RoutedEventArgs e)
        {
            answer = Double.Parse(calculator_type_label.Text);

            if (answer == word_problems.ElementAt(corresponding_question).Value)
            {
                var dialog = new MessageDialog("Generate new question if you want to practice.", "Correct");
                dialog.ShowAsync();
                scores += 10;
            }
            else
            {
                var dialog = new MessageDialog("Practice more questions by generating.", "Wrong !!!");
                dialog.ShowAsync();
            }
            calculator_type_label.Text = "0";
            if (question_number_int >= 10)
            {
                question_number_int = 1;
            }
            else
            {
                question_number_int++;
            }
            question_number.Text = question_number_int.ToString();
            word_problem.Text = generate_new_questions();
            score_label.Text = scores.ToString();
        }

        private void zero_button_Click(object sender, RoutedEventArgs e)
        {
            if (calculator_type_label.Text.Equals("0"))
            {
                calculator_type_label.Text = "0";
            }
            else
            {
                calculator_type_label.Text = calculator_type_label.Text + "0";
            }
        }

        private void reset_Tapped(object sender, TappedRoutedEventArgs e)
        {
            calculator_type_label.Text = "0";
            question_number_int = 1;
            question_number.Text = question_number_int.ToString();
            scores = 0;
            score_label.Text = scores.ToString();
        }

        private void submit_score_Tapped(object sender, RoutedEventArgs e)
        {
            if (scores >= 100)
            {
                var dialog = new MessageDialog("Show your score to your teacher and get credits.", "Well Done !!");
                dialog.ShowAsync();
                question_number_int = 1;
                question_number.Text = question_number_int.ToString();
                scores = 0;
                score_label.Text = scores.ToString();
            }
            else if (scores == 90)
            {
                var dialog = new MessageDialog("Show your score to your teacher and get credits. You may also need to work a little more.", "Good !");
                dialog.ShowAsync();
            }
            else if (scores == 80)
            {
                var dialog = new MessageDialog("You may also need to work a little more.", "Nice !");
                dialog.ShowAsync();
            }

            else if (scores == 70)
            {
                var dialog = new MessageDialog("Your score is noticeable! You may need to work a little more to get more archievement.", "Noticeable !");
                dialog.ShowAsync();
            }
            else
            {
                var dialog = new MessageDialog("You may need to work a little more to get more archievement. Keep studying to get a good point.", "Improvement Needed !!!");
                dialog.ShowAsync();
            }
        }

        private void about_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("Arithmetic for Kids by Deniz K.Acikbas and San Zhar. This application is made for MLH Surfs Up Hackhaton.", "About");
            dialog.ShowAsync();
        }
    }
}
