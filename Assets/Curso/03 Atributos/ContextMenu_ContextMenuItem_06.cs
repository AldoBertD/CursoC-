using UnityEngine;

namespace Curso.Atributos
{
    public class ContextMenu_ContextMenuItem_06 : MonoBehaviour
    {
        [ContextMenu("Execute")]
        private void PrintExecute()
        {
            Debug.Log("Execute!");
        }

        [ContextMenuItem("Get a Random Scale","ExecuteRandomScale")]
        public float randomScale;

        private void ExecuteRandomScale()
        {
            randomScale = Random.Range(0,10f);
        }
    }
}
