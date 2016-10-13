using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIBasicStudyProgram.Test
{
    public class InotifyPropertyChanged : INotifyPropertyChanged
    {
        private string name;
        public string Name { get { return name; }set { name = value;RaisePropertyChanged("Name"); } }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("name"));
            }
        }
    }
}
