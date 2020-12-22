using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;
    
    void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == strTag)
            Application.Quit();
    }
}
