﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User : Entity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public virtual ICollection<UserUseCase> UserUserCases { get; set; } = new HashSet<UserUseCase>();
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
        public virtual Cart Cart { get; set; }
    }
}
