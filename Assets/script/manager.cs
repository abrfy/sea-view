using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        //DontDestroyOnLoad(gameObject);
    }
    public void Play(int num)
    {
        SceneManager.LoadScene(num);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
