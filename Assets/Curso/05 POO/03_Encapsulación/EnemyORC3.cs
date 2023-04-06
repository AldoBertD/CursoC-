using UnityEngine;

namespace Curso.POO3
{
    public class EnemyORC3 : Enemy3
    {
        public override void Attack() //estoy sobreescribiendo la logica de attack del padre
        {
            damage = 999; //el protected me permite editar las clases hijas, pero para el resto de clases no me permite editarlas
            base.Attack();
            Debug.Log("I'm an ORC!");
        }
    }
}
