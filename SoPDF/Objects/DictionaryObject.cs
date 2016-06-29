using SoPDF.Core;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace SoPDF.Objects
{
    public class DictionaryObject : PdfObject, IDictionary<string, PdfObject>
    {
        #region IDictionary
        // The array of items
        private List<DictionaryEntry> _items;

        public DictionaryObject()
        {
            _items = new List<DictionaryEntry>();
        }

        public PdfObject this[string key]
        {
            get
            {
                return _items.Single(i => i.Key.ToString() == key).Value as PdfObject;
            }

            set
            {
                if (value != null)
                {
                    if (ContainsKey(key))
                    {
                        Remove(key);
                    }
                    Add(key, value);
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
        }

        public int Count
        {
            get
            {
                return _items.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public ICollection<string> Keys
        {
            get
            {
                List<string> keys = new List<string>();
                foreach (DictionaryEntry entry in _items)
                {
                    keys.Add(entry.Key.ToString());
                }
                return keys;
            }
        }

        public ICollection<PdfObject> Values
        {
            get
            {
                List<PdfObject> pdfObjects = new List<PdfObject>();
                foreach (DictionaryEntry entry in _items)
                {
                    pdfObjects.Add(entry.Value as PdfObject);
                }
                return pdfObjects;
            }
        }

        public void Add(KeyValuePair<string, PdfObject> item)
        {
            if (!string.IsNullOrEmpty(item.Key) && item.Value != null)
            {
                _items.Add(new DictionaryEntry(item.Key, item.Value));
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public void Add(string key, PdfObject value)
        {
            if (!string.IsNullOrEmpty(key) && value != null)
            {
                _items.Add(new DictionaryEntry(key, value));
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool Contains(KeyValuePair<string, PdfObject> item)
        {
            return _items.Contains(new DictionaryEntry(item.Key, item.Value));
        }

        public bool ContainsKey(string key)
        {
            return _items.Exists(i => i.Key.ToString() == key);
        }

        public IEnumerator<KeyValuePair<string, PdfObject>> GetEnumerator()
        {
            List<KeyValuePair<string, PdfObject>> keyValuePairs = new List<KeyValuePair<string, PdfObject>>();
            foreach (DictionaryEntry entry in _items)
            {
                keyValuePairs.Add(new KeyValuePair<string, PdfObject>(entry.Key.ToString(), entry.Value as PdfObject));
            }
            return keyValuePairs.GetEnumerator();
        }

        public bool Remove(KeyValuePair<string, PdfObject> item)
        {
            return _items.Remove(new DictionaryEntry(item.Key, item.Value));
        }

        public bool Remove(string key)
        {
            if (_items.Any(i => i.Key.ToString() == key))
            {
                return _items.Remove(_items.Single(i => i.Key.ToString() == key));
            }
            else
            {
                return false;
            }
        }

        public bool TryGetValue(string key, out PdfObject value)
        {
            if (!string.IsNullOrEmpty(key))
            {
                value = this[key];

                if (value != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        void ICollection<KeyValuePair<string, PdfObject>>.CopyTo(KeyValuePair<string, PdfObject>[] array, int arrayIndex)
        {
            for (int i = 0; i < arrayIndex; i++)
            {
                array[i] = new KeyValuePair<string, PdfObject>(_items[i].Key.ToString(), _items[i].Value as PdfObject);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
        #endregion

        public override byte[] ToBytes(bool isReference = false)
        {
            if (_items.Count > 0)
            {
                List<byte> output = new List<byte>();

                output.AddRange(PdfWriter.PdfEncoding.GetBytes("<<"));
                foreach (DictionaryEntry entry in _items)
                {
                    output.AddRange((new NameObject(entry.Key.ToString())).ToBytes());
                    output.AddRange(PdfWriter.PdfEncoding.GetBytes(" "));
                    output.AddRange((entry.Value as PdfObject).ToBytes());
                    output.AddRange(PdfWriter.PdfEncoding.GetBytes(" "));
                }
                output.AddRange(PdfWriter.PdfEncoding.GetBytes(">>"));

                return output.ToArray();
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
