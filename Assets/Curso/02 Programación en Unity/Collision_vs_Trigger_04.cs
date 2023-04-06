using UnityEngine;

namespace Curso.ProgramaciónUnity
{
    public class Collision_vs_Trigger_04 : MonoBehaviour
    {
        //region sirve para crear un menu desplegable desde #region hasta #endregion, es para organizar mejor el código
        #region Collision 

        private void OnCollisionEnter(Collision collision) //si este script lo tengo en un cubo y una esfera me choca, el collision sera la colision de la esfera. 
        {
            Debug.Log("Collision ENTER");    
        }

        private void OnCollisionStay(Collision collision) 
        {
            Debug.Log("Collision STAY"); 
        }
        
        private void OnCollisionExit(Collision collision) 
        {
            Debug.Log("Collision EXIT"); 
        }

        #endregion

        //Una Collision es una pared por ejemplo, no puedo atravezar la pared, o una bala, me impacta y bueno se destruye la bala sale sangre y hace como que me desangro
        //Un Trigger es una puerta por ejemplo, si me acerco a la puerta, esta se abre, aca si puyedo atravezarla
        
        #region Trigger 

        private void OnTriggerEnter(Collider other) 
        {
            Debug.Log("Trigger ENTER");
        }
        
        private void OnTriggerStay(Collider other) 
        {
            Debug.Log("Trigger STAY");
        }

        private void OnTriggerExit(Collider other) 
        {
            Debug.Log("Trigger EXIT");
        }

        #endregion
    }
}
