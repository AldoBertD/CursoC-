using UnityEngine;

namespace Curso.FundamentosBásicos
{
    public class Operadores_02 : MonoBehaviour
    {
        int myInt;
        bool myBool;
        private void Start() 
        {
            //Operadores Aritmeticos
            myInt = 2+2;
            myInt = 2-2;
            myInt = 2*2;
            myInt = 2/2;

            //Operadores de Asignación
            myInt = myInt + 2; 
            myInt += 2; //myInt = myInt + 2 
            myInt -= 2;
            myInt *= 2;
            myInt /= 2;
            //Operadores Relacionales

            myBool = 2 > 1;
            myBool = 2 < 2;
            myBool = 2 == 2;
            myBool = 2 >= 2;
            myBool = 2 <= 2;
            myBool = 2 != 2;
                
            //Operadores Lógicos   
            myBool = 2 == 2 || 4 == 4 ; //Si la primera condicion es verdadera O la segunda condición es verdadera
            myBool = 2 == 2 && 4 == 4;
            myBool = !(2 == 2); //El simbolo de interrogacion invierte el resultado, entonces 2 = 2 entonces !(true) que equivale a False 
        }
    }
}
