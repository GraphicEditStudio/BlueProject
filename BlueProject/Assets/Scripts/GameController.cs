using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public static GameController instance;
    public bool isDead = false;
    public Text txt;
    public int MaxInterval = 36;
    private int currentInterval = 0;
    private int currentIndex = 0;
    private bool progressing = true;
    private void Awake() {
        if(instance == null) {
            instance = this;
        }
        PlayerCrash();
    }

    public void PlayerCrash() {
        this.isDead = true;
        // Display the Game Over Screen
        
    }

    private void Update() {
  
        if (this.isDead && Input.GetButtonDown("Jump")) {
            //...reload the current scene.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void FixedUpdate(){
        string temporaryText = "Game Over";
        if(currentInterval == 0 && progressing && this.isDead){
            txt.text += temporaryText[currentIndex];
            if(currentIndex == temporaryText.Length - 1){
               progressing = false;
            }
            currentInterval = MaxInterval;
            currentIndex++;
        }
        currentInterval--;
    }

}
