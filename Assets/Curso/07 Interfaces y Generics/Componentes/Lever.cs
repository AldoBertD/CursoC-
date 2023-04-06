using UnityEngine;

namespace Curso.InterfacesyGenerics
{
    public class Lever : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Interaction: Lever");
        }
    }
}
