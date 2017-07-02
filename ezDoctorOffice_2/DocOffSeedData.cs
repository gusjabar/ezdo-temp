using System;
using System.Threading.Tasks;
using ezDoctorOffice_2.Models;
using ezDoctorOffice_2.Repository;

namespace ezDoctorOffice_2
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
            
             _context.Add(new User{
                  LastName="Barreto",
                  Name="Javier"
            });
            await _context.SaveChangesAsync();
        }
    }
}
