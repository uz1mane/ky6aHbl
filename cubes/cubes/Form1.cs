using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cubes
{
    public partial class Form1 : Form
    {
        int counter = 0;
        Engine engine;
        public Form1()
        {
            InitializeComponent();
            engine = new Engine(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> ans = engine.Go();

            btFirst.Text = "You: " + ans[0].ToString();
            btSecond.Text = "Computer: " + ans[1].ToString();

            if (ans[0] > ans[1])
                btAnswer.Text = "You win!";
            if (ans[0] < ans[1])
            {
                if (counter < 3)
                    btAnswer.Text = "Computer wins!";
                else
                    btAnswer.Text = "Computer wins!))0)";
                counter++;
            }
            if (ans[0] == ans[1])
            {
                btAnswer.Text = "Draw!";
                counter = 0;
            }
        }
    }
}
