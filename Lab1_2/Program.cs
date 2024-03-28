using System;

namespace Lab1_2{
    class Lab1_2
    {
        public static int Dis(int[] nums)
        {
            int maxValue=nums.Max();  
            int i=0;
            int j=nums.Length-1;
            while (nums[i]!=maxValue)
            {
                i++;
            }
            while (nums[j]!=maxValue)
            {
                j--;
            }
            return j-i;
        }
        public static void zero(int[,] matrix)
        {
            int n=matrix.GetLength(0);  
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<i;j++)  
                {
                    matrix[i,j]=0;
                }
            }
            for(int i=0;i<n;i++)
            {
                for(int j=i+1;j<n;j++)  
                {
                    matrix[i,j]=1;
                }
            }
        }
        public static int[] Swap(int[] rd)
        {
            int i=0;
            int j=rd.Length-1;
            while (i<rd.Length/2 && j>rd.Length/2)
            {
                if(rd[i]%2==0 && rd[j]%2==0)
                {
                    int temp=rd[i];
                    rd[i]=rd[j];
                    rd[j]=temp;
                }
                i++;
                j--;
            }
            return rd;
        }
        static void Main(string[] args)
        {
            int num=Convert.ToInt32(Console.ReadLine());
            int[] rd=new int[num];
            for(int i=0; i<num;i++)
            {
                rd[i]=Convert.ToInt32(Console.ReadLine());
            }
            int n2=Convert.ToInt32(Console.ReadLine());
            int[] rd1=new int[n2];
            for (int i=0;i<n2;i++)
            {
                rd1[i]=Convert.ToInt32(Console.ReadLine());
            }
            int[,] mat= new int[num,n2];
            for(int i=0;i<num;i++)
            {
                for(int j=0;j<n2;j++)
                {
                    mat[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            
            Console.WriteLine("\n");
            Swap(rd);
            zero(mat);
            for(int i=0;i<num;i++)
            {
                for(int j=0;j<n2;j++)
                {
                    Console.Write(mat[i,j] + " ");
                }
                Console.WriteLine("\n");
            }
            for (int i = 0; i < rd.Length; i++)
            {
                Console.Write(rd[i] + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine(Dis(rd1));
        }
    }
}