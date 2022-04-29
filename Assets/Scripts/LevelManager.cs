using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    DataTracker dt = DataTracker.Instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dt.currentScene == 1)
        {
            GoToIntro();
            dt.currentScene = 0;
        }
    }

    public void GoToIntro()
    {
        SceneManager.LoadScene(1);
    }
}
