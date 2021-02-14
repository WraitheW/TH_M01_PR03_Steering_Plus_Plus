using UnityEngine;

public class WanderSwitcher : MonoBehaviour
{
    Pursuer myPursuer;
    Wanderer myWander;
    SwitcherWander mySwitcher;
    Evader myEvader;
    WanderSwitcher myWanderSwitcher;
    GameObject player;

    public GameManagerScript gm;
    bool isEvading;

    // Start is called before the first frame update
    void Start()
    {
        myPursuer = this.GetComponent<Pursuer>();
        myWander = this.GetComponent<Wanderer>();
        mySwitcher = this.GetComponent<SwitcherWander>();
        myEvader = this.GetComponent<Evader>();
        myWanderSwitcher = this.GetComponent<WanderSwitcher>();
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        isEvading = gm.isEvading;

        GameObject target = myWander.myTarget;
        GameObject character = gameObject;

        if (isEvading)
        {
            myPursuer.enabled = false;
            myWander.enabled = false;
            mySwitcher.enabled = false;
            myEvader.enabled = true;
            myEvader.myTarget = player;
        }
        if (!isEvading && gm.buttonEvadePressed == true)
        {
            myPursuer.enabled = false;
            myWander.enabled = true;
            mySwitcher.enabled = true;
            myEvader.enabled = false;
            myWander.myTarget = player;
            myWanderSwitcher.enabled = false;
        }
    }
}
