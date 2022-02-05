namespace codingfreaks.XamarinFormsSample.Logic.Ui.Services
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;

	public interface IDataStore<T>
	{
		#region methods

		Task<bool> AddItemAsync(T item);

		Task<bool> DeleteItemAsync(string id);

		Task<T> GetItemAsync(string id);

		Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);

		Task<bool> UpdateItemAsync(T item);

		#endregion
	}
}
