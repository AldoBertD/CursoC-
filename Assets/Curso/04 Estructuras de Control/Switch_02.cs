using UnityEngine;

namespace Curso.EstructurasDeControl
{
    public enum EPlataform
    {
        None,
        PC,
        Xbox,
        PlayStation,
        Switch
    }
    public class Switch_02 : MonoBehaviour
    {
        public int weaponType;
        public string enemyClass;
        public EPlataform currentPlataform;

        private void Start() 
        {
            switch (weaponType)
            {
                case 0: 
                    //Hago algo
                    break;
                case 1: //puedo encadenar los case, en el caso 1,3 y 4 ejecuta esto:
                case 3:
                case 4:
                    //Hago algo
                    break;
                case 2:
                    //Hago algo
                    break;
                default:
                    //Hago algo
                    break;
            }
            switch (currentPlataform)
            {
                case EPlataform.None:
                    break;
                case EPlataform.PC:
                    break;
                case EPlataform.Xbox:
                    break;
                case EPlataform.PlayStation:
                    break;  
                case EPlataform.Switch:
                    break;
                default:
                    break;
            }
        }


    }
}
