using UnityEngine;

namespace Curso.ProgramaciónUnity
{
    public class Update_FixedUpdate_LateUpdate_02 : MonoBehaviour
    {
        private void Update() 
        {
            Debug.Log("Update");
        }
        private void FixedUpdate() 
        {
            Debug.Log("FixedUpdate");            
        }
        private void LateUpdate() 
        {
            Debug.Log("LateUpdate");            
        }
    }
}
