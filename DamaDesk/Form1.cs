using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] button = new Button[8,8];
            int top = 0, left = 0;
            for(int i = 0; i < 8; i++)
            {
                for(int j=0; j < 8; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Width = 100;
                    button[i, j].Height = 100;
                    button[i, j].Top = top;
                    button[i, j].Left = left;
                    left += 50;
                    if((i+j)%2==0)
                    {
                        button[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        button[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(button[i, j]);
                }
                top += 50;
                left = 0;
            }

        }
    }
}
