using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Zadanie.Db.Entities
{
    //Tabela posiadająca 4 kolumny o następujących nazwach
    public class LoanedBooksEntiti
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual int IdBook { get; set; }
        public virtual string Name { get; set; }
        public virtual string DateOfLend { get; set; }
    }
}
