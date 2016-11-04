using UnityEngine;
using System.Collections;

// How to put the destruction in focus.
// Which movement is the least intrusive.

public class CameraController5 : MonoBehaviour {

    //Camera Shake

    [Tooltip("The rotation speed of the camera")]
    [SerializeField]
    private float smooth = 3f;
    [Tooltip("Offset in the Y")]
    [SerializeField]
    private int cameraHeight = 5;
    [Tooltip("Offset in the Z")]
    [SerializeField]
    private int cameraLength = 8;

    private bool move;

    private GameObject player;
    private GameObject tempTrans;

    private RaycastHit hit;

    private float offsetZ;

    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void LateUpdate()
    {
        offsetZ = cameraLength;
        Vector3 targetCamPos = player.transform.position + new Vector3(0, cameraHeight, -offsetZ);
        transform.position = Vector3.Lerp(transform.position, targetCamPos, Time.deltaTime * smooth);
        Debug.Log(offsetZ);
    }
    void FixedUpdate()
    {
        if (Physics.Linecast(player.transform.position, transform.position, out hit))
        {
            offsetZ = 0;
        }
    }
}