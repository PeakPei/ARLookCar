using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetManager : MonoBehaviour {
    
    
    //音效
    public AudioClip openDoorVoice;
    public AudioClip EngineVoice;
    public AudioClip closeDoorVoice;
    private AudioSource audioSource;

    private int count=0;
    public float angle = 0;
    private bool IsOpen=false;
    private bool IsClose=false;
   //UI面板
    public GameObject colorPanel;
    public GameObject partPanel;
    //车门，及旋转中心
    public Transform[] Doors;
    public Transform[] rotateMent;
    //引擎盖，以及旋转中心
    public Transform Engine;
    public Transform EngineRotate;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        
        if (IsOpen) {
            audioSource.clip = openDoorVoice;
            audioSource.Play();
            for (int i = 0; i < Doors.Length; i++)
            {
              
                if(i%2==1)
                Doors[i].RotateAround(rotateMent[i].transform.position, Vector3.up, 20 * Time.deltaTime);
                if (i % 2 == 0)
                    Doors[i].RotateAround(rotateMent[i].transform.position, Vector3.up, -20 * Time.deltaTime);
                if(angle<=60)
                    Engine.RotateAround(EngineRotate.position, Vector3.forward, 20 * Time.deltaTime);
                angle += 20 * Time.deltaTime;
              
                //Debug.Log(angle);
            }
            if (angle >= 90)
                IsOpen = false;
    
        }
        if (IsClose) {
            audioSource.clip = closeDoorVoice;
            audioSource.Play();
            for (int i = 0; i < Doors.Length; i++)
            {
                if (i % 2 == 1)
                    Doors[i].RotateAround(rotateMent[i].transform.position, Vector3.up, -15 * Time.deltaTime);
                if (i % 2 == 0)
                    Doors[i].RotateAround(rotateMent[i].transform.position, Vector3.up, 15 * Time.deltaTime);
                if(angle<=60)
                    Engine.RotateAround(EngineRotate.position, Vector3.forward, -15*Time.deltaTime);
                angle -= 15 * Time.deltaTime;
                //Debug.Log(angle);
            }
            if (angle <= 0)
                IsClose = false;
        }
    }
    //打开车门
    public void OpenDoors() {
        count++;
        if (count % 2 == 1)
        {
            IsOpen = true;
            IsClose = false;
        }
        else {
            IsOpen = false;
            IsClose = true;
        }
      
    }
    /// <summary>
    ///打开颜色面板 
    /// </summary>
    public void ChangeColorPanel() {
        colorPanel.SetActive(true);
        partPanel.SetActive(false);
    }
    public void OpenEngine() {

        audioSource.clip = EngineVoice;
        audioSource.Play();
    }
    /// <summary>
    /// 打开部件面板
    /// </summary>
    public void ChangePartsPanel() {
        partPanel.SetActive(true);
        colorPanel.SetActive(false);
    }
}
