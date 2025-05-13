using System;

namespace Lab7_CosmeticApp_UWP
{
    public static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            using var db = new Data.AppDbContext();
            db.Database.EnsureCreated();
            Console.WriteLine("Database created.");
        }
    }
}