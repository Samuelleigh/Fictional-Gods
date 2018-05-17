using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class DataController : MonoBehaviour {

    public Data_FictionalGods[] allFictionalGods;
    public int levelID;
    [HideInInspector]
    public Data_FictionalGods[] backUp;

    // Use this for initialization
    void Start () {

        backUp = DeepClone<Data_FictionalGods[]>(allFictionalGods);

        DontDestroyOnLoad(gameObject);

        SceneManager.LoadScene("Level Select");
    }

    public Data_FictionalGods GetCurrentGod()
    {
        levelID = LevelSelect.level;
        return allFictionalGods[levelID];
    }

    public void ResetRoundData()
    {

        allFictionalGods = DeepClone <Data_FictionalGods[]>(backUp);
    }

    public static T DeepClone<T>(T obj)
    {
        using (var ms = new MemoryStream())
        {
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, obj);
            ms.Position = 0;

            return (T)formatter.Deserialize(ms);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
