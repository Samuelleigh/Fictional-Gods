using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    //set up
    private DataController dataController;
    private SpriteController spriteController;
    private Data_FictionalGods currentGod;

    //import from Datacontroller

    public string godName;
    public string godOf;
    public List <string> Fiction;
    public List <string> gameRules;
    public Sprite godPortait;

    //game objects for info

    public GameObject fictionRoot;
    public GameObject rulesRoot;
    public GameObject portaitRoot;

    //Text UI

    public List<Text> godNameText;
    public List<Text> godOfText;
    public List<Text> godOfPara;

    public Image Portait;


    public int currentMode;


    //tab cheats
    public List<GameObject> cheats;

    
	// Use this for initialization
	void Start () {
        spriteController = FindObjectOfType<SpriteController>();
        dataController = FindObjectOfType<DataController>();
        currentGod = dataController.GetCurrentGod(LevelSelect.level);

        rulesRoot.SetActive(false);
        portaitRoot.SetActive(false);

        godName = currentGod.name;
        godOf ="God of "+ currentGod.godOf;
        Fiction = currentGod.Fiction;
        gameRules = currentGod.GameRules;

        for (int i = 0; i < godNameText.Count; i++) { godNameText[i].text = godName; }
        for (int i = 0; i < godOfText.Count; i++) { godOfText[i].text = godOf; }

        godOfPara[0].text = Fiction[0];
        godOfPara[1].text = gameRules[0];

        Portait.sprite = spriteController.GodPortaits[LevelSelect.level];
        
    }

	
	// Update is called once per frame
	void Update () {
		
	}

    public void SwitchMode(int mode) {
        currentMode = mode;

        //FictionMode
        if (currentMode == 0) { portaitRoot.SetActive(false); rulesRoot.SetActive(false); fictionRoot.SetActive(true);
            cheats[0].SetActive(true); cheats[1].SetActive(false); cheats[2].SetActive(false);
        }

        //RulesMode
        if (currentMode == 1) {fictionRoot.SetActive(false); portaitRoot.SetActive(false); rulesRoot.SetActive(true);
            cheats[0].SetActive(false); cheats[1].SetActive(true); cheats[2].SetActive(false);
        }

        //Portait Mode
        if (currentMode == 2) { fictionRoot.SetActive(false);  rulesRoot.SetActive(false); portaitRoot.SetActive(true);
            cheats[0].SetActive(false); cheats[1].SetActive(false); cheats[2].SetActive(true);
        }

    }

    public void Back() {

        SceneManager.LoadScene("Level Select");

    }
}
