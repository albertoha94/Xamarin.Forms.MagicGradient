using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xamarin.MagicGradient.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Gradients Example";
        }
    }
}