namespace WeightedArrays
{
    public class WeightedArrayEntry<T>
    {
        private float _weight;
        private T _item;

        public float Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }

        public T Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }

        public WeightedArrayEntry(T item, float weight)
        {
            _item = item;
            _weight = weight;            
        }

    }   
}