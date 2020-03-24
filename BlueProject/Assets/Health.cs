using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Core
{
    public class ObjectRef
    {
        public string tag { get; set; }
        public Vector3 lastLocation { get; set; }
        public float DropRateBonus { get; set; }

    }
    internal class Health : MonoBehaviour
    {
        public float healthpoints;
        public float maxhealtpoints;       
        [HideInInspector] bool godMode;       
        public delegate void SomeBodyDiedEventHandler(ObjectRef refe);
        //subscribe to this event to get notification on death of object
        public event SomeBodyDiedEventHandler DieMOFO;       
        private bool died;
        private void Awake()
        {
            healthpoints = 100;
            maxhealtpoints = 100;           
            godMode = false;
            died = false;
        }      
        public void SetGodMode(bool stat)
        {
            if (gameObject.tag == "Player")
            {
                godMode = stat;
            }
        }
        private void Update()
        {
           
        }
        public void TakeDamage(float damage, GameObject caller = null)
        {
            if (!godMode && !died)
            {
                healthpoints = (healthpoints - damage) > 0 ? (healthpoints - damage) : 0;
                if (healthpoints <= 0)
                {
                    died = true;
                    Died();
                }
                
            }
        }
        private void Died()
        {
            //last location can be used for drop location
            //I originally used this event for chest drops on a hack and slash game
            DieMOFO(new ObjectRef()
            {
                tag = gameObject.tag,
                DropRateBonus = 0,
                lastLocation = transform.position
            });
           //disable movement
           //disable animations

        }
        //heals the gameobject
        public void Heal(float extrahealth)
        {
            healthpoints = (healthpoints + extrahealth) < maxhealtpoints ? (healthpoints + extrahealth) : maxhealtpoints;
        }
        public bool HealthCheck(float percent)
        {
            var min = (maxhealtpoints - (maxhealtpoints * (percent + 3)) / 100);
            var max = (maxhealtpoints - (maxhealtpoints * (percent - 10)) / 100);
            if (healthpoints < max && healthpoints >= min)
            {
                return true;
            }
            return false;
        }
    }
}

