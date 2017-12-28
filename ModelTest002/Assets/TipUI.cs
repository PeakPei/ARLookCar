using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TipUI : MonoBehaviour {
    public ChangeColor color;
    public ChangeDoors doors;
    public ChangeEngine engine;
    public ChangeHood hood;
    public ChangeWheels wheels;
    public Text outLineText;
    public Text contentText;
    public string content;

    public void ShowTip() {
        content = color.colorStr + "\n" + doors.doorStr + "\n" + hood.hoodStr + "\n" + wheels.wheelsStr;
        outLineText.text = content.ToString();
        contentText.text = content.ToString();
    }
}
