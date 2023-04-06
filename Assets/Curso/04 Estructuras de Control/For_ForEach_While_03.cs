using System.Collections;
using UnityEngine;

namespace Curso.EstructurasDeControl
{
    public class For_ForEach_While_03 : MonoBehaviour
    {
        public int[] weaponAmmoArray;

        private void CheckWeaponAmmo()
        {
            for(int i = 0;  i < weaponAmmoArray.Length; i++)
            {
                Debug.Log(string.Format("Index {0} Ammo: {1}",i, weaponAmmoArray[i]));
            }

            foreach (int weaponAmmo in weaponAmmoArray)
            {
                Debug.Log(string.Format("Index ? - Ammo: {0}",weaponAmmo)); //es mas simple pero no puedo acceder a los indices
            }
        }

        private IEnumerator Fade()
        {
            float alpha = 1;
            
            while (alpha > 0)
            {
                alpha -= Time.deltaTime * 1;
                yield return null;
            }
        }
    }
}
