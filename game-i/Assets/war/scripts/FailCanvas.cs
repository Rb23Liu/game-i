using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailCanvas : MonoBehaviour
{

    public void ReStart()
    {
        SceneManager.LoadScene(0);
    }


    public void Quit()
    {
#if UNITY_EDITOR_WIN
        EditorApplication.isPlaying = false;
        return;
#endif
        Application.Quit();
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
