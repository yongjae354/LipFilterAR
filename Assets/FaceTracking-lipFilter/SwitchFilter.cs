using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchFilter : MonoBehaviour
{
    private int i;
    public Material[] filterMaterials;
    public int numMaterials;
    public GameObject ButtonManager;
    private bool buttonPressed = false;
    private int buttonNum;

    // Start is called before the first frame update
    void Start()
    {
        i = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // if (buttonPressed) {
        //     ChangeFilterToSpecific(buttonNum);
        //     buttonPressed = false;
        // } 
        if (ButtonManager.GetComponent<ButtonBehavior>().b0dwn) {
            ChangeFilterToSpecific(0);
            ButtonManager.GetComponent<ButtonBehavior>().b0dwn = false;
        }
        if (ButtonManager.GetComponent<ButtonBehavior>().b1dwn) {
            ChangeFilterToSpecific(1);
            ButtonManager.GetComponent<ButtonBehavior>().b1dwn = false;
        }
        if (ButtonManager.GetComponent<ButtonBehavior>().b2dwn) {
            ChangeFilterToSpecific(2);
            ButtonManager.GetComponent<ButtonBehavior>().b2dwn = false;
        }
        if (ButtonManager.GetComponent<ButtonBehavior>().b3dwn) {
            ChangeFilterToSpecific(3);
            ButtonManager.GetComponent<ButtonBehavior>().b3dwn = false;
        }
    }

    
    
    // public void pressButton(int n) {
    //     buttonPressed = true;
    //     buttonNum = n;
    // }


    void ChangeFilterToSpecific(int index) {
        GetComponent<MeshRenderer>().material = filterMaterials[index];
    }

    // void ChangeFilter()
    // {
    //     GetComponent<MeshRenderer>().material = filterMaterials[i];
    //     i++;
    //     if (i == numMaterials)
    //     {
    //         i = 0;
    //     }
    // }

    // void SwitchFilterOnTouch() {
    //     if (Input.touchCount > 0)
    //     {
    //         Touch touch = Input.GetTouch(0);
    //         if (touch.phase == TouchPhase.Began)
    //         {
    //             ChangeFilter();
    //         }
    //     }
    // }
    
}
