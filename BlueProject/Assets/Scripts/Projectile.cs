using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Combat
{
    public class Projectile : MonoBehaviour
    {
        //set parent when launching the projectile
        [HideInInspector] public GameObject parent;
        public float damage = 1;          
        /*  we don't need this because of pooling
        float jictimer = 0;
        public float lifeSpan = 5;             
        void Update()
        {
            JustInCase();
        }
        private void JustInCase()
        {
            jictimer += Time.deltaTime;
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
            if (jictimer > lifeSpan)
            {
                //just in case
                //destroy after 5 seconds
                Destroy(this.gameObject);
            }
        }
        */
        public void TranslateDamage(GameObject target, float attackPower)
        {
            var health = target.GetComponent<Health>();
            health.TakeDamage(attackPower);
        }
        private void OnTriggerEnter2D(Collider2D target)
        {
            //don't collide with enemy
            if ((target.tag == "Enemy" && parent.tag == "Player") || (target.tag == "Player" && parent.tag == "Enemy"))
            {
                TranslateDamage(target.gameObject, damage);
            }
            if(!target.CompareTag(parent.tag))Hit();
            //Destroy(gameObject); no need to destroy
        }
        private void Hit()
        {
            //explosion or damage effect
            gameObject.SetActive(false);
        }
       
    }
}
