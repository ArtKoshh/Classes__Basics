using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Classes__Basics
{
    internal class Human
    {
        private string firstname;
        private string lastname;
        private string eyeColour;
        private int age;

        public Human()
        {
            Console.WriteLine("Constructor called , Object created");
        }
        public Human(string firstname)
        {
            this.firstname = firstname;


        }
        public Human(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;

        }
        public Human(string firstname, string lastname, string eyeColour)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.eyeColour = eyeColour;

        }

        public Human(string firstname, string lastname, string eyeColour, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.eyeColour = eyeColour;
            this.age = age; 
        }

        public void IntroduceMyself()
        {
            if(age != 0 && lastname != null && firstname != null && eyeColour != null)
                Console.WriteLine("hi im {0} {1} my eye colour is {2} im {3} years old",firstname,lastname,eyeColour,age);
            else if(eyeColour != null && lastname != null && firstname != null)
            {
                Console.WriteLine("hi im {0} {1} i have eye colour {2}", firstname, lastname,eyeColour);
            }
            else if (firstname != null && lastname != null)
            {
                Console.WriteLine("hi im {0} {1}", firstname, lastname);
            }else if (firstname != null)
            {
                Console.WriteLine("hi my name is {0}", firstname);
            }

        }
    }
}
