using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    //set up
    private DataController dataController;
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
    

    
	// Use this for initialization
	void Start () {
        dataController = FindObjectOfType<DataController>();
        currentGod = dataController.GetCurrentGod();

        rulesRoot.SetActive(false);
        portaitRoot.SetActive(false);

        godName = currentGod.name;
        godOf ="God of:  "+ currentGod.godOf;
        Fiction = currentGod.Fiction;
        gameRules = currentGod.GameRules;

        for (int i = 0; i < godNameText.Count; i++) { godNameText[i].text = godName; }
        for (int i = 0; i < godOfText.Count; i++) { godOfText[i].text = godOf; }

        godOfPara[0].text = Fiction[0];
        godOfPara[1].text = gameRules[0];

        Portait.sprite = godPortait;
        
    }

	
	// Update is called once per frame
	void Update () {
		
	}

    public void SwitchMode(int mode) {
        currentMode = mode;

        //FictionMode
        if (currentMode == 0) { portaitRoot.SetActive(false); rulesRoot.SetActive(false); fictionRoot.SetActive(true); }

        //RulesMode
        if (currentMode == 1) {fictionRoot.SetActive(false); portaitRoot.SetActive(false); rulesRoot.SetActive(true); }

        //Portait Mode
        if (currentMode == 2) { fictionRoot.SetActive(false);  rulesRoot.SetActive(false); portaitRoot.SetActive(true); }

    }
}
