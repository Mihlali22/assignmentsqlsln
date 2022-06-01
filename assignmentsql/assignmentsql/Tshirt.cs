using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace assignmentsql
{
    public class Tshirt : INotifyPropertyChanged
    {
        private int _price;
        private string _size;
        private string _qualityType;

        private Color _colour;

        public event PropertyChangedEventHandler PropertyChanged;

        private string _imageName;

        public string ImageName
        {
            get { return _imageName; }
            set { _imageName = value;
                OnPropertyChanged();
            }
        }

       public Color Colour
        {
            get { return _colour; }
            set { _colour = value;
                OnPropertyChanged();
            }
        }

        public Tshirt()
        {
            this.Colour = Color.White;
            this._price = 0;
            this._size = "M";
            this._qualityType = "cotton";

            Console.WriteLine("");
        }

        public Tshirt(int price, string qualityType, string size,string imageName ,Color color)
        {
            _qualityType = qualityType;
            _price = price;
            _size = size;
            _colour = color;
            _imageName = imageName;

        }

        public string qualityType
        {
            get { return _qualityType; }
            set
            {
                _qualityType = value;
                OnPropertyChanged();
            }
        }

        public int price
        {
            get { return _price; }
            set { _price = value; OnPropertyChanged(); }
        }

        public string size
        {
            get { return _size; }
            set { _size = value; OnPropertyChanged(); }
        }



        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
