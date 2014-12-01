using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using Microsoft.Win32;

namespace Wpf
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(text_1.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(text_1.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
            myAL.Sort();
            lbMain.Items.Add("Отсортированный массив");
            foreach (int elem in myAL)
            {
                lbMain.Items.Add(elem);
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lbMain.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
     
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(text_1.Text);
            Random rnd1 = new Random();
            int k=itemCount, x=0;
            int[] fibarray = new int[k];
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 0; index < itemCount; index++)
            {
                fibarray[index] = -100 + rnd1.Next(200);
                myAL.Add(fibarray[index]);
                lbMain.Items.Add(fibarray[index]);
            }

            lbMain.Items.Add("\nКоличество элементов, чьи соседи меньше: ");
            for (index = 1; index < itemCount-1; index++)
            {
                if (fibarray[index] > fibarray[index - 1] && fibarray[index] > fibarray[index + 1]) x++;
            }

            lbMain.Items.Add(x);
            lbMain.Items.Add("\nНомер элемента > 25: ");
            int y=-1;
            for (index = 0; index < itemCount; index++)
            {
                if (fibarray[index] > 25) { y = index; break; }
            }

            if (y != -1) lbMain.Items.Add(y);
            else lbMain.Items.Add("Такого элемента нет!");

            lbMain.Items.Add("\nСумма элементов, больших второго: ");
            int sum = 0;
            for (index = 0; index < itemCount; index++) {
                if (fibarray[index] > fibarray[1])
                    sum = sum + fibarray[index];
            }

            lbMain.Items.Add(sum);
        
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {

            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = 10;// Convert.ToInt32(text_1.Text);
            Random rnd1 = new Random();
            int k = itemCount, x = 0;
            int[] fibarray = new int[k];
            int first=0;
            int average=0;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 0; index < itemCount; index++)
            {
                fibarray[index] = -100 + rnd1.Next(200);
                myAL.Add(fibarray[index]);
                lbMain.Items.Add(fibarray[index]);
                average += fibarray[index];
            }
            first=fibarray[0];
          
            ///////Определить­, превосходи­т ли первый элемент массива из десяти чисел среднее значение элементов этого массива.
            if (first>(average/10)) { lbMain.Items.Add("\nПервый элемент превосходит среднее значение элементов этого массива "); }
            else{lbMain.Items.Add("\nПервый элемент не превосходит среднее значение элементов этого массива  ");}
            
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            //Дан массив из 10 чисел. Определить­ сколько раз меняется знак у его элементов.

            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = 10;// Convert.ToInt32(text_1.Text);
            Random rnd1 = new Random();
            int k = itemCount, x = 0;
            int[] fibarray = new int[k];
            int sign = 0;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 0; index < itemCount; index++)
            {
                fibarray[index] = -100 + rnd1.Next(200);
                myAL.Add(fibarray[index]);
                lbMain.Items.Add(fibarray[index]);
            }
         
             lbMain.Items.Add("\n Смена знака происходит ");
             for (index = 1; index < itemCount - 1; index++)
             {
                 if (fibarray[index] * fibarray[index - 1] < 0) sign++;
             }
           
            ///if (first > (average / 10)) { lbMain.Items.Add("\nПервый элемент превосходит среднее значение элементов этого массива "); }
            lbMain.Items.Add(sign);
            lbMain.Items.Add("раза"); 
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            //Найти, сколько   элементов массива из 10 чисел больше, чем   четвертый элемент этого массива.
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = 10;// Convert.ToInt32(text_1.Text);
            Random rnd1 = new Random();
            int k = itemCount, x = 0;
            int[] fibarray = new int[k];
            int sum=0;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 0; index < itemCount; index++)
            {
                fibarray[index] = -100 + rnd1.Next(200);
                myAL.Add(fibarray[index]);
                lbMain.Items.Add(fibarray[index]);
            }
       
            lbMain.Items.Add("\n Количество элементов которые превосходят 4 элемент массива равно: ");
            for (index = 0; index < itemCount; index++)
            {
                if (fibarray[index]>fibarray[3]) sum++;
            }

            ///if (first > (average / 10)) { lbMain.Items.Add("\nПервый элемент превосходит среднее значение элементов этого массива "); }
            lbMain.Items.Add(sum);
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            //Найти сумму элементов массива из 10 чисел, меньших, чем 21.
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = 10;// Convert.ToInt32(text_1.Text);
            Random rnd1 = new Random();
            int k = itemCount, x = 0;
            int[] fibarray = new int[k];
            int sum = 0;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 0; index < itemCount; index++)
            {
                fibarray[index] = -100 + rnd1.Next(200);
                myAL.Add(fibarray[index]);
                lbMain.Items.Add(fibarray[index]);
            }

            lbMain.Items.Add("\n Сумма элементов массива меньших 21 равна: ");
            for (index = 0; index < itemCount; index++)
            {
                if (fibarray[index] < 21) sum++;//+=fibarray[index]
            }
            lbMain.Items.Add(sum);
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            //Дан массив из 10 чисел. Увеличить на единицу значения всех элементов кратных 5.
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = 10;// Convert.ToInt32(text_1.Text);
            Random rnd1 = new Random();
            int k = itemCount, x = 0;
            int[] fibarray = new int[k];
            int sum = 0;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 0; index < itemCount; index++)
            {
                fibarray[index] = -100 + rnd1.Next(200);
                myAL.Add(fibarray[index]);
                lbMain.Items.Add(fibarray[index]);
            }

            lbMain.Items.Add("\n Новый массив  ( изменённый с условием: увеличить на единицу значения всех элементов кратных 5.) ");
            for (index = 0; index < itemCount; index++)
            {
                if (fibarray[index] % 5 == 0) fibarray[index]= fibarray[index]+1;//+=fibarray[index]
            }
            for (index = 0; index < itemCount; index++)
            {
                lbMain.Items.Add(fibarray[index]);
            }
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            //Для массива из 10 целых чисел подчитать сумму элементов,­ значения которых не кратны 3.
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = 10;// Convert.ToInt32(text_1.Text);
            Random rnd1 = new Random();
            int k = itemCount, x = 0;
            int[] fibarray = new int[k];
            int sum = 0;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 0; index < itemCount; index++)
            {
                fibarray[index] = -100 + rnd1.Next(200);
                myAL.Add(fibarray[index]);
                lbMain.Items.Add(fibarray[index]);
            }

            lbMain.Items.Add("\n Сумма элементов массива не кратных 3 равна : ");
            for (index = 0; index < itemCount; index++)
            {
                if (fibarray[index] %3!=0) sum++;
            }
            lbMain.Items.Add(sum);
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            //Для массива из десяти чисел подсчитать­, сколько чисел меньше первого элемента массива и одновремен­но больше последнего­ элемента.
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = 10;// Convert.ToInt32(text_1.Text);
            Random rnd1 = new Random();
            int k = itemCount, x = 0;
            int[] fibarray = new int[k];
            int sum = 0;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 0; index < itemCount; index++)
            {
                fibarray[index] = -100 + rnd1.Next(200);
                myAL.Add(fibarray[index]);
                lbMain.Items.Add(fibarray[index]);
            }

            lbMain.Items.Add("\n Сумма элементов массива  меньше первого элемента массива и одновремен­но больше последнего­ элемента : ");
            for (index = 0; index < itemCount; index++)
            {
                if ((fibarray[index]<fibarray[0]) && (fibarray[index]>fibarray[9])) sum++;
            }
            lbMain.Items.Add(sum);
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            //Дан массив из 10 чисел. Подсчитать­ количество­ не отрицатель­ных элементов массива.

            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = 10;// Convert.ToInt32(text_1.Text);
            Random rnd1 = new Random();
            int k = itemCount, x = 0;
            int[] fibarray = new int[k];
            int sum = 0;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 0; index < itemCount; index++)
            {
                fibarray[index] = -100 + rnd1.Next(200);
                myAL.Add(fibarray[index]);
                lbMain.Items.Add(fibarray[index]);
            }

            lbMain.Items.Add("\n Количество­ не отрицатель­ных элементов массива: ");
            for (index = 0; index < itemCount; index++)
            {
                if (fibarray[index] >=0) sum++;
            }
            lbMain.Items.Add(sum);
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {//Дан массив из 10 разных чисел. Найти элемент, меньше всего отличающий­ся от второго. Указание: функция абсолютной­ величины – ABS.
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = 10;// Convert.ToInt32(text_1.Text);
            Random rnd1 = new Random();
            int k = itemCount, x = 0;
            int[] fibarray = new int[k];
            int sum, sum2;
            int indexs = 0;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 0; index < itemCount; index++)
            {
                fibarray[index] = -100 + rnd1.Next(200);
                myAL.Add(fibarray[index]);
                lbMain.Items.Add(fibarray[index]);
            }
            sum = Math.Abs(fibarray[3] - fibarray[0]);

            lbMain.Items.Add("\n Элемент, меньше всего отличающий­ся от второго: ");
            for (index = 1; index < itemCount; index++)
            {if(index!=3){
                sum2 = Math.Abs(fibarray[3] - fibarray[index]);
                if (sum > sum2) { sum2 = sum; indexs = index; }
               // if (fibarray[index] >= 0) sum++;
            }}
            lbMain.Items.Add(index);
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            //Дан массив из 10 чисел. Подсчитать­ количество­ не нулевых элементов массива.
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = 10;// Convert.ToInt32(text_1.Text);
            Random rnd1 = new Random();
            int k = itemCount, x = 0;
            int[] fibarray = new int[k];
            int sum = 0;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 0; index < itemCount; index++)
            {
                fibarray[index] = -100 + rnd1.Next(200);
                myAL.Add(fibarray[index]);
                lbMain.Items.Add(fibarray[index]);
            }

            lbMain.Items.Add("\n Количество­ нулевых элементов массива: ");
            for (index = 0; index < itemCount; index++)
            {
                if (fibarray[index] != 0) sum++;
            }
            lbMain.Items.Add(sum);
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            //В массиве из 10 целых чисел подсчитать­ количество­ элементов,­ кратных 3.
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = 10;// Convert.ToInt32(text_1.Text);
            Random rnd1 = new Random();
            int k = itemCount, x = 0;
            int[] fibarray = new int[k];
            int sum = 0;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 0; index < itemCount; index++)
            {
                fibarray[index] = -100 + rnd1.Next(200);
                myAL.Add(fibarray[index]);
                lbMain.Items.Add(fibarray[index]);
            }

            lbMain.Items.Add("\n Сумма элементов массива н кратных 3 равна : ");
            for (index = 0; index < itemCount; index++)
            {
                if (fibarray[index] % 3 == 0) sum++;
            }
            lbMain.Items.Add(sum);
        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
            //Найти сумму элементов массива из 10 чисел, меньших, чем 5-й элемент этого массива.
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = 10;// Convert.ToInt32(text_1.Text);
            Random rnd1 = new Random();
            int k = itemCount, x = 0;
            int[] fibarray = new int[k];
            int sum = 0;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 0; index < itemCount; index++)
            {
                fibarray[index] = -100 + rnd1.Next(200);
                myAL.Add(fibarray[index]);
                lbMain.Items.Add(fibarray[index]);
            }

            lbMain.Items.Add("\n Количество элементов которые меньше чем 5 элемент массива равно: ");
            for (index = 0; index < itemCount; index++)
            {
                if (fibarray[index] < fibarray[4]) sum++;
            }
            lbMain.Items.Add(sum);

        }

        private void button18_Click(object sender, RoutedEventArgs e)
        {
            //Отобразить массив виде гистораммы
         
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = 10;// Convert.ToInt32(text_1.Text);
            Random rnd1 = new Random();
            int k = itemCount, x = 0, sum=0;
            int[] fibarray = new int[k];
            int[] fibarray2 = new int[k];
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 0; index < itemCount; index++)
            {
                fibarray[index] = -100 + rnd1.Next(200);
                if (fibarray[index] < 0) fibarray[index] = fibarray[index] * (-1);
                myAL.Add(fibarray[index]);
                lbMain.Items.Add(fibarray[index]);
                sum += fibarray[index];
            }

            lbMain.Items.Add("\n Массив в виде гистограммы:\n ");
            for (index = 0; index < itemCount; index++)
            {
                
                lbMain.Items.Add(fibarray2[index]);
            }

  
        }



    }
               
}
