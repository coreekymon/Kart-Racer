﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
   public void SceneChange(string scene)
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
