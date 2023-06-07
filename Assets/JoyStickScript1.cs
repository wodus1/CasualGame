using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStickScript1 : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    // Start is called before the first frame update
    [SerializeField]
    RectTransform lever;
    [SerializeField]
    Transform player;
    private RectTransform rectTransform;
    float range;
    Vector3 pos;
    Vector3 pos_normalized;
    void Start()
    {
        rectTransform = gameObject.GetComponent<RectTransform>();
        range = rectTransform.rect.width * 1.2f;
    }

    // Update is called once per frame
    void Update()
    {
        player.position += new Vector3(pos_normalized.x*2, 0, pos_normalized.y *2) * 5 * Time.deltaTime;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        pos = new Vector3(eventData.position.x - (rectTransform.position.x), eventData.position.y - (rectTransform.position.y), 0);
        pos = Vector3.ClampMagnitude(pos, range);
        lever.localPosition = pos;
    }

    public void OnDrag(PointerEventData eventData)
    {
        pos = new Vector3(eventData.position.x - (rectTransform.position.x), eventData.position.y - (rectTransform.position.y), 0);
        pos = Vector3.ClampMagnitude(pos, range);
        lever.localPosition = pos;
        pos_normalized = pos.normalized;
 
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        lever.localPosition = Vector2.zero;
    }

}
