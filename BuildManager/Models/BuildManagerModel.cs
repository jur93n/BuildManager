using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.Models
{
    class BuildManagerModel
    {
        static DateTime CreationDate { get; set; } = DateTime.Now;

        private string _typeOfWork;
        private string _worker;
        private string _duration;
        private int _totalPrice;

        public string TypeOfWork
        {
            get { return _typeOfWork; }
            set { _typeOfWork = value; }
        }
        
        public string Worker
        {
            get { return _worker; }
            set { _worker = value; }
        }

        public string Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public int TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }


    }
}
