using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalClassExample
{
    class Animal
    {
        #region properties
        private string name;
        private string type;
        private string sound;
        private bool fur;
        #endregion

        #region fields
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }

        public bool Fur
        {
            get { return fur; }
            set { fur = value; }
        }
    #endregion

        public Animal()
        {

        }

        public Animal (string _name, string _type, string _sound, bool _fur)
        {
            this.name = _name;
            this.type = _type;
            this.sound = _sound;
            this.fur = _fur;
        }

        public static List<string> GetAnimalTypes(List<Animal> animals)
        { 
        List<string> animalTypes = new List<string>();
            foreach(Animal animal in animals)
            {
                if(!animalTypes.Contains(animal.Type))
                {
                    animalTypes.Add(animal.Type);
                }
            }
            return animalTypes;
        }

        public static void PrintAnimalTypes(List<Animal> animalList)
        {
            List<string> animalTypes = Animal.GetAnimalTypes(animalList);
            for (int i = 0; i < animalTypes.Count; i++)
            {
                Console.Write($"{animalTypes[i]}, ");
            }
        }
     }
}
