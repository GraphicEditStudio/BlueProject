using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Core;
public class MainMenu : MonoBehaviour
{
    void Start(){
        gameObject.SetActive(false);
        gameObject.GetComponent<Renderer>();
    }
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void quitGame()
    {
        Application.Quit();//only work when playing the .exe
            
    }

    public void backButton()
    {
        SceneManager.LoadScene(0); //Scene 0 is the main menu
    }

    public void settingsScene()
    {
        SceneManager.LoadScene(2); //Scene index2= settings Scene
    }

    public void restartButton()
    {
        SceneManager.LoadScene(1);//Scene1= first level
    }
}
