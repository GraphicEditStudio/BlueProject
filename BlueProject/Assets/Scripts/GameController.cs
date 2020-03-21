using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {
    public static GameController instance;
    public bool isDead = false;
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
        this.isDead = true;
        // Display the Game Over Screen
        StartCoroutine("Progressive");

    }
    public void PlayerClear(){
        StartCoroutine("ProgressiveClear");
    }
    private void Update() {
        if (this.isDead && Input.GetButtonDown("Jump")) {
            //...reload the current scene.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
