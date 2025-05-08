// 新建脚本 CharacterLoader.cs
using UnityEngine;

public class CharacterLoader : MonoBehaviour
{
    public GameObject characterPrefab;

    void Start()
    {
        // 动态加载预制体
        Instantiate(characterPrefab,
            Vector3.zero,
            Quaternion.identity);
    }
}