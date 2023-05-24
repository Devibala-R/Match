using UnityEngine;
using UnityEngine.EventSystems;
public class Drop : MonoBehaviour,IDropHandler
{
    public static int count;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData != null)
        {
            Debug.Log(gameObject.transform.position);
            Debug.Log(eventData.position);
            if (gameObject.CompareTag (eventData.pointerDrag.tag))
            {
              
                Debug.Log(gameObject.name);
                Debug.Log(eventData.pointerDrag.name);
                // pointerdrag  object position= this script game object position
                eventData.pointerDrag.GetComponent<RectTransform>().position = GetComponent<RectTransform>().position;

                Debug.Log(eventData.pointerDrag.GetComponent<RectTransform>().position);
                Debug.Log(GetComponent<RectTransform>().position);
               LevelManager.LevelCount++;
               
                if (LevelManager.LevelCount == 4)
                {
                    LevelManager.NextsceneCall();

                }
              
            }
            else
            {
                Debug.Log("Not ok");
                eventData.pointerDrag.GetComponent<RectTransform>().position = Draggable.OriginalPosition;
                
            }
            
        }

    }
}
