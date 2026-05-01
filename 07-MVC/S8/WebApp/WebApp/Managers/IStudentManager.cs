using WebApp.Models;

namespace WebApp.Managers
{
    public interface IStudentManager  : IGenericManager<Student>
    {
        public Student GetByName(string name);
 
    }
}
