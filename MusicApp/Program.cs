using System;
using System.Linq;
using MusicApp.Data;
using MusicApp.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddDbContext<MusicAppContext>(options =>
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MusicAppDb;Trusted_Connection=True;"));

        var serviceProvider = services.BuildServiceProvider();
        var context = serviceProvider.GetRequiredService<MusicAppContext>();

       
        var artist = new Artist { FirstName = "John", LastName = "Doe", Country = "USA" };
        context.Artists.Add(artist);
        context.SaveChanges();

       
        var artists = context.Artists.ToList();
        foreach (var a in artists)
        {
            Console.WriteLine($"Artist: {a.FirstName} {a.LastName}, Country: {a.Country}");
        }
    }
}
