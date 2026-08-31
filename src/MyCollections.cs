using System.Collections;

namespace MyCollections {
	//************************** MyList<T> **************************
	public class MyList<T>: IEnumerable<T>, ICollection<T> {
		private T[] _array;
		private int _count;

		public bool IsReadOnly => false;

		public int Count => _count;
		public int Capacity => _array.Length;

		public bool Empty => _count == 0;

		public MyList() => _array = new T[4];
		public MyList(T[] array) {
			_array = array.ToArray();
			_count = array.Length;
		}
		public MyList(MyList<T> list) {
			_array = list._array.ToArray();
			_count = list._count;
		}

		public T this[int index] {
			get {
				ValidateIndex(index);
				return _array[index];
			}
			set {
				ValidateIndex(index);
				_array[index] = value;
			}
		}

		private void ValidateIndex(int index) {
			if (index < 0 || index > _count - 1) throw new IndexOutOfRangeException($"The given index was out of range. index: {index}, array bounds: [0, {_count - 1}]");
		}

		public void Add(T item) {
			if (_count == Capacity) Array.Resize(ref _array, Math.Max(4, Capacity * 2));
			_array[_count++] = item;
		}

		public bool Remove(T item) {
			int index = IndexOf(item);
			if (index != -1) {
				if (index < _count - 1) Array.Copy(_array, index + 1, _array, index, _count - index - 1);
				_array[--_count] = default!;
				return true;
			}
			return false;
		}

		public bool Contains(T item) {
			for (int i = 0; i < _count; ++i)
				if (EqualityComparer<T>.Default.Equals(_array[i], item)) return true;
			return false;
		}

		public int IndexOf(T item) => Array.IndexOf(_array, item, 0, _count);

		public void Clear() {
			if (_count != 0) {
				Array.Clear(_array, 0, _count);
				Array.Resize(ref _array, 4);
				_count = 0;
			}
		}

		public void CopyTo(T[] array, int arrayIndex) {
			if (array is null) throw new ArgumentNullException(nameof(array));
			if (arrayIndex < 0) throw new ArgumentOutOfRangeException(nameof(arrayIndex));
			if (array.Length - arrayIndex < _count) throw new ArgumentException("Destination array is too small.");
			Array.Copy(_array, 0, array, arrayIndex, _count);
		}

		public IEnumerator<T> GetEnumerator() {
			for (int i = 0; i < _count; ++i) {
				yield return _array[i];
			}
		}
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
	//************************** MyList<T> **************************

	//************************** MyKeyValuePair<TKey, TValue> **************************
	public struct MyKeyValuePair<TKey, TValue> {
		private readonly TKey _key;
		private TValue _value;

		public TKey Key => _key;
		public TValue Value {
			get => _value;
			set => _value = value;
		}

		public MyKeyValuePair(TKey key, TValue value) {
			_key = key;
			_value = value;
		}
	}
	//************************** MyKeyValuePair<TKey, TValue> **************************

	//************************** HashMap<TKey, TValue> **************************
	public class HashMap<TKey, TValue>: IEnumerable<MyKeyValuePair<TKey, TValue>> where TKey : notnull {
		// _count / _hashTable.Length
		private const double MaxLoad = 0.5;

		private Entry[] _entries;
		private int[] _hashTable;
		private int _count;

		private static readonly EqualityComparer<TKey> Comparer = EqualityComparer<TKey>.Default;

		public int Capacity => _entries.Length;
		public int Count => _count - _numOfRemovedEntries;

		public bool Empty => Count == 0;

		private int _numOfRemovedEntries;

		private struct Entry {
			public MyKeyValuePair<TKey, TValue> Pair;
			public int nextEntryIndex = -1;
			public bool IsRemoved = false;
			public Entry(TKey key, TValue value) => Pair = new(key, value);
		}

		public HashMap() {
			_entries = new Entry[4];
			_hashTable = new int[4];
			_count = 0;
			_numOfRemovedEntries = 0;
			InitializeHashTable();
		}

		public HashMap(HashMap<TKey, TValue> map) {
			_entries = map._entries.ToArray();
			_hashTable = map._hashTable.ToArray();
			_count = map._count;
			_numOfRemovedEntries = map._numOfRemovedEntries;
		}

		public TValue this[TKey key] {
			get {
				if (GetValueByKey(key, out TValue? value))
					return value!;
				else
					throw new KeyNotFoundException($"The given key was not found. key: {key}");
			}
			set {
				if (!SetValueByKey(key, value)) TryAdd(key, value);
			}
		}

