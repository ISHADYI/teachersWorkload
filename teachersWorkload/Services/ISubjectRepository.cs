using teachersWorkload.Models;

namespace teachersWorkload.Services
{
    public interface ISubjectRepository
    {
        IEnumerable<Subject> GetAll();
        Subject GetById(int id);
        void Add(Subject subject);
        void Update(Subject subject);
    }
}
