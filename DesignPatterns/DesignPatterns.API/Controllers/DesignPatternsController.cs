using DesignPatterns.GoF.Creationals.AbstractFactory;
using DesignPatterns.GoF.Creationals.FactoryMethod;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DesignPatternsController : ControllerBase
{
    [HttpPost("FactoryMethod")]
    public IActionResult FactoryMethod(PaymentType? paymentType)
    {
        Operation operation = new();

        operation.SetPaymentType(paymentType);

        return Ok(operation.MakePayment());
    }

    [HttpPost("AbstractFactory")]
    public IActionResult AbstractFactory(string database)
    {
        UserDAO? userDAO = DAOFactory.SetFactory(database)?.CreateUserDAO;

        return Ok(new { Get = userDAO?.Get(), Save = userDAO?.Save() });
    }
}