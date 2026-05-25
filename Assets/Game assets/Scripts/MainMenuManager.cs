using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public string CurrentScene()
    {
        var current = SceneManager.GetActiveScene().name;

        return current;
    }

    public void LoadLevels()
    {
        switch (CurrentScene())
        {
            case "Main Menu":
                SceneManager.LoadScene("Intro Video");
                break;
            case "Intro Video":
                SceneManager.LoadScene("Level 1");
                break;
            default:
                Debug.LogWarning("Unknown level: " + CurrentScene());
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (CurrentScene() == "Intro Video")
        {
            UnityEngine.Video.VideoPlayer vp = FindObjectOfType<UnityEngine.Video.VideoPlayer>();
            if (vp != null)
            {
                vp.loopPointReached += EndReached;
            }
        }
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        LoadLevels();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}