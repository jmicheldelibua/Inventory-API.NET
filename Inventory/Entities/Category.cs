using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Inventory.Entities
{
    [Bind("CategoryId,Name,Description")]
    public class Category
    {
        
        
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [IgnoreDataMember]
        public bool Erased { get; set; }
        [IgnoreDataMember]
        public DateTime CreatedAt { get; set; }
        [IgnoreDataMember]
        public DateTime ModifiedAt { get; set; }
        [IgnoreDataMember]
        public DateTime ErasedAt { get; set; }

        [IgnoreDataMember]
        public List<Item> Items { get; set; }
    }
}