		private void InitializeHashTable() {
			for (int i = 0; i < _hashTable.Length; ++i)
				_hashTable[i] = -1;
		}

		private int GetHash(TKey key) => Math.Abs(key.GetHashCode() % _hashTable.Length);
		private int GetHash(Entry entry) => GetHash(entry.Pair.Key);

		private void ReHash() {
			InitializeHashTable();
			for (int i = 0; i < _count; ++i) {
				ref Entry entry = ref _entries[i];
				if (entry.IsRemoved) continue;
				ref int hashGroupIndex = ref _hashTable[GetHash(entry)];

				if (hashGroupIndex == -1) {
					entry.nextEntryIndex = -1;
					hashGroupIndex = i;
					continue;
				}

				entry.nextEntryIndex = hashGroupIndex;
				hashGroupIndex = i;
			}
		}

		public bool TryAdd(TKey key, TValue value) {
			if (ContainsKey(key)) return false;
			if (Count + 1 > _hashTable.Length * MaxLoad) {
				Array.Resize(ref _hashTable, _hashTable.Length * 2);
				ReHash();
			}

			if (_count == Capacity) Array.Resize(ref _entries, Capacity * 2);

			ref Entry entry = ref _entries[_count++];
			entry = new(key, value);

			ref int hashGroupIndex = ref _hashTable[GetHash(entry)];
			if (hashGroupIndex != -1) entry.nextEntryIndex = hashGroupIndex;
			hashGroupIndex = _count - 1;

			return true;
		}

		public bool RemoveByKey(TKey key) {
			ref int hashGroupIndex = ref _hashTable[GetHash(key)];
			int previousIndex = -1;
			for (int index = hashGroupIndex; index != -1; index = _entries[index].nextEntryIndex) {
				ref Entry entry = ref _entries[index];
				if (Comparer.Equals(entry.Pair.Key, key)) {
					if (previousIndex != -1) _entries[previousIndex].nextEntryIndex = entry.nextEntryIndex;
					else hashGroupIndex = entry.nextEntryIndex;

					entry.IsRemoved = true;
					++_numOfRemovedEntries;

					if (_numOfRemovedEntries >= _count / 2) CleanUpRemovedEntries();

					return true;
				}
				previousIndex = index;
			}
			return false;
		}

		public bool ContainsKey(TKey key) {
			int index = _hashTable[GetHash(key)];
			while (index != -1) {
				Entry entry = _entries[index];
				if (!entry.IsRemoved && Comparer.Equals(entry.Pair.Key, key)) return true;
				index = entry.nextEntryIndex;
			}
			return false;
		}

		public bool GetValueByKey(TKey key, out TValue? value) {
			int index = _hashTable[GetHash(key)];
			while (index != -1) {
				Entry entry = _entries[index];
				if (Comparer.Equals(entry.Pair.Key, key)) {
					value = entry.Pair.Value;
					return true;
				}
				index = entry.nextEntryIndex;
			}
			value = default;
			return false;
		}

		public bool SetValueByKey(TKey key, TValue value) {
			int index = _hashTable[GetHash(key)];
			while (index != -1) {
				ref Entry entry = ref _entries[index];
				if (Comparer.Equals(entry.Pair.Key, key)) {
					entry.Pair.Value = value;
					return true;
				}
				index = entry.nextEntryIndex;
			}
			return false;
		}

		public bool Clear() {
			if (Count == 0) return false;
			Array.Clear(_entries, 0, _count);
			Array.Resize(ref _entries, 4);
			Array.Resize(ref _hashTable, 4);
			_count = 0;
			_numOfRemovedEntries = 0;
			return true;
		}

		private void CleanUpRemovedEntries() {
			Entry[] tempArray = new Entry[Math.Max(4, Count * 2)];
			int tempIndex = 0;
			for (int i = 0; i < _count; ++i) {
				Entry tempEntry = _entries[i];
				if (!tempEntry.IsRemoved) tempArray[tempIndex++] = tempEntry;
			}
			_entries = tempArray;
			_count -= _numOfRemovedEntries;
			_numOfRemovedEntries = 0;
			Array.Resize(ref _hashTable, Math.Max(4, (int)(_count * 2 / MaxLoad))); // aiming for load-factor = 0.25
			ReHash();
		}

		public IEnumerator<MyKeyValuePair<TKey, TValue>> GetEnumerator() {
			for (int i = 0; i < _count; ++i) {
				Entry entry = _entries[i];
				if (!entry.IsRemoved) yield return entry.Pair;
			}
		}
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
	//************************** HashMap<TKey, TValue> **************************
}