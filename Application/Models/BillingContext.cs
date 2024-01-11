using Microsoft.EntityFrameworkCore;
using Application.Models;
public class BillingContext : DbContext
{
    public BillingContext(DbContextOptions<BillingContext> options) : base(options)
    {
    }
    public DbSet<BillPropert> BillProperts{ get; set; }

}
