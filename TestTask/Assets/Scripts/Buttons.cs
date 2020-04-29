using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void Menu()
    {
        Debug.Log("yes");
        //SceneManager.LoadScene(0);
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
