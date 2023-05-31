using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class unitFrame : MonoBehaviour
{
    public Transform unit;
    public Image clickImage;
    selectionController sc;
   
    public void setUp(Transform assignedUnit, selectionController scPull) {
        unit = assignedUnit;
        sc = scPull;
    }

    private void OnEnable() {
        Debug.Log("enabled");
        clickImage = transform.GetChild(0).GetComponent<Image>();
        clickImage.sprite = unit.GetComponent<unitStats>().getClassImage();
    }

    public void click() {
        sc.changeUnit(unit);    }
}
