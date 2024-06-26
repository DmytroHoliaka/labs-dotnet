﻿namespace LINQ_to_XML.DTO
{
    internal class CaretakerInfo
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"#{Id} | Name: {FullName} | Salary: {Salary}";
        }
    }
}
