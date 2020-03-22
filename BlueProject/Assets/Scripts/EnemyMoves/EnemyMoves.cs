using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Move", menuName = "Enemy's Move")]
public class EnemyMoves : ScriptableObject
{
    public float radius, angle, duration;
    //duration means how long (in sec) it takes to complete the move
    //if forward angle=0, radius is the distance
    //if turn right, both radius and angle must be negatuve
}
