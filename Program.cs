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
			//Console uzerinde calısacaktır.
			var random = new Random();
			Dictionary<int, string> DictNames = new Dictionary<int, string>();
			Dictionary<int, string> DictSurnames = new Dictionary<int, string>();

			//List<string> DictNames = new List<string,int>();
			//List<string> DictSurnames = new List<string>();

			Console.WriteLine("How many names do you want to generate ?");
			int numberOfName = Convert.ToInt32(Console.ReadLine());
			//int numberOfName = 1;

			//when does it start ? a-b
			int rndStrt = random.Next(0, 2);


			Console.WriteLine("Please select the number of words in the name.");

			//how many letters of name 

			//int rndNameLetters = random.Next(0, 6);
			int rndNameLetters = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Please select the number of words in the surname.");

			//how many letters of  surname

			//int rndSurnameLetters = random.Next(0, 6);
			int rndSurnameLetters = Convert.ToInt32(Console.ReadLine());


			string name1, surName1;
			int count = 1;
			for (int j = 0; j < numberOfName; j++)
			{
				List<string> name = new List<string>();
				List<string> surName = new List<string>();

				switch (rndStrt)
				{
					case 0:
						{
							int sayac = 1;

							while (count <= numberOfName)
							{

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
								DictNames.Add(sayac, name1);
								sayac++;

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
								DictSurnames.Add(sayac, surName1);
								sayac++;

								Console.WriteLine("Result: " + name1 + " " + surName1);
								count++;
							}
						}
						break;
					case 1:
						{
							int sayac = 1;

							while (count <= numberOfName)
							{
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
								DictSurnames.Add(sayac, surName1);
								sayac++;

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
								DictNames.Add(sayac, name1);
								sayac++;

								Console.WriteLine("Result: " + name1 + " " + surName1);
								count++;
							}

						}
						break;
				}


				//if (rndStrt == 0)

				//{
				//    for (int i = 0; i < rndNameLetters; i += 2)
				//    {
				//        int rndName = random.Next(0, 5);
				//        name.Add(letters[rndName]);
				//        //i++;

				//        int rndSurname = random.Next(0, 21);
				//        name.Add(Sletters[rndSurname]);
				//        //i++;

				//    }
				//    name1 = string.Join("", name);
				//    DictNames.Add(name1);

				//    for (int i = 0; i < rndSurnameLetters; i += 2)
				//    {
				//        int rndSurname = random.Next(0, 20);
				//        surName.Add(Sletters[rndSurname]);
				//        //i++;

				//        int rndName = random.Next(0, 4);
				//        surName.Add(letters[rndName]);
				//        //i++;

				//    }
				//    surName1 = string.Join("", surName);
				//    DictSurnames.Add(surName1);

				//    Console.WriteLine("Result: " + name1 + " " + surName1);
				//}
				//else
				//{
				//    for (int i = 0; i < rndSurnameLetters; i += 2)
				//    {
				//        int rndSurname = random.Next(0, 20);
				//        surName.Add(Sletters[rndSurname]);
				//        //i++;
				//        int rndName = random.Next(0, 4);
				//        surName.Add(letters[rndName]);
				//        //i++;
				//    }
				//    surName1 = string.Join("", surName);
				//    DictSurnames.Add(surName1);


				//    for (int i = 0; i < rndNameLetters; i += 2)
				//    {
				//        int rndName = random.Next(0, 5);
				//        name.Add(letters[rndName]);
				//        //i++;
				//        int rndSurname = random.Next(0, 21);
				//        name.Add(Sletters[rndSurname]);
				//        //i++;

				//    }
				//    name1 = string.Join("", name);
				//    DictNames.Add(name1);

				//    Console.WriteLine("Result: " + name1 + " " + surName1);

				//    //string name1 = string.Join("", name);
				//    //string surName1 = string.Join("", surName);

				//    //Console.WriteLine("Result: " + name1 + " " + surName1);

				//}
			}


			//names.Add();


			//string firstName = firstNames[random.Next(0, firstNames.Length)];
			//string lastName = firstNames[random.Next(0, firstNames.Length)];

			Console.ReadKey();
		}
	}
}
