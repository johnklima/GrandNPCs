using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using static DragonCouncilAbsoluteMatrix;

public class NPCController : MonoBehaviour
{

    NavMeshAgent agent;
    DragonCouncilAbsoluteMatrix dialogueMatrix;
    AnimParamDriver animDriver;

    public Transform PersonOfIntent;   //navmesh and/or dialogue target
    private Transform previousPerson = null;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogueMatrix = GetComponentInParent<DragonCouncilAbsoluteMatrix>();
        agent = GetComponent<NavMeshAgent>();
        animDriver = GetComponent<AnimParamDriver>();

        Transform characters = transform.parent;

        int count = characters.childCount;

        // a wee trick to not pick me as a target, for testing
        PersonOfIntent = transform;
        while (PersonOfIntent == transform)
        {
            int c = Random.Range(0, count);
            PersonOfIntent = characters.GetChild(c);
        }

        previousPerson = PersonOfIntent;
    }
    // Update is called once per frame
    void Update()
    {
        if (previousPerson != PersonOfIntent)
        {
            //if(Vector3.Distance(PersonOfIntent.position,transform.position) > 2.0f)
            {
                agent.SetDestination(PersonOfIntent.position);
                animDriver.Walk();
                agent.isStopped = false;
                StartCoroutine(MoveNPC());
            }
            previousPerson = PersonOfIntent;
        }
        
    }

    void SaySomething()
    {
        string myname = transform.name;
        string theirname = PersonOfIntent.name;

        var dialogue =
            dialogueMatrix.Matrix[myname][theirname];
        
               
        //pick a random
        int say = Random.Range(0, 3);
        string toSay = "nothing" ;

        if (say == 0)
            toSay = dialogue.forceful;
        if (say == 1)
            toSay = dialogue.wise;
        if (say == 2)
            toSay = dialogue.sarcastic; ;

        Debug.Log(myname + " says to " + theirname + ": " + toSay );

        animDriver.Talk(say);
    }
    IEnumerator MoveNPC ()
    {
        while(agent.remainingDistance > 2)
        {
            agent.SetDestination(PersonOfIntent.position);   //moving target
            yield return null;
        }
        SaySomething();
        agent.isStopped = true;

        yield return null;
    }
}
