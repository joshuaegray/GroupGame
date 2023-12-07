using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{

   
    // Start is called before the first frame update
  

    public void loadLevel(string levelName)
    {
        // Takes in a string level name and uses it to load that level
        SceneManager.LoadScene(levelName);
    }

    
    
    
}
