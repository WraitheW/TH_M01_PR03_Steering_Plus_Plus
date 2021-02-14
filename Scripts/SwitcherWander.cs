using UnityEngine;

public class SwitcherWander : MonoBehaviour
{
    Pursuer myPursuer;
    Wanderer myWander;
    GameObject player;

    public float targetRadius;

    // Start is called before the first frame update
    void Start()
    {
        myPursuer = this.GetComponent<Pursuer>();
        myWander = this.GetComponent<Wanderer>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject target = myWander.myTarget;
        GameObject character = gameObject;
        float targetDistance = (target.transform.position - character.transform.position).magnitude;

        if (targetDistance < targetRadius)
        {
            myPursuer.enabled = true;
            myWander.enabled = false;
            myPursuer.myTarget = player;
        }
        if (targetDistance > targetRadius)
        {
            myPursuer.enabled = false;
            myWander.enabled = true;
            myWander.myTarget = player;
        }
    }
}
