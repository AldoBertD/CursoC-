using UnityEngine;

namespace Curso.InterfacesyGenerics
{
    public class Chest : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Interaction: Chest");
        }
    }
}
