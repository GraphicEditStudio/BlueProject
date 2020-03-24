using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlueGame
{

     [CreateAssetMenu(menuName = "ObjectPooler", fileName = "NewObjectPooler")]
    public class GeneralPoolerManagerScriptableObject : ScriptableObject
    {

        public GameObject poolableObject; //Drag here the GameObject you want to manage with the Pooling System

        [Header("Options")]

      
        public int createOnStart = 0; //Instantiate a predefined number of GameObjects when the game starts

        private List<GameObject> objectsList = new List<GameObject>();

        
        void OnEnable()
        {

             objectsList = new List<GameObject>(); // Clear the objectsList variable
            
            if (createOnStart > 0) InitializePool(createOnStart); // this number of GameObjects is instantiated
        }

        public GameObject GetObject()
        {
            
            foreach (GameObject go in objectsList) // Search through the objectsList 
            {
                if (go != null && !go.activeInHierarchy)
                {
                    go.SetActive(true);
                    return go;
                }
            }
            
           
            GameObject newGo = Instantiate(poolableObject);  // the Pooling System creates and returns a new GameObject 
            objectsList.Add(newGo);
            return newGo;
        }

        
        public int GetPoolSize() // The number of objects inside the Pool
        {
            return objectsList.Count;
        }

        
         public int CountActiveObjects() // The numer of active objects.
        {
            int counter = 0;
            foreach (GameObject go in objectsList)
            {
                
                if (go != null && go.activeInHierarchy) counter++; // Count if the GameObject exists and is active
            }
            return counter;
        }

         
        public void DestroyPool() // Remove all the objects from the Pool and phisically destroy them
        {
            
            foreach (GameObject go in objectsList) // Destroy 
            {
                if (go != null) Destroy(go);
            }
            
            objectsList.Clear(); // Clear 
        }


       
        public void InitializePool(int quantity)  // Instantiate the specified quantity of GameObjects inside the Pool
        {
            for (var i = 0; i < quantity; i++)
            {
               
                GameObject go = Instantiate(poolableObject);  // Create a new object, disable it and add it
                go.SetActive(false);
                objectsList.Add(go);
            }
        }

    }
}


