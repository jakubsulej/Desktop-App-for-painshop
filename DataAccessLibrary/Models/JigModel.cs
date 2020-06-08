using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class JigModel
    {
        private string _jigName;

        public string JigName
        {
            get 
            { 
                return _jigName; }

            set 
            {
                _jigName = value;
            }

        }

        private int _jigNumber;

        public int JigNumber
        {
            get 
            { 
                return _jigNumber;
            }
            set 
            { 
                _jigNumber = value; 
            }
        }

    }
}
