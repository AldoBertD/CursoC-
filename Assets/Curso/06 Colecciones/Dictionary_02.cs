using System.Collections.Generic;
using UnityEngine;

namespace Curso.Colecciones
{
    public class Dictionary_02 : MonoBehaviour
    {
        [Header("Content")]
        public GameObject[] myContent;

        [Header("Dictionary")]
        public Dictionary<string, GameObject> characterDictionary; //puedo buscar un gameobject por su nombre
        private void Start() 
        {
            characterDictionary = new Dictionary<string, GameObject>();
            
            //Add
            for (int i = 0; i < myContent.Length; i++)
            {
                characterDictionary.Add(myContent[i].name, myContent[i]); //accedo al diccionario, le agrego el KEY (String = Nombre) y el gameObject myContent
            }
            
            //Yo escribo ORC y puedo acceder a ese conetenido

            //Remove
            characterDictionary.Remove("Orc");

            //If Contains
            bool contains = characterDictionary.ContainsKey("Orc");

            //Read
            GameObject myValue = characterDictionary["Orc"];

            //No puedo repetir las KEY's, no puede haber 2 Orc, puede haber OrcA y OrcB
            int amount = characterDictionary.Count;

        }
    }
}
