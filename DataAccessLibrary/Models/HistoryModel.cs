using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class HistoryModel
    {
        public int CoatQuantity { get; set; }
        public string CoatTime { get; set; }
        public string User { get; set; }
        public string CoatType { get; set; }
        public string CoatDate { get; set; }
    }
}
