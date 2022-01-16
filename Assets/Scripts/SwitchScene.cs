using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    private string sceneNameToLoad;
    
    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene(sceneNameToLoad);
    }
}
