using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayStats : MonoBehaviour
{
    static Player player;
    public Text _hp, _rocketAmmo;
    static Text hp, rocketAmmo;
    private void Awake()
    {
        hp = _hp;
        rocketAmmo = _rocketAmmo;
    }
    private void Start()
    {
        player = Player.instance;
    }

    public static void UpdateHealth()
    {
        hp.text = " x " + player.GetCurrentHP();
    }
    public static void UpdateRocketAmmo(int ammo)
    {
        rocketAmmo.text = " x " + ammo;
    }
}
