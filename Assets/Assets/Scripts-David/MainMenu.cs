using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void MenuPlayGame()
    {
        SceneManager.LoadScene("davidDevScene");
    }
    public void QuitGame()
    {
	Debug.Log("Quit");
	Application.Quit();

        SceneManager.LoadScene("davidDevScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
