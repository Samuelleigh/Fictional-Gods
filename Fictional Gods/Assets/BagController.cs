using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BagController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject rock;
    public GameObject Canvas;

    public Image containerImage;
    public List<GameObject> inactiveRocks;
    public Image wow;
    public List<GameObject> activeRocks;
    public bool isOver = false;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            inactiveRocks.Add(Instantiate(rock, Canvas.transform));
            inactiveRocks[i].GetComponent<Image>().color = Color.clear;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isOver = true;
        Debug.Log("wow");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isOver = false;
    }


    // Update is called once per frame
    void Update () {
        if (isOver == true) {

            inactiveRocks[0].transform.position = Input.mousePosition;
          //  Debug.Log("wow");
        }

    }

    void Click() { }

}
