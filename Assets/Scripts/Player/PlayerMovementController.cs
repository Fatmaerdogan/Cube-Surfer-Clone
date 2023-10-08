using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private float forwardMovementSpeed;
    [SerializeField] private float horizontalMovementSpeed;
    [SerializeField] private float horizontalLimitValue;

    private PlayerDataTransmitter playerDataTransmitter;
    private float newPositionX;

    private void Start()
    {
        playerDataTransmitter=GetComponent<PlayerDataTransmitter>();
        Events.GameFinish += GameFinish;
    }
    private void OnDestroy()
    {
        Events.GameFinish -= GameFinish;
    }
    void FixedUpdate()
    {
        SetPlayerForwardMovement();
        SetPlayerHorizontalMovement();
    }


    private void SetPlayerForwardMovement()
    {
        transform.Translate(Vector3.forward * forwardMovementSpeed * Time.fixedDeltaTime);
    }


    private void SetPlayerHorizontalMovement()
    {
        newPositionX = transform.position.x + playerDataTransmitter.GetPlayerHorizontalValue * horizontalMovementSpeed * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -horizontalLimitValue, horizontalLimitValue);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
    public void GameFinish()
    {
        forwardMovementSpeed = 0;
        SceneManager.LoadScene(0);
    }
}
