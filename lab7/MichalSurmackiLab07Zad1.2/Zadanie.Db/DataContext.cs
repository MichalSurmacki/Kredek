using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Zadanie.Db.Entities;

namespace Zadanie.Db
{
    //baza danych
    public class DataContext : DbContext
    {
        //Tabela przechowywująca książki dostępne w zbiorze
        public virtual DbSet<BooksEntiti> BooksEntitis { get; set; }

        //Tabela przechowywująca wypożyczone książki
        public virtual DbSet<LoanedBooksEntiti> LoanedBooksEntitis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=MichalSurmackiLab07Zad12;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
      
    }
}
