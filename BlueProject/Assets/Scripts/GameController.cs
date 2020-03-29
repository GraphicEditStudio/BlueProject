using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Core;
public class GameController : MonoBehaviour {
    public float reqTimeToWin = 100f;
    public static GameController instance;
    public GameObject PauseMenu;
    public bool isDead = false;
    public bool displayingMessage = false;
    public bool isPaused = false;
    public Text txt;
    public float displayDelay = 0.25f;
    private IEnumerator WinningProgression()
    {
        yield return new WaitForSeconds(reqTimeToWin);
        if (!isDead) PlayerClear();
        yield return null;
    }
    private IEnumerator Progressive(){
        string temporaryText = "Game Over";
        int len = temporaryText.Length;
        for (int i = 0; i < len; i++){
            txt.text += temporaryText[i];
            yield return new WaitForSeconds(displayDelay);
        }
    }

    private IEnumerator ProgressiveClear(){
        string temporaryText = "You\nSurvived!";
        int len = temporaryText.Length;
        for(int i = 0; i < len; i++){
            txt.text += temporaryText[i];
            yield return new WaitForSeconds(displayDelay);
        }
    }

    private void Awake()
    {
        Time.timeScale = 1;
        if (instance == null) {
            instance = this;
        }
        if(txt == null){
           // txt = GameObject.Find("DisplayText");
        }
        
    }
    private void Start()
    {
        StartCoroutine(WinningProgression());
    }
    public void PlayerCrash() {
        // Display the Game Over Screen
        StartCoroutine(Progressive());

    }
    public void PlayerClear(){
        // Displays the clear screen
        StartCoroutine(ProgressiveClear());
    }
    private void Update() {

        if (Input.GetKeyDown(KeyCode.Escape) && !this.displayingMessage)
        {
            TogglePause();
        }

        if (this.isDead && Input.GetKeyDown(KeyCode.Return)) {
            //...reload the current scene.
            SceneManager.LoadScene(1);
        }
        if(this.isDead && !this.displayingMessage){
            PlayerCrash();
            displayingMessage = true;
        }
    }
    public void TogglePause()
    {
        if (!isPaused)
        {
            Time.timeScale = 0; // For some reason the enemies don't pause when this happens 
            isPaused = true;
            PauseMenu.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            isPaused = false;
            PauseMenu.SetActive(false);
        }
    }
}
