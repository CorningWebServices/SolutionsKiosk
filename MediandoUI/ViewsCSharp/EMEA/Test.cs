using System;

using Xamarin.Forms;

namespace MediandoUI
{
	public class Test : ContentPage
	{
		public Test ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


