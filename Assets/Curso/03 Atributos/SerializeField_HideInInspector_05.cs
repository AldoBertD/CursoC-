using UnityEngine;

namespace Curso.Atributos
{
    public class SerializeField_HideInInspector_05 : MonoBehaviour
    {
        [SerializeField]
        private bool canShoot;

        [HideInInspector]
        public bool canRun;
    }
}
