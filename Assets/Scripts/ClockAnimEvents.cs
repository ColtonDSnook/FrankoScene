using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClockAnimEvents : MonoBehaviour
{
    public void Looper()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
