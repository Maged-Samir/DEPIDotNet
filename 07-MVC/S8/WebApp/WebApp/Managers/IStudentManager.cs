using WebApp.Models;

namespace WebApp.Managers
{
    public interface IStudentManager
    {
        public List<Student> GetAll();
        public Student GetById(int id);
        public int Insert(Student Student);
        public int Update(Student Student);
        public void Delete(int id);
    }
}
