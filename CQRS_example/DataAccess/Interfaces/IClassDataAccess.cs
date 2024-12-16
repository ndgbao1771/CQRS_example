using CQRS_example.Models;

namespace CQRS_example.DataAccess.Interfaces
{
    public interface IClassDataAccess
    {
        List<Class> GetClass();
        Class GetClassById(int id);
        Class AddClass(string className);
        Class UpdateClass(int id, Class classes);
        void DeleteClass(int id);
    }
}
