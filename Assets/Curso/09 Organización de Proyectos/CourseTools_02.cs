using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Tools //lo guardo en el mismo namespace de UnityEngine, lo guardo en Tools
{
    public static class CourseTools_02 //la clase debe ser estatica
    {
        public static RectTransform GetRectTransform(this Transform t) //las funciones tmb son estaticas
        {
            return t as RectTransform;
        }
    }
}
