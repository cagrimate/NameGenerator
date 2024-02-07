using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NameGenerator
{
	internal class Program
	{
		private static readonly string[] letters = { "A", "E", "I", "O", "U" };
		private static readonly string[] Sletters = { "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z" };
		static void Main(string[] args)
		{
			//proje name generator olarak başlangıc seviye bir proje olacaktır
			var random = new Random();
			Dictionary<int, string> DictNames = new Dictionary<int, string>();
			Dictionary<int, string> DictSurnames = new Dictionary<int, string>();

			Console.WriteLine("How many names do you want to generate ?");
			int numberOfName = Convert.ToInt32(Console.ReadLine());

			//when does it start ? a-b
			int rndStrt = random.Next(0, 2);

			Console.WriteLine("Please select the number of words in the name.");

			//how many letters of name 
			int rndNameLetters = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Please select the number of words in the surname.");

			//how many letters of  surname
			int rndSurnameLetters = Convert.ToInt32(Console.ReadLine());

			int count = 1;
			for (int j = 0; j < numberOfName; j++)
			{
				switch (rndStrt)
				{
					case 0:
						{
							int sayacName = 1;
							int sayacSurname = 1;

							while (count <= numberOfName)
							{
								string name1 = "";
								string surName1 = "";
								List<string> name = new List<string>();
								List<string> surName = new List<string>();

								for (int i = 0; i < rndNameLetters;)
								{
									int rndName = random.Next(0, 5);
									name.Add(letters[rndName]);
									i++;
									if (i < rndNameLetters)
									{
										int rndSurname = random.Next(0, 21);
										name.Add(Sletters[rndSurname]);
										i++;
									}
								}
								name1 = string.Join("", name);
								DictNames.Add(sayacName, name1);
								sayacName++;

								for (int i = 0; i < rndSurnameLetters;)
								{
									int rndSurname = random.Next(0, 20);
									surName.Add(Sletters[rndSurname]);
									i++;
									if (i < rndSurnameLetters)
									{
										int rndName = random.Next(0, 4);
										surName.Add(letters[rndName]);
										i++;
									}
								}
								surName1 = string.Join("", surName);
								DictSurnames.Add(sayacSurname, surName1);
								sayacSurname++;

								Console.WriteLine("Result: " + name1 + " " + surName1);
								count++;
							}
						}
						break;
					case 1:
						{
							int sayacName = 1;
							int sayacSurname = 1;
							List<string> name = new List<string>();
							List<string> surName = new List<string>();

							while (count <= numberOfName)
							{
								string name1 = "";
								string surName1 = "";
								for (int i = 0; i < rndSurnameLetters;)
								{
									int rndSurname = random.Next(0, 20);
									surName.Add(Sletters[rndSurname]);
									i++;
									if (i < rndSurnameLetters)
									{
										int rndName = random.Next(0, 4);
										surName.Add(letters[rndName]);
										i++;
									}
								}
								surName1 = string.Join("", surName);
								DictSurnames.Add(sayacSurname, surName1);
								sayacSurname++;
								for (int i = 0; i < rndNameLetters;)
								{
									int rndName = random.Next(0, 5);
									name.Add(letters[rndName]);
									i++;
									if (i < rndNameLetters)
									{
										int rndSurname = random.Next(0, 21);
										name.Add(Sletters[rndSurname]);
										i++;
									}
								}
								name1 = string.Join("", name);
								DictNames.Add(sayacName, name1);
								sayacName++;

								Console.WriteLine("Result: " + name1 + " " + surName1);
								count++;
							}
						}
						break;
				}
				Console.ReadKey();
			}
		}
	}
}