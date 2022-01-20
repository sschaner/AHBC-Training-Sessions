using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesData
{
    class Program
    {
        static void Main(string[] args)
        {
            using(MoviesEntities db = new MoviesEntities())
            {
                Console.Write("Movie Title: ");
                string title = Console.ReadLine();

                DVD dvd = new DVD { Title = title };
                db.DVDs.Add(dvd);
                db.SaveChanges();

                List<DVD> dvds = db.DVDs.OrderBy(x => x.Title).ToList();

                foreach (DVD item in dvds)
                {
                    Console.WriteLine($"ID: {item.Id} - {item.Title}");
                }

                Console.Write("Enter the ID to delete: ");
                int id = int.Parse(Console.ReadLine());

                db.DVDs.Remove(db.DVDs.Where(x => x.Id == id).First());
                db.SaveChanges();

                Console.WriteLine();
                Console.WriteLine("Press any key to update the director of 'Man of Steel'.");

                DVD dvdToUpdate = db.DVDs.Single(x => x.Id == 1);
                dvdToUpdate.Director = "Zack Snyder";
                db.SaveChanges();

                Console.WriteLine();
                Console.WriteLine("Press any key to show list.");
                Console.WriteLine();

                Console.ReadKey();
                dvds = db.DVDs.OrderBy(x => x.Title).ToList();
                foreach (DVD item in dvds)
                {
                    Console.WriteLine($"{item.Title} - Directed by {item.Director}");
                }


                Console.ReadKey();

            }
        }
    }
}
