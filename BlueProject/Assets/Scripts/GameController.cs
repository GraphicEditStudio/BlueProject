using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Core;
public class GameController : MonoBehaviour {
    [HideInInspector]
    public int enemyKilled = 0;
    public int totalEnemy;
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
    IEnumerator DisplayText(string text, float waitTime, float delayPerLetter)
    {
        displayingMessage = true; //for now
        yield return new WaitForSeconds(waitTime);
     //   displayingMessage = true; put this here later
        int len = text.Length;
        for (int i = 0; i < len; i++)
        {
            txt.text += text[i];
            yield return new WaitForSeconds(delayPerLetter);
        }
    }
    IEnumerator ClearDisplay(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        txt.text = "";
        displayingMessage = false;
        yield return null;
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
        StartCoroutine(DisplayText("Game Over\nPress Enter to retry", 0f, displayDelay));

    }
    public void PlayerClear(){
        // Displays the clear screen
        StartCoroutine(DisplayText("You\nSurvived!", 0f, displayDelay / 2));
        StartCoroutine(ClearDisplay(3.74f));
        StartCoroutine(DisplayText("Total Enemy Killed:\n" + enemyKilled + " / " + totalEnemy + "\nPress Escape to go back.", 3.75f, displayDelay / 2));
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
        }
    }
    public void TogglePause()
    {
        if (!isPaused)
        {
            Time.timeScale = 0; 
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
