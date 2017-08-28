using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using VRStandardAssets.Utils;

[RequireComponent(typeof(VRInteractiveItem))]
public class VRItemEventHandler : MonoBehaviour {

    private VRInteractiveItem item;
    public UnityEvent GazeEnterEvent;
    public UnityEvent GazeExitEvent;

	// Use this for initialization
	void Start () {
        item = GetComponent<VRInteractiveItem> ();
        item.OnOver += OnGazeEnter;
        item.OnOut += OnGazeExit;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGazeEnter() {
        GazeEnterEvent.Invoke ();
    }

    void OnGazeExit() {
        GazeExitEvent.Invoke ();
    }
}
