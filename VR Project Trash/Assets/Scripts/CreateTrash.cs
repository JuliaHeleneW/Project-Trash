using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CreateTrash : MonoBehaviour
{
    //Code for making a list of trash and
    //instantiating random objects from it
    //was taken from User glasstongue on the Unity
    //Forums: "Adding prefabs to a list or an array from a folder and instantiating them."


    //define a list
    public static List<GameObject> myListObjects = new List<GameObject>();

    public Transform dumper;
    public float cooldown;
    private float cooldownRef;
    public Transform endpoint;
    public NavMeshAgent navAgent;

    // Start is called before the first frame update
    void Start()
    {
        //Make a list using all Game objects in the "Trash Objects" folder
        Object[] subListObjects = Resources.LoadAll("Trash Objects", typeof(GameObject));  
        
        foreach (GameObject subListObject in subListObjects)
        {
            GameObject lo = (GameObject)subListObject;

            myListObjects.Add(lo);
        }
        cooldownRef = cooldown;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > cooldownRef)
        {
            //Debug.Log("Spawning...");
            SpawnRandomObject();

            /*
            cooldownRef = Time.time + cooldown;
            Instantiate(instantTrash, dumper);
            instantTrash.GetComponent<TrashAI>().SetEndpoint(endpoint);
            instantTrash.GetComponent<TrashAI>().SetNavAgent(navAgent);*/
        }
    }

    void SpawnRandomObject()
    {
        //spawns item in array position between 0 and 100
        int whichItem = Random.Range(0, myListObjects.Count);

        GameObject trash = Instantiate(myListObjects[whichItem]) as GameObject;
        cooldownRef = Time.time + cooldown;

        trash.transform.position = dumper.position;
        //trash.transform.localPosition.y = 1.400002f;

        //foreach(Transform child in trash.transform)
        //{
        //if (child.GetComponent<TrashAI>() != null)
        //{
        trash.GetComponent<TrashAI>().SetEndpoint(endpoint);
                //trash.GetComponent<TrashAI>().SetNavAgent(navAgent);
            //}
        //}
    }
}
