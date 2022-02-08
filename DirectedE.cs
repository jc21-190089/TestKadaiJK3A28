using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DirectedE
    {
        public static int[] SEARCH(int[] f,int[] n,int s)
        {
            int i,t,w, top, last, x, temp;
            int N = f.Count();//点の個数
            int M = n.Count();//辺の個数
            int[] start = new int[] {0,1,2,3,4,2,5,4,6 };
            int[] end = new int[] {0,2,3,4,1,5,4,6,2 };


            //↓↓配列の複製↓↓
            int[] edgefirst = new int[N + 1];
            int[] edgenext = new int[M + 1];

            edgefirst[0] = 0;
            edgenext[0] = 0;

            for (t = 1; t <=N; t++)
            {
                edgefirst[t] = f[t-1];//edgefirst[t] = fcopy[t-1];
            }
            for (w = 1; w <= M; w++)
            {
                edgenext[w] = n[w-1];//edgenext[w] = ncopy[w-1];
            }
            //↑↑配列の複製↑↑
            

            int[] current = new int[N+1];//配列currentの作成
            int[] searched = new int[M+1];//配列serchedの作成
            int[] path = new int[M+1];//配列pathの作成

            for(i=0; i <= N; i++)
            {
                current[i] = edgefirst[i];
            }
            top = 1;
            last = M ;
            x = s;//出発点の設定
            while(last>=1)
            {
                if (current[x] != 0)
                {
                    temp = current[x];
                    searched[top] = temp;
                    current[x] = edgenext[temp];
                    x = end[temp];
                    top = top + 1;
                }
                else
                {
                    top = top - 1;
                    temp = searched[top];
                    path[last] = temp;
                    x = start[temp];
                    last = last - 1;
                }
            }
            int[] newpath = new int[M];

     
            for (int q = 0; q < M; q++)
            {
                newpath[q] = path[q + 1];
            }
            return newpath;


        }
    }
}

