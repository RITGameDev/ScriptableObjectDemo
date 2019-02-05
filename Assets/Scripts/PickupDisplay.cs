using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Example of how you could use a scriptable object from 
/// Inside a MonoBehavior
/// 
/// Author: Ben Hoffman 
/// 6/27/2018
/// </summary>
namespace CompleteDemo
{
    public class PickupDisplay : MonoBehaviour
    {
        /// <summary>
        /// The PickupItem scriptable object data to use on this display
        /// </summary>
        [Tooltip("The PickupItem scriptable object data to use on this display")]
        public PickupItem Pickup;

        [Space(10)] // 10 pixels of spacing that will make the component 
                    // more readable in the editor

        [Header("UI Objects")]

        [Tooltip("The name of this pickup item, filled out by the ScriptableObject")]
        public Text ItemName_Text;

        [Tooltip("Description of this item, filled out by ScriptableObject")]
        public Text ItemDesc_Text;

        [Tooltip("Icon of this item, filled out by ScriptableObject")]
        public Image Item_Icon_Image;

        [Tooltip("Weight of this item, filled out by ScriptableObject")]
        public Slider Item_Weight;


        void Start()
        {
            InitializeDisplay();
        }

        /// <summary>
        /// Set up the UI values on this pickup display
        /// based on the given scriptable object
        /// </summary>
        private void InitializeDisplay()
        {
            // Ensure that all the given public properties are not null
            // Debug asserts will be removed in release mode
            Debug.Assert(Pickup != null, "PickUp display is missing a Pickup reference!");
            Debug.Assert(ItemName_Text != null, "ItemName_Text is null!");
            Debug.Assert(ItemDesc_Text != null, "ItemDesc_Text is null!");
            Debug.Assert(Item_Icon_Image != null, "Item_Icon_Image is null!");
            Debug.Assert(Item_Weight != null, "Item_Weight is null!");

            // Set the values of the UI based on the scriptable Object
            ItemName_Text.text = Pickup.Name;
            ItemDesc_Text.text = Pickup.Description;
            Item_Icon_Image.sprite = Pickup.PickupIcon;
            Item_Weight.value = Pickup.Weight;

            // Pros:
            // - Its dynamic and reusable code! 
            // - Very easy for designers/artists
            // Cons:
            // - Small runtime cost when used            
        }

    }
}   // namespace CompleteDemo