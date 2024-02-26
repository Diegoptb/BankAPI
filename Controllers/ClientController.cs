using Microsoft.AspNetCore.Mvc;
using BankAPI.Data;
using BankAPI.Data.BankModels;

namespace BankAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
    private readonly BankContext _context;
    public ClientController(BankContext context)
    {
        _context = context;
    }

    [HttpGet("{id}")]
    public ActionResult<Client> GetById(int id)
    {
        var client = _context.Clients.Find(id);

        if (client is null)
        {
            return NotFound();
        }
        return client;
    }
}