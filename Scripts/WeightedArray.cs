using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace WeightedArrays
{
    public class WeightedArray<T> 
    {    
        private List<WeightedArrayEntry<T>> _weightedArrayEntries;

        public List<WeightedArrayEntry<T>> WeightedArrayEntries => _weightedArrayEntries;
        
        public int NumChoices
        {
            get
            {
                return _weightedArrayEntries.Count;
            }
        }

        public WeightedArray()
        {
            _weightedArrayEntries = new List<WeightedArrayEntry<T>>();
        }

        public void AddItem(T item, float weight)
        {
            _weightedArrayEntries.Add(new WeightedArrayEntry<T>(item, weight));
        }

        public T GetRandomItem()
        {
            var total = 0.0f;
            var numEntries = _weightedArrayEntries.Count;
            for(var i = 0; i < numEntries; i++)
            {
                total += _weightedArrayEntries[i].Weight;
            }
            
            var currentWeight = Random.Range(0.0f, total);        
            for (int i = 0; i < numEntries; i++)
            {
                currentWeight -= _weightedArrayEntries[i].Weight;
                if(currentWeight <= 0)
                {
                    return _weightedArrayEntries[i].Item;
                }
            }

            return default(T);
        }    
    }
}