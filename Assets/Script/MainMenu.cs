using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {
       
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SettingsGame()
    {
        SceneManager.LoadScene("Settings");
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GetdoftdareCompnay()
    {
        Application.OpenURL("https://www.doftdare.com/");//linki açabilmek için
    }

    public void GetdoftdareCompanyGame()
    {
        Application.OpenURL("https://www.doftdare.com/game");//linki açabilmek için
    }

    public void GetInstagram()
    {
        Application.OpenURL("https://www.instagram.com/doftdare/");
    }

    public void GetDiscord()
    {
        Application.OpenURL("https://discord.com/invite/4uyRYaXT6K");
    }

    public void GetLinkdein()
    {
        Application.OpenURL("https://www.linkedin.com/company/doftdare");
    }

    public void GameOverBackMenu()
    {
        Time.timeScale = 1f;//oyunu tekrar baþlattýk
        SceneManager.LoadScene("MainMenu");
    }

    public void GameOverPlay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");

    }

    public void VictoryBackMenu()
    {
        Time.timeScale = 1f;//oyunu tekrar baþlattýk
        SceneManager.LoadScene("MainMenu");
    }

    public void VictoryPlay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }
}