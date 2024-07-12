namespace EasySplit.ES.Repositories.Models.Interfaces
{
    public interface IPersonRepository
    {
        Task<Person> GetByIdAsync (int id);
        Task AddAsync (Person person);
        Task UpdateAsync (Person person);
        Task DeleteAsync (int id);
    }
}
