using System;
using System.ComponentModel.DataAnnotations;
//Created by Aucharla Maneesh- 700731564
namespace AucharlaVersionE.Models
{
    public class AucharlaModel
    {
        // This property is for input number box
        [Range(1,100, ErrorMessage ="Please enter a number in the range of 1 and 100.")]
        [Display(Name ="Please enter Circle Measurements:")]
        public int Measurement { get; set; }

        //Property for check box
        [Display(Name = "The number entered is Diameter of the Circle:")]
        public bool IsDiameter { get; set; }

        //Value to display Area
        public double Area { get; set; }

        //Value to display Circumference
        public double Circumference { get; set; }

        //Thsi method calculates Area and Circumference based on provided input either by Radius or Diamtere
        public string CalculateAreaAndCircumference()
        {
            if(IsDiameter) // Since its a boolean we can directly check
            {
                //Number entered is diameter
                Area = Math.PI * ((Measurement / 2) * (Measurement / 2));
                Circumference = Math.PI * Measurement;

                return $"Area of Circle with diameter: {Measurement} units is {Area} units. Circumference is {Circumference}";
            }
            else
            {
                //Number entered is Radius
                Area = Math.PI * Measurement * Measurement;
                Circumference = 2 * Math.PI * Measurement;

                return $"Area of Circle with radius: {Measurement} units is {Area} units. Circumference is {Circumference}";
            }

        }

    }
}
