using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class Enemy : MonoBehaviour
    {
        private Health healthObject;
        // Start is called before the first frame update
        void Start()
        {
            healthObject = GetComponent<Health>();
        }

        // Update is called once per frame
        void Update()
        {
            if(healthObject.healthPoints <= 0){
                gameObject.SetActive(false);
            }
        }
    }
}

