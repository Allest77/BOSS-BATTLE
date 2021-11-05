using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuEvents : MonoBehaviour {
    public Button credits;
    public GameObject panel;
    public Canvas page;
    public AudioSource menuMusic;
    bool gameStart;

    public GameObject music;
    private BGMScript track;

    private void Awake() {
        track = music.GetComponent<BGMScript>();
    }

    //Level Select
    public void LoadLevel(int levelIndex) {
        SceneManager.LoadScene("BulletLevel");
        menuMusic.Stop();
        Destroy(music.gameObject);

        //Credits
        void Update()
        {
            if (gameStart)
            {
                credits.gameObject.SetActive(false);
            }
            else
            {
                credits.gameObject.SetActive(true);
            }
        }
    }

    public void DisplayText()
    {
        page.gameObject.SetActive(true);
        panel.gameObject.SetActive(true);
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("BYE");
    }
}
