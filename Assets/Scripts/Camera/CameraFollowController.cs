using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private Vector3 newPosition;
    private Vector3 offset;

    [SerializeField] private float lerpValue;



    void Start()
    {
        SetOffsetValue();
    }


    void LateUpdate()
    {
        SetCameraSmoothFollow();
    }



    private void SetOffsetValue()
    {
        offset = transform.position - playerTransform.position;

    }



    private void SetCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, playerTransform.position.y, playerTransform.position.z) + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
