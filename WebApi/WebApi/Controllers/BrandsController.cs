using Business.Abstracts;
using Business.Dtos.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandsController : ControllerBase
{
    private readonly IBrandService _brandService;

    public BrandsController(IBrandService brandService)
    {
        _brandService = brandService;
    }

    [HttpPost]
    public IActionResult Add(CreateBrandRequest createBrandRequest)
    {
        var response = _brandService.Add(createBrandRequest);
        return CreatedAtAction("Add", response);
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var response = _brandService.GetAll();
        return Ok(response);
    }
}