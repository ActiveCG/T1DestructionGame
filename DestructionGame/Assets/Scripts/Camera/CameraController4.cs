using UnityEngine;
using System.Collections;

public class CameraController4 : MonoBehaviour
{

    [Tooltip("The smoothness of the camera movement")]
    [SerializeField]
    private int smoothness = 3;
    [Tooltip("Offset in the Y")]
    [SerializeField]
    private float cameraHeight = 5;
    [Tooltip("Offset in the Z")]
    [SerializeField]
    private float cameraLength = 8;

    private float offsetZ;
    private float offsetY;

    private GameObject player;

    private RaycastHit hit;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void LateUpdate()
    {
        Vector3 targetCamPos = player.transform.position + new Vector3(0, cameraHeight, -cameraLength);
        transform.position = Vector3.Lerp(transform.position, targetCamPos, Time.deltaTime * smoothness);
    }
    void FixedUpdate()
    {
        if (Physics.Linecast(player.transform.position, transform.position, out hit))
        {
            offsetZ = hit.distance;
            offsetY = player.transform.position.y;
        }
    }
}