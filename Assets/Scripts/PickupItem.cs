using UnityEngine;

/// <summary>
/// Template for a pickup item in our game
/// This is an example of how you can use scriptable objects
/// 
/// Author: Ben Hoffman
/// 6/27/2018
/// </summary>
[CreateAssetMenu(fileName = "Pickup Item", menuName = "Pickup")]
public class PickupItem : ScriptableObject
{
    /// <summary>
    /// The name of this pickup
    /// </summary>
    public string PickupName;

    /// <summary>
    /// Description of what this item does
    /// </summary>
    public string Description;

    /// <summary>
    /// Color of this pickup
    /// </summary>
    public Color PickupColor;

    /// <summary>
    /// How much does this item weigh?
    /// </summary>
    public int Weight;
    
}
