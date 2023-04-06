using System.Collections.Generic;
using UnityEngine;

namespace Curso.Colecciones
{
    public class Stack_03 : MonoBehaviour
    {
        [Header("Content")]
        public GameObject[] myContent;

        [Header("Stack")]
        public Stack<GameObject> cardsStack;

        private void Start() 
        {
            //Inicializarlo
            cardsStack = new Stack<GameObject>(); 

            //Add
            for (int i = 0; i < myContent.Length; i++)
            {
                cardsStack.Push(myContent[i]);
            }

            //Return First y Removerlo
            GameObject myGameObjectPop = cardsStack.Pop(); //agarro la primera carta del stack (la de arriba) y lo elimino

            //Return
            GameObject myGameObjectPeek = cardsStack.Peek(); //solo lo agarro, como si lo estuviera viendo, no lo elimino

            //Contains
            bool contains = cardsStack.Contains(myGameObjectPeek);

            //Amount
            int amount = cardsStack.Count;

            //Clear
            cardsStack.Clear();
        }
    }
}
