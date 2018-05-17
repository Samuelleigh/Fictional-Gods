using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {

    public static int level = 1;
    public object other;

    // Use this for initialization
    void Start () {
		
	}

    public void Clicked(int levelID)
    {

        level = levelID;
        SceneManager.LoadScene("game");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
