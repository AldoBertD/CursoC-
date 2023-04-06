using UnityEngine;

namespace Curso.POO
{
    public class Enemy2 : MonoBehaviour
    {
        public string title;
        public int damage;
        public float health;

        private void Start() 
        {
            Attack();
        }

        public virtual void Attack() //El public virtual, permite que los hijos puedan tomar esta funcion y sobreescribirla
        {
            Debug.Log(string.Format("Enemy {0} Attack. Damage: {1}",title, damage));
        }   

        private void Defense()
        {
            Debug.Log(string.Format("Enemy {0} Attack. Damage: {1}",title, health));
        }
    }
}
