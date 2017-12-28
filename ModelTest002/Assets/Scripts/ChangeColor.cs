using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeColor : MonoBehaviour {
    public Material Wheel;
    public Material body;
    public Color red;
    public Color green;
    public Color bule;
    public Color purple;
    public Color golden;
    public Color sliver;
    public Color black;
    public Color orange;
    public string colorStr= "Color: ";
    /// <summary>
    /// 红色
    /// </summary>
    public void ChangeRed() {
        body.color = red;
        Wheel.color = red;
        colorStr += "Red";
    }
    /// <summary>
    /// 绿色
    /// </summary>
    public void ChangeGreen() {
        body.color = green;
        Wheel.color = green;
        colorStr += "Green";
    }
    /// <summary>
    /// 蓝色
    /// </summary>
    public void ChangeBule() {
        body.color = bule;
        Wheel.color = bule;
        colorStr += "Blue";
    }
    /// <summary>
    /// 紫色
    /// </summary>
    public void ChangePurple() {
        body.color = purple;
        Wheel.color = purple;
        colorStr += "Purple";
    }
    /// <summary>
    /// 金色
    /// </summary>
    public void ChangeGolden() {
        body.color = golden;
        Wheel.color = golden;
        colorStr += "Golden";
    }
    /// <summary>
    /// 黑色
    /// </summary>
    public void ChangeBlack() {
        body.color = black;
        Wheel.color = black;
        colorStr += "Black";
    }
    /// <summary>
    /// 银色
    /// </summary>
    public void ChangeSliver() {
        body.color = sliver;
        Wheel.color = sliver;
        colorStr += "Sliver";
    }
    /// <summary>
    /// 橘黄色
    /// </summary>
    public void ChangeOrange() {
        body.color = orange;
        Wheel.color = orange;
        colorStr += "Orange";
    }
    public void GetBack() {
        transform.gameObject.SetActive(false);
    }
}
