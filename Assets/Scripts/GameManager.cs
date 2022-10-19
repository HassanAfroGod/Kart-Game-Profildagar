using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    ArcadeKart playerKart;

    [SerializeField]
    List<Transform> levelCheckpoints;

    void Start()
    {
        if(!playerKart)
        {
            playerKart = FindObjectOfType<ArcadeKart>();
        }
    }

    void Update()
    {
        Vector3 playerposition = playerKart.transform.position;
        Vector3 checkpointPosition = levelCheckpoints[0].position;


        Vector3 diff = new Vector3(playerposition.x - checkpointPosition.x + playerposition.y - checkpointPosition.y, checkpointPosition.z - checkpointPosition.z);



        float distanceBetween2Objects = Mathf.Sqrt(Mathf.Pow(diff.x, 2) + Mathf.Pow(diff.y, 2)) + Mathf.Pow(diff.z, 2);

        Debug.Log(distanceBetween2Objects);

        

    }
}
