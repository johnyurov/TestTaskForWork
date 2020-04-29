using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        //SceneManager.LoadScene(0);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Options()
    {

    }
    private void Update()
    {
        //if (Input.GetMouseButtonDown(0) && tag.Equals("Restart"))
        //{
        //    Restart();
        //}
        //if (Input.GetMouseButtonDown(0) && tag.Equals("Menu"))
        //{
        //    Restart();
        //}
    }
}
