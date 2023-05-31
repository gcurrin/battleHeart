using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectionController : MonoBehaviour
{
    public LayerMask clickable;
    public Transform currentUnit;
    unitController unitControl;

    public Transform[] units;
    public Transform partyPanel;
    public List<Transform> party;
    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i < units.Length; i++) {
            Vector3 spot = new Vector3(i * 4 -6, 0, 0);
            Transform newUnit = Instantiate(units[i], spot, Quaternion.identity, transform);
            partyPanel.GetChild(i).GetComponent<unitFrame>().setUp(newUnit, this);
            partyPanel.GetChild(i).gameObject.SetActive(true);
            
            party.Add(newUnit);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)) leftClick();


        if (Input.GetMouseButtonDown(1)) rightClick();

        checkKeys();

        
    }



    public void changeUnit(Transform newUnit) {
        currentUnit = newUnit;
        if (unitControl != null)  unitControl.deSelect();
        unitControl = newUnit.GetComponent<unitController>();
        unitControl.onSelect();
    }

    void leftClick() {
        Vector3 mousePos = Input.mousePosition;
        Ray click = Camera.main.ScreenPointToRay(mousePos);
        if (Physics.Raycast(click, out RaycastHit hit, 100, clickable)) {
            if (hit.transform.CompareTag("unit")) {
                changeUnit(hit.transform);
            }

            

        }
    }
    void rightClick() {
        Vector3 mousePos = Input.mousePosition;
        Ray click = Camera.main.ScreenPointToRay(mousePos);
        if (Physics.Raycast(click, out RaycastHit hit, 100, clickable) && currentUnit != null) {
            if (hit.transform.CompareTag("ground")) {
                unitControl.moveTo(hit.point);
            }
            if (hit.transform.CompareTag("enemy")) {
                unitControl.setTarget(hit.transform);
            }

        }
    }


    void checkKeys() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            changeUnit(party[0]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            changeUnit(party[1]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            changeUnit(party[2]);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4)) {
            changeUnit(party[3]);
        }
    }
}
