using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDoors : MonoBehaviour {
    //车门渲染器
    public MeshFilter [] DoorsRender;
    //车门渲染类型frist second third
    public Mesh[] FirstDoorsMesh;
    public Mesh[] SecondDoorsMesh;
    public Mesh[] ThirdDoorsMesh;
    public string doorStr = "Doors: ";
    /// <summary>
    /// 更换车门
    /// </summary>
    public void ChangeFirst() {
        for (int i = 0; i < DoorsRender.Length; i++) {
            DoorsRender[i].mesh = FirstDoorsMesh[i];
        
        }
        doorStr += "001";
    }
    public void ChangeSecond() {
        for (int i = 0; i < DoorsRender.Length; i++)
        {
            DoorsRender[i].mesh = SecondDoorsMesh[i];
           
        }
        doorStr += "002";
    }
    public void ChangeThird() {
        for (int i = 0; i < DoorsRender.Length; i++)
        {
            DoorsRender[i].mesh = ThirdDoorsMesh[i];
        }
        doorStr += "003";
    }
    public void GetBack() {
        this.gameObject.SetActive(false);
    }
}
