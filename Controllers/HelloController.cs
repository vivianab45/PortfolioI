//import
using Microsoft.AspNetCore.Mvc;
//namespace
namespace PortfolioI.Controllers;

public class HelloController : Controller
{
    //route to Index front page
    [HttpGet]
    [Route("")]
    //render-"This is my Index!"
    public string Index()
    {
        return "This is my Index!";
    }

    //route to Projects
    [HttpGet]
    [Route("projects")]
    //render-"these are my projects"
    public string Projects()
    {
        return "These are my projects";
    }

    //route to Contact
    [HttpGet]
    [Route("contact")]
    //this will also work: [HttpGet("contact")]
    //render-"this is my contact!"
    public string Contact()
    {
        return "This is my Contact!";
    }
}   