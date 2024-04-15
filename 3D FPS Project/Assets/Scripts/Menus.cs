using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public int levelOne;

    public void OnPlayButtonPressed()
    {
        SceneManager.LoadScene(levelOne);
    }

    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
