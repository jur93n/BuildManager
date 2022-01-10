using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BuildManager.Models
{
    public class BuildManagerModel : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        private string _typeOfWork;
        private string _worker;
        private string _duration;
        private int _totalPrice;

        public string TypeOfWork
        {
            get { return _typeOfWork; }
            set 
            {
                if (_typeOfWork == value)
                    return;
                _typeOfWork = value;
                OnPropertyChanged("TypeOfWork");
            }
        }
        
        public string Worker
        {
            get { return _worker; }
            set 
            {
                if (_worker == value)
                    return;
                _worker = value;
                OnPropertyChanged("Worker");
            }
        }

        public string Duration
        {
            get { return _duration; }
            set 
            {
                if (_duration == value)
                    return;
                _duration = value;
                OnPropertyChanged("Duration");
            }
        }

        public int TotalPrice
        {
            get { return _totalPrice; }
            set 
            {
                if (_totalPrice == value)
                    return;
                _totalPrice = value;
                OnPropertyChanged("TotalPrice");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        
    }
}
