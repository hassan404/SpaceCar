using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KartGame.KartSystems
{
    [RequireComponent(typeof(HealthSystem))]
    public class WeaponSystem : MonoBehaviour
    {
        [Tooltip("Mounted position of weapon")]
        Transform mount;
        Collider hitDetecter;

        // Start is called before the first frame update
        public virtual void Launch()
        {
            //deloys the weapon
        }
        public virtual void OnCollisionEnter(Collision collision)
        {
            //unique mechanism of each weapon
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}