using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using okLims.Data;
using okLims.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace okLims.Controllers.api
{


[Authorize]
[Produces("application/json")]
[Route("api/InstrumentType")]
public class InstrumentTypeController : Controller
{
    private readonly ApplicationDbContext _context;

    public InstrumentTypeController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetInstrumentType()
    {
        List<InstrumentType> Items = await _context.InstrumentType.ToListAsync();
        int Count = Items.Count();
        return Ok(new { Items, Count });
    }

    [HttpPost("[action]")]
    public IActionResult Insert([FromBody]CrudViewModel<InstrumentType> payload)
    {
        InstrumentType InstrumentType = payload.value;
        _context.InstrumentType.Add(InstrumentType);
        _context.SaveChanges();
        return Ok(InstrumentType);
    }

    [HttpPost("[action]")]
    public IActionResult Update([FromBody]CrudViewModel<InstrumentType> payload)
    {
        InstrumentType InstrumentType = payload.value;
        _context.InstrumentType.Update(InstrumentType);
        _context.SaveChanges();
        return Ok(InstrumentType);
    }

    [HttpPost("[action]")]
    public IActionResult Remove([FromBody]CrudViewModel<InstrumentType> payload)
    {
        InstrumentType InstrumentType = _context.InstrumentType
            .Where(x => x.InstrumentTypeId == (int)payload.key)
            .FirstOrDefault();
        _context.InstrumentType.Remove(InstrumentType);
        _context.SaveChanges();
        return Ok(InstrumentType);

    }

}
}
