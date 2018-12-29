using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Kredek.Db.Entities
{
    public class ContactEntiti
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual string NewNew { get; set; }
    }
}
