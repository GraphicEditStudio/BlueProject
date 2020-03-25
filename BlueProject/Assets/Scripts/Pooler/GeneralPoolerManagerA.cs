using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlueGame
{
    public class GeneralPoolerManagerA : MonoBehaviour
    {
   
 	    public MainPoolA objectsPooler; //The array of Object Poolers.

        private static MainPoolA _objectsPooler;
        private static GeneralPoolerManagerA generalPoolerManagerA;
       
	    public static GeneralPoolerManagerA Instance
        {
            get
            {
                if (!generalPoolerManagerA)
                {
                    generalPoolerManagerA = FindObjectOfType(typeof(GeneralPoolerManagerA)) as GeneralPoolerManagerA;
                    if (!generalPoolerManagerA)
                    {
                        Debug.LogError("Create an Empty GameObject and drag this Script on it.");
                    }
                    else
                    {
                        generalPoolerManagerA.Init();
                    }
                }

                return generalPoolerManagerA;
            }
        }

        void Init()
        {
        }

        void Awake()
        {
            _objectsPooler = objectsPooler;
            
        }

       
       
        public static MainPoolA GetObjectPooler(int index)  // Return the Object Pooler 
        {
            if ( _objectsPooler) return _objectsPooler; else return null;
			
        }



    }


}
