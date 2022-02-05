namespace codingfreaks.XamarinFormsSample.Logic.Ui.ViewModels
{
	using BaseTypes;
	using System;
	using System.Linq;

	public class MyViewModel : BaseViewModel
	{
		#region member vars

		

		#endregion

		#region constructors and destructors

		public MyViewModel()
		{
			
		}

		#endregion

		#region properties

		public string Message { get; set; } = "Hello MVVM!";

		#endregion
	}
}
