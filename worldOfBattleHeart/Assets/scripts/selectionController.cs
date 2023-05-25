using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectionController : MonoBehaviour
{
    public LayerMask clickable;
    public Transform currentUnit;
    unitController unitControl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Ray click = Camera.main.ScreenPointToRay(mousePos);
            if (Physics.Raycast(click, out RaycastHit hit, 100, clickable))
            {
                if (hit.transform.CompareTag("unit"))
                {
                    changeUnit(hit.transform);
                }
                
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Vector3 mousePos = Input.mousePosition;
            Ray click = Camera.main.ScreenPointToRay(mousePos);
            if (Physics.Raycast(click, out RaycastHit hit, 100, clickable) && currentUnit !=null)
            {
                if (hit.transform.CompareTag("ground"))
                {
                    unitControl.moveTo(hit.point);
                }
                if (hit.transform.CompareTag("enemy"))
                {
                    unitControl.setTarget(hit.transform);
                }

            }

        }
    }



    void changeUnit(Transform newUnit) {
        currentUnit = newUnit;
        if (unitControl != null)  unitControl.deSelect();
        unitControl = newUnit.GetComponent<unitController>();
        unitControl.onSelect();
    }
}
