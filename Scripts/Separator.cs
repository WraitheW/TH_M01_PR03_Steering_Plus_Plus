using UnityEngine;

public class Separator : Kinematic
{
    Separate myMoveType;
    LookWhereGoing myRotateType;

    public Kinematic[] targets;

    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new Separate();
        myMoveType.character = this;
        myMoveType.targets = targets;

        myRotateType = new LookWhereGoing();
        myRotateType.character = this;
        myRotateType.target = myTarget;
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = myRotateType.getSteering().angular;
        base.Update();
    }
}
