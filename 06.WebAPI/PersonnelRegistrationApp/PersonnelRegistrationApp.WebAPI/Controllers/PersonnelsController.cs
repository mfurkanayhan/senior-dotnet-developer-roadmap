using AutoMapper;
using FluentValidation.Results;
using GenericFileService.Files;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonnelRegistrationApp.WebAPI.DTOs;
using PersonnelRegistrationApp.WebAPI.Models;
using PersonnelRegistrationApp.WebAPI.Validators;

namespace PersonnelRegistrationApp.WebAPI.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class PersonnelsController : ControllerBase
{
    static List<Personnel> personnels = new();
    private readonly IMapper _mapper;
    public PersonnelsController(IMapper mapper) // Constructor
    {
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(personnels);
    }

    [HttpPost]
    public IActionResult Add([FromForm] PersonnelDto request)
    {
        string fileName = "";

        if (request.File is not null)
        {
            fileName = FileService.FileSaveToServer(request.File, "wwwroot/");
        }

        //PersonelDtoValidator validator = new();
        //ValidationResult result = validator.Validate(request);

        //if (!result.IsValid)
        //{
        //    return BadRequest(result.Errors.Select(s => s.ErrorMessage));
        //}

        Personnel personnel = _mapper.Map<Personnel>(request);
        personnel.Avatar = fileName;

        Personnel lastPersonnel = personnels.OrderBy(p => p.Id).LastOrDefault();

        if (lastPersonnel is null)
        {
            personnel.Id = 1;            
        }
        else
        {
            personnel.Id = lastPersonnel.Id + 1;
        }

        personnel.CreatedTime = DateTime.Now;
        personnels.Add(personnel);

        return Ok(new { Message = "API Running" });
    }

    [HttpPut]
    public IActionResult Update(int id, [FromForm] PersonnelDto request)
    {
        Personnel personnel = personnels.FirstOrDefault(p => p.Id == id);

        if (personnel is null)
        {
            return BadRequest(new { Message = "No such personnel found." });
        }

        _mapper.Map(request, personnel);
        if (request.File is not null)
        {
            FileService.FileDeleteToServer("wwwroot/" + personnel.Avatar);

            string fileName = FileService.FileSaveToServer(request.File, "wwwroot/");
            personnel.Avatar = fileName;            
        }

        return NoContent();
    }

    [HttpDelete]
    public IActionResult DeleteById (int id)
    {
        Personnel personnel = personnels.Find(p => p.Id == id);
        if (personnel is null)
        {
            return BadRequest(new { Message = "No personnel records found." });
        }
        if (!string.IsNullOrEmpty(personnel.Avatar))
        {
            FileService.FileDeleteToServer("wwwroot/" + personnel.Avatar);
        }

        personnels.Remove(personnel);
        return NoContent();
    }

    [HttpPost]
    public IActionResult FileMethod(List<IFormFile> file)
    {
        // Can be saved to a physical folder.
        // Can be uploaded to FTP.
        // Convert to bytes and store as text.
        // Can be saved to the cloud.
        // Can upload through an API or library to a hosting site and save the link.

        foreach (var f in file)
        {
            byte[] bytes = FileService.FileConvertByteArrayToDatabase(f);

            // 77 90 144 => exe
            using MemoryStream memoryStream = new MemoryStream();
            f.CopyTo(memoryStream);
            byte[] array = memoryStream.ToArray();
            string text = Convert.ToBase64String(array);

            using (var fileStream = new FileStream("wwwroot/test.xlsx", FileMode.Create))
            {
                fileStream.Write(bytes, 0, bytes.Length);
            }

            // FileStream stream = System.IO.File.Create("wwwroot/test.jpg");
            // f.CopyTo(stream);
        }

        return NoContent();
    }
}