using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStickScript : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    // Start is called before the first frame update
    [SerializeField]
    RectTransform lever;
    [SerializeField]
    Transform player;
    private RectTransform rectTransform;
    float range;
    Vector3 pos;
    void Start()
    {
        rectTransform = gameObject.GetComponent<RectTransform>();
        range = rectTransform.rect.width * 1.2f;
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
        player.eulerAngles = new Vector3((eventData.position.y - (rectTransform.position.y))/3, 0, (-(eventData.position.x - (rectTransform.position.x)))/3);
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        lever.localPosition = Vector2.zero;
    }
}
