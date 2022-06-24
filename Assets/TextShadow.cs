using TMPro;
using UnityEngine;

public class TextShadow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private TextMeshProUGUI _parent;

    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        _parent = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
    }

    public void Update()
    {
        _text.text = _parent.text;
    }
}
