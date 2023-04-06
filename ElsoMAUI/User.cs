using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoMAUI
{
    public class User
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool Gender { get; private set; }
        public DateTime Registered { get; private set; }
        /// <summary>
        /// Felhasználó létrehozása
        /// </summary>
        /// <param name="name">Teljes név</param>
        /// <param name="age">Életkor</param>
        public User(string name, int age, bool gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Registered = DateTime.Now;
            
        }
        public override string ToString()
        {
            return $"{Name} {(Gender ? "úr" : "úrnő")}, {Age} éves, {Registered.ToString("G")} dátummal regisztrálva!";
        }
    }
}
