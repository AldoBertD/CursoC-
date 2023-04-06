using UnityEngine;
using UnityEngine.Tools; //con esto puedo llamar a la clase CourseTools_02

namespace Curso.OrganizaciónDeProyecto
{
    public class Helper_02 : MonoBehaviour
    {
        private void Start() 
        {
            RectTransform test = CourseTools_02.GetRectTransform(transform); //llame a esa clase con una sola lineas, ideal para operaciones matemáticas complejas    
        }
    }
}
