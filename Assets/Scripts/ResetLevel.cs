using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
  //  public string SceneName;
    // Start is called before the first frame update
   
    public void RestartLevel()
    {
        Debug.Log("Restarting");
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
