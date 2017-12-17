using System.Collections;
using System.Collections.Generic;

public class Help {
    static private Help instance;

    static public Help getInstance()
    {
        if(instance == null)
        {
            instance = new Help();
            instance.Init();
        }
        return instance;
    }

    private Dictionary<int, string> cardid2prefab;
    public void Init()
    {
        cardid2prefab = new Dictionary<int, string>();
        
        cardid2prefab[3 << 8 + 1] = "big_cards/diamond_3";
        cardid2prefab[3 << 8 + 2] = "big_cards/heart_3";
        cardid2prefab[3 << 8 + 3] = "big_cards/club_3";
        cardid2prefab[3 << 8 + 4] = "big_cards/diamond_3";


        cardid2prefab[4 << 8 + 1] = "big_cards/diamond_4";
        cardid2prefab[4 << 8 + 2] = "big_cards/heart_4";
        cardid2prefab[4 << 8 + 3] = "big_cards/club_4";
        cardid2prefab[4 << 8 + 4] = "big_cards/diamond_4";

        cardid2prefab[5 << 8 + 1] = "big_cards/diamond_5";
        cardid2prefab[5 << 8 + 2] = "big_cards/heart_5";
        cardid2prefab[5 << 8 + 3] = "big_cards/club_5";
        cardid2prefab[5 << 8 + 4] = "big_cards/diamond_5";

        cardid2prefab[6 << 8 + 1] = "big_cards/diamond_6";
        cardid2prefab[6 << 8 + 2] = "big_cards/heart_6";
        cardid2prefab[6 << 8 + 3] = "big_cards/club_6";
        cardid2prefab[6 << 8 + 4] = "big_cards/diamond_6";


        cardid2prefab[7 << 8 + 1] = "big_cards/diamond_7";
        cardid2prefab[7 << 8 + 2] = "big_cards/heart_7";
        cardid2prefab[7 << 8 + 3] = "big_cards/club_7";
        cardid2prefab[7 << 8 + 4] = "big_cards/diamond_7";


        cardid2prefab[8 << 8 + 1] = "big_cards/diamond_8";
        cardid2prefab[8 << 8 + 2] = "big_cards/heart_8";
        cardid2prefab[8 << 8 + 3] = "big_cards/club_8";
        cardid2prefab[8 << 8 + 4] = "big_cards/diamond_8";

        cardid2prefab[9 << 8 + 1] = "big_cards/diamond_9";
        cardid2prefab[9 << 8 + 2] = "big_cards/heart_9";
        cardid2prefab[9 << 8 + 3] = "big_cards/club_9";
        cardid2prefab[9 << 8 + 4] = "big_cards/diamond_9";

        cardid2prefab[10 << 8 + 1] = "big_cards/diamond_10";
        cardid2prefab[10 << 8 + 2] = "big_cards/heart_10";
        cardid2prefab[10 << 8 + 3] = "big_cards/club_10";
        cardid2prefab[10 << 8 + 4] = "big_cards/diamond_10";
        // J
        cardid2prefab[11 << 8 + 1] = "big_cards/diamond_J";
        cardid2prefab[11 << 8 + 2] = "big_cards/heart_J";
        cardid2prefab[11 << 8 + 3] = "big_cards/club_J";
        cardid2prefab[11 << 8 + 4] = "big_cards/diamond_J";
        // Q
        cardid2prefab[12 << 8 + 1] = "big_cards/diamond_Q";
        cardid2prefab[12 << 8 + 2] = "big_cards/heart_Q";
        cardid2prefab[12 << 8 + 3] = "big_cards/club_Q";
        cardid2prefab[12 << 8 + 4] = "big_cards/diamond_Q";
        // K
        cardid2prefab[13 << 8 + 1] = "big_cards/diamond_K";
        cardid2prefab[13 << 8 + 2] = "big_cards/heart_K";
        cardid2prefab[13 << 8 + 3] = "big_cards/club_K";
        cardid2prefab[13 << 8 + 4] = "big_cards/diamond_K";
        // A
        cardid2prefab[14 << 8 + 1] = "big_cards/diamond_A";
        cardid2prefab[14 << 8 + 2] = "big_cards/heart_A";
        cardid2prefab[14 << 8 + 3] = "big_cards/club_A";
        cardid2prefab[14 << 8 + 4] = "big_cards/diamond_A";
        // 2
        cardid2prefab[16 << 8 + 1] = "big_cards/diamond_2";
        cardid2prefab[16 << 8 + 2] = "big_cards/heart_2";
        cardid2prefab[16 << 8 + 3] = "big_cards/club_2";
        cardid2prefab[16 << 8 + 4] = "big_cards/diamond_2";
        // 小王、大王
        cardid2prefab[18 << 8 + 1] = "big_cards/black_Joker";
        cardid2prefab[20 << 8 + 2] = "big_cards/red_Joker";
    }

    public string getPrefabById(int id)
    {
        return cardid2prefab[id];
    }
}
