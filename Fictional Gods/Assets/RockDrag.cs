using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RockDrag : MonoBehaviour, IDragHandler, IEndDragHandler {

    public GameObject me;

    public void OnDrag(PointerEventData eventData)
    {
        me.GetComponent<Image>().color = new Color (1f,1f,1f,1f);
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData) { }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
