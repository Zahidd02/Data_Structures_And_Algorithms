using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary_Exercise_1
{
    internal class Student
    {
        public static Dictionary<String, Double> findMaxMinScorers(Dictionary<String, Double> studentMarks)
        {
            //Implement your logic here and change the return statement accordingly

            #region Finding Max and Min using Linq 
            //KeyValuePair<String, Double> max = (from x in studentMarks orderby x.Value descending select x).FirstOrDefault();
            //KeyValuePair<String, Double> min = (from x in studentMarks orderby x.Value ascending select x).FirstOrDefault();

            //Dictionary<String, Double> result = (from x in studentMarks where (x.Value == max.Value || x.Value == min.Value) select x).ToDictionary(x => x.Key, x => x.Value);
            //return result;
            #endregion

            #region Finding Max and Min using 1-1 array correspondence
            int i = 0;
            Double[] score = new Double[studentMarks.Count];
            String[] names = new String[studentMarks.Count];
            foreach (var item in studentMarks)
            {
                score[i] = item.Value;
                names[i] = item.Key;
                i++;
            }

            Double max = score[0];//90
            Double min = score[1];//68
            for (int j = 1; j < score.Length; j++)
            {
                if (max < score[j])
                {
                    max = score[j];
                }
                else if(min > score[j])
                {
                    min = score[j];
                }
            }

            Dictionary<String,Double> result = new Dictionary<String,Double>();

            for (int k = 0; k < score.Length; k++)
            {
                if(score[k] == max)
                {
                    result.Add(names[k], score[k]);
                }
                else if(score[k] == min)
                {
                    result.Add(names[k], score[k]);
                }
            }
            return result;
            #endregion
        }
    }
}
