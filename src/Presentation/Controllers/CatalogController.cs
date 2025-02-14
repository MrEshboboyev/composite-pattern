using Microsoft.AspNetCore.Mvc;
using Application.Services;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CatalogController : ControllerBase
{
    private readonly CatalogService _catalogService;

    public CatalogController() => _catalogService = new CatalogService();

    [HttpGet("display")]
    public IActionResult DisplayCatalog()
    {
        var catalog = _catalogService.GetSampleCatalog();
        catalog.Display(0);
        return Ok("Catalog displayed in console.");
    }
}
