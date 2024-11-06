using UnityEngine;

/// <summary>
/// This follow player class will update the camera position to follow the player.
/// Standard coding documentation can be found in 
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments
/// </summary>
public class FollowPlayer : MonoBehaviour
{
    // Player object
    public GameObject player;

    // Camera offset according to the player
    private Vector3 offset = new Vector3(0,6,-7);

    /// <summary>
    /// This method is called before the first frame update
    /// </summary>
    void Start()
    {
        
    }

    /// <summary>
    /// This method is called once per frame
    /// </summary>
    void Update()
    {
        // Move the camera following the player
        // transform.position = player.transform.position + offset;
        
    }

    /// <summary>
    /// This method is called once per frame, after all Update functions have been called
    /// </summary>
    void LateUpdate()
    {
        // Update the camera position after the player has been updated
        transform.position = player.transform.position + offset;
    }
}


