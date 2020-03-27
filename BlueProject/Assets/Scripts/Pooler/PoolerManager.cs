using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BlueGame
{
    public class PoolerManager : MonoBehaviour
    {
        [System.Serializable]
        public class Pool
        {
            public string tag;
            public GameObject prefab;
            public int size;
        }
        public static PoolerManager instance;
        private void Awake()
        {
            instance = this;
        }
        public List<Pool> poolList;
        public Dictionary<string, Queue<GameObject>> poolDictionary;
        private void Start()
        {
            GameObject obj;
            Queue<GameObject> objPool;
            int poolSize;
            poolDictionary = new Dictionary<string, Queue<GameObject>>();
            foreach (Pool pool in poolList)
            {
                objPool = new Queue<GameObject>();
                poolSize = pool.size;
                for (int i = 0; i < poolSize; i++)
                {
                    obj = Instantiate(pool.prefab);
                    obj.SetActive(false);
                    objPool.Enqueue(obj);
                }
                poolDictionary.Add(pool.tag, objPool);
            }
        }
        public void DestroyPool(string tag)
        {
            GameObject obj;
            Queue<GameObject> objPool = poolDictionary[tag];
            int poolSize = objPool.Count;
            for (int i = 0; i < poolSize; i++)
            {
                obj = objPool.Dequeue();
                Destroy(obj);
            }
            objPool.Clear();    //idk if this is necessary
            poolDictionary.Remove(tag);
        }
        public GameObject Spawn(string tag, Vector3 position, Quaternion rotation)
        {
            if (!poolDictionary.ContainsKey(tag))
            {
                Debug.Log("Tag " + tag + " doesn't exist.");
                return null;
            }
            GameObject obj = poolDictionary[tag].Dequeue();
            obj.SetActive(false);       // in case the obj already active, so that onEnable() is called again
            obj.transform.position = position;
            obj.transform.rotation = rotation;
            obj.SetActive(true);
            poolDictionary[tag].Enqueue(obj);
            return obj;
        }
    }
}
