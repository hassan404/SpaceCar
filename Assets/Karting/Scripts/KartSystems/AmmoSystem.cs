using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KartGame.KartSystems
{
    public class AmmoSystem : MonoBehaviour
    {
        [Tooltip("Tells Whether ammo is deflectable or not")]
        public bool isDeflectable;
        [Tooltip("Damage that ammo deals to an object.")]
        public int damage;
        Transform launcher;
        public Vector3 target;
        Collider collider;



        private void OnCollisionEnter(Collision collision)
        {
            GameObject other = collision.gameObject;
            if (other.CompareTag("HealthSystem"))
            {
                other.GetComponent<HealthSystem>().TakeDamage(damage);
            }
        }
        void setTransform(Transform t)
        {
            launcher = t;
        }
        public void setTarget(Vector3 t)
        {
            target = t;
        }

    }
}
