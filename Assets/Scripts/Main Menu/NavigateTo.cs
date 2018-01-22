using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class NavigateTo : MonoBehaviour {

   
    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

	
}
