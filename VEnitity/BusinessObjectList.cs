using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VEntityFramework
{
	public class BusinessObjectList<T> : IList<T>, IList
		where T : VBusinessObject
	{
		readonly VBusinessObject parent;
		readonly IList<T> innerList;

		public BusinessObjectList(VBusinessObject parent)
		{
			this.parent = parent;
			innerList = new List<T>();
		}

		public T this[int index]
		{
			get => innerList[index];
			set => innerList[index] = value;
		}

		object IList.this[int index]
		{
			get => ((IList)innerList)[index];
			set => ((IList)innerList)[index] = value;
		}

		public int Count => innerList.Count;

		public bool IsReadOnly => innerList.IsReadOnly;

		public bool IsFixedSize => ((IList)innerList).IsFixedSize;

		public bool IsSynchronized => ((IList)innerList).IsSynchronized;

		public object SyncRoot => ((IList)innerList).SyncRoot;

		public void Add(T item)
		{
			innerList.Add(item);
		}

		public int Add(object value)
		{
			return ((IList)innerList).Add(value);
		}

		public void Clear()
		{
			innerList.Clear();

#if DEBUG
			throw new Exception("If we decide to use this, make sure you deregister all bizos from loadout.Children to avoid HasChanged Bugs");
#endif
		}

		public bool Contains(T item)
		{
			return innerList.Contains(item);
		}

		public bool Contains(object value)
		{
			return Contains((T)value);
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			innerList.CopyTo(array, arrayIndex);
		}

		public void CopyTo(Array array, int index)
		{
			((IList)innerList).CopyTo(array, index);
		}

		public IEnumerator<T> GetEnumerator()
		{
			return innerList.GetEnumerator();
		}

		public int IndexOf(T item)
		{
			return innerList.IndexOf(item);
		}

		public int IndexOf(object value)
		{
			return IndexOf((T)value);
		}

		public void Insert(int index, T item)
		{
			innerList.Insert(index, item);
		}

		public void Insert(int index, object value)
		{
			Insert(index, (T)value);
		}

		public bool Remove(T item)
		{
			parent.DeregisterChild(item);
			parent.HasChanges = true;
			return innerList.Remove(item);
		}

		public void Remove(object value)
		{
			Remove((T)value);
		}

		public void RemoveAt(int index)
		{
			parent.DeregisterChild(innerList[index]);
			parent.HasChanges = true;
			innerList.RemoveAt(index);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
