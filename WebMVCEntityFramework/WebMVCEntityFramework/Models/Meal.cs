﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCEntityFramework.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}