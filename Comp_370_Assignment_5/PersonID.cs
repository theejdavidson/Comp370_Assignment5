using System;
namespace Comp_370_Assignment_5
{
    //Person Identifier class (assumes U.S. Social Security format)

    struct PersonID
    {    //  Identifier for a person (U.S. Social Security version)
        int value;        //  Up to 999-99-9999 (one billion  minus 1)

        public PersonID(int ssn)           //  If illegal value, set negative
        { value = (ssn <= 0 || ssn > 999999999) ? -1 : ssn; }


        public override string ToString()
        {    //  Convert to common display form with hyphens
            if (value == 0) return ("unassigned");
            if (value < 0) return ("**invalid**");
            int part1, part2, part3;        //  Split into three subfields
            part1 = value / 1000000;
            part2 = (value - (part1 * 1000000)) / 10000;
            part3 = value % 10000;
            return part1.ToString("D3") + "-"      //  Supply leading zeros
                 + part2.ToString("D2") + "-"      //    on each subfield
                 + part3.ToString("D4");           //      as needed

        }

        //    Relational operators

        public static bool operator ==(PersonID ls, PersonID rs) { return ls.value == rs.value; }
        public static bool operator <(PersonID ls, PersonID rs) { return ls.value < rs.value; }
        public static bool operator !=(PersonID ls, PersonID rs) { return !(rs == ls); }
        public static bool operator >(PersonID ls, PersonID rs) { return rs < ls; }
        //Test driver found issue with the following operators:
        public static bool operator <=(PersonID ls, PersonID rs) { return !(rs > ls); }
        public static bool operator >=(PersonID ls, PersonID rs) { return !(rs < ls); }
    }
}