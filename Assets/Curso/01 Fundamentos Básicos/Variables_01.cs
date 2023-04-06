using UnityEngine;

namespace Curso.FundamentosBásicos
{
    public class Variables_01 : MonoBehaviour
    {
        //Tipos de Datos: Valor
        public int myInt;
        public float myFloat;
        public double myDouble;
        public bool myBool;
        public char myChar; //1 solo caracter
        public Vector3 myStructVector;
        public Quaternion myStructQuaternion; //manejar rotaciones

        //Tipos de Datos 2: Referencia
        public Transform myClassTransform;
        public GameObject myClassGameobject;
        
        private void Start() 
        {
            //Tipos de Datos: Valor
            myInt = 5;
            myFloat = 2.5f; //la f me indica que es de tipo float
            myDouble = 0.000000001f;
            myBool = true;
            myChar = 'A'; //Usa las comillas simples ' ' 
            myStructVector  = new Vector3(1,2,3);
            myStructQuaternion = new Quaternion (1,2,3,4);
    
            //Tipos de Datos 2: Referencia
            myClassTransform = this.transform; //Obtengo la ubicación rotacion y escala del objeto que este puesto en este script
            myClassGameobject = this.gameObject; //Obtengo una referencia al objeto que esta anexado a esta variable
        }
    
        
    }
}
