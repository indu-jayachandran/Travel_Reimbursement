using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Application.Models;
using Microsoft.AspNetCore.Authorization;



namespace RaiseBillController.Controllers{


  public class RaiseBillController:Controller{
   
    

     public IActionResult Success(){
        return View();
    }
          

    public IActionResult Index()
      {
          return View();
      }

       public async Task<IActionResult> Logout()
    {  
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("MultiLogin","Index");
    }


  }

}