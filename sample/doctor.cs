using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class doctor
    {
        string name;
        int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static doctor GetDoctorData(string name1,int age2)
        {
            doctor doc = new doctor();
            doc.name = name1;
            doc.age = age2;
            return doc;
        }
    }
}
