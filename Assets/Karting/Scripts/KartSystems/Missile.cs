using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KartGame.KartSystems
{
    public class Missile : AmmoSystem
    {
        [Tooltip("The speed of missile")]
        public float speed;
        public Rigidbody2D body;
        bool shot;
        private void Start()
        {
            shot = false;


        }
        public void shoot()
        {
            shot = true;
        }
        // Update is called once per frame
        void Update()
        {
            if (shot)
            {
                body.transform.position = Vector3.MoveTowards(transform.position, target + Vector3.up, speed * Time.deltaTime);
            }
        }

    }
}