using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class BankAccountPrivate
    {
        private string _name;
        private int _accountNumber;

        public string CustomeName
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
