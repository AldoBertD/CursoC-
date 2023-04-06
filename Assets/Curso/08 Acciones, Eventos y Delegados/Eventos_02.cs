using UnityEngine;
using UnityEngine.Events;

namespace Curso.AccionesEventosDelegados
{
    public class Eventos_02 : MonoBehaviour
    {
        // Event: viene siempre en C#
        public delegate void MyDelegateEvent();
        public MyDelegateEvent myDelegateEventVar; //Creo la variable como un delegate
        public event MyDelegateEvent myEventVar; //Creo la variable como un evento

        // UnityEvents: viene exclusivamente en Unity
        public UnityEvent myUnityEventVar;

        public UnityEvent<bool> myUnityEventOneParamVar;
        public UnityEvent<bool, int, string> myUnityEventThreeParamVar;

        private void Start() 
        {
            //Event
            //Los eventos son exactamente igual que los delegates pero mas seguros
            myEventVar += PrintMessage;
            myEventVar();

            //UnityEvents
            myUnityEventVar.AddListener(PrintMessage); //+=
            myUnityEventVar.RemoveListener(PrintMessage); //-=

            myUnityEventVar.Invoke(); //asi lo llamo

            myUnityEventOneParamVar.Invoke(true); //le paso esa info a las funciónes que lo esten pidiendo
            myUnityEventThreeParamVar.Invoke(true,5,"test");
        }
        private void PrintMessage()
        {
            Debug.Log("Hello World!");
        }
    }
}
