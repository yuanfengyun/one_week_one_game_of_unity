using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCards : MonoBehaviour {
    private GameObject handCards;
    private Dictionary<int, GameObject> card2Obj;
    private List<int> cards;

    // Use this for initialization
    public void Start() {
        handCards = GameObject.Find("HandCards_1");
        card2Obj = new Dictionary<int, GameObject>();
        cards = new List<int>();


        for (int i = 14; i >= 3; i--)
        {
            addCard(i<<8 + 1);
        }
        
    }

    public void addCard(int card)
    {
        string prefab_name = Help.getInstance().getPrefabById(card);
        Debug.Log(prefab_name + " " + card);
        GameObject prefab = Resources.Load(prefab_name, typeof(GameObject)) as GameObject;
        GameObject instance = Instantiate(prefab) as GameObject;
        instance.transform.SetParent(handCards.transform);

        card2Obj[card] = instance;
        cards.Insert(0, card);
        cards.Sort();
        cards.Reverse();
        updateCards();
    }

    public void removeCard(int card)
    {
        var obj = card2Obj[card];
        Destroy(obj);
        cards.Remove(card);
        card2Obj.Remove(card);
        updateCards();
    }

    public void updateCards()
    {
        float start_x = -cards.Count/ 2 * 30-50;
        for (int i = 0; i < cards.Count; i++)
        {
            var obj = card2Obj[cards[i]];
            obj.transform.localPosition = new Vector3(start_x + i*40, -150);
        }
    }

    private int c = 0;
    public void Update()
    {
        c = c + 1;

        if (c == 120)
        {
            removeCard(3 << 8 + 1);
            removeCard(4 << 8 + 1);
            removeCard(5 << 8 + 1);
            removeCard(6 << 8 + 1);
        }
    }
}
