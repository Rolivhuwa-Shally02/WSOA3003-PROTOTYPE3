﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class level2load : MonoBehaviour {

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Gameover.isPlayerDead = false;
            Time.timeScale = 1;
            SceneManager.LoadScene("Game");
        }
    }
}
