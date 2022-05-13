using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene_DeleteLater : MonoBehaviour
{
    private int NextLevelLoad;

    private void Start()
    {
        NextLevelLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(NextLevelLoad);
        }
    }

    public void OnDinnerComplete()
    {
        SceneManager.LoadScene(NextLevelLoad);
    }

    //public void GoToIntro()
    //{
    //    SceneManager.LoadScene(1);
    //}
}
