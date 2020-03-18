using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public static GameController instance;
    public bool isDead = false;


    private void Awake() {
        if(instance == null) {
            instance = this;
        }
    }

    public void PlayerCrash() {
        this.isDead = true;

    }

    private void Update() {
  
        if (this.isDead && Input.GetButtonDown("Jump")) {
            //...reload the current scene.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
