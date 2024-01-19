using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortailService.Model
{
    public class User
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        //public string mail { get; set; }
        //public string address { get; set; }
        //public string phone { get; set; }


        public User() { }

        public User (/*int id,*/ string name/*, string mail, string address, string phone*/)
        {
            //Id = id;
            Name = name;
            //this.mail = mail;
            //this.address = address;
            //this.phone = phone;
        }
    }
}
