using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUICotroller : MonoBehaviour
{
    public Button playButton;
    public Button mainMenuButton;
    public Button creditButton;
    public Button exitButton;

    void Start()
    {
         playButton.onClick.AddListener(PlayGame);
         mainMenuButton.onClick.AddListener(MainMenu);
         creditButton.onClick.AddListener(Credit);
         exitButton.onClick.AddListener(Exit);
    }

    public void PlayGame()
  {
    SceneManager.LoadScene("Pinball_Scene");
  }
  public void MainMenu()
  {
		// kembali ke main menu
    SceneManager.LoadScene("MainMenu");
  }
  public void Credit()
  {
    SceneManager.LoadScene("CreditMenu");
  }
  private void Exit()
  {
    Application.Quit();
  }
}
