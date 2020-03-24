using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlueGame
{
    public class GeneralPoolerManagerB : MonoBehaviour
    {
   
 	    public MainPoolB objectsPooler; //The array of Object Poolers.

        private static MainPoolB _objectsPooler;
        private static GeneralPoolerManagerB generalPoolerManagerB;
       
	    public static GeneralPoolerManagerB Instance
        {
            get
            {
                if (!generalPoolerManagerB)
                {
                    generalPoolerManagerB = FindObjectOfType(typeof(GeneralPoolerManagerB)) as GeneralPoolerManagerB;
                    if (!generalPoolerManagerB)
                    {
                        Debug.LogError("Create an Empty GameObject and drag this Script on it.");
                    }
                    else
                    {
                        generalPoolerManagerB.Init();
                    }
                }

                return generalPoolerManagerB;
            }
        }

        void Init()
        {
        }

        void Awake()
        {
            _objectsPooler = objectsPooler;
            
        }

       
       
        public static MainPoolB GetObjectPooler(int index)  // Return the Object Pooler 
        {
            if ( _objectsPooler) return _objectsPooler; else return null;
			
        }



    }


}
