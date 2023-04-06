using System.Collections.Generic;
using UnityEngine;

namespace Curso.Colecciones
{
    public class List_01 : MonoBehaviour
    {
        [Header("Content")]
        public int[] myContent;

        [Header("List")]
        public List<int> weaponsList;

        private void Start() 
        {
            //Inicializar la lista, es obligatorio para utilizarla
            weaponsList = new List<int>();

            //Add
            /*
            for (int i = 0; i < myContent.Length; i++)
            {
                weaponsList.Add(myContent[i]);
            }    
            */
            weaponsList.AddRange(myContent); //sirve igual que el for de arriba

            //Remove
            weaponsList.Remove(myContent[2]);

            //Read
            int tempValue = weaponsList[2]; //se lee igual que el array

            //Amount
            int amount = weaponsList.Count;

            //Clear
            weaponsList.Clear();
        }
    }
}
