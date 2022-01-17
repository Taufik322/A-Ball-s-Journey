using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  public void PlayGame ()
  {
      SceneManager.LoadScene("Level 1");
  }
  public void QuitGame() {  
      Debug.Log("QUIT");  
      SceneManager.LoadScene("Quit");  
  } 
  public void PlayGameMenu ()
  {
      SceneManager.LoadScene("Menu");
  }
}
