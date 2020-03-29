using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class Enemy : MonoBehaviour
    {
        Health healthObject;
        public EnemyMovement movementObject;
        // Start is called before the first frame update
        void Start()
        {
            healthObject = GetComponent<Health>();
            movementObject = GetComponent<EnemyMovement>();
        }

        // Update is called once per frame
        void Update()
        {
            if(healthObject.healthPoints <= 0){

                healthObject.Died();
            }
        }
        
    }
}

