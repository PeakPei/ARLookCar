using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEngine : MonoBehaviour {
    public string engineStr = "Engine:  ";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /// <summary>
    /// 更换车胎
    /// </summary>
    public void ChangeFirst()
    {
        Debug.Log("ChangeFirst()");
        engineStr += "001";
    }
    public void ChangeSecond()
    {
        Debug.Log(" ChangeSecond()");
        engineStr += "002";
    }
    public void ChangeThird()
    {
        engineStr += "003";
        Debug.Log(" ChangeThird()");
    }
    public void GetBack()
    {
        this.gameObject.SetActive(false);
    }
}
