using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace My1WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          

        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBoxOne.Text);
            b = Convert.ToDouble(textBoxTwo.Text);
            switch (comboBox.Text)
            {
                case "+":
                    textBoxThree.Text = Convert.ToString(a + b);
                    break;
                case "-":
                    textBoxThree.Text = Convert.ToString(a - b);
                    break;
                case "*":
                    textBoxThree.Text = Convert.ToString(a * b);
                    break;
                case "/":
                    if(b == 0)
                    {
                        MessageBox.Show("На ноль делить нельзя!");
                    }
                    textBoxThree.Text = Convert.ToString(a / b);
                    break;
                default:
                    Console.WriteLine("Неизвестный оператор.");
                    break;
                
            }
        }


        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textBoxOne.Text = "";
            textBoxTwo.Text = "";
            textBoxThree.Text = "";
            comboBox.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string a = "=";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "myText";
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.InitialDirectory = @"D:/";
            saveFileDialog.Title = "Сохраните свой файл здесь";
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                using(StreamWriter sw =  new StreamWriter(@"D:/myText.txt", true))
                {
                    sw.Write(textBoxOne.Text);
                    sw.Write(comboBox.Text);
                    sw.Write(textBoxTwo.Text);
                    sw.Write(a);
                    sw.WriteLine(textBoxThree.Text);
                }
            }
            MessageBox.Show("Файл сохранен");

           
            }
        }
}
