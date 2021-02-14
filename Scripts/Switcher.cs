using UnityEngine;

public class Switcher : MonoBehaviour
{
    Pursuer myPursuer;
    PathFollower myFollowPath;
    GameObject player;

    public GameObject[] path;

    public float targetRadius;

    // Start is called before the first frame update
    void Start()
    {
        myPursuer = this.GetComponent<Pursuer>();
        myFollowPath = this.GetComponent<PathFollower>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject target = myFollowPath.myTarget;
        GameObject character = gameObject;
        float targetDistance = (target.transform.position - character.transform.position).magnitude;

        if (targetDistance < targetRadius)
        {
            myPursuer.enabled = true;
            myFollowPath.enabled = false;
            myPursuer.myTarget = player;
        }
        if (targetDistance > targetRadius)
        {
            myPursuer.enabled = false;
            myFollowPath.enabled = true;
            myFollowPath.myTarget = player;
            myFollowPath.path = path;
        }
    }
}
