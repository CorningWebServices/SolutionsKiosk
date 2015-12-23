using System.ComponentModel;
using PropertyChanged;

namespace MediandoUI
{
	[ImplementPropertyChanged]
	public class BaseViewModel 
	{
		public readonly MediandoDatabase db = App.Database;

		public bool IsLoading { get; set; }

		public bool IsRunning { get; set; }

		public bool IsDataDownloading{ get; set;}

	}
}
