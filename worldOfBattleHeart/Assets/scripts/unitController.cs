using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class unitController : MonoBehaviour
{
    NavMeshAgent navi;
    public Transform target;
    Transform selectedQuad;

    //attack stuff
    public float attackRange = 2;
    public int damage;
    public float attackTime =1;
    float timeSinceLastAttack;

    //movementStuff
    bool moveCommand;

    // Start is called before the first frame update
    void Start()
    {
        navi = GetComponent<NavMeshAgent>();
        selectedQuad = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (navi.remainingDistance < 1) moveCommand = false;
        timeSinceLastAttack += Time.deltaTime;
        if(target != null && !moveCommand)
        {
            
            if (Vector3.Distance(transform.position, target.position) < attackRange)
            {
                navi.Stop();
                if (timeSinceLastAttack > attackTime)
                {
                    timeSinceLastAttack = 0;
                    target.GetComponent<Health>().takeDamage(damage, Health.DamageType.physical);
                }

            } else {
                navi.SetDestination(target.position);
            }
        }
        

    }

    public void moveTo(Vector3 pos)
    {
        moveCommand = true;
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
