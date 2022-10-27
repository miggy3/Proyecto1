using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour
{
    public Button startbutton;
    private void Awake()
    {
        
        StartCoroutine(StartMainMenu);
    }
    private IEnumerator StartMainMenu()
    {
        yield return new WaitUntil(5);

        SceneManager.LoadScene("1");
    }

    public void StartMainMenu()
    {

    }
}
