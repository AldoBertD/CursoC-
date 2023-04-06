using UnityEngine;

namespace Curso.EstructurasDeControl
{
    public struct PlayerData
    {
        public int score;
        public bool isAlive;
    }

    public class JumpStatements_04 : MonoBehaviour
    {
        public PlayerData[] playerData;

        private void CheckMaxScore()
        {
            for (int i = 0; i < playerData.Length; i++)
            {
                //If score >= 10, ganamos
                if (playerData[i].score >=10) //si tenermos varios jugadores mayor a 10, tomara al primero que encontro
                {
                    //Winner
                    break;
                }
            }
        }

        private void CheckPlayerScore()
        {
            for (int i = 0; i < playerData.Length; i++)
            {
                //If esta muerto, skip
                if (!playerData[i].isAlive)
                {
                    continue; //se saltea esta data, es como un break pero pasa al siguiente indice de i
                }
                //Else
            }
        }

        private void CheckPlayerScore(int index)
        {
            //If esta muerto, no executar
            if (!playerData[index].isAlive)
            {
                return; //Early Exit,
            }
            //Else
        }
    }
}
