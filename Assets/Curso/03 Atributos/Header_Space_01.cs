using UnityEngine;

namespace Curso.Atributos
{
    public class Header_Space_01 : MonoBehaviour
    {
        [Header("Stats")]
        public string displayName;
        [Space]
        public int health;
        public int mana;
        [Space(50)]
        public bool isAlive;

        [Header ("References")]
        public CapsuleCollider capsuleCollider;
    }
}
