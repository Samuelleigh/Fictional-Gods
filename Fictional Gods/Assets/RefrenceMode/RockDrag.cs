using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RockDrag : MonoBehaviour, IDragHandler, IEndDragHandler, IPointerClickHandler
{

    public GameObject me;
    public BagController bag;
    

    public bool firstClick = false;

    public void Awake()
    {
        bag = FindObjectOfType<BagController>();
    }

    public void OnPointerClick(PointerEventData eventData) 
    {
        if (firstClick == false) { bag.Clicked(me); firstClick = true;  }
    }

    public void OnDrag(PointerEventData eventData)
    {
        
        me.GetComponent<Image>().color = new Color (1f,1f,1f,1f);
        transform.position = Input.mousePosition;
       // bag.Clicked(me);
    }

    public void OnEndDrag(PointerEventData eventData) {

       

    }

    public void OnDrop(PointerEventData eventData)
    {
      
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
