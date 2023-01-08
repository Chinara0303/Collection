using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services
{
    public class AuthorService:IAuthorService
    {
        public List<Author> GetAuthorFullNameByFilteredAge()
        {
            var authors = GetAuthors();
            List<Author> authorList = new List<Author>();
            foreach (var author in authors)
            {
                if (author.Age > 40)
                {
                    authorList.Add(author);
                }
            }
            return authorList;
        }

        private List<Author> GetAuthors()
         {
            List<Author> authors = new();
            authors.Add(new Author()
            {
                Name = "Chingiz",
                Surname = "Abdullayev",
                Age = 63
            });
            authors.Add(new Author()
            {
                Name = "Anar",
                Surname = "Rzayev",
                Age = 84
            });
            authors.Add(new Author()
            {
                Name = "Elxan",
                Surname = "Elatli",
                Age = 61
            });
            return authors;
         }
    }
}
