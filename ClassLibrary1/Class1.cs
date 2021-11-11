using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public class Class1
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="n"></param>
		/// <param name="str"></param>
		/// <param name="rez1"></param>
		/// <param name="rez2"></param>
		public static void Start(int n, out string str, out string str2,out string str3)
		{
			str = "";// строка с генерирированнными числами
			str2 = "";// строка с результатами чисел
			str3 = "";// строка с результатами чисел
			double rez1 = 0; //результат rez1
			double rez2 = 0; //результат rez2
			int zn = 0; // число
			Random rnd = new Random();
			for (int i = 0; i < n; i++)
			{
				//диапазон от -4 до 7
				zn = rnd.Next(-4, 7);
				if (zn > 0)
				{
					rez1 = Math.Sqrt(zn); //вычисляем результат
					rez1 = Math.Round(rez1);//округляем результат числа
					str2 += Convert.ToString(rez1) + " , ";//заполнение строки с результатами чисел
				}
				else
				{
					if (zn < 0)
					{
						rez2 = zn * zn;//вычисляем результат
						str3 += Convert.ToString(rez2) + " , ";//заполнение строки с результатами чисел
					}
				}
				str += Convert.ToString(zn) + " , "; //заполнение строки с геннерированными числами
			}
		}
	}
}
