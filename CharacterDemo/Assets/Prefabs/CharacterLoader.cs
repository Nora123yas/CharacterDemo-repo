// �½��ű� CharacterLoader.cs
using UnityEngine;

public class CharacterLoader : MonoBehaviour
{
    public GameObject characterPrefab;

    void Start()
    {
        // ��̬����Ԥ����
        Instantiate(characterPrefab,
            Vector3.zero,
            Quaternion.identity);
    }
}