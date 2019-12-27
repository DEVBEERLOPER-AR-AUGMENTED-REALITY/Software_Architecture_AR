using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{   
    public void startADD () {
        SceneManager.LoadScene ("SceneADD");
    }

    public void startACDM () {
        SceneManager.LoadScene ("SceneACDM");
    }

    public void startRozanskiAndWoods () {
        SceneManager.LoadScene ("SceneRozanskiWoods");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
