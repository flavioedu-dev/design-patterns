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
    public IActionResult AbstractFactory(string? database)
    {
        DAOFactory dAOFactory = DAOFactory.SetFactory(database);

        UserDAO userDAO = dAOFactory.CreateUserDAO;

        return Ok(userDAO.Get());
    }
}
