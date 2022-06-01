using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace assignmentsql
{
    public partial class MainPage : ContentPage
    {
        private List<Tshirt> _tshirts = new List<Tshirt>();

        public List<Tshirt> Tshirts
            { get { return _tshirts; }
        set { _tshirts = value; }
        }
        public MainPage()
        {
            InitializeComponent();

            CreateTshirts();

            BindingContext = this;

        }
        public void CreateTshirts()
        {
            Tshirt mytshirt = new Tshirt(350, "cotton", "M", "images.jpeg", Xamarin.Forms.Color.Orange);
            _tshirts.Add(mytshirt);

            Tshirt allens = new Tshirt(350, "100% cotton", "S", "tshirt5.jpg", Xamarin.Forms.Color.Black);
            _tshirts.Add(allens);

            Tshirt mihlali = new Tshirt(350, "100% cotton", "L", "mans.jpg", Xamarin.Forms.Color.AntiqueWhite);
            _tshirts.Add(mihlali);

            Tshirt sams = new Tshirt(350, "100% cotton", "XXL", "shirt4.jpg", Xamarin.Forms.Color.DeepPink);
            _tshirts.Add(sams);

            Tshirt tarryn = new Tshirt(350, "100% cotton", "L", "tshirt.jpg", Xamarin.Forms.Color.Blue);
            _tshirts.Add(tarryn);


        }

        private async void tshirtsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Tshirt tshirt = (Tshirt)e.Item;
            if (tshirt == null)
            {
                await Navigation.PushAsync(new MainPage());
            }
        }
    }
}
