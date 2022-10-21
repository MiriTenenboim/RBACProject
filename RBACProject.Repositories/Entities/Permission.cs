﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RBACProject.Repositories.Entities
{
    public class Permission
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return $"Permission: Id={this.Id} Name={this.Name} Description={this.Description}";
        }
    }
}