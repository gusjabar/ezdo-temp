using System;
using System.Linq;
using System.Threading.Tasks;
using Repository.Entities;

namespace Repository
{
    public class DocOffSeedData
    {
        DocOffContext _context;
        public DocOffSeedData(DocOffContext context)
        {
            _context = context;
        }
        public async Task EnsuerDataSeed()
        {
            if (_context.Users.Any()) return;

             _context.Add(new User{
                  LastName="Barreto",
                  Name="Javier"
            });
            await _context.SaveChangesAsync();
        }
    }
}
