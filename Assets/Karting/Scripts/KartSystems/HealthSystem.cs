using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KartGame.KartSystems
{
    public class HealthSystem : MonoBehaviour
    {
        [Min(0), Tooltip("Maximum health of the object.")]
        public int MaxHealth;
        [Tooltip("Remaining health of the object.")]
        protected int RemHealth {
            get;
            private set;
        }
       


        // Start is called before the first frame update
        void Start()
        {
            RemHealth = MaxHealth;
        }

        //Take damage according to the value mentioned in the arugment
        public void TakeDamage(int damage)
        {
            int temp = RemHealth - damage;
            if (temp > 0)
            {
                RemHealth = temp;
            }
            else
            {
                RemHealth = 0;
            }
        }

    }

}

