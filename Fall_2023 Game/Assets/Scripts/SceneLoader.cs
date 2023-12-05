using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
    
    public void LoadShopScene()
    {
        SceneManager.LoadScene("Store");
    }

    public void LoadStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    
    public void LoadTutorialScene()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
