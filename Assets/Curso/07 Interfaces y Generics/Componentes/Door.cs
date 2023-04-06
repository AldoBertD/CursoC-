using UnityEngine;

namespace Curso.InterfacesyGenerics
{
    public class Door : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Interaction: Door");
        }
    }
}
