using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    /* Each boolean value represents whether the button is pressed or not. **/
    public bool b0dwn, b1dwn, b2dwn, b3dwn = false;

    /* Takes an index (button number) and switches the corresponding boolean 
    /* value to true. **/
    public void pressDownButton(int index) {
        if (index == 0) {
            b0dwn = true;
        }
        else if (index == 1) {
            b1dwn = true;
        }
        else if (index == 2) {
            b2dwn = true;
        }
        else if (index == 3) {
            b3dwn = true;
        }
    }
}
