using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace websql.Models
{
    public class Usertbl
    {
        private int id;
        private string name;
        private int gender;
        private string birth;
        private string pass;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        
        public string Name
        {
            get { return this.name; }
            set { this.name=value; }
        }

        public int Gender
        {
            get { return this.gender; }
            set { this.gender = value;  }
        }

        public string Birth
        {
            get { return this.birth; }
            set { this.birth = value; }
        }

        public string Pass
        {
            get { return this.pass; }
            set { this.pass=value;}
        }
    }
}
