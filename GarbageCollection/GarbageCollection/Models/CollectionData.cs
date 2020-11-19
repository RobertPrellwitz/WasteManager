using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GarbageCollection.Models
{
    public class CollectionData
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date{ get; set; }
        public bool Paid { get;set;}
        public bool special { get; set; }
        public double charge { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser identityUser { get; set; }

    }
}
