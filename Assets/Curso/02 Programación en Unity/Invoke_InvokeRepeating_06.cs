using UnityEngine;

namespace Curso.ProgramaciónUnity
{
    public class Invoke_InvokeRepeating_06 : MonoBehaviour
    {
        private void Start() 
        {
            Invoke("CallInvoke",3f); //lo llamo luego de 3s
            InvokeRepeating("CallInvoke",5f,1f);
            IsInvoking("CallInvoke"); //aca consulto si estoy haciendo un Invoke
            CancelInvoke("CallInvoke"); //aca cancelo el invoke hecho
        }   

        private void CallInvoke()
        {
            Debug.Log("Invoke Called");
        }
    }
}
