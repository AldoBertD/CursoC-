using UnityEngine;

namespace Curso.AccionesEventosDelegados
{
    public class Delegados_01 : MonoBehaviour
    {
        // Void
        public delegate void MyDelegate(); //lo declaramos
        public MyDelegate myDelegateVar; //creo la variable

        // Return
        public delegate int MyDelegateInt();
        public MyDelegateInt myDelegateIntVar;

        // Params
        public delegate void MyDelegateOneParam(string myString); //creo la variable con un parametro
        public MyDelegateOneParam myDelegateOneParamVar;

        // Multicast
        public delegate void MyDelegateMulticast();
        public MyDelegateMulticast myDelegateMulticastVar;
        
        // Callback
        public delegate void MyDelegateCallback(bool success);
        public MyDelegateCallback myDelegateCallbackVar;

        private void Start() 
        {
            // Void
            myDelegateVar = PrintMessage; //Le asigne la función a la variable
            myDelegateVar(); //ejecuto la función

            // Return
            myDelegateIntVar = GetWeaponId;
            int myWeapon = myDelegateIntVar(); //me devuelve un valor 

            // Params
            myDelegateOneParamVar = PrintMessageWithValue;
            myDelegateOneParamVar("Hola");

            // Multicast
            myDelegateMulticastVar += PrintMessage;
            myDelegateMulticastVar += ChangeWeapon;
            myDelegateMulticastVar += Heal;
            myDelegateMulticastVar(); //ejecuta las 3 funciones
            myDelegateMulticastVar -= Heal;
            myDelegateMulticastVar(); //ejecuta solo 2 funciones

            // Callback
            myDelegateCallbackVar = RequestCompleted; //recibe un bool, TRUE OR FALSE
            RequestConnection(myDelegateCallbackVar); //Llamo a esta función. llama primero a requestconnection y luego llama al requestcompleted.
        }

        private void PrintMessage()
        {
            Debug.Log("Hello World!");
        }

        private void PrintMessageWithValue(string message)
        {
            Debug.Log(string.Format("Mensaje: {}", message));
        }
        private int GetWeaponId()
        {
            return 5;
        }

        private void ChangeWeapon()
        {
            Debug.Log("Change Weapon");
        }

        private void Heal()
        {
            Debug.Log("Heal");
        }

        bool connectionReady = true; //usado en networking, conexion a base de datos, conexion a internet

        private void RequestConnection(MyDelegateCallback callback)
        {
            if(connectionReady)
            {
                callback(true);
            }
            else
            {
                callback(false);
            }
        }

        private void RequestCompleted(bool success)
        {
            Debug.Log($"Connection Ready: {success}");
        }
    }
}
