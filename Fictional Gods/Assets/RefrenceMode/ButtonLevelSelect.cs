using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLevelSelect : MonoBehaviour {

    //signifyer

    public int ID;

    //ui
    public Text godName;
    public Text godOf;
    public Image Portait;

    //imported
    public DataController dataController;
    public SpriteController spriteController;
    public Data_FictionalGods god;

    private void Awake()
    {
        dataController = FindObjectOfType<DataController>();
        spriteController = FindObjectOfType<SpriteController>();
        god = dataController.GetCurrentGod(ID);
    }

    // Use this for initialization
    void Start () {

        godName.text = god.name;
        Portait.sprite = spriteController.GodPortaits[ID];
        godOf.text = "God of " + god.godOf;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
