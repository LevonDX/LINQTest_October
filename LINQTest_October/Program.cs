using System;
using System.Collections.Generic;

namespace LINQTest_October
{
	class Person
	{
		public int Id { get; set; }
		public string Name { get; set; } = "";
		public int Age { get; set; }
		public string Surname { get; set; } = "";
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			List<Person> persons = new List<Person>
				{
					new Person { Id = 1, Name = "John", Age = 25, Surname = "Doe" },
					new Person { Id = 2, Name = "Jane", Age = 30, Surname = "Smith" },
					new Person { Id = 3, Name = "Michael", Age = 35, Surname = "Johnson" },
					new Person { Id = 4, Name = "Emily", Age = 28, Surname = "Williams" },
					new Person { Id = 5, Name = "David", Age = 32, Surname = "Brown" },
					new Person { Id = 6, Name = "Olivia", Age = 27, Surname = "Jones" },
					new Person { Id = 7, Name = "Daniel", Age = 31, Surname = "Taylor" },
					new Person { Id = 8, Name = "Sophia", Age = 29, Surname = "Anderson" },
					new Person { Id = 9, Name = "Matthew", Age = 33, Surname = "Thomas" },
					new Person { Id = 10, Name = "Ava", Age = 26, Surname = "Wilson" }
				};

			var pns = persons.Select(p => new { p.Name, p.Surname }); // projection

			var a = new { Name = "John", Surname = "Doe", Age = 38 }; // unnamed type


			foreach (var item in pns)
			{
				Console.WriteLine($"{item}");
			}
		}
	}
}