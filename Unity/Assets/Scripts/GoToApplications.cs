﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GoToApplicationScene()
    {
        SceneManager.LoadScene("Applications");
    }

    public void GoToTheoryScene()
    {
        SceneManager.LoadScene("Theory");
    }
}
