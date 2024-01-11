using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Application.Models;
using Microsoft.AspNetCore.Authorization;
using Application.Filters;
using Serilog;

namespace Application.Controllers;

[ExceptionLogFilter]
public class ManagerController : Controller
{
    private readonly ILogger<ManagerController> _logger;

    public ManagerController(ILogger<ManagerController> logger)
    {
        _logger = logger;
    }

   

   
     [HttpGet]
    public IActionResult LoginManager()
    {
       
        return View();
    }
    
    [HttpPost]
     public IActionResult LoginManager(User user)
    {
       string result= Database.LoginManager(user);
       Console.WriteLine(result);
       if(result=="success")
       {
         Log.Information("Employee Login Triggered");
          HttpContext.Session.SetString("Name",user.Name);
          return RedirectToAction("Index","RaiseBill");
       }
       else{
        TempData["msg"]="Incorrect EmailID/Password";
        return View(); 
       }
    
     }
        
 }