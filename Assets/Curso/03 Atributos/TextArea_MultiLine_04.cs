using UnityEngine;

namespace Curso.Atributos
{
    public class TextArea_MultiLine_04 : MonoBehaviour
    {
        [TextArea]
        public string description;

        [TextArea(1, 20)]
        public string description2;

        [Multiline]
        public string note;

        [Multiline(6)]
        public string note2;
    }
}
