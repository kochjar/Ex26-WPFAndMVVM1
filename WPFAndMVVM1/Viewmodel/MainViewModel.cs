using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAndMVVM1.Viewmodel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string myLabelText = "Text not set yet";
        private string myTextBoxText = "Text not set yet";

        public string MyLabelText { 
            get { return myLabelText; } 
            set {
                myLabelText = value;
                OnPropertyChanged("MyLabelText");
            } 
        }
        public string MyTextBoxText { 
            get { return myTextBoxText; } 
            set { 
                myTextBoxText = value;
                Debug.WriteLine("Changing" + value);
                OnPropertyChanged("MyTextBoxText");
            } 
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)

        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;

            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        


    }
}
