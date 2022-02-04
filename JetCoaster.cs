using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class JetCoaster
    {
        public static int ride(int k,int[] g,int r)
        {
            //配列の個数[g.Length-1];
            //for (int i = 0; i <4; i++)
            //入れ替えループ
            /*itizihozon = g[0];
                g[0] = g[1];
                g[1] = g[2];
                g[2] = g[3];
                g[3] = itizihozon;*/

            //配列のコピー
            int[] qqq = new int[g.Length];
            Array.Copy(g, qqq,g.Length);

            int goukei = 0;      
            int itizihozon = 0;
            int teiin = k;//teiin=6
            //rの回数分ループ
            for (int w = 0; w < r; w++)
            {
                k = teiin;
                int count = 0;
                //rの1回のループ
                for (int i = 0; i < g.Length; i++)
                {
                    if (k >= g[i])
                    {
                        k = k - g[i];
                        goukei = goukei + g[i];
                        count = count + 1;
                    }
                    else
                    {
                        break;
                    }
                }
                //rで使用したcountをもとに配列を回転させる
                for (int j = 0; j < count; j++)
                {
                    itizihozon = g[0];
                    for (int q = 0; q < g.Length; q++)
                    {
                        if (q == g.Length - 1)//if (q == 3)4回目,
                        {
                            g[q] = itizihozon;
                        }
                        else//(q=0)1回目,(q=1)2回目,(q=2)3回目,
                        {
                            g[q] = g[q+1]; 
                        }
                    } 
                }
            }
            //配列のコピー
            Array.Copy(qqq, g, qqq.Length);
            //合計の表示
            return goukei;       
        }
    }
}
