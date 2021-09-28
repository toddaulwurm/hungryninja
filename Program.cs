using System;
using System.Collections.Generic;

namespace hungryninja
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Buffet newbuffet = new Buffet();
            // Console.WriteLine(newbuffet.Serve().Name);
            Ninja first = new Ninja();
            // Console.WriteLine(first.CalorieIntake);
            first.Eat(newbuffet.Serve());
            first.Eat(newbuffet.Serve());
            first.Eat(newbuffet.Serve());
            first.Eat(newbuffet.Serve());
            Console.WriteLine(first.CalorieIntake);
        }
    }
    public class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy; 
        public bool IsSweet; 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        
        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
    }
    public class Buffet
    {
        public List<Food> Menu;
        
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Hummus", 100, true, false),
                new Food("fries", 500, false, false),
                new Food("siracha", 10, true, false),
                new Food("hamburger", 1000, false, false),
                new Food("risotto", 1500, false, false),
                new Food("icecream", 800, false, true),
                new Food("pie", 500, false, true)
            };
        }
        
        public Food Serve()
        {   
            Random rand = new Random();
            return Menu[(rand.Next(7))];
        }
    }
    class Ninja
    {
        public int CalorieIntake;
        public List<Food> FoodHistory;
        
        // add a constructor
        public Ninja()
        {
            CalorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        // add a public "getter" property called "IsFull"
        public bool IsFull
        {
            get
            {
                if(CalorieIntake>1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
        // build out the Eat method
        public void Eat(Food item)
        {
            if(!IsFull)
            {
                CalorieIntake+= item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"Name: {item.Name}, Spicy? {item.IsSpicy} Sweet? {item.IsSweet}");
            }
            else
            {
                Console.WriteLine("TOO FULL!");
            }
        }
    }
}
