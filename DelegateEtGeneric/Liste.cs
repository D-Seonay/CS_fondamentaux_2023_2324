using System;
using System.Collections;


namespace DelegateEtGeneric
{
    internal class Liste<T> : IEnumerable<T>
    {
    
        //une liste d'éléments non typés (donc de type object)
        private ArrayList elements;
        
        public int Count => elements.Count;
        
        public T this[int index]
        {
            get => (T)elements[index];
        }
        
        public  Liste()
        {
            elements = new ArrayList();
        }
        public void Ajouter(T element)
        {
            elements.Add(element);
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in elements)
            {
                yield return (T)element;
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Trier(DelegateQuiCompareDeuxTrucs<T> test)
            
        {
            for (var i = 0; i < Count; i++)
            {
                for (var j = i + 1; j < Count; j++)
                {
                    if (test(this[i], this[j]))
                    {
                        var temp = elements[i];
                        elements[i] = elements[j];
                        elements[j] = temp;
                    }
                }
            }
        }

    }
}