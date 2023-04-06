using UnityEngine;

namespace Curso.FundamentosBásicos
{
    public class CadenasDeTexto_03 : MonoBehaviour
    {
        string myString;

        private void Start() 
        {
            myString = "Aldo";
            myString = "Aldo" + " " + "Bert";

            int age = 22;

            myString = "Edad de Aldo: " + age.ToString(); //la funcion .ToString() convierte el texto a string

            myString = string.Format("Edad de {0}: {1}", "Aldo", age); //este es mejor, y mas comoda
            myString = $"Edad de Aldo: {age}"; //es lo mismo que lo de arriba

            myString = "22_Aldo_Rifle"; //edad_nombre_arma
            string[] characterInfo = myString.Split('_'); //divide my string y ponlo en un array llamado characterInfo
            // characterInfo[0]= "22";
            // characterInfo[1]= "Aldo";
            // characterInfo[2]= "Rifle";
            // si pongo myString. puedo ver todas las opciones que tengo para usar con strings
        }
    }
}
