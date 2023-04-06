using UnityEngine;

namespace Curso.OrganizaciónDeProyecto
{
    public class Documentación_01 : MonoBehaviour
    {
        private void Start() 
        {
           int myValue; 
           myValue = GetId("Mariano"); //con esto documentamos la función y variables que debemos usar
           //zombie code no usar: no comentar codigo viejo que ya no sirve, siempre debo borrarlo
        }

        /// <summary>
        /// Summary: Descripción Corta
        /// </summary>
        /// <remarks>
        /// Remarks: Descripción más detallada de la función
        /// </remarks>
        /// <param name="characterName">Param: Descripción de la variable</param>
        /// <returns>
        /// Returns: Descripción del tipo de valor que devuelve
        ///</returns>

        private int GetId(string characterName)
        {
            return 1;
        }
        
    }
}
