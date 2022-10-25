using System.Reflection.Metadata.Ecma335;
using WebApi.Models;
using WebApi.Models.Data;
using WebApi.Models.Entities;

namespace WebApi.Services
{
    public class CaseManager
    {
        private readonly DataContext _context;

        public CaseManager(DataContext context)
        {
            _context = context;
        }

        public async Task<CaseEntity> CreateCaseAsync(CaseRequest req)
        {
            try 
            {
                var caseEntity = new CaseEntity
                {
                    Email = req.Email,
                    Id = Guid.NewGuid(),
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    CustomerName = req.CustomerName,
                    Subject = req.Subject,
                    Message = req.Message,
                    Status = req.Status
                };

                _context.Add(caseEntity);
                await _context.SaveChangesAsync();

                return caseEntity;
            }
            catch 
            {
                return null;
            }
        }
    }
}
