using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Repository.Entities;

namespace Repository
{
    public class DocOffSeedData
    {
        DocOffContext _context;
        UserManager<DocOffUser> _userManager;

        public DocOffSeedData(DocOffContext context, UserManager<DocOffUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task EnsuerDataSeed()
        {
            if (await _userManager.FindByEmailAsync("gusjabar@yahoo.com.ar") == null)
            {

                var user = new DocOffUser()
                {
                    UserName = "gusjabar",
                    Email = "gusjabar@yahoo.com.ar"
                };
                await this._userManager.CreateAsync(user, "J@vier0#1");

            }

            if (!_context.Customers.Any())
            {
                _context.Add(new Customer
                {
                    LastName = "Barreto",
                    Name = "Javier"
                });
                await _context.SaveChangesAsync();
            }
        }
    }
}
