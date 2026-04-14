using teachersWorkload.Models;

namespace teachersWorkload.Services
{
    public class SubjectRepository : ISubjectRepository
    {
        private List<Subject> subjects = new List<Subject>();

        public IEnumerable<Subject> GetAll() => subjects;
        public Subject GetById(int id) => subjects.FirstOrDefault(s => s.Id == id);
        public void Add(Subject subject)
        {
            subject.Id = subjects.Count + 1;
            subjects.Add(subject);
        }
        public void Update(Subject subject)
        {
            var existing = GetById(subject.Id);
            if (existing != null)
            {
                existing.Name = subject.Name;
                existing.Hours = subject.Hours;
                existing.GroupNumber = subject.GroupNumber;
                existing.Semester = subject.Semester;
                existing.IsOnline = subject.IsOnline;
            }
        }
    }
}
