using UnityEngine.EventSystems;

/**
 * 如果脚本继承了以下几种接口，则统一用这个替换
 * 这个只支持 Awake Start Update LateUpdate
 *
 */

public class JSComponent_EventTrigger : JSComponent,
    IEventSystemHandler,
    IPointerEnterHandler,
    IPointerExitHandler,
    IPointerDownHandler,
    IPointerUpHandler,
    IPointerClickHandler,
    IBeginDragHandler,
    IInitializePotentialDragHandler,
    IDragHandler,
    IEndDragHandler,
    IDropHandler,
    IScrollHandler,
    IUpdateSelectedHandler,
    ISelectHandler,
    IDeselectHandler,
    IMoveHandler,
    ISubmitHandler,
    ICancelHandler
{
    int idUpdate;
    int idLateUpdate;

    int idOnBeginDrag;
    int idOnCancel;
    int idOnDeselect;
    int idOnDrag;
    int idOnDrop;
    int idOnEndDrag;
    int idOnInitializePotentialDrag;
    int idOnMove;
    int idOnPointerClick;
    int idOnPointerDown;
    int idOnPointerEnter;
    int idOnPointerExit;
    int idOnPointerUp;
    int idOnScroll;
    int idOnSelect;
    int idOnSubmit;
    int idOnUpdateSelected;

    protected override void InitMemberFunction()
    {
        base.InitMemberFunction();
        idUpdate = JSApi.getObjFunction(JsObjID, "Update");
        idLateUpdate = JSApi.getObjFunction(JsObjID, "LateUpdate");

        idOnBeginDrag = JSApi.getObjFunction(JsObjID, "OnBeginDrag");
        idOnCancel = JSApi.getObjFunction(JsObjID, "OnCancel");
        idOnDeselect = JSApi.getObjFunction(JsObjID, "OnDeselect");
        idOnDrag = JSApi.getObjFunction(JsObjID, "OnDrag");
        idOnDrop = JSApi.getObjFunction(JsObjID, "OnDrop");
        idOnEndDrag = JSApi.getObjFunction(JsObjID, "OnEndDrag");
        idOnInitializePotentialDrag = JSApi.getObjFunction(JsObjID, "OnInitializePotentialDrag");
        idOnMove = JSApi.getObjFunction(JsObjID, "OnMove");
        idOnPointerClick = JSApi.getObjFunction(JsObjID, "OnPointerClick");
        idOnPointerDown = JSApi.getObjFunction(JsObjID, "OnPointerDown");
        idOnPointerEnter = JSApi.getObjFunction(JsObjID, "OnPointerEnter");
        idOnPointerExit = JSApi.getObjFunction(JsObjID, "OnPointerExit");
        idOnPointerUp = JSApi.getObjFunction(JsObjID, "OnPointerUp");
        idOnScroll = JSApi.getObjFunction(JsObjID, "OnScroll");
        idOnSelect = JSApi.getObjFunction(JsObjID, "OnSelect");
        idOnSubmit = JSApi.getObjFunction(JsObjID, "OnSubmit");
        idOnUpdateSelected = JSApi.getObjFunction(JsObjID, "OnUpdateSelected");
    }
    void Update()
    {
        CallIfExist(idUpdate);
    }
    void LateUpdate()
    {
        CallIfExist(idLateUpdate);
    }
    public virtual void OnBeginDrag(PointerEventData eventData)
    {
		CallIfExist(idOnBeginDrag, eventData);
    }
    public virtual void OnCancel(BaseEventData eventData)
    {
		CallIfExist(idOnCancel, eventData);
    }
    public virtual void OnDeselect(BaseEventData eventData)
    {
		CallIfExist(idOnDeselect, eventData);
    }
    public virtual void OnDrag(PointerEventData eventData)
    {
		CallIfExist(idOnDrag, eventData);
    }
    public virtual void OnDrop(PointerEventData eventData)
    {
		CallIfExist(idOnDrop, eventData);
    }
    public virtual void OnEndDrag(PointerEventData eventData)
    {
		CallIfExist(idOnEndDrag, eventData);
    }
    public virtual void OnInitializePotentialDrag(PointerEventData eventData)
    {
		CallIfExist(idOnInitializePotentialDrag, eventData);
    }
    public virtual void OnMove(AxisEventData eventData)
    {
		CallIfExist(idOnMove, eventData);
    }
    public virtual void OnPointerClick(PointerEventData eventData)
    {
		CallIfExist(idOnPointerClick, eventData);
    }
    public virtual void OnPointerDown(PointerEventData eventData)
    {
		CallIfExist(idOnPointerDown, eventData);
    }
    public virtual void OnPointerEnter(PointerEventData eventData)
    {
		CallIfExist(idOnPointerEnter, eventData);
    }
    public virtual void OnPointerExit(PointerEventData eventData)
    {
		CallIfExist(idOnPointerExit, eventData);
    }
    public virtual void OnPointerUp(PointerEventData eventData)
    {
        CallIfExist(idOnPointerUp, eventData);
    }
    public virtual void OnScroll(PointerEventData eventData)
    {
		CallIfExist(idOnScroll, eventData);
    }
    public virtual void OnSelect(BaseEventData eventData)
    {
		CallIfExist(idOnSelect, eventData);
    }
    public virtual void OnSubmit(BaseEventData eventData)
    {
		CallIfExist(idOnSubmit, eventData);
    }
    public virtual void OnUpdateSelected(BaseEventData eventData)
    {
		CallIfExist(idOnUpdateSelected, eventData);
    }
}
