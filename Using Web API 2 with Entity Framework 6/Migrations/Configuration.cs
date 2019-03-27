namespace Using_Web_API_2_with_Entity_Framework_6.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Using_Web_API_2_with_Entity_Framework_6.Models.BookServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Using_Web_API_2_with_Entity_Framework_6.Models.BookServiceContext context)
        {
            context.Authors.AddOrUpdate(x => x.Id,
        new Author() { Id = 1, strName = "Jane Austen" },
        new Author() { Id = 2, strName = "Charles Dickens" },
        new Author() { Id = 3, strName = "Miguel de Cervantes" }
        );

            context.Books.AddOrUpdate(x => x.Id,
                new Book()
                {
                    Id = 1,
                    strTitle = "Pride and Prejudice",
                    intYear = 1813,
                    intAuthorId = 1,
                    decPrice = 9.99M,
                    strGenre = "Comedy of manners"
                },
                new Book()
                {
                    Id = 2,
                    strTitle = "Northanger Abbey",
                    intYear = 1817,
                    intAuthorId = 1,
                    decPrice = 12.95M,
                    strGenre = "Gothic parody"
                },
                new Book()
                {
                    Id = 3,
                    strTitle = "David Copperfield",
                    intYear = 1850,
                    intAuthorId = 2,
                    decPrice = 15,
                    strGenre = "Bildungsroman"
                },
                new Book()
                {
                    Id = 4,
                    strTitle = "Don Quixote",
                    intYear = 1617,
                    intAuthorId = 3,
                    decPrice = 8.95M,
                    strGenre = "Picaresque"
                }
                );

        }
    }
}
