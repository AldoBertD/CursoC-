using UnityEngine;

namespace Curso.POO
{
    public class Enemy : MonoBehaviour
    {
        public string title;
        public int damage;
        public float health;

        private void Start() 
        {
            
        }

        private void Attack()
        {
            Debug.Log(string.Format("Enemy {0} Attack. Damage: {1}",title, damage));
        }   

        private void Defense()
        {
            Debug.Log(string.Format("Enemy {0} Attack. Damage: {1}",title, health));
        }
    }
}
