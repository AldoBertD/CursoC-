using UnityEngine;

namespace Curso.Atributos
{
    [RequireComponent(typeof(BoxCollider), typeof(Rigidbody))]
    public class RequireComponent_07 : MonoBehaviour
    {
        private BoxCollider boxCollider;
        private Rigidbody rigidbody;

        private void Awake() //obtengo los componentes
        {
            boxCollider = GetComponent<BoxCollider>();
            rigidbody = GetComponent<Rigidbody>();    
        }

        private void Start() //en el start modifico los componentes del awake
        {
            boxCollider.enabled = true;
            rigidbody.isKinematic = false;    
        }
    }
}
