using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "SampleScene";

    public void startGame()
    {
        Debug.Log("HERE");
        SceneManager.LoadScene(newGameLevel);
    }
}
