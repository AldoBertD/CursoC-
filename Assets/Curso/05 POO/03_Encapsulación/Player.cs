using UnityEngine;

namespace Curso.POO3
{
    public class Player : MonoBehaviour
    {
        public Enemy3 enemy;

        private void Start() 
        {
            /*
            float tempHealth = enemy.health; //si puedo tener una referencia a un valor de health
            enemy.damage = 0; //aca sobreescribo un valor, cosa que no deberia poder permitirse    
            */

            string tempValue = enemy.Title; //aca solo puedo leerlo, mas no editarlo
        }   
    }
}
