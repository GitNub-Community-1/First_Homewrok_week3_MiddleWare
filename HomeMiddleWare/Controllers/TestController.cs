using Microsoft.AspNetCore.Mvc;
using DbContext;

namespace HomeMiddleWare.Controllers;
[ApiController]
public class TestController : ControllerBase
{
    [HttpGet("plus")]
    public int PlusNumbers(int a, int b)
    {
        var result = a + b;
        return result;
    }
    [HttpGet("minus")]
    public int MinusNumber(int a, int b)
    {
        var result = a - b;
        return result;
    }
    [HttpGet("multiplication")]
    public int MultNumber(int a, int b)
    {
        var result = a * b;
        return result;
    }
    [HttpGet("Devide")]
    public int DevidedNUmber(int a, int b)
    {
        var result = a / b;
        return result;
    }
    
}