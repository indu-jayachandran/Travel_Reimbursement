using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Application.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Web;
using Serilog;
using Application.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Controllers{


public class EmployeeController : Controller
{
    
   
      [HttpGet]
       public IActionResult LoginEmployee(){
        return View();

       }

    [HttpPost]
     public async Task<IActionResult>  LoginEmployee(User user)
    { 
      string result= Database.LoginEmployee(user);
       Console.WriteLine(result);
       if(result=="success")
       {   
        Log.Information("Employee Login Triggered");
        HttpContext.Session.SetString("Name",user.Name);
        return RedirectToAction("Success","RaiseBill");
          
       }
      else{
        TempData["msg"]="Incorrect EmailID/Password";
        return View(); 
       }
    
     }

}

}