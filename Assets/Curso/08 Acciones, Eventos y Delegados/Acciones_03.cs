using System;
using UnityEngine;
using UnityEngine.Events;
namespace Curso.AccionesEventosDelegados
{
    public class Acciones_03 : MonoBehaviour
    {
        //asi como los eventos cubren a los delegates, las unity events cubren a las actions
        public Action myActionVar; //es una accion pura de C#
        public UnityAction myUnityActionVar; //es una acción de unity
        public Action<int> myActionOneParamVar;
        public UnityAction<int> myUnityActionOneParamVar;
        public Action<int, bool, string> myActionThreeParamVar;
        public UnityAction<int, bool, string> myUnityActionThreeParamVar;

        private void Start() 
        {
            myActionVar += PrintMessage; //asi lo hago multicast
            myActionVar = PrintMessage; //asi single cast
            myActionVar(); //asi lo invoco

            myUnityActionVar = PrintMessage;
            myUnityActionVar += PrintMessage;
            myUnityActionVar();

            //el delegate, Acciones y Eventos son basicamente lo mismo
            //el delegate es para sistemas de comunicaciones
            //Las acciones son como internamente se usan
            //Casi siempre se usen los Events y pocas veces el delegate, casi nunca las acciones
        }

        private void PrintMessage()
        {
            Debug.Log("Hola Mundo");
        }
    }
}
