using UnityEngine;

namespace Curso.FundamentosBásicos
{
    public class Array_07 : MonoBehaviour
    {
        public int enemyIdA; //si quiero generar enemigos asi no lo debo hacer
        public int enemyIdB;
        public int enemyIdC;
        public int enemyIdD;
        public int enemyIdE;
        public int enemyIdF;
        public int enemyIdZ;

        public int[] enemyId; //asi creo un array
        public int[] Id = {1,2,3,4}; //asi se pone valores por defecto, no es recomendable

        private void Start() 
        {
            int myId = enemyId[0]; //representa 1
        }
    }
}
