using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Audio;
namespace Core{
    public class MainMenu : MonoBehaviour
    {
        public GameObject settingCanvas, mainCanvas;
        AudioManager audioManager;
        private void Start()
        {
            audioManager = AudioManager.instance;
            if (!settingCanvas)
            {
                settingCanvas = GameObject.Find("SettingsCanvas");
            }
            if (settingCanvas)
            {
                settingCanvas.SetActive(false);
            }
            if (!mainCanvas)
            {
                mainCanvas = GameObject.Find("MainCanvas");
            }

            

        }
        public void ToMainMenu()
        {
            audioManager.Play("ButtonClick");
            SceneManager.LoadScene(0);
        }
        public void PlayGame()
        {
            audioManager.Play("ButtonClick");
            SceneManager.LoadScene(1);
        }

        public void QuitGame()
        {
            audioManager.Play("ButtonClick");
            Application.Quit();//only work when playing the .exe
        }

        public void BackButton()
        {
            audioManager.Play("ButtonClick");
            settingCanvas.SetActive(false);
            mainCanvas.SetActive(true);
        }

        public void SettingsButton()
        {
            audioManager.Play("ButtonClick");
            settingCanvas.SetActive(true);
            mainCanvas.SetActive(false);
        }

        public void RestartButton()
        {
            audioManager.Play("ButtonClick");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reload current scene
        }
        public void ButtonClickSound()
        {
            audioManager.Play("ButtonClick");
        }
    }

}
