using UnityEngine;

namespace Curso.InterfacesyGenerics
{
    public class Window : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Interaction: Window");
        }
    }
}
