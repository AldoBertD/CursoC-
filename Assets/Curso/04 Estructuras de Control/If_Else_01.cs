using UnityEngine;

namespace Curso.EstructurasDeControl
{
    public class If_Else_01 : MonoBehaviour
    {
        public bool canAttack;

        private void Attack()
        {   
            if (canAttack)
            {
                Debug.Log("Attack!");
            }
            else
            {
                Debug.Log("No Attack");
            }

            Debug.Log(canAttack ? "Verdadero" : "Falso"); //Operador Ternario

            int id = canAttack ? 24 : -1; // si canAttack es verdadero el id sera 24 sino -1

            if (canAttack)
                Debug.Log("Attack!"); //se puede hacer esto solo si es una linea
        }

        public int currentAmmo;
        public int totalAmmo;

        private void CheckAmmo()
        {
            if (currentAmmo > 0)
            {
                //Shoot
            }

            if (totalAmmo == 0 || currentAmmo <=0)
            {
                //Require Ammo
            }
        }


        public SphereCollider shieldCollider;

        private void Defense()
        {
            if (shieldCollider != null) //mala practica
            {
                //Use Shield
            }
            if (shieldCollider) //funka igual que lo de arriba
            {
                //Use Shield
            }
        }

    }
}
