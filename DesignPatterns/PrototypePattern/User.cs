using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{

    class User: IUser
    {
        public User(string name, string addr) {

            this.name = name;
            this.Address = addr;
        }
        private string name;
        public string Name {
            get
            {
                return name;
            }
        }
        public string Address { get; set; }
        private int age; 
        public int Age { 
        set
            {
                age = value;
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return  $"{name}    {age}   {Address}";
        }

    }
    interface IUser :ICloneable
    {
        string Address { get; set; }
        int Age { set; }
        string Name { get; }
    }



}
