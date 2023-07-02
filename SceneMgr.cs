using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class SceneMgr
{
    private static SceneMgr _instance;
    public static SceneMgr Instance 
    {
        get 
        {
            if (_instance == null) 
            {
                _instance = new SceneMgr();
            }
            return _instance;
        }
    }
    public void Test() 
    {
    
    }
}
