using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Banking.Data.Context;

public class BankingDbContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }

    public BankingDbContext()
    {
    }

    public BankingDbContext(DbContextOptions<BankingDbContext> options) : base(options)
    {
    }
    
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-AEMEP9V;Initial Catalog=BankingDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
}