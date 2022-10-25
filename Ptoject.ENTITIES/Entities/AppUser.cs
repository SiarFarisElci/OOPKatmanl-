using Microsoft.AspNetCore.Identity;
using Ptoject.ENTITIES.CoreInterfaces;
using Ptoject.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptoject.ENTITIES.Entities
{
    public class AppUser : IdentityUser<int> , IEntity
    {
        public AppUser()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public DateTime CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
