using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour {
    public float health;
    public enum Actions{
        // Commented out enums only apply if the game is in 3D
        IDLE, UP, DOWN, LEFT, RIGHT, /*FORWARD, BACKWARD,*/ ATTACK
    }
    public Actions currentState = Actions.IDLE;
    public void Action(Actions Action){
        switch(Action){
            case Actions.ATTACK:
                break;
            case Actions.DOWN:
                break;
            case Actions.UP:
                break;
            case Actions.LEFT:
                break;
            case Actions.RIGHT:
                break;
            
            // Commented out areas only apply if the game is in 3D
            /*
            case Actions.FORWARD:
                break;
            case Actions.BACKWARD:
                break;
            */
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Something");
    }
}