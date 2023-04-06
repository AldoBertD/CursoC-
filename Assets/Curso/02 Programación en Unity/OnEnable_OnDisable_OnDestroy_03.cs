using UnityEngine;

namespace Curso.ProgramaciónUnity
{
    public class OnEnable_OnDisable_OnDestroy_03 : MonoBehaviour
    {
        //On enable es cuando el objeto se habilita
        //On disable es cuando el objeto se deshabilita
        //On destroy es cuando el objeto se destruye
        private void OnEnable() 
        {
            Debug.Log("OnEnable");
        }

        private void OnDisable() 
        {
            Debug.Log("OnDisable");
        }

        private void OnDestroy() 
        {
            Debug.Log("OnDestroy");
        }
    }
}
