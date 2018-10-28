﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Controllers.Resources
{
    public class ContactResource
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
