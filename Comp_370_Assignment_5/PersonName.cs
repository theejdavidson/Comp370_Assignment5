using System;
namespace Comp_370_Assignment_5
{
//  Person Name class (European version)      

//  Objects represent names of people, following the usual conventions for English
//  and other common European names, consisting of a surname and any number of 
//  given names.  

public struct PersonName
    {
        const int MAXLEN = 48;      //  Maximum length (to fit on mailing label, etc.)
        string value;             //  Internal representation (surname,given names)
                                  //  e.g. Bush,George Herbert Walker

        //  Constructors

        public PersonName(string last, string rest)
        {
            value = last.Trim() + "," + rest.Trim();
            if (value.Length > MAXLEN)
                value = value.Substring(0, MAXLEN);
        }

        //  Accessors

        public string Surname()
        { return value.Substring(0, value.IndexOf(',', 0)); }

        public string Prenames()
        { return value.Substring(value.IndexOf(',', 0) + 1); }

        public override string ToString()      //  Internal name format
        { return value; }


        public string Ename()                   //  English name format
        {
            int commaPosn = value.IndexOf(',', 0);
            return value.Substring(commaPosn + 1) + " " + value.Substring(0, commaPosn);
        }
    }
}
