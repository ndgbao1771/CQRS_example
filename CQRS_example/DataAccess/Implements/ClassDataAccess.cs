using CQRS_example.DataAccess.Interfaces;
using CQRS_example.Models;

namespace CQRS_example.DataAccess.Implements
{
    public class ClassDataAccess : IClassDataAccess
    {
        private readonly Ex_DbContext _context;

        public ClassDataAccess(Ex_DbContext context)
        {
            _context = context;
        }

        public Class AddClass(string className)
        {
            var Class = new Class()
            {
                ClassName = className
            };
            _context.Classes.Add(Class);
            _context.SaveChanges();

            return Class;
        }

        public void DeleteClass(int id)
        {
            var result = GetClassById(id);
            if (result != null)
            {
                _context.Classes.Remove(result);
                _context.SaveChanges();
            }
        }

        public List<Class> GetClass()
        {
            return _context.Classes.ToList();
        }

        public Class GetClassById(int id)
        {
            return _context.Classes.FirstOrDefault(x => x.Id == id);
        }

        public Class UpdateClass(int id, Class classes)
        {
            var result = GetClassById(id);
            if (result != null)
            {
                result.ClassName = classes.ClassName;
                _context.SaveChanges();
            }

            return classes;
        }
    }
}
