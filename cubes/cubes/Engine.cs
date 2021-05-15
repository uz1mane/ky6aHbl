using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubes
{
    class Engine
    {
        Form1 form;
        Random rand = new Random();

        public Engine(Form1 form)
        {
            this.form = form;
        }

        public List<int> Go()
        {
            List<double> p = new List<double>();

            p.Add((double)1 / 6);
            p.Add((double)2 / 6);
            p.Add((double)3 / 6);
            p.Add((double)4 / 6);
            p.Add((double)5 / 6); 
            p.Add(1);

            double answer1 = rand.NextDouble();
            double answer2;

            for (int i = 0; i < p.Count; i++)
            {
                if (answer1 - p[i] < 0)
                {
                    answer1 = i + 1;
                    break;
                }
            }
            
            //for (int i = 0; i < p.Count; i++)
            //{
            //    if (answer2 - p[i] < 0)
            //    {
            //        answer2 = i + 1;
            //        break;
            //    }
            //}

            switch (answer1)
            {
                case 1:
                    answer1 = 1;
                    break;
                case 2:
                    answer1 = 2;
                    break;
                case 3:
                    answer1 = 3;
                    break;
                case 4:
                    answer1 = 4;
                    break;
                case 5:
                    answer1 = 5;
                    break;
                case 6:
                    answer1 = 6;
                    break;                    
            }
            //switch (answer2)
            //{
            //    case 1:
            //        answer2 = 1;
            //        break;
            //    case 2:
            //        answer2 = 2;
            //        break;
            //    case 3:
            //        answer2 = 3;
            //        break;
            //    case 4:
            //        answer2 = 4;
            //        break;
            //    case 5:
            //        answer2 = 5;
            //        break;
            //    case 6:
            //        answer2 = 6;
            //        break;
            //}

            List<int> ans = new List<int>();

            ans.Add((int)answer1);
            if (answer1 < 6)
                answer2 = answer1 + 1;
            else
                answer2 = 6;
            ans.Add((int)answer2);

            return ans;
        }
    }
}
