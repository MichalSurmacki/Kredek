using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Zadanie.Db.Entities
{
    //Tabela posiadająca 5 kolumn o następujących nazwach
    public class BooksEntiti
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int YearOfPublish { get; set; }
        public virtual string Author { get; set; }
        public virtual bool IsLent { get; set; }
    }
}
