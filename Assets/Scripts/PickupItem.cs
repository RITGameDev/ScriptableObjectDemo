using UnityEngine;

/// <summary>
/// Template for a pickup item in our game
/// This is an example of how you can use scriptable objects
/// 
/// Author: Ben Hoffman
/// 6/27/2018
/// </summary>
namespace CompleteDemo
{
    [CreateAssetMenu(fileName = "Pickup Item", menuName = "Pickup")]
    public class PickupItem : ScriptableObject
    {
        /// <summary>
        /// The name of this pickup
        /// </summary>
        public string Name;

        /// <summary>
        /// Description of what this item does
        /// </summary>
        public string Description;

        /// <summary>
        /// The icon of this pickup to be used in UI
        /// </summary>
        public Sprite PickupIcon;

        /// <summary>
        /// How much does this item weigh?
        /// </summary>
        public int Weight;

    }
}   // namespace CompleteDemo