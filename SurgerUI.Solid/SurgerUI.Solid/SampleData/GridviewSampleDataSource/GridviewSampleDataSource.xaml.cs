﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace SurgerUI.Solid.SampleData.GridviewSampleDataSource
{
	using System;
    using Windows.UI.Xaml; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class GridviewSampleDataSource { }
#else

	public class GridviewSampleDataSource : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public GridviewSampleDataSource()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("ms-appx:/SampleData/GridviewSampleDataSource/GridviewSampleDataSource.xaml", System.UriKind.RelativeOrAbsolute);
                Application.LoadComponent(this, resourceUri);
			}
			catch (System.Exception)
			{
			}
		}

		private Groups _Groups = new Groups();

		public Groups Groups
		{
			get
			{
				return this._Groups;
			}
		}
	}

	public class GroupsItem : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Property1 = string.Empty;

		public string Property1
		{
			get
			{
				return this._Property1;
			}

			set
			{
				if (this._Property1 != value)
				{
					this._Property1 = value;
					this.OnPropertyChanged("Property1");
				}
			}
		}

		private double _Property2 = 0;

		public double Property2
		{
			get
			{
				return this._Property2;
			}

			set
			{
				if (this._Property2 != value)
				{
					this._Property2 = value;
					this.OnPropertyChanged("Property2");
				}
			}
		}
	}

	public class Groups : System.Collections.ObjectModel.ObservableCollection<GroupsItem>
	{ 
	}
#endif
}
