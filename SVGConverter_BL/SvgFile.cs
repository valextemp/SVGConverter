using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SVGConverter_BL
{
    public class SvgFile : INotifyPropertyChanged
    {
        int dataChangingCount;
        int dataChangeCount;
        string svgFileName;
        string svgFullFileName;
        string status="Ожидание";

        public event PropertyChangedEventHandler PropertyChanged;

        public string SvgFileName { get=> System.IO.Path.GetFileName(svgFullFileName); }
        public string SvgFullFileName { get => svgFullFileName; }
        public int DataChangingCount
        {
            get => dataChangingCount;
            private set
            {
                dataChangingCount = value;
                OnPropertyChanged("DataChangingCount");
            }

        }
        public int DataChangeCount
        {
            get => dataChangeCount;
            private set
            {
                dataChangeCount = value;
                OnPropertyChanged("DataChangeCount");
            }
        }
        public string Status
        {
            get => status;
            private set
            {
                status = value;
                OnPropertyChanged("Status");
                //PropertyChanged(this, new PropertyChangedEventArgs("Status"));
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name="")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }


        public void AddChangingCount ()
        {
            DataChangingCount++;
        }

        public void AddChangeCount()
        {
            DataChangeCount++;
        }

        public void ResetDataChangingCount()
        {
            DataChangingCount = 0;
        }

        public void ResetDataChangeCount()
        {
            DataChangeCount = 0;
        }

        public void ResetCounts()
        {
            ResetDataChangingCount();
            ResetDataChangeCount();
        }

        public void StatusWait()
        {
            Status = "Ожидание";
        }

        public void StatusWork()
        {
            Status = "В работе";
        }

        public void StatusReady()
        {
            Status = "Готово";
        }

        public void StatusError()
        {
            Status = "Ошибка";
        }


        public SvgFile(string fullFileName)
        {
            svgFullFileName = fullFileName;
            dataChangingCount = 0;
            dataChangeCount = 0;
            StatusWait();
        }


    }
}
