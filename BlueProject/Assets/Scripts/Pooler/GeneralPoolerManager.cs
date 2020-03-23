using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlueGame
{
    public class GeneralPoolerManager : MonoBehaviour
    {
   
 	    public GeneralPoolerManagerScriptableObject[] objectsPooler; //The array of Object Poolers.

        private static GeneralPoolerManagerScriptableObject[] _objectsPooler;
        private static GeneralPoolerManager generalPoolerManager;
       
	   public static GeneralPoolerManager Instance
        {
            get
            {
                if (!generalPoolerManager)
                {
                    generalPoolerManager = FindObjectOfType(typeof(GeneralPoolerManager)) as GeneralPoolerManager;
                    if (!generalPoolerManager)
                    {
                        Debug.LogError("Create an Empty GameObject and drag this Script on it.");
                    }
                    else
                    {
                        generalPoolerManager.Init();
                    }
                }

                return generalPoolerManager;
            }
        }

        void Init()
        {
        }

        void Awake()
        {
            _objectsPooler = objectsPooler;
            
        }

       
       
         public static GeneralPoolerManagerScriptableObject GetObjectPooler(int index)  // Return the Object Pooler 
        {
            if (index < _objectsPooler.Length) return _objectsPooler[index]; else return null;
        }



    }


}
