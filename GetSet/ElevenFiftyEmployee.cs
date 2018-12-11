using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class ElevenFiftyEmployee
    {
        private int _id;
        private int _yearsExperience;
        private string _jobTitle;
        private string _employeeName;
        private string _commonWorkQuote;
        private string _company;

        public int Id
        {
            set
            {
                if (value < 0)
                    throw new Exception("The employee Id is not valid");
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

        public string Name
        {
            set
            {
                try
                {
                    this._employeeName = value;
                }
                catch (Exception)
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("The name is not valid");
                }
            }

            get
            {
                return this._employeeName;
            }
        }

        public void SetCommonWorkQuote(string quote)
        {
            this._commonWorkQuote = quote;
        }

        public string GetQuote()
        {
            return this._commonWorkQuote;
        }

        public string CommonWorkQuote { get; set; }
        public string CompanyName { get; set; }
    }
}
