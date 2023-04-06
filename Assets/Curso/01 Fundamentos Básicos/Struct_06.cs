using UnityEngine;

namespace Curso.FundamentosBásicos
{
    public class Struct_06 : MonoBehaviour
    {
        //Un struct es un conjunto de variables
        [System.Serializable] //Con esto visualizo el Struct en Publico, igual que para el Enum
        public struct PlayerData //si esto lo pongo afuera de la funcion Struct_06 puedo acceder a el en todos lados si pongo el System.Serializable
        {
            public string Name;
            public int Health;
            public bool IsDead;
            public int ammo;
        }

        public PlayerData playerData;

        private void Start() 
        {
            playerData.Name = "Aldo";
            playerData.Health = 100;
            playerData.IsDead = false;   
            ChangeInfo(playerData); 
        }

        private void ChangeInfo(PlayerData data)
        {
            data.ammo = 1000;
        }
    }
}
