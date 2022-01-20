using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using(BloggingEntities db = new BloggingEntities())
            {
                Console.Write("Blog Name: ");
                string name = Console.ReadLine();

                // Entity Framework will turn 'blog' into a row
                Blog blog = new Blog { Name = name };
                db.Blogs.Add(blog); // Adds it to your Context but doesn't save to your database. Must save to database.
                db.SaveChanges();


                List<Blog> blogs = db.Blogs.OrderBy(x => x.Name).ToList();

                Console.WriteLine();
                foreach (Blog item in blogs)
                {
                    Console.WriteLine($"ID: {item.BlogId} - {item.Name}");
                }

                Console.Write("Enter the ID to delete: ");
                int id = int.Parse(Console.ReadLine());

                //db.Blogs.Remove(db.Blogs.Where(x => x.Name == "Stupid Name").First()); // Removes from the database (must've saved to database first
                db.Blogs.Remove(db.Blogs.Where(x => x.BlogId == id).First());
                db.SaveChanges();

                Console.WriteLine();
                Console.WriteLine("Press key to update author.");

                Blog blogToUpdate = db.Blogs.Single(x => x.BlogId == 2);
                blogToUpdate.Author = "Gynell Schaner";
                db.SaveChanges();

                Console.WriteLine();
                Console.WriteLine("Press key to show list.");

                Console.ReadKey();
                blogs = db.Blogs.OrderBy(x => x.Name).ToList();
                foreach (Blog item in blogs)
                {
                    Console.WriteLine($"{item.Name} by {item.Author}");
                }

                Console.ReadKey();
            }
        }
    }
}
