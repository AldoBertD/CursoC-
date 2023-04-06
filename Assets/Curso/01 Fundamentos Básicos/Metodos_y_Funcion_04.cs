using UnityEngine;

namespace Curso.FundamentosBásicos
{
    public class Metodos_y_Funcion_04 : MonoBehaviour
    {
        //Metodos_y_Funcion_04 myClass;
        //un metodo se llama desde fuera, mientras una funcion lo llamas desde adentro
        private void Start() 
        {
            //myClass.Shoot(); //esto es un método
            Shoot(10); //esto es una función       
            Shoot(weaponType: 2); //aca solo afecta al weaponType   
            int myId; 
            myId = GetPlayerId();
            ChangePlayerIdWithOut(out myId); //modifica el valor myId
            ChangePlayerIdWithRef(ref myId); //modifica el valor myId
        }
        
        int ammo;
        public void Shoot(int amountBullets = 5, int weaponType = 0) //tmb puedo poner int amountBullets = 5, (el por defecto sera 5, pero como le mande 10 se sobrescribe y tendre 10 balas)
        {
            // Disparar
            ammo -= amountBullets;
        }

        private void ChangePlayerIdWithOut(out int id)
        {
            id = 20;
        }

        private void ChangePlayerIdWithRef(ref int id)
        {
            id = 30;
        }

        private int GetPlayerId() //Devuelve un valor tipo int, se le pone Get... al nombre para identificar que devuelve un valor
        {
            return 10;
        }
    }
}
