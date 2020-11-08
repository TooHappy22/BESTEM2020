﻿using System;
using APIs;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Handlers
{
    public class LoadingSceneHandler : MonoBehaviour
    {
        private void Start()
        {
            SceneManager.LoadScene("AuthenticationScene");
        }
    }
}
