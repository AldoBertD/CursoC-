using UnityEngine;

namespace Curso.POO
{
    public class EnemyORC2 : Enemy2
    {
        public override void Attack() //estoy sobreescribiendo la logica de attack del padre
        {
            damage = 999;
            base.Attack();
            Debug.Log("I'm an ORC!");
        }
    }
}
