using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Core{
    public class MainMenu : MonoBehaviour
    {
        public GameObject settingCanvas, mainCanvas;
        private void Start()
        {
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
        public void PlayGame()
        {
            SceneManager.LoadScene(1);
        }

        public void QuitGame()
        {
            Application.Quit();//only work when playing the .exe
        }

        public void BackButton()
        {
            settingCanvas.SetActive(false);
            mainCanvas.SetActive(true);
        }

        public void SettingsButton()
        {
            settingCanvas.SetActive(true);
            mainCanvas.SetActive(false);
        }

        public void RestartButton()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reload current scene
        }
    }

}
