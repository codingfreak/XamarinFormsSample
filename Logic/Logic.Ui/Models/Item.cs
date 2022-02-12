namespace codingfreaks.XamarinFormsSample.Logic.Ui.Models
{
	using Mvvm.BaseTypes;
	using System;
	using System.Linq;

	public class Item : BaseModel
	{
		#region properties

		public string Id { get; set; }

		public string Text { get; set; }

		public string Description { get; set; }

		public bool IsValid => !string.IsNullOrWhiteSpace(Text) && !string.IsNullOrWhiteSpace(Description);

		#endregion
	}
}
