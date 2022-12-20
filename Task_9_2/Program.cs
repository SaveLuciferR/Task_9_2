using System;
using System.Text.RegularExpressions;

namespace Task_9_2
{
	class Program
	{
		static void Main()
		{
			StreamReader fileIn = new StreamReader("text.txt");
			string text = fileIn.ReadToEnd();
			fileIn.Close();

			string afterText = "";

			string[] newText = Regex.Split(text, "[\n]+");

			foreach (string s in newText)
			{
				afterText += s[0] + " ";
			}

			Console.WriteLine(afterText);
		}
	}
}