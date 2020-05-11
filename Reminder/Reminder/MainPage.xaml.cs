using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Reminder
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Reminder.ItemsSource = Reminds;

        }

        ObservableCollection<Remind> Reminds = new ObservableCollection<Remind>()
        {
            new Remind
            {
            }
        }; 

        public void Add(object sender, EventArgs e)
        {
            Reminds.Add(new Remind { Header = EHeader.Text, Description = EDiscription.Text });
        }
    }
}
