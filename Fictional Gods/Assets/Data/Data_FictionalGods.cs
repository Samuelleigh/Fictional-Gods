using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data_FictionalGods {

   
    public string name;
    public string godOf;
    public List<string> Fiction;
    public List<string> GameRules;
    [NonSerialized]
    public List<Sprite> godPortrait;
    


}
