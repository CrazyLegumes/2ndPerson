using UnityEngine;
using System.Collections;
using System;

public class Button : InteractableObject {

    InteractableObject button;
    Player activator;

    [SerializeField]
    bool isTimed;

    [SerializeField]
    float Timer;

    float currTime = 0.0f;

    [SerializeField]
    Animation press;


    public override void StartInteract(Player p)
    {
        if (button.isActive)
            return;

        button.isActive = true;
        Press();
    }

    public override void StopInteract()
    {

        if (!button.isActive)
            return;
        button.isActive = false;
        
    }

    void Press()
    {
        press.Play();
        button.StopInteract();
    }

    // Use this for initialization
    void Start () {
        button = GetComponent<Button>();
        button.isActive = false;
        button.type = Activate;
        
	
	}
	
	// Update is called once per frame
	void Update () {
	
        
	}
}
