using UnityEngine;

namespace Curso.ProgramaciónUnity
{
    public class OnBecameVisible_OnBecameInvisible_05 : MonoBehaviour
    {
        private void OnBecameVisible() 
        {
            Debug.Log("Visible");
        }
        private void OnBecameInvisible() 
        {
            Debug.Log("Invisible");

        }
    }
}
