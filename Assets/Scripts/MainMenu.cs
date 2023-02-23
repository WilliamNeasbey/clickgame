using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string LevelToLoad;
    public void TestScene()
    {
        SceneManager.LoadScene("TestScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void VsKendrick()
    {
        SceneManager.LoadScene("RPSKendrick");
    }

    public void VsGoku()
    {
        SceneManager.LoadScene("RPSProphet");
    }

    public void PowerRangers()
    {
        SceneManager.LoadScene("RPSPowerRangers");
    }

    // RPSMrBeastAndSans
    public void TagTeam()
    {
        SceneManager.LoadScene("RPSMrBeastAndSans");
    }
}
