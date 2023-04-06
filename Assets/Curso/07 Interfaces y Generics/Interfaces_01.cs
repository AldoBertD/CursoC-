using UnityEngine;

namespace Curso.InterfacesyGenerics
{
    //Creando la interfaz
    public interface IInteractable
    {
        void Interact();
    }
    public class Interfaces_01 : MonoBehaviour
    {
        public GameObject[] myInteractables;

        private void Start() 
        {
           for (var i = 0; i < myInteractables.Length; i++)
           {
                IInteractable myInteractable = myInteractables[i].GetComponent<IInteractable>();
                myInteractable?.Interact(); //Si no es null hace que se haga la función interact
           }    
        }
    }
}
