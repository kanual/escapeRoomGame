using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonui : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Level1";

    public void NewGameButton() {
        SceneManager.loadScene(newGameLevel);
    }
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
