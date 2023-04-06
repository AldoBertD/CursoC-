using UnityEngine;

namespace Curso.FundamentosBásicos
{
    public class Conversion_08 : MonoBehaviour
    {
        public enum AttackType
        {
            None, //Efecto predeterminado, normalmente es none
            Fire,
            Ice,
            Sword,
            Punch
        }
        private void Start() 
        {
            //Conversion (Cast)
            int myCastInt = (int)2.55f; //este valor float lo convierto al int
            Collider myCollider = GetComponent<Collider>();
            BoxCollider myBoxCollider;
            myBoxCollider = (BoxCollider)myCollider;
            myBoxCollider = myCollider as BoxCollider;

            //Conversion (Parse)
            string myStringInt = "128";
            int myIntParsed;
            
            myIntParsed = int.Parse(myStringInt); //128
            bool resultParse = int.TryParse(myStringInt, out myIntParsed); //tomo el String y lo intento convertir a int, y si lo puedo convertir lo paso a myIntParsed, de ahi con el resultparse puedo hacer un if y verificar si funka

            //Conversion (Enum)
            string myStringEnum = "Fire";

            AttackType myEnum;

            myEnum = (AttackType)System.Enum.Parse(typeof(AttackType), myStringEnum); //cuando tengo un string y lo quiero convertir a un Enum

        }
    }
}
