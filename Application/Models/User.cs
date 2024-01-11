using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Application.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;



public class User{

  public int UserID{get; set;}

  public string? Name{get; set;}


  [Required(ErrorMessage = "Email is required.")]
  [EmailAddress]
  public string? EmailId{get;set;}


    [Required(ErrorMessage = "Password is required.")]
  [DataType(DataType.Password)]
  public string? userPassword{get;set;}

  public Boolean KeepLoggedIn{get; set;}

}