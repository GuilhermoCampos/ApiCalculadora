using Microsoft.AspNetCore.Mvc;

namespace ApiDotnetCalculadora.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculadoraController : ControllerBase{
    public CalculadoraController(){

    }

    [HttpGet("+/{valores}")]
    public double Soma(string valores){
        string[] valoresSplit = valores.Split(",");
        int val1 = int.Parse(valoresSplit[0]);
        int val2 = int.Parse(valoresSplit[1]);
        return val1 + val2;
    }
}