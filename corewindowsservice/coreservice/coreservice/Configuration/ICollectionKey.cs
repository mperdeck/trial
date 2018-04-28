namespace Decideware.Configuration
{
	/// <summary>
	/// Defines the properties and methods of a class that is used in a collection and retrieved by a key value.
	/// </summary>
	/// <typeparam name="TKey">The type of the key.</typeparam>
	public interface ICollectionKey<TKey>
	{
		/// <summary>
		/// Gets the unique key for this item.
		/// </summary>
		TKey Key { get; }
	}
}
