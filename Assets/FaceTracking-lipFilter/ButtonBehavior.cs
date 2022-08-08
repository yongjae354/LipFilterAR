using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    public bool b0dwn, b1dwn, b2dwn, b3dwn = false;

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
