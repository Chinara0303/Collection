using DomainLayer.Models;


namespace ServiceLayer.Services.Interfaces
{
    public interface IAuthorService
    {
        List<Author> GetAuthorFullNameByFilteredAge();
    }
}
