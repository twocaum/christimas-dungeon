using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleCount : MonoBehaviour
{
    UnityEngine.UI.Text text;
    int count;

    void Awake()
    {
        text = GetComponent<UnityEngine.UI.Text>();
    }

    void Start() => UpdateCount();

    void OnEnable() => Collectible.OnCollected += OnCollectibleCollected;
    void OnDisable() => Collectible.OnCollected -= OnCollectibleCollected;

    void OnCollectibleCollected()
    {
        count++;
        UpdateCount();
    }

    // Update is called once per frame
    void UpdateCount()
    {
        text.text = $"{count} / {Collectible.total}";
    }
}
