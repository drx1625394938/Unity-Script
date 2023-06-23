using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingManage : MonoBehaviour
{
    AsyncOperation async;
    public Slider slider;
   // private Text text;
    public void Start()
    {
        //text = GetComponent<Text>();
        loadLoadingScene("Game");
    }
    public void loadLoadingScene(string NextScene)
    { 
       async=SceneManager.LoadSceneAsync(NextScene);
    }
    private void Update()
    {
        //text.text = (async.progress * 100).ToString()+"%";
        slider.value = async.progress;
    }
}
