using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class SceneLoadManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && SceneManager.GetActiveScene().name != "FinalHistoria")
        {
            LoadNextScene();
        }
        else if (Input.anyKeyDown && SceneManager.GetActiveScene().name == "FinalHistoria")
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void LoadNextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextSceneIndex == 5) nextSceneIndex = 0;
        SceneManager.LoadScene(nextSceneIndex);
    }


}
