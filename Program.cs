using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORT
{
	class mass
	{
		int[] arr = new int[50];
		int[] arr3 = new int[50];
		int[] arr_pr = new int[50];
		public mass(int n)
		{

			Random rand = new Random();
			for (int i = 0; i < n; i++)
			{
				arr[i] = rand.Next(10, 99);
			}
	
		}
		public void array_3()
		{
			int j = 0;
			int k = 0;
			int n = this.arr.Length;
			for (int i = 0; i < n; i++)
			{
				if (this.arr[i] % 3 == 0)
				{
					this.arr3[j] = arr[i];
					j++;
				}
				else
				{
					this.arr_pr[k] = arr[i];
					k++;

				}
			}
		}
		public void arr_print(int[] arr)
		{
			for (int l = 0; l < arr.Length; l++)
			{
				if (arr[l]!=0) Console.Write(' ' + Convert.ToString(arr[l]));
			}
		}
		public void insert(int[] arr,int i_who, int i_where)
		{
			int b = arr[i_who];
			int j = i_who;
			while (j - 1 >= i_where)
			{
				arr[j] = arr[j - 1];
				j--;
			}
			arr[i_where] = b;
		}
		public void Sort(int[] arr)
		{
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] < arr[i-1])
				{
					if (i == 1)
					{
						this.insert(arr, 1, 0);
					}
					else
					{
						
						for (int k = 1; k < i; k++)
						{
							if (arr[i-(k+1)] < arr[i])
							{
								this.insert(arr, i, i-k);
								k=i;
							}
							else
							{
								if (i - (k + 1) == 0) this.insert(arr, i, 0);
							}
						}
					}
				}
			}
		}
		static void Main(string[] args)
		{
			int d = 50;
			mass t = new mass(d);
			t.arr_print(t.arr);
			Console.WriteLine();
			t.array_3();
			t.arr_print(t.arr3);
			Console.WriteLine();
			t.arr_print(t.arr_pr);
			t.Sort(t.arr3);
			t.Sort(t.arr_pr);
			Console.WriteLine();
			t.arr_print(t.arr3);
			Console.WriteLine();
			t.arr_print(t.arr_pr);
			int j = 0;
			for (int i = 0; i < t.arr.Length; i++)
			{
				if (t.arr3[i] != 0)
				{
					t.arr[j] = t.arr3[i];
					j++;
				}
			}
			for (int k = 0; k < t.arr.Length; k++)
			{
				if (t.arr_pr[k] != 0)
				{
					t.arr[j] = t.arr_pr[k];
					j++;
				}
			}
			Console.WriteLine();
			t.arr_print(t.arr);

		}
	}
}
