using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class PowerUpList : MonoBehaviour
{
    [System.Serializable]
    public class PowerUp
    {
        public string name;
        public UnityEvent effect;
    }
    public static PowerUpList instance {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<PowerUpList>();
            }
            return _instance;
        }
    }
    private static PowerUpList _instance;
    Player player;
    public List<PowerUp> list;
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        player = Player.instance;
    }
    public UnityEvent GetPowerUpEffect(int id)
    {
        return list[id].effect;
    }
    public string GetName(int id)
    {
        return list[id].name;
    }
    //useless for the moment
    //public int GetId(string name)
    //{
    //    int id = -1, length;
    //    length = list.Count;
    //    for (int i = 0; i < length; i++)
    //    {
    //        if(string.CompareOrdinal(list[i].name, name) == 0)
    //        {
    //            id = i;
    //            break;
    //        }
    //    }
    //    return id;
    //}
    public void PlayerHeal(int amount)
    {
        player.Heal(amount);
    }
    public void AddRockets(int amount)
    {
        player.AddAmmo(1, amount);
    }
}
