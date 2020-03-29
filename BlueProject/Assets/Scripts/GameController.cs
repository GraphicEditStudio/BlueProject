using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {
    public static GameController instance;
    public bool isDead = false;
    public bool isPaused = false;
    public Text txt;
    public float displayDelay = 0.45f;
    private IEnumerator Progressive(){
        string temporaryText = "Game Over";
        for(int i = 0; i < temporaryText.Length; i++){
            txt.text += temporaryText[i];
            yield return new WaitForSeconds(displayDelay);
        }
    }

    private IEnumerator ProgressiveClear(){
        string temporaryText = "Cleared Level";
        for(int i = 0; i < temporaryText.Length; i++){
            txt.text += temporaryText[i];
            yield return new WaitForSeconds(displayDelay);
        }
    }

    private void Awake() {
        if(instance == null) {
            instance = this;
        }
        
    }
    public void PlayerCrash() {
        // Display the Game Over Screen
        StartCoroutine("Progressive");

    }
    public void PlayerClear(){
        // Displays the clear screen
        StartCoroutine("ProgressiveClear");
    }
    private void Update() {

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!isPaused)
            {
                Time.timeScale = 0;
                isPaused = true; // for some reason enemies arent stopping
                //here we need the trigger for the canvas_pause
            }
            else
            {
                Time.timeScale = 1;
                isPaused = false;
            }
        }


        if (this.isDead && Input.GetKeyDown(KeyCode.Return)) {
            //...reload the current scene.
            SceneManager.LoadScene(1);
        }
        if(this.isDead){
            PlayerCrash();
        }

    }
}
