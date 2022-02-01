using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KartGame.KartSystems
{
    public class Bullet : AmmoSystem
    {
        [Tooltip("The speed of bullet")]
        public float speed;
        public Rigidbody2D body;
        public void shoot()
        {
            speed = speed * Time.fixedDeltaTime;
            Vector3 direction = body.transform.position - target;
            body.velocity =direction *speed  ;
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}