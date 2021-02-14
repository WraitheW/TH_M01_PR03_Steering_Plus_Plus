using UnityEngine;

public class EvasionSwitcher : MonoBehaviour
{
    Pursuer myPursuer;
    PathFollower myFollowPath;
    Switcher mySwitcher;
    Evader myEvader;
    EvasionSwitcher myEvasionSwitcher;
    GameObject player;

    public GameObject[] path;

    public GameManagerScript gm;
    bool isEvading;

    // Start is called before the first frame update
    void Start()
    {
        myPursuer = this.GetComponent<Pursuer>();
        myFollowPath = this.GetComponent<PathFollower>();
        mySwitcher = this.GetComponent<Switcher>();
        myEvader = this.GetComponent<Evader>();
        myEvasionSwitcher = this.GetComponent<EvasionSwitcher>();
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        isEvading = gm.isEvading;

        GameObject target = myFollowPath.myTarget;
        GameObject character = gameObject;

        if (isEvading)
        {
            myPursuer.enabled = false;
            myFollowPath.enabled = false;
            mySwitcher.enabled = false;
            myEvader.enabled = true;
            myEvader.myTarget = player;
        }
        if (!isEvading && gm.buttonEvadePressed == true)
        {
            myPursuer.enabled = false;
            myFollowPath.enabled = true;
            mySwitcher.enabled = true;
            myEvader.enabled = false;
            myFollowPath.myTarget = player;
            myFollowPath.path = path;
            myEvasionSwitcher.enabled = false;
        }
    }
}
