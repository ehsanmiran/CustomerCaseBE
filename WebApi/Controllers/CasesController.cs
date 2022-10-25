using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/Cases")]
    [ApiController]
    public class CasesController : ControllerBase
    {
        private readonly CaseManager _caseManager;

        public CasesController(CaseManager caseManager)
        {
            _caseManager = caseManager;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CaseRequest req)
        {
            var cas = await _caseManager.CreateCaseAsync(req);
            if (cas != null)
                return new OkObjectResult(cas);

            return new BadRequestResult();
        }
    }
}
