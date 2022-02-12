namespace codingfreaks.XamarinFormsSample.Logic.Mvvm.BaseTypes
{
	using System;
	using System.ComponentModel;
	using System.Linq;
	using System.Runtime.CompilerServices;

	public abstract class BaseViewModel : INotifyPropertyChanged
	{
		#region methods

		public virtual void OnAppearing()
		{
		}

		#endregion

		#region properties

		public bool IsBusy { get; protected set; }

		public string Title { get; protected set; }

		#endregion

		#region INotifyPropertyChanged

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		#endregion
	}
}
