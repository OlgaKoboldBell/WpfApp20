using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int[,] A = new int[4, 4];
        Random r1 = new Random();
        Random r2 = new Random();
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = "0";
            _1.Content = "0";
            _2.Content = "0";
            _3.Content = "0";
            _4.Content = "0";
            _5.Content = "0";
            _6.Content = "0";
            _7.Content = "0";
            _8.Content = "0";
            _9.Content = "0";
            _10.Content = "0";
            _11.Content = "0";
            _12.Content = "0";
            _13.Content = "0";
            _14.Content = "0";
            _15.Content = "0";
            _16.Content = "0";

            int a = r1.Next(1, 16);
            int b = r2.Next(1, 16);
            if (a == b)
            {
                while (a == b)
                {
                    a = r1.Next(0, 3);
                    b = r2.Next(0, 3);
                }
            }
            if (a == 1)
                _1.Content = "2";
            if (a == 2)
                _2.Content = "2";
            if (a == 3)
                _3.Content = "2";
            if (a == 4)
                _4.Content = "2";
            if (a == 5)
                _5.Content = "2";
            if (a == 6)
                _6.Content = "2";
            if (a == 7)
                _7.Content = "2";
            if (a == 8)
                _8.Content = "2";
            if (a == 9)
                _9.Content = "2";
            if (a == 10)
                _10.Content = "2";
            if (a == 11)
                _11.Content = "2";
            if (a == 12)
                _12.Content = "2";
            if (a == 13)
                _13.Content = "2";
            if (a == 14)
                _14.Content = "2";
            if (a == 15)
                _15.Content = "2";
            if (a == 16)
                _16.Content = "2";
            if (b == 1)
                _1.Content = "2";
            if (b == 2)
                _2.Content = "2";
            if (b == 3)
                _3.Content = "2";
            if (b == 4)
                _4.Content = "2";
            if (b == 5)
                _5.Content = "2";
            if (b == 6)
                _6.Content = "2";
            if (b == 7)
                _7.Content = "2";
            if (b == 8)
                _8.Content = "2";
            if (b == 9)
                _9.Content = "2";
            if (b == 10)
                _10.Content = "2";
            if (b == 11)
                _11.Content = "2";
            if (b == 12)
                _12.Content = "2";
            if (b == 13)
                _13.Content = "2";
            if (b == 14)
                _14.Content = "2";
            if (b == 15)
                _15.Content = "2";
            if (b == 16)
                _16.Content = "2";


        }

        private void NovaGra_Click(object sender, RoutedEventArgs e)
        {
                _1.Content = " ";
                _2.Content = " ";
                _3.Content = " ";
                _4.Content = " ";
                _5.Content = " ";
                _6.Content = " ";
                _7.Content = " ";
                _8.Content = " ";
                _9.Content = " ";
                _10.Content = " ";
                _11.Content = " ";
                _12.Content = " ";
                _13.Content = " ";
                _14.Content = " ";
                _15.Content = " ";
                _16.Content = " ";
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "")
                MessageBox.Show("Cпочатку натисніть СТАРТ!");
            else
            {
             FunConvert(A, r1, r2);

            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (A[i, j] != 0 && (i - 1) >= 0 && A[i - 1, j] == 0)
                    {
                        A[i - 1, j] = A[i, j];
                        A[i, j] = 0;
                    }
                    if (A[i, j] != 0 && (i - 1) >= 0 && A[i, j] == A[i - 1, j])
                    {

                        A[i - 1, j] = A[i - 1, j] + A[i, j];

                        if (A[i - 1, j] == 4)
                        {
                            tb.Text = (Convert.ToInt32(tb.Text) + 1000).ToString();
                        }

                        if (A[i - 1, j] == 8)
                        {
                            tb.Text = (Convert.ToInt32(tb.Text) + 5000).ToString();
                        }
                        if (A[i - 1, j] == 16)
                        {
                            tb.Text = (Convert.ToInt32(tb.Text) + 10000).ToString();
                        }
                        if (A[i - 1, j] == 32)
                        {
                            tb.Text = (Convert.ToInt32(tb.Text) + 20000).ToString();
                        }
                        A[i, j] = 0;
                    }
                }
            }
            FunRand2(A, r1, r2);
            FunToString(A, r1, r2);
                
            }
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "")
                MessageBox.Show("Cпочатку натисніть СТАРТ!");

            else
            {
                FunConvert(A, r1, r2);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (A[i, j] != 0 && (i + 1) <= 3 && A[i + 1, j] == 0)
                    {
                        A[i + 1, j] = A[i, j];
                        A[i, j] = 0;
                    }
                    if (A[i, j] != 0 && (i + 1) <= 3 && A[i + 1, j] == A[i, j])
                    {
                        A[i + 1, j] = A[i + 1, j] + A[i, j];
                        if (A[i + 1, j] == 4)
                        {
                            tb.Text = (Convert.ToInt32(tb.Text) + 1000).ToString();
                        }

                        if (A[i + 1, j] == 8)
                        {
                            tb.Text = (Convert.ToInt32(tb.Text) + 5000).ToString();
                        }
                        if (A[i + 1, j] == 16)
                        {
                            tb.Text = (Convert.ToInt32(tb.Text) + 10000).ToString();
                        }
                        if (A[i + 1, j] == 32)
                        {
                            tb.Text = (Convert.ToInt32(tb.Text) + 20000).ToString();
                        }
                        A[i, j] = 0;
                    }
                }
            }
            FunRand2(A, r1, r2);
            FunToString(A, r1, r2);
                //if (tb.Text == 50000.ToString())
                //    MessageBox.Show("Гру закінчено! МОЛОДЕЦЬ!");
            }
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "")
                MessageBox.Show("Cпочатку натисніть СТАРТ!");

            else
            {
                FunConvert(A, r1, r2);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (A[i, j] != 0 && (j + 1) <= 3 && A[i, j + 1] == 0)
                    {
                        A[i, j + 1] = A[i, j];
                        A[i, j] = 0;
                    }
                    if (A[i, j] != 0 && (j + 1) <= 3 && A[i, j + 1] == A[i, j])
                    {
                        A[i, j + 1] = A[i, j + 1] + A[i, j];
                        if (A[i, j + 1] == 4)
                        {
                            tb.Text = (Convert.ToInt32(tb.Text) + 1000).ToString();
                        }

                        if (A[i, j + 1] == 8)
                        {
                            tb.Text = (Convert.ToInt32(tb.Text) + 5000).ToString();
                        }
                        if (A[i, j + 1] == 16)
                        {
                            tb.Text = (Convert.ToInt32(tb.Text) + 10000).ToString();
                        }
                        if (A[i, j + 1] == 32)
                        {
                            tb.Text = (Convert.ToInt32(tb.Text) + 20000).ToString();
                        }
                        A[i, j] = 0;
                    }

                }
            }
            FunRand2(A, r1, r2);
            FunToString(A, r1, r2);
                //if (tb.Text == 50000.ToString())
                //    MessageBox.Show("Гру закінчено! МОЛОДЕЦЬ!");
            }
        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "")
                MessageBox.Show("Cпочатку натисніть СТАРТ!");

            else
            {
                FunConvert(A, r1, r2);
                for (int i = 3; i >= 0; i--)
                {
                    for (int j = 3; j >= 0; j--)
                    {
                        if (A[i, j] != 0 && (j - 1) >= 0 && A[i, j - 1] == 0)
                        {
                            A[i, j - 1] = A[i, j];
                            A[i, j] = 0;
                        }
                        if (A[i, j] != 0 && (j - 1) >= 0 && A[i, j - 1] == A[i, j])
                        {
                            A[i, j - 1] = A[i, j - 1] + A[i, j];


                            if (A[i, j - 1] == 4)
                            {
                                tb.Text = (Convert.ToInt32(tb.Text) + 1000).ToString();
                            }

                            if (A[i, j - 1] == 8)
                            {
                                tb.Text = (Convert.ToInt32(tb.Text) + 5000).ToString();
                            }
                            if (A[i, j - 1] == 16)
                            {
                                tb.Text = (Convert.ToInt32(tb.Text) + 10000).ToString();
                            }
                            if (A[i, j - 1] == 32)
                            {
                                tb.Text = (Convert.ToInt32(tb.Text) + 20000).ToString();
                            }
                            A[i, j] = 0;
                        }
                    }
                }

                FunRand2(A, r1, r2);
                FunToString(A, r1, r2);
                //if (tb.Text == 50000.ToString())
                //    MessageBox.Show("Гру закінчено! МОЛОДЕЦЬ!");
            }


        }
        void FunConvert(int[,] A, Random r1, Random r2)
        {
            A[0, 0] = Convert.ToInt32(_1.Content);
            A[0, 1] = Convert.ToInt32(_2.Content);
            A[0, 2] = Convert.ToInt32(_3.Content);
            A[0, 3] = Convert.ToInt32(_4.Content);
            A[1, 0] = Convert.ToInt32(_5.Content);
            A[1, 1] = Convert.ToInt32(_6.Content);
            A[1, 2] = Convert.ToInt32(_7.Content);
            A[1, 3] = Convert.ToInt32(_8.Content);
            A[2, 0] = Convert.ToInt32(_9.Content);
            A[2, 1] = Convert.ToInt32(_10.Content);
            A[2, 2] = Convert.ToInt32(_11.Content);
            A[2, 3] = Convert.ToInt32(_12.Content);
            A[3, 0] = Convert.ToInt32(_13.Content);
            A[3, 1] = Convert.ToInt32(_14.Content);
            A[3, 2] = Convert.ToInt32(_15.Content);
            A[3, 3] = Convert.ToInt32(_16.Content);
        }
        void FunToString(int[,] A, Random r1, Random r2)
        {
            _1.Content = A[0, 0].ToString();
            _2.Content = A[0, 1].ToString();
            _3.Content = A[0, 2].ToString();
            _4.Content = A[0, 3].ToString();
            _5.Content = A[1, 0].ToString();
            _6.Content = A[1, 1].ToString();
            _7.Content = A[1, 2].ToString();
            _8.Content = A[1, 3].ToString();
            _9.Content = A[2, 0].ToString();
            _10.Content = A[2, 1].ToString();
            _11.Content = A[2, 2].ToString();
            _12.Content = A[2, 3].ToString();
            _13.Content = A[3, 0].ToString();
            _14.Content = A[3, 1].ToString();
            _15.Content = A[3, 2].ToString();
            _16.Content = A[3, 3].ToString();
            //if (tb.Text == 50000.ToString())
            //    MessageBox.Show("Гру закінчено! МОЛОДЕЦЬ!");

        }
        void FunRand2(int[,] A, Random r1, Random r2)
        {
            int a = r1.Next(0, 3);
            int b = r2.Next(0, 3);
            if (A[a, b] == 0)
                A[a, b] = 2;
            else
            {
                while (A[a, b] != 0)
                {
                    a = r1.Next(0, 3);
                    b = r2.Next(0, 3);
                }
                A[a, b] = 2;
            }
        }
    }
}
