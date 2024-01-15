using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class CharacterCustomization : MonoBehaviour
{
    [SerializeField] private BodyPartData[] bodyPartDataArray;

    public enum BodyPartType
    {
        Hair,
        Head,
        Shirt,
        Pants,
        Shoes
    }


    [System.Serializable]
    public class BodyPartData
    {
        public BodyPartType bodyPartType;
        public Mesh[] meshArray;
        public SkinnedMeshRenderer skinnedMeshRenderer;
    }

    public void ChangeBodyPart(BodyPartType bodyPartType)
    {
        BodyPartData bodypartData = GetBodyPartData(bodyPartType);
        int meshIndex = System.Array.IndexOf(bodypartData.meshArray, bodypartData.skinnedMeshRenderer.sharedMesh);
        bodypartData.skinnedMeshRenderer.sharedMesh = bodypartData.meshArray[(meshIndex + 1) % bodypartData.meshArray.Length];
    }

    private BodyPartData GetBodyPartData(BodyPartType bodyPartType)
    {
        foreach (BodyPartData bodyPartData in bodyPartDataArray)
        {
            if (bodyPartData.bodyPartType == bodyPartType)
            {
                return bodyPartData;
            }
        }
        return null;
    }
}
