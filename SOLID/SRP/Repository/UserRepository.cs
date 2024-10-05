using SOLID.SRP.Context;
using SOLID.SRP.Models;

namespace SOLID.SRP.Repository
{
    public class UserRepository
    {
        private readonly SRPContext _context;

        public UserRepository(SRPContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            _context.Add(user);
        }

        public void Remove(User user)
        {
            _context.Remove(user);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
