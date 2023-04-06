using UnityEngine;

namespace Curso.FundamentosBásicos
{
    public class Constructor_09 : MonoBehaviour
    {
        private void Start() 
        {
            Weapon myWeapon = new Weapon();

            myWeapon.Shoot();
        }
    }

    public class Weapon
    {
        int ammo;

        public Weapon()
        {
            ammo = 30;
        }
    
        public Weapon(int ammo)
        {
            this.ammo = ammo;
        }
        public void Shoot()
        {

        }
    }
}
