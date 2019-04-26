using System;
namespace Comp_370_Assignment_5
{
    public class Person
    {
        public PersonID personID { get; set; }
        public PersonName personName { get; set; }
        public Sex sex { get; set; }
        public DateTime dob { get; set; }

        //default constructor
        public Person()
        {
            personID = new PersonID(0);
            personName = new PersonName("", "");
            sex = Sex.unknown;
            dob = new DateTime();
        }

        public override string ToString()
        {

            return base.ToString();
        }
    }
}
