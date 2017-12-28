using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {
    public GameObject Car;
    private AudioSource audioSource;
	// Use this for initialization
	void Start () {
        audioSource = Car.GetComponent<AudioSource>();
	}

    public void OpenMusic() {

        audioSource.Play();
    }
    public void ExitGame() {
        Application.Quit();
    }
}
