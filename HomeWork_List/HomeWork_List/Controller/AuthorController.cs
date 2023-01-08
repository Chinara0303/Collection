using ServiceLayer.Services;

namespace HomeWork_List.Controller
{
    public class AuthorController
    {
        public void GetAuthorFullNameByFilteredAge()
        {
            AuthorService author = new();
            var authors= author.GetAuthorFullNameByFilteredAge();
            foreach (var item in authors)
            {
                Console.WriteLine($"{item.Name} {item.Surname}");
            }
        }
    }
}
