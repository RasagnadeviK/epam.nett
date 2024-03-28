// See https://aka.ms/new-console-template for more information
using System;
namespace Lab1
{
    class Lab1
    {
        static int fibanocci(int num)
        {
            if (num<=1){
                return num;
            }
            int f1=0;
            int f2=1;
            int fn=0;
            int s=0;
            for(int i=2;i<=num;i++)
            {
                fn=f1+f2;
                f1=f2;
                f2=fn;
                s+=f1;
            }


            return s;
        }
        static int Count(int num)
        {
            string rd=Convert.ToString(num,2);
            int c=0;
            for(int i=0;i<rd.Length;i++)
            {
                if (rd[i]=='1')
                {
                    c++;
                }
            }
            return c;
        }
        static int sumofodd(int num)
        {
            int sum=0;
            int a;
            while(num>0){
                a=num%10;
                if(a%2!=0)
                {
                    sum+=a;
                }
                num/=10; 
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int num=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(sumofodd(num));
             Console.WriteLine((Count(14)));
             Console.WriteLine((fibanocci(5)));
        }

    }
}