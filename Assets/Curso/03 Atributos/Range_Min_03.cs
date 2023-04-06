using UnityEngine;

namespace Curso.Atributos
{
    public class Range_Min_03 : MonoBehaviour
    {
        [Range(10f,100f)]
        public float shootSpeed;

        [Range(1,10)]
        public int shootRate;

        [Min(2.5f)]
        public float bulletsSpeed;

        [Min(1)]
        public int bulletsPerShoot;
    }
}
