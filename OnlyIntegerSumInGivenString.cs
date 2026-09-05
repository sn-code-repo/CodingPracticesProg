using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProg
{
    class OnlyIntegerSumInGivenString
    {
		public int Sum(string str)
		{
			int sum = 0;
			string conti = String.Empty;
			foreach (char s in str)
			{

				if (IsInteger(s))
				{
					conti = conti + Convert.ToString(s);
					if (!String.IsNullOrEmpty(conti))
					{
						sum = sum + Convert.ToInt32(conti);
					}
				}
				else
				{					
					conti = string.Empty;
				}
			}

			Console.WriteLine(sum);
			return sum;
		}
		public bool IsInteger(char s)
		{
			try
			{
				int number;
				bool IsNumber = int.TryParse(s.ToString(), out number);
				return IsNumber;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

	}
}
