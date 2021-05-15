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

        Engine engine;
        public Form1()
        {
            InitializeComponent();
            engine = new Engine(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> ans = engine.Go();

            btFirst.Text = "First dice: " + ans[0].ToString();
            btSecond.Text = "Second dice: " + ans[1].ToString();

            if (ans[0] > ans[1])
                btAnswer.Text = "Dice №1 wins!";
            if (ans[0] < ans[1])
                btAnswer.Text = "Dice №2 wins!";
            if (ans[0] == ans[1])
                btAnswer.Text = "Draw!";
        }
    }
}
