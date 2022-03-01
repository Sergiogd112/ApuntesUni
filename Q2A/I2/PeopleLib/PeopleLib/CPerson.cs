using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleLib
{
    public class CPerson
    {
        //  ATTRIBUTES
        int age;
        float height;
        string name;
        public CPerson(int age=10,float height = 0, string name = "")
        {
            this.age = age;
            this.name = name;
            this.height = height;
        }

        //  METHODS

        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return (this.age);
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return (this.name);
        }
        public void SetHeight(float height)
        {
            this.height = height;
        }
        public float GetHeight()
        {
            return (this.height);
        }
        public bool IsOlderThan(CPerson p)
        {
            if (this.age > p.GetAge())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void CopyAgeTo(CPerson p)
        {
            p.SetAge(this.age);
        }
        public CPerson GetCopy()
        {
            // Create a copy of itself
            CPerson p = new CPerson();
            p.SetAge(this.age);
            p.SetHeight(this.height);
            p.SetName(this.name);

            // Return the new object (the copy) as a result
            return p;
        }
    }
}
