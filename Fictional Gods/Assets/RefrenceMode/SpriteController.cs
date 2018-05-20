using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour {

    public List<Sprite> GodPortaits;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
    }

    public Sprite PortraitReturn(int ID) {

        return GodPortaits[ID];
    }

	// Update is called once per frame
	void Update () {
		
	}
}
