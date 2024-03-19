﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_XML.DTO
{
    internal class CaretakerCity
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? City { get; set; }

        public override string ToString()
        {
            return $"#{Id} | Name: {FullName} | City: {City}";
        }
    }
}
