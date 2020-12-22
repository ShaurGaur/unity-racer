using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelWithButton : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyRestart))
            Application.Quit();
    }
}
