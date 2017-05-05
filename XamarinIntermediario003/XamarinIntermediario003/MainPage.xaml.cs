using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinIntermediario003.Services;

namespace XamarinIntermediario003
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.btnCarregar.Clicked += async (sender, e) =>
                {
                    var tags = await Api.GetTagsAsync();
                    this.lvwTags.ItemsSource = tags;
                };
        }
    }
}
