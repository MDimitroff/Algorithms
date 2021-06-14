using System.Collections;

namespace CustomSet
{
    public class CustomSet
    {
        private readonly Hashtable _data;

        public int Size { get => _data.Count; }

        public CustomSet()
        {
            _data = new Hashtable();
        }

        public void Add(object item)
        {
            var hashCode = GetHashCode(item.ToString());
            if (_data.Contains(hashCode)) return;
            
            _data.Add(hashCode, item);
        }

        public void Remove(object item)
        {
            var hashCode = GetHashCode(item.ToString());
            _data.Remove(hashCode);
        }

        public CustomSet Union(CustomSet secondSet)
        {
            var tempSet = new CustomSet();

            foreach (var value in secondSet._data.Values)
            {
                if (!tempSet._data.ContainsValue(value))
                {
                    tempSet.Add(value);
                }
            }

            foreach (var value in _data.Values)
            {
                if (!tempSet._data.ContainsValue(value))
                {
                    tempSet.Add(value);
                }
            }

            return tempSet;
        }

        public CustomSet Intersection(CustomSet secondSet)
        {
            var tempSet = new CustomSet();

            foreach (var value in _data.Values)
            {
                if (secondSet._data.ContainsValue(value))
                {
                    tempSet.Add(value);
                }
            }

            return tempSet;
        }

        public CustomSet Difference(CustomSet secondSet)
        {
            var tempSet = new CustomSet();

            foreach (var value in _data.Values)
            {
                if (!secondSet._data.ContainsValue(value))
                {
                    tempSet.Add(value);
                }
            }

            return tempSet;
        }

        public bool IsSubset(CustomSet secondSet)
        {
            if (Size < secondSet.Size)
            {
                return false;
            }

            foreach (var value in secondSet._data.Values)
            {
                if (!_data.ContainsValue(value)) return false;
            }

            return true;
        }

        private string GetHashCode(string item)
        {
            char[] chars = item.ToCharArray();
            int hashValue = 0;
            
            for (int i = 0; i < chars.Length; i++)
            {
                hashValue += 37 * i + chars[i];
            }

            return hashValue.ToString();
        }
    }
}
