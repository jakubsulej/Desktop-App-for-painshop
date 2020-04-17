using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    class HistoryModel
    {
        public int CoatQuantity { get; set; }
        public DateTime CoatTime { get; set; }
        public string User { get; set; }
        public string CoatType { get; set; }
        public DateTime CoatDate { get; set; }
    }
}
