using UnityEngine;

namespace Curso.FundamentosBásicos
{
    public class TipoEnum_05 : MonoBehaviour
    {
        public int attackTypeInt; //0 = Fire, 1 = Ice, 2 = Sword, 3 = Punch

        public enum AttackType
        {
            None, //Efecto predeterminado, normalmente es none
            Fire,
            Ice,
            Sword,
            Punch
        }

        public AttackType attackTypeEnum = AttackType.Sword; //Aca le di un valor por defecto

        private void Start() 
        {
            attackTypeEnum = AttackType.Fire;
        }
    }
}
