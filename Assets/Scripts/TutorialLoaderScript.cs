using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialLoaderScript : MonoBehaviour {

    public void GoToTutorial()
    {
        SceneManager.LoadScene("tutorial");
    }
}
