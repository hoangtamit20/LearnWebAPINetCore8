using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DemoAPINet8.Models.Validations;

namespace DemoAPINet8.Models
{
    public class Shirt
    {
        private int shirtID;
        private string? brand;
        private string? color;
        private int size;
        private string? gender;
        private double price;

        public Shirt()
        {
        }

        public Shirt(int shirtID, string? brand, string? color, int size, string? gender, double price)
        {
            this.shirtID = shirtID;
            this.brand = brand;
            this.color = color;
            this.size = size;
            this.gender = gender;
            this.price = price;
        }

        public int ShirtID { get => shirtID; set => shirtID = value; }
        [Required]
        public string? Brand { get => brand; set => brand = value; }
        public string? Color { get => color; set => color = value; }
        [Shirt_EnsureCorrectSizing]
        public int Size { get => size; set => size = value; }
        public string? Gender { get => gender; set => gender = value; }
        public double Price { get => price; set => price = value; }
    }
}