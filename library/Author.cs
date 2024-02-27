using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class Author
    {
        private string name;
        private string email;

        public Author(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public void SetName(string name)
            { this.name = name;  }
        public void SetEmail(string name)
        { this.name = name; }

        public string GetName()
        {
            return name;
        }

    }
}
