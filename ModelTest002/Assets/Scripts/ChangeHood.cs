using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHood : MonoBehaviour {
    public GameObject FirstHood;
    public GameObject SecondHood;
    public string hoodStr = "Hood:  ";
    /// <summary>
    /// 更换引擎盖
    /// </summary>
    public void ChangeFirst()
    {
        FirstHood.SetActive(true);
        SecondHood.SetActive(false);

        hoodStr += "001";

    }
    public void ChangeSecond()
    {
        FirstHood.SetActive(false);
        SecondHood.SetActive(true);
        hoodStr += "002";
    }
   
    public void GetBack()
    {
        this.gameObject.SetActive(false);
    }
}
