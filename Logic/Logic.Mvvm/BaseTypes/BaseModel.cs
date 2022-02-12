namespace codingfreaks.XamarinFormsSample.Logic.Mvvm.BaseTypes
{
	using System;
	using System.ComponentModel;
	using System.Linq;
	using System.Runtime.CompilerServices;

	public abstract class BaseModel : INotifyPropertyChanged
	{
		#region events

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion

		#region methods

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		#endregion
	}
}
