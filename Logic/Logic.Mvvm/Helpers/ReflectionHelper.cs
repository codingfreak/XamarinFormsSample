namespace codingfreaks.XamarinFormsSample.Logic.Mvvm.Helpers
{
	using BaseTypes;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Reflection;

	public static class ReflectionHelper
	{
		#region constants

		private static readonly Lazy<IEnumerable<Assembly>> AssemblyCollectionFactory = new Lazy<IEnumerable<Assembly>>(() => AppDomain.CurrentDomain.GetAssemblies());

		private static readonly Lazy<IEnumerable<Type>> ViewModelTypeFactory = new Lazy<IEnumerable<Type>>(
			() =>
			{
				return AssemblyCollectionFactory.Value.SelectMany(
					a => a.GetTypes()
						.Where(t => !t.IsAbstract && typeof(BaseViewModel).IsAssignableFrom(t))
						.ToArray());
			});

		#endregion

		#region properties

		public static IEnumerable<Type> ViewModelTypes => ViewModelTypeFactory.Value;

		#endregion
	}
}
