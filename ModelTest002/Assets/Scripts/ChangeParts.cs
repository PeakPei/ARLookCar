using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeParts : MonoBehaviour {
    public GameObject DoorsPanel;
    public GameObject WheelsPanel;
    public GameObject EnginePanel;
    public GameObject BumperPanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /// <summary>
    /// 更换车门
    /// </summary>
    public void ChangeDoor() {
        Debug.Log("更换车门");
        DoorsPanel.SetActive(true);
        EnginePanel.SetActive(false);
        WheelsPanel.SetActive(false);
        BumperPanel.SetActive(false);
    }
    /// <summary>
    /// 更换引擎
    /// </summary>
    public void ChangeEngine() {
        Debug.Log("更换引擎");
        EnginePanel.SetActive(true);
        DoorsPanel.SetActive(false);
    
        WheelsPanel.SetActive(false);
        BumperPanel.SetActive(false);
    }
    /// <summary>
    /// 更换轮胎
    /// </summary>
    public void ChangeWheel() {
        Debug.Log("更换轮胎");
        WheelsPanel.SetActive(true);
        DoorsPanel.SetActive(false );
        EnginePanel.SetActive(false);
     
        BumperPanel.SetActive(false);
    }
    /// <summary>
    /// 更换引擎盖
    /// </summary>
    public void ChangeBumper() {
        Debug.Log("更换引擎盖");
        BumperPanel.SetActive(true);
        DoorsPanel.SetActive(false);
        EnginePanel.SetActive(false);
        WheelsPanel.SetActive(false);
 
    }
    /// <summary>
    /// 返回
    /// </summary>
    public void GetBack() {
        Debug.Log("返回");
        this.gameObject.SetActive(false);
        DoorsPanel.SetActive(false);
        EnginePanel.SetActive(false);
        WheelsPanel.SetActive(false);
        BumperPanel.SetActive(false);
    }
}
