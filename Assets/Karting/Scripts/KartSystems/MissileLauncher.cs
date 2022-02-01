using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KartGame.KartSystems
{
    public class MissileLauncher : WeaponSystem
    {
        Missile ammo;
        private void Start()
        {
            ammo = new Missile();

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