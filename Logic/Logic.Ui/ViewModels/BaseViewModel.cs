﻿namespace Ui.Mobile.ViewModels
{
	using Models;
	using Services;
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Linq;
	using System.Runtime.CompilerServices;
	using Xamarin.Forms;

	public class BaseViewModel : INotifyPropertyChanged
	{
		#region member vars

		private bool isBusy;

		private string title = string.Empty;

		#endregion

		#region methods

		protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "", Action onChanged = null)
		{
			if (EqualityComparer<T>.Default.Equals(backingStore, value))
			{
				return false;
			}
			backingStore = value;
			onChanged?.Invoke();
			OnPropertyChanged(propertyName);
			return true;
		}

		#endregion

		#region properties

		public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

		public bool IsBusy
		{
			get => isBusy;
			set => SetProperty(ref isBusy, value);
		}

		public string Title
		{
			get => title;
			set => SetProperty(ref title, value);
		}

		#endregion

		#region INotifyPropertyChanged

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
			var changed = PropertyChanged;
			if (changed == null)
			{
				return;
			}
			changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		#endregion
	}
}
