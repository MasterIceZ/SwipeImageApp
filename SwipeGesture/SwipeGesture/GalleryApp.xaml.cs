using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwipeGesture
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GalleryApp : ContentPage
	{
		public GalleryApp ()
		{
			InitializeComponent ();
		}
		int state = 0, images = 5;
		string[] image_array = new string[5]
		{
            "https://i.redd.it/2axq83mwivja1.png",
            "https://i.redd.it/ith22br44bia1.jpg",
            "https://i.redd.it/soloh4rvekja1.png",
            "https://i.redd.it/5yqeuglgkrja1.jpg",
            "https://i.redd.it/erh614se9sia1.jpg"
        };
		void swipeHandler(object sender, SwipedEventArgs e)
		{
			if(e.Direction == SwipeDirection.Left)
			{
				state = (state + 1 + images) % images;
				img.Source = image_array[state];
			}
			else if(e.Direction == SwipeDirection.Right)
			{
				state = (state - 1 + images) % images;
				img.Source = image_array[state];
			}
		}
	}
}