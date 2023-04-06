using System.Collections.Generic;
using UnityEngine;

namespace Curso.InterfacesyGenerics
{
    public class Generics_02 : MonoBehaviour
    {
        public List<int> numbers;
        public List<string> words;

        private void Start() 
        {
            numbers = ReverseList(numbers);
            words = ReverseList(words);
        }

        private List<T> ReverseList<T>(List<T> listToReverse) //me devuelve una lista de tipo T, T de template. El input es listToReverse, el nombre de la función es ReverseList y es de tipo List<T>
        {
            List<T> reversedList = new List<T>();
            
            for (var i = listToReverse.Count - 1; i >= 0; i--)
            {
                reversedList.Add(listToReverse[i]);
            }
            return reversedList;
        }
    }
}
