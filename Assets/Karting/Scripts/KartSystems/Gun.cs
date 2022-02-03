using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KartGame.KartSystems
{

    public class Gun : WeaponSystem
    {
        Bullet ammo;
        private void Start()
        {
            ammo = new Bullet();
            
        }
        public override void Launch()
        {
            ammo.shoot();
            
        }
        void setTarget(Vector3 target)
        {
            ammo.setTarget(target);
        }

    }
}
