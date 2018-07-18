﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMusicScript : MonoBehaviour {

    private void Update()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("MUSIC");
        if(objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
