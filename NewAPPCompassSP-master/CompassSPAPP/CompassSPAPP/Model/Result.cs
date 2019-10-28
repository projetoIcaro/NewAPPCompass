using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CompassSPAPP.Model
{
    public class Result : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private string jsonResult;
        public string JsonResult
        {
            get { return jsonResult; }
            set
            {
                if (jsonResult != value)
                {
                    jsonResult = value;
                    NotifyPropertyChanged();
                }
            }
        }

        

    }
}
