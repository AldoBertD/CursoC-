using UnityEngine;
using System.Collections;

namespace Curso.ProgramaciónUnity
{
    public class Coroutine_07 : MonoBehaviour
    {
        private void Start()
        {
            #region Start
            StartCoroutine(CallCorroutine()); //Cualquiera de estas 3 funciona para llamarlas, pero recomiendo esta
            StartCoroutine("CallCorroutine"); 
            Coroutine myCoroutine;
            myCoroutine = StartCoroutine(CallCorroutine()); 
            #endregion

            #region Stop
            StopCoroutine(CallCorroutine());
            StopCoroutine("CallCorroutine");
            StopCoroutine(myCoroutine);
            StopAllCoroutines();
            #endregion

            #region Parametros
            StartCoroutine(CallCorroutineWithParameters(2.5f, 100, "test"));
            #endregion

        }
        private IEnumerator CallCorroutine()
        {
            Debug.Log("CALL");

            yield return new WaitForSeconds(5f);
            
            Debug.Log("CALL 2");
        }
        
        private IEnumerator CallCorroutineWithParameters(float myFloat, int myInt, string myString)
        {
            yield return null;
        }
    }
}
