using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    [SerializeField] GameObject _effectPrefab;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        Instantiate(_effectPrefab, transform.position, transform.rotation);
    }
}
