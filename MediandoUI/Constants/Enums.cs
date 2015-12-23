using System;

namespace MediandoUI
{
	public enum LayoutType
	{
		ListLayout = 1,
		TiledLayout = 2
	}

	public enum LibraryType
	{
		NewsLetter = 1,
		All = 2,
		MyDocuments = 3,
		Search = 4
	}
			

	public enum IOSDevices
	{
		Simulator = 0,
		IPhone4S = 1,
		IPhone5 = 2,
		IPhone5S = 3,
		IPhone6 = 4,
		IPhone6Plus = 5,
		IPad2 = 6,
		IPadWithRetina = 7,
		IPadAir = 8,
		IPadMini = 9,
		IPhone6S = 10,
		IPhone6SPlus = 11,
		UnKnown = 100,
	}

	public enum DeviceGroup
	{
		Small, //IPhone 4S
		Medium, //IPhone 5, IPhone 5S, Nexus 5, 
		Large,	//Iphone 6, Nexus 5, Galaxy S5
		ExtraLarge //IPhone 6S, Nexus 6
	}

	public enum Orientation
	{
		Portrait,
		Landscape
	}

	public enum VideoState
	{
		STOP,
		RESTART,
		PAUSE,
		PLAY,
		ENDED,
		NONE
	}
		
}

