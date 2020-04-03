using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpList : MonoBehaviour
{
    Player player;
    private void Start()
    {
        player = Player.instance;
    }
    public void PlayerHeal(int amount)
    {
        player.Heal(amount);
    }
    public void AddRockets(int amount)
    {
        player.AddAmmo(1, amount);
    }
}
