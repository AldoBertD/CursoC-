using UnityEngine;

namespace Curso.POO4
{
    public abstract class Enemy4 : MonoBehaviour
    {
        [Header("Enemy")]
        [SerializeField] private string title;
        [SerializeField] protected int damage; //cambio el private por protected, todos los hijos pueden modificar
        [SerializeField] protected float health; //el protected no permite modificar a otras variables

        public string Title { get => title;} //es una función que me permite leerle pero no editarla

        //recomendación, variables con guion bajo "_variable" son variable privadas
        //variables solas "variables" son variables publicas o protected
        //una variable con mayúscula es una propiedad "Variable"

        private void Start() 
        {
            Attack();
        }

        public virtual void Attack() //El public virtual, permite que los hijos puedan tomar esta funcion y sobreescribirla
        {
            Debug.Log(string.Format("Enemy {0} Attack. Damage: {1}",title, damage));
        }   

        public abstract void Defense(); //función Abstracta
    }
}
