using SoPDF.Core;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace SoPDF.Objects
{
    public class DictionaryObject : PdfObject, IDictionary<NameObject, PdfObject>
    {
        //public Dictionary<string, PdfObject> Content { get; set; }

        // The array of items
        private List<DictionaryEntry> _items;

        public DictionaryObject()
        {
            _items = new List<DictionaryEntry>();
        }

        public DictionaryObject(Dictionary<string, PdfObject> content)
        {
            if (content == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                base.Content = content;
            }
        }

        public PdfObject this[NameObject key]
        {
            get
            {
                return _items.Single(i => i.Key == key).Value as PdfObject;
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

        public ICollection<NameObject> Keys
        {
            get
            {
                List<NameObject> nameObjects = new List<NameObject>();
                foreach (DictionaryEntry entry in _items)
                {
                    nameObjects.Add(entry.Key as NameObject);
                }
                return nameObjects;
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

        public void Add(KeyValuePair<NameObject, PdfObject> item)
        {
            if (item.Key != null && item.Value != null)
            {
                _items.Add(new DictionaryEntry(item.Key, item.Value));
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public void Add(NameObject key, PdfObject value)
        {
            if (key != null && value != null)
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

        public bool Contains(KeyValuePair<NameObject, PdfObject> item)
        {
            return _items.Contains(new DictionaryEntry(item.Key, item.Value));
        }

        public bool ContainsKey(NameObject key)
        {
            return _items.Exists(i => i.Key == key);
        }

        public IEnumerator<KeyValuePair<NameObject, PdfObject>> GetEnumerator()
        {
            List<KeyValuePair<NameObject, PdfObject>> keyValuePairs = new List<KeyValuePair<NameObject, PdfObject>>();
            foreach (DictionaryEntry entry in _items)
            {
                keyValuePairs.Add(new KeyValuePair<NameObject, PdfObject>(entry.Key as NameObject, entry.Value as PdfObject));
            }
            return keyValuePairs.GetEnumerator();
        }

        public bool Remove(KeyValuePair<NameObject, PdfObject> item)
        {
            return _items.Remove(new DictionaryEntry(item.Key, item.Value));
        }

        public bool Remove(NameObject key)
        {
            if (_items.Any(i => i.Key == key))
            {
                return _items.Remove(_items.Single(i => i.Key == key));
            }
            else
            {
                return false;
            }
        }

        public override byte[] ToBytes()
        {
            Dictionary<string, PdfObject> content = base.Content as Dictionary<string, PdfObject>;

            if (content.Count > 0)
            {
                List<byte> output = new List<byte>();

                foreach (KeyValuePair<string, PdfObject> obj in content)
                {
                    output.AddRange(PdfWriter.PdfEncoding.GetBytes("   "));
                    output.AddRange(new NameObject(obj.Key).ToBytes());
                    output.AddRange(PdfWriter.PdfEncoding.GetBytes(" "));
                    output.AddRange(obj.Value.ToBytes());
                    output.AddRange(PdfWriter.PdfEncoding.GetBytes("\n"));
                }

                output.RemoveRange(0, 2);
                output.InsertRange(0, PdfWriter.PdfEncoding.GetBytes("<<"));
                output.AddRange(PdfWriter.PdfEncoding.GetBytes(">>"));

                return output.ToArray();
            }
            else
            {
                return PdfWriter.PdfEncoding.GetBytes("<<>>");
            }
        }

        public bool TryGetValue(NameObject key, out PdfObject value)
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

        void ICollection<KeyValuePair<NameObject, PdfObject>>.CopyTo(KeyValuePair<NameObject, PdfObject>[] array, int arrayIndex)
        {
            for (int i = 0; i < arrayIndex; i++)
            {
                array[i] = new KeyValuePair<NameObject, PdfObject>(_items[i].Key as NameObject, _items[i].Value as PdfObject);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}
