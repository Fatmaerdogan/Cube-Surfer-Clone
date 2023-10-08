using UnityEngine;

public class PlayerDataTransmitter : MonoBehaviour
{
    private PlayerInputController playerInputController;

    private void Start()
    {
        playerInputController=GetComponent<PlayerInputController>();
    }
    public float GetPlayerHorizontalValue=> playerInputController.HorizontalValue;
    
}
