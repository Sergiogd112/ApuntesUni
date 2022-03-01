using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleLib
{
    public class CList
    {
        const int MAXP = 10; // maximum number of people
        int number; // number of people in the list
        CPerson[] people; // vector of people 
        /// Constructor. Initializes the attributes of the list
        public CList()
        {
            number = 0;
            people = new CPerson[MAXP];
        }
        /// Adds a person at the end of the list
        /// param p: The person to be added
        /// returns: 0 everything Ok, -1 the vector was full
        public int AddPerson(CPerson p)
        {
            if (number == MAXP)
            {
                return -1;
            }
            else
            {
                people[number] = p;
                number++;
                return 0;
            }
        }
        public CPerson GetPerson(int i)
        {
            if (i < 0 || i >= number)
            {
                return null;
            }
            else
            {
                return people[i];
            }
        }
    }
}
