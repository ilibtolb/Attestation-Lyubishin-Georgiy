using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButons : MonoBehaviour
{
    //класс со всеми холстами
    public GameObject game;
    public GameObject menu;
    public GameObject LoseMenu;
    public GameObject WinMenu;
    public GameObject UpgradeMenu;
    public GameObject PauseMenu;
    public GameObject GamePause; //отдельный холст с кнопкой паузы, чтобы проще в самой игре выставлять координаты
    public Transform parent;
    public Transform player;
    public BugGenerator bug;
    public Fire playerShoot;

    public void Close(GameObject canvas)
    {
        canvas.SetActive(false);
    }

    public void Open(GameObject canvas)
    {
        canvas.SetActive(true);
    }

    public void NewGame()
    {
        foreach (Transform child in parent) Destroy(child.gameObject);
        bug.CreateLvl();
        player.position = new Vector3(-3, 4.37f, -6.3f);
        Open(game);
        Open(GamePause);
        Close(menu);
    }

    public void Lose()
    {
        Close(game);
        Close(GamePause);
        Open(LoseMenu);
    }

    public void Win()
    {
        Close(game);
        Close(GamePause);
        Open(WinMenu);
    }

    public void MainMenu()
    {
        Close(PauseMenu);
        Close(GamePause);
        Close(LoseMenu);
        Close(WinMenu);
        Open(menu);
    }

    /*public void Upgrade()
    {
        Close(WinMenu);
        Open(UpgradeMenu);
    }*/

    public void Restart()
    {
        foreach (Transform child in parent) Destroy(child.gameObject);
        bug.CreateLvl();
        player.position = new Vector3(-3, 4.37f, -6.3f);
        Close(LoseMenu);
        Open(game);
    }

    public void NextLvl()
    {
        foreach (Transform child in parent) Destroy(child.gameObject);
        bug.NextLvl();
        playerShoot.NextLvl();
        player.position = new Vector3(-3, 4.37f, -6.3f);
        Open(game);
        Open(GamePause);
        Close(WinMenu);
    }

    public void Pause()
    {
        Open(PauseMenu);
        Close(game);
        Close(GamePause);
    }

    public void Resume()
    {
        Close(PauseMenu);
        Open(game);
        Open(GamePause);
    }
}
