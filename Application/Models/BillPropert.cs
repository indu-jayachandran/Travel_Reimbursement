using System.ComponentModel.DataAnnotations;
using System.Web;
public class BillPropert{

    [Key]

    public int ID{get; set;}
    public string? FirstName{get; set;}

    public string? LastName{get; set;}

    public string? Email{get; set;}

    public String? Visited_Palce{get; set;}

    public string? Travel_By{get; set;}

    public string? vehicle_Name{get; set;}

    public string? Purpose_of_Visit{get; set;}

    public DateTime Date_of_Visit{get; set;}

    public DateTime Date_of_Return{get; set;}

    
     public string? Bill_File {get;set;}
    public long Bill_Number{get; set;}

    public DateTime Date_on_Bill{get; set;}

    public decimal Expense{get; set;}
    


}