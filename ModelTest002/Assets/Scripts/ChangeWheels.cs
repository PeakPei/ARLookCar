using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWheels : MonoBehaviour {
    public   GameObject[] FirstWheels;
    public   GameObject[] SecondWheels;
    public   GameObject[] ThirdWheels;

    public string wheelsStr = "Wheels: ";
    /// <summary>
    /// 更换车胎
    /// </summary>
    public void ChangeFirst()
    {
        for (int i = 0; i < FirstWheels.Length; i++)
        {
            FirstWheels[i].SetActive(true);
            SecondWheels[i].SetActive(false);
            ThirdWheels[i].SetActive(false);
        }
        wheelsStr += " 001";
        Debug.Log("ChangeFirst()");
    }
    public void ChangeSecond()
    {
        for (int i = 0; i < SecondWheels.Length; i++)
        {
            FirstWheels[i].SetActive(false);
            SecondWheels[i].SetActive(true);
            ThirdWheels[i].SetActive(false);
        }
        wheelsStr += " 002";
        Debug.Log(" ChangeSecond()");
    }
    public void ChangeThird()
    {
        for (int i = 0; i < FirstWheels.Length; i++)
        {
            FirstWheels[i].SetActive(false);
            SecondWheels[i].SetActive(false);
            ThirdWheels[i].SetActive(true);
        }
        wheelsStr += " 003";
        Debug.Log(" ChangeThird()");
    }
    public void GetBack()
    {
        this.gameObject.SetActive(false);
    }
}
