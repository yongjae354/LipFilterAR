using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchFilter : MonoBehaviour
{
    private int i = 1;
    public Material[] filterMaterials;
    public GameObject ButtonManager;

    // Update is called once per frame
    void Update()
    {
        SwitchFilterOnButtonAction();
    }

    /* Checks if a button is pressed down, and changes the filter to
    /* the filter mapped by the button. **/
    void SwitchFilterOnButtonAction() {
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

    /* Takes an index and switches the displaying material to a material in 
    /* filterMaterials[]. **/
    void ChangeFilterToSpecific(int index) {
        GetComponent<MeshRenderer>().material = filterMaterials[index];
    }

    /* Switches the filter when screen is touched. **/
    void SwitchFilterOnTouch() {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                ChangeFilter();
            }
        }
    }

    /* Changes the displaying filter to the next filter in filterMaterials[]. **/
    void ChangeFilter() {
        GetComponent<MeshRenderer>().material = filterMaterials[i];
        i++;
        if (i >= filterMaterials.Length)
        {
            i = 0;
        }
        
    }
    
}
