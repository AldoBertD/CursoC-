using UnityEngine;

namespace Curso.OrganizaciónDeProyecto
{
    public class Validación_03 : MonoBehaviour
    {
        [SerializeField] private Sprite sprite;
        [SerializeField] private SpriteRenderer spriteRenderer;

        private void OnValidate() 
        {
            if(!spriteRenderer)
            {
                spriteRenderer = GetComponent<SpriteRenderer>();
            }    
            if(!sprite)
            {
                Debug.Log("Missing Sprite!");
                return;
            }
            
            // Si el sprite existe los añado
            spriteRenderer.sprite = sprite; 
        }
    }
}
