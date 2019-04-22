using EfcoreAutoMapDemoConsoles.Model;

namespace EfcoreAutoMapDemoConsoles
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var _context = new SchoolContext())
            {
                var stu = new Students()
                {
                    Name = "test",
                    Score = 100
                };
                _context.Set<Students>().Add(stu);
                _context.SaveChanges();
            }
        }
    }
}
