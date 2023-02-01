using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Snake : MonoBehaviour
{

    void OnTriggerEnter(Collider other) 
    {

        SceneManager.LoadScene(15);
    }
}