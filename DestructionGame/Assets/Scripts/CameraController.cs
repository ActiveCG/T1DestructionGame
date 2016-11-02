using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    [SerializeField]
    private int rotationSpeed = 3;
    [Tooltip("Offset in the Y")]
    [SerializeField]
    private int cameraHeight = 5;
    [Tooltip("Offset in the Z")]
    [SerializeField]
    private int cameraLength = 8;

    private GameObject player;

    private Quaternion currentRotation;

    private float rotationAngle;
    private float currentRotationAngle;

    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	void LateUpdate ()
    {
        rotationAngle = player.transform.eulerAngles.y;

        currentRotationAngle = transform.eulerAngles.y;

        currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, rotationAngle, Time.deltaTime * rotationSpeed);

        currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

        transform.position = player.transform.position;
        transform.position -= currentRotation * Vector3.forward * cameraLength;
        transform.position = new Vector3(transform.position.x, player.transform.position.y + cameraHeight, transform.position.z);
        transform.LookAt(player.transform.position + new Vector3(0, 3, 0));
        if (Physics.Raycast(transform.position, transform.forward, cameraLength))
        {

        }
    }
}