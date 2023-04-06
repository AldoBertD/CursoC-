using UnityEngine;

namespace Curso.POO4
{
    public class EnemyORC4 : Enemy4
    {
        public override void Attack() //estoy sobreescribiendo la logica de attack del padre
        {
            damage = 999; //el protected me permite editar las clases hijas, pero para el resto de clases no me permite editarlas
            base.Attack();
            Debug.Log("I'm an ORC!");
        }

        public override void Defense()
        {
            Debug.Log(string.Format("Enemy {0} Attack. Damage: {1}", damage, health));
        }
    }
}
