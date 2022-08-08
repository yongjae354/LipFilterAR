using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchFilter : MonoBehaviour
{
    private int i;
    public Material[] filterMaterials;
    public int numMaterials;
    public GameObject ButtonManager;

    // Start is called before the first frame update
    void Start()
    {
        i = 1;
    }

    // Update is called once per frame
    void Update()
    {
        SwitchFilterOnButtonAction();
    }

    /* Checks if a button is pressed down, and changes the filter to
    /* the filter mapped by the button **/
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

    void ChangeFilterToSpecific(int index) {
        GetComponent<MeshRenderer>().material = filterMaterials[index];
    }


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
        void ChangeFilter()
    {
        GetComponent<MeshRenderer>().material = filterMaterials[i];
        i++;
        if (i == numMaterials)
        {
            i = 0;
        }
    }
    
}
