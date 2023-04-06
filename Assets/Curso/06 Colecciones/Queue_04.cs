using System.Collections.Generic;
using UnityEngine;

namespace Curso.Colecciones
{
    public class Queue_04 : MonoBehaviour
    {
        [Header("Content")]
        public GameObject[] myContent;

        [Header("Queue")]
        public Queue<GameObject> playerQueue;

        private void Start() 
        {
            playerQueue = new Queue<GameObject>(); //Inicializamos

            //Add
            for (int i = 0; i < myContent.Length; i++)
            {
                playerQueue.Enqueue(myContent[i]); //asi agregamos
            }

            //Remove
            GameObject myGameObject = playerQueue.Dequeue();

            //Contains
            bool contains = playerQueue.Contains(myGameObject);

            //Amount
            int amount = playerQueue.Count;

            //Clear
            playerQueue.Clear();
        }
    }
}
