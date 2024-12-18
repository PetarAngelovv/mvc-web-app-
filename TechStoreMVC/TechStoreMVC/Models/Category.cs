﻿namespace TechStoreMVC.Models
{
    public class Category
    { 
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} (ID: {Id})";
        }
    }
}
