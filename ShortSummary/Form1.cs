using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortSummary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            lines.Add("Никита Фоменко");
            lines.Add("Языки:\nC#\nPython\nC++\nJava");
            lines.Add("Учусь в компьютерной академии ШАГ");
            int charsCount = 0;
            foreach ( var line in lines)
            {
                charsCount += line.Count();
                if (line == lines.Last())
                {
                    MessageBox.Show(line, (charsCount / lines.Count).ToString());
                }
                else
                {
                    MessageBox.Show(line);
                }
                
            }
        }
    }
}
