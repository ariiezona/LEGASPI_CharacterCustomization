using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomizationUI : MonoBehaviour
{
    [SerializeField] private Button hairButton;
    [SerializeField] private Button headButton;
    [SerializeField] private Button shirtButton;
    [SerializeField] private Button pantsButton;
    [SerializeField] private Button shoesButton;
    [SerializeField] CharacterCustomization characterCustomization;

    private void Awake()
    {
        hairButton.onClick.AddListener(() =>
        {
            Debug.Log("Hair Changed");
            characterCustomization.ChangeBodyPart(CharacterCustomization.BodyPartType.Hair);
        });
        headButton.onClick.AddListener(() =>
        {
            Debug.Log("Head Changed");
            characterCustomization.ChangeBodyPart(CharacterCustomization.BodyPartType.Head);
        });
        shirtButton.onClick.AddListener(() =>
        {
            Debug.Log("Shirt Changed");
            characterCustomization.ChangeBodyPart(CharacterCustomization.BodyPartType.Shirt);
        });
        pantsButton.onClick.AddListener(() =>
        {
            Debug.Log("Pants Changed");
            characterCustomization.ChangeBodyPart(CharacterCustomization.BodyPartType.Pants);
        });
        shoesButton.onClick.AddListener(() =>
        {
            Debug.Log("Shoes Changed");
            characterCustomization.ChangeBodyPart(CharacterCustomization.BodyPartType.Shoes);
        });
    }
}
