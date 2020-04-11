using Audio;
using UnityEngine;
using UnityEngine.Events;
using BlueGame;

namespace Core.Combat
{
    public class Projectile : MonoBehaviour
    {
        //set parent when launching the projectile
        [HideInInspector] public GameObject parent;
        public int damage = 1;
        public string hitSFXName;
        public string hitVFXName;
        public delegate void hitMethod();
        public hitMethod Deactivate;
        private void Awake()
        {
            Deactivate = Disable;
        }
        void Disable()
        {
            gameObject.SetActive(false);
        }

        public void TranslateDamage(GameObject target, int attackPower)
        {
            var health = target.GetComponent<Health>();
            health.TakeDamage(attackPower);
        }
        private void OnTriggerEnter2D(Collider2D target)
        {
            if (target.CompareTag("Projectile")) return;
            if (target.CompareTag("Collectable")) return;
            //don't collide with enemy
            if ((target.CompareTag("Enemy") && parent.CompareTag("Player")) || (target.CompareTag("Player") && parent.CompareTag("Enemy")))
            {
                TranslateDamage(target.gameObject, damage);
            }
            if (target.CompareTag("ScreenBorder"))
            {
                Deactivate();
                return;
            }
            if(!target.CompareTag(parent.tag))Hit();
            //Destroy(gameObject); no need to destroy
        }
        private void Hit()
        {
            //explosion or damage effect
            if (hitVFXName.Length != 0) PoolerManager.instance.Spawn(hitVFXName, transform.position, Quaternion.identity);            
            if (hitSFXName.Length != 0) AudioManager.instance.Play(hitSFXName);
            Deactivate();
        }
       
    }
}
