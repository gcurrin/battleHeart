using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class unitController : MonoBehaviour
{
    NavMeshAgent navi;
    public Transform target;
    Transform selectedQuad;
    // Start is called before the first frame update
    void Start()
    {
        navi = GetComponent<NavMeshAgent>();
        selectedQuad = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveTo(Vector3 pos)
    {
        navi.SetDestination(pos);
    }

    public void setTarget(Transform newTarget)
    {
        target = newTarget;
    }

    public void deSelect()
    {
        selectedQuad.gameObject.SetActive(false);
    }

    public void onSelect()
    {
        selectedQuad.gameObject.SetActive(true);
    }
    
}
