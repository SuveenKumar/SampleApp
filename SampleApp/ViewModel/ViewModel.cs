using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.ViewModel
{
    public class ViewModel:INotifyPropertyChanged
    {
        private string m_firstName;
        private string m_LastName;

        public ViewModel()
        {
            FirstName = "Deepti";
            LastName = "Gupta";
            Console.WriteLine(FirstName);
        }


        public string FirstName
        {
            get
            {
                return m_firstName;
            }
            set
            {
                m_firstName = value;
                OnPropertyChanged(nameof(FirstName));
                OnPropertyChanged(nameof(FullName));
            }
        }

        public string LastName
        {
            get
            {
                return m_LastName;
            }
            set
            {
                m_LastName = value;
                OnPropertyChanged(nameof(LastName));
                OnPropertyChanged(nameof(FullName));
            }
        }
        
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
