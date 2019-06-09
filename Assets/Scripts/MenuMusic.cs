using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMusic : MonoBehaviour
{
    public string SceneName;
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if(objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Scene CurrentScene = SceneManager.GetActiveScene();
        SceneName = CurrentScene.name;
        if(SceneName == "FieldTrack" || SceneName == "MoonTrack" || SceneName == "SnowyMountainTrack" || SceneName == "DesertTrack" || SceneName == "CityTrack")
        {
            Destroy(this.gameObject);
        }
    }
}
