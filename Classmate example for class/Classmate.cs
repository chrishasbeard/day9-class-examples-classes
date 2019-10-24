using System;
using System.Collections.Generic;
using System.Text;

namespace Classmate_example_for_class
{
    class Classmate
    {
        #region fields
        private string name;
        private string hometown;
        private string favoriteFood;
        private string hobby;
        private double favoriteNumber;
        #endregion

        #region properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Hometown
        {
            get
            {
                return hometown;
            }
            set
            {
                hometown = value;
            }
        }

        public string FavoriteFood
        {
            get
            {
                return favoriteFood;
            }
            set
            {
                favoriteFood = value;
            }
        }

        public string Hobby
        {
            get
            {
                return hobby;
            }
            set
            {
                hobby = value;
            }
        }
        
        public double FavoriteNumber
        {
            get
            {
                return favoriteNumber;
            }
            set
            {
                favoriteNumber = value;
            }
        }
        #endregion


        #region methods
        public Classmate()
        {

        }

        public Classmate(string _name, string _hometown, string _favFood, string _hobby, double _favNum)
        {
            name = _name;
            hometown = _hometown;
            favoriteFood = _favFood;
            favoriteNumber = _favNum;
            hobby = _hobby;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Classmate" + Name);
            Console.WriteLine($"Hometown: {Hometown}");
            Console.WriteLine($"Favorite food: {FavoriteFood}");
            Console.WriteLine($"Favorite hobby: {Hobby}");
            Console.WriteLine($"Favorite number: {FavoriteNumber}");
        }

        public double SquareFavNumber()
        {
            return favoriteNumber * favoriteNumber;
        }

        #endregion

    }
}
