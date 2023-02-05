using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

//https://www.youtube.com/watch?v=Pe2qwTuT0P0
