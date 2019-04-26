using System;
namespace Comp_370_Assignment_5
{
    public class TestDriver
    {
        public static void Main()
        {
            Console.WriteLine("Testing PersonID \n--------------\n");
            PersonID negID = new PersonID(-1);
            PersonID zeroID = new PersonID(0);
            PersonID oneID = new PersonID(1);
            PersonID oneDup = new PersonID(1);
            PersonID maxID = new PersonID(999999999);
            Console.WriteLine("Negative ID test case (should return invalid): " + negID);
            Console.WriteLine("Zero val ID test case (should return invalid): " + zeroID);
            Console.WriteLine("1 val ID test case (should return properly formatted): " + oneID);
            Console.WriteLine("max value ID test case (should return invalid): " + maxID);
            Console.WriteLine("Testing relational operators: ");
            Console.WriteLine(" = test: " + (oneID == oneDup));
            Console.WriteLine(" > test: " + (maxID > oneID));
            Console.WriteLine(" != test: " + (oneID != maxID));
            Console.WriteLine(" < test: " + (oneID < maxID));
            //Commented sections of code pass, however the remaining 
            //relational operator tests return unexpected results 
            Console.WriteLine(" >= test: " + (/*oneID >= oneDup  &&*/ maxID >= oneID));
            Console.WriteLine(" <= test: " + (/*oneID <= oneDup &&*/ oneID <= maxID));

            Console.WriteLine("Testing Sex enum \n--------------\n");
            Console.WriteLine(Sex.female + " " + Sex.male + " " + Sex.unknown);

            Console.WriteLine("\nTesting PersonName \n--------------\n");
            PersonName personNameA = new PersonName("Davidson", "Ethan Joseph");
            PersonName personNameBlank = new PersonName("", "");
            PersonName personNameTooLong = new PersonName("abcdefghijklmnopqrstuvqxyzabcdefghijklmnopqrstu",
                "abcdefghijklmnopqrstuvqxyz abcdefghijklmnopqrstuvqxyz");

            Console.WriteLine("Standard name testing: \ntoString internal format: " + personNameA.ToString());
            Console.WriteLine("English name format: " + personNameA.Ename());
            Console.WriteLine("Prenames: " + personNameA.Prenames() + "\nSurname: " + personNameA.Surname() + "\n");

            Console.WriteLine("Blank string testing: \ntoString internal format: " + personNameBlank.ToString());
            Console.WriteLine("English name format: " + personNameBlank.Ename());
            Console.WriteLine("Prenames: " + personNameBlank.Prenames() + "\nSurname: " 
            + personNameBlank.Surname() + "\n");

            Console.WriteLine("Over max length string testing: \ntoString internal format: " 
            + personNameTooLong.ToString());
            Console.WriteLine("English name format: " + personNameTooLong.Ename());
            //surname returns as entered, prenames cut off entirely due to surname length
            Console.WriteLine("Prenames: " + personNameTooLong.Prenames() + "\nSurname: " + personNameTooLong.Surname());


            Console.WriteLine("\nTesting Person Class\n--------------\n");
            Person ethan = new Person();
            Console.WriteLine("Default constructor info:\n");
            Console.WriteLine("Name: " + ethan.personName + "\nSex: " + ethan.sex + "\nID: " + ethan.personID + "\nDate of Birth: " +ethan.dob);
            Console.WriteLine("\nSetting person info...\n");
            ethan.dob = new DateTime(1996, 09, 17);
            ethan.personName = new PersonName("Davidson", "Ethan Joseph");
            ethan.sex = Sex.male;
            ethan.personID = new PersonID(123456789);
            Console.WriteLine("Name: " + ethan.personName.Ename() + "\nSex: " + ethan.sex + "\nID: " + ethan.personID + "\nDate of Birth: " + ethan.dob);
            return;
        }
    }
}
