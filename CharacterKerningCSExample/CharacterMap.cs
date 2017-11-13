using System.Collections.Generic;

namespace CharacterKerningCSExample
{
    public static class CharacterMap
    {
        private static List<string> CHAR00 = new List<string> {
        "11111111",	//; $00 (00)
		"11111111",
        "11111111",
        "11111111",
        "11111111",
        "11111111",
        "11111111",
};

        private static List<string> CHAR04 = new List<string> {
		"11111001",	// ; $30 (48)
		"11110110",
        "11110110",
        "11110110",
        "11110110",
        "11110110",
        "11111001",

};


        private static List<string> CHAR24 = new List<string> {
//private static   List<string> CHAR2 =  new List<string> {
		"11111001",	// ; $32 (50)
		"11110110",
        "11111110",
        "11111101",
        "11111011",
        "11110111",
        "11110000",

};

        private static List<string> CHAR34 = new List<string> {
//private static   List<string> CHAR3 =  new List<string> {
		"11111001",	// ; $33 (51)
		"11110110",
        "11111110",
        "11111001",
        "11111110",
        "11110110",
        "11111001",

};

        private static List<string> CHAR44 = new List<string> {
//private static   List<string> CHAR4 =  new List<string> {
		"11111101",	// ; $34 (52)
		"11111001",
        "11110101",
        "11110101",
        "11110000",
        "11111101",
        "11111101",

};

        private static List<string> CHAR54 = new List<string> {
//private static   List<string> CHAR5 =  new List<string> {
		"11110000",	// ; $35 (53)
		"11110111",
        "11110001",
        "11111110",
        "11111110",
        "11110110",
        "11111001",

};

        private static List<string> CHAR64 = new List<string> {
//private static   List<string> CHAR6 =  new List<string> {
		"11111001",	// ; $36 (54)
		"11110110",
        "11110111",
        "11110001",
        "11110110",
        "11110110",
        "11111001",

};

        private static List<string> CHAR74 = new List<string> {
//private static   List<string> CHAR7 =  new List<string> {
		"11110000",	// ; $37 (55)
		"11111110",
        "11111110",
        "11111101",
        "11111011",
        "11110111",
        "11110111",

};

        private static List<string> CHAR84 = new List<string> {
//private static   List<string> CHAR8 =  new List<string> {
		"11111001",	// ; $38 (56)
		"11110110",
        "11110110",
        "11111001",
        "11110110",
        "11110110",
        "11111001",

};

        private static List<string> CHAR94 = new List<string> {
//private static   List<string> CHAR9 =  new List<string> {
		"1111001",	// ; $39 (57)
		"1110110",
        "1110110",
        "1111000",
        "1111110",
        "1110110",
        "1111001",

};


        private static List<string> CHARSPC = new List<string> {
//private static   List<string> CHARSPC =  new List<string> {
		"11111111",	// ; $20 (32)
		"11111111",
        "11111111",
        "11111111",
        "11111111",
        "11111111",
        "11111111",
};




        private static List<string> CHAR05 = new List<string> {
//private static   List<string> CHAR0 =  new List<string> {
		"11110001",	// ; $30 (48)
		"11101110",
        "11101110",
        "11101110",
        "11101110",
        "11101110",
        "11110001",

};

        private static List<string> CHAR1 = new List<string> {
//private static   List<string> CHAR1 =  new List<string> {
		"11111011",	// ; $31 (49)
		"11110011",
        "11111011",
        "11111011",
        "11111011",
        "11111011",
        "11110001",

};

        private static List<string> CHAR25 = new List<string> {
//private static   List<string> CHAR2 =  new List<string> {
		"11110001",	// ; $32 (50)
		"11101110",
        "11111110",
        "11111101",
        "11111011",
        "11110111",
        "11100000",

};

        private static List<string> CHAR35 = new List<string> {
//private static   List<string> CHAR3 =  new List<string> {
		"11110001",	// ; $33 (51)
		"11101110",
        "11111110",
        "11111001",
        "11111110",
        "11101110",
        "11110001",

};

        private static List<string> CHAR45 = new List<string> {
//private static   List<string> CHAR4 =  new List<string> {
		"11111101",	// ; $34 (52)
		"11111001",
        "11110101",
        "11101101",
        "11100000",
        "11111101",
        "11111101",

};

        private static List<string> CHAR55 = new List<string> {
//private static   List<string> CHAR5 =  new List<string> {
		"11100000",	// ; $35 (53)
		"11101111",
        "11100001",
        "11111110",
        "11111110",
        "11101110",
        "11110001",

};

        private static List<string> CHAR65 = new List<string> {
//private static   List<string> CHAR6 =  new List<string> {
		"11110001",	// ; $36 (54)
		"11101110",
        "11101111",
        "11100001",
        "11101110",
        "11101110",
        "11110001",

};

        private static List<string> CHAR75 = new List<string> {
//private static   List<string> CHAR7 =  new List<string> {
		"11100000",	// ; $37 (55)
		"11111110",
        "11111110",
        "11111101",
        "11111011",
        "11110111",
        "11101111",

};

        private static List<string> CHAR85 = new List<string> {
//private static   List<string> CHAR8 =  new List<string> {
		"11110001",	// ; $38 (56)
		"11101110",
        "11101110",
        "11110001",
        "11101110",
        "11101110",
        "11110001",

};

        private static List<string> CHAR95 = new List<string> {
//private static   List<string> CHAR9 =  new List<string> {
		"11110001",	// ; $39 (57)
		"11101110",
        "11101110",
        "11110000",
        "11111110",
        "11101110",
        "11110001",

};





        private static List<string> CHARA5 = new List<string> {
//private static   List<string> CHARA =  new List<string> {
		"11110001",	// ; $41 (65)
		"11101110",
        "11101110",
        "11100000",
        "11101110",
        "11101110",
        "11101110",

};

        private static List<string> CHARB5 = new List<string> {
//private static   List<string> CHARB =  new List<string> {
		"11100001",	// ; $42 (66)
		"11101110",
        "11101110",
        "11100001",
        "11101110",
        "11101110",
        "11100001",

};

        private static List<string> CHARC5 = new List<string> {
//private static   List<string> CHARC =  new List<string> {
		"11110001",       // ; $43 (67)
		"11101110",
        "11101111",
        "11101111",
        "11101111",
        "11101110",
        "11110001",

};

        private static List<string> CHARD5 = new List<string> {
//private static   List<string> CHARD =  new List<string> {
		"11100001",	// ; $44 (68)
		"11101110",
        "11101110",
        "11101110",
        "11101110",
        "11101110",
        "11100001",

};

        private static List<string> CHARE5 = new List<string> {
//private static   List<string> CHARE =  new List<string> {
		"11100000",	// ; $45 (69)
		"11101111",
        "11101111",
        "11100011",
        "11101111",
        "11101111",
        "11100000",

};

        private static List<string> CHARF5 = new List<string> {
//private static   List<string> CHARF =  new List<string> {
		"11100000",	// ; $46 (70)
		"11101111",
        "11101111",
        "11100011",
        "11101111",
        "11101111",
        "11101111",

};

        private static List<string> CHARG5 = new List<string> {
//private static   List<string> CHARG =  new List<string> {
		"11110001",	// ; $47 (71)
		"11101110",
        "11101111",
        "11101100",
        "11101110",
        "11101110",
        "11110001",

};

        private static List<string> CHARH5 = new List<string> {
//private static   List<string> CHARH =  new List<string> {
		"11101110",	// ; $48 (72)
		"11101110",
        "11101110",
        "11100000",
        "11101110",
        "11101110",
        "11101110",

};

        private static List<string> CHARI = new List<string> {
//private static   List<string> CHARI =  new List<string> {
		"11110001",	// ; $49 (73)
		"11111011",
        "11111011",
        "11111011",
        "11111011",
        "11111011",
        "11110001",

};

        private static List<string> CHARJ = new List<string> {
//private static   List<string> CHARJ =  new List<string> {
		"11111110",	// ; $4A (74)
		"11111110",
        "11111110",
        "11111110",
        "11111110",
        "11110110",
        "11111001",

};

        private static List<string> CHARK5 = new List<string> {
//private static   List<string> CHARK =  new List<string> {
		"11101110",	// ; $4B (75)
		"11101101",
        "11101011",
        "11100111",
        "11101011",
        "11101101",
        "11101110",

};

        private static List<string> CHARL5 = new List<string> {
//private static   List<string> CHARL =  new List<string> {
		"11101111",	// ; $4C (76)
		"11101111",
        "11101111",
        "11101111",
        "11101111",
        "11101111",
        "11100000",

};

        private static List<string> CHARM5 = new List<string> {
//private static   List<string> CHARM =  new List<string> {
		"11101110",	// ; $4D (77)
		"11100100",
        "11101010",
        "11101010",
        "11101110",
        "11101110",
        "11101110",

};

        private static List<string> CHARN5 = new List<string> {
//private static   List<string> CHARN =  new List<string> {
		"11101110",	// ; $4E (78)
		"11100110",
        "11100110",
        "11101010",
        "11101100",
        "11101100",
        "11101110",

};

        private static List<string> CHARO5 = new List<string> {
//private static   List<string> CHARO =  new List<string> {
		"11110001",	// ; $4F (79)
		"11101110",
        "11101110",
        "11101110",
        "11101110",
        "11101110",
        "11110001",

};

        private static List<string> CHARP5 = new List<string> {
//private static   List<string> CHARP =  new List<string> {
		"11100001",	// ; $50 (80)
		"11101110",
        "11101110",
        "11100001",
        "11101111",
        "11101111",
        "11101111",

};

        private static List<string> CHARQ5 = new List<string> {
//private static   List<string> CHARQ =  new List<string> {		
		"11110001",	// ; $51 (81)
		"11101110",
        "11101110",
        "11101110",
        "11101110",
        "11101101",
        "11110010",

};

        private static List<string> CHARR5 = new List<string> {
//private static   List<string> CHARR =  new List<string> {
		"11100001",	// ; $52 (82)
		"11101110",
        "11101110",
        "11100001",
        "11101011",
        "11101101",
        "11101110",

};

        private static List<string> CHARS5 = new List<string> {
//private static   List<string> CHARS =  new List<string> {
		"11110001",	// ; $53 (83)
		"11101110",
        "11101111",
        "11110001",
        "11111110",
        "11101110",
        "11110001",

};

        private static List<string> CHART5 = new List<string> {
//private static   List<string> CHART =  new List<string> {
		"11100000",	// ; $54 (84)
		"11111011",
        "11111011",
        "11111011",
        "11111011",
        "11111011",
        "11111011",

};

        private static List<string> CHARU5 = new List<string> {
//private static   List<string> CHARU =  new List<string> {
		"11101110",	// ; $55 (85)
		"11101110",
        "11101110",
        "11101110",
        "11101110",
        "11101110",
        "11110001",

};

        private static List<string> CHARV5 = new List<string> {
//private static   List<string> CHARV =  new List<string> {
		"11101110",	// ; $56 (86)
		"11101110",
        "11101110",
        "11101110",
        "11101110",
        "11110101",
        "11111011",

};

        private static List<string> CHARW5 = new List<string> {
//private static   List<string> CHARW =  new List<string> {
		"11101110",	// ; $57 (87)
		"11101110",
        "11101110",
        "11101110",
        "11101010",
        "11101010",
        "11110101",

};

        private static List<string> CHARX5 = new List<string> {
//private static   List<string> CHARX =  new List<string> {
		"11101110",	// ; $58 (88)
		"11101110",
        "11110101",
        "11111011",
        "11110101",
        "11101110",
        "11101110",

};

        private static List<string> CHARY5 = new List<string> {
//private static   List<string> CHARY =  new List<string> {
		"11101110",	// ; $59 (89)
		"11101110",
        "11101110",
        "11110101",
        "11111011",
        "11111011",
        "11111011",

};

        private static List<string> CHARZ5 = new List<string> {
//private static   List<string> CHARZ =  new List<string> {		
		"11100000",	// ; $5A (90)
		"11111110",
        "11111101",
        "11111011",
        "11110111",
        "11101111",
        "11100000",

};



        private static List<string> CHARA4 = new List<string> {
//private static   List<string> CHARA =  new List<string> {
		"11111001",	// ; $41 (65)
		"11110110",
        "11110110",
        "11110000",
        "11110110",
        "11110110",
        "11110110",

};

        private static List<string> CHARB4 = new List<string> {
//private static   List<string> CHARB =  new List<string> {
		"11110001",	// ; $42 (66)
		"11110110",
        "11110110",
        "11110001",
        "11110110",
        "11110110",
        "11110001",

};

        private static List<string> CHARC4 = new List<string> {
//private static   List<string> CHARC =  new List<string> {
		"11111001",       // ; $43 (67)
		"11110110",
        "11110111",
        "11110111",
        "11110111",
        "11110110",
        "11111001",

};

        private static List<string> CHARD4 = new List<string> {
//private static   List<string> CHARD =  new List<string> {
		"11110001",	// ; $44 (68)
		"11110110",
        "11110110",
        "11110110",
        "11110110",
        "11110110",
        "11110001",

};

        private static List<string> CHARE4 = new List<string> {
//private static   List<string> CHARE =  new List<string> {
		"11110000",	// ; $45 (69)
		"11110111",
        "11110111",
        "11110001",
        "11110111",
        "11110111",
        "11110000",

};

        private static List<string> CHARF4 = new List<string> {
//private static   List<string> CHARF =  new List<string> {
		"11110000",	// ; $46 (70)
		"11110111",
        "11110111",
        "11110001",
        "11110111",
        "11110111",
        "11110111",

};

        private static List<string> CHARG4 = new List<string> {
//private static   List<string> CHARG =  new List<string> {
		"11111001",	// ; $47 (71)
		"11110110",
        "11110111",
        "11110100",
        "11110110",
        "11110110",
        "11111001",

};

        private static List<string> CHARH4 = new List<string> {
//private static   List<string> CHARH =  new List<string> {
		"11110110",	// ; $48 (72)
		"11110110",
        "11110110",
        "11110000",
        "11110110",
        "11110110",
        "11110110",

};



        private static List<string> CHARL4 = new List<string> {
//private static   List<string> CHARL =  new List<string> {
		"11110111",	// ; $4C (76)
		"11110111",
        "11110111",
        "11110111",
        "11110111",
        "11110111",
        "11110000",

};



        private static List<string> CHARO4 = new List<string> {
//private static   List<string> CHARO =  new List<string> {
		"11111001",	// ; $4F (79)
		"11110110",
        "11110110",
        "11110110",
        "11110110",
        "11110110",
        "11111001",

};

        private static List<string> CHARP4 = new List<string> {
//private static   List<string> CHARP =  new List<string> {
		"11110001",	// ; $50 (80)
		"11110110",
        "11110110",
        "11110001",
        "11110111",
        "11110111",
        "11110111",

};

        private static List<string> CHARQ4 = new List<string> {
//private static   List<string> CHARQ =  new List<string> {		
		"11111001",	// ; $51 (81)
		"11110110",
        "11110110",
        "11110110",
        "11110110",
        "11110101",
        "11111010",

};

        private static List<string> CHARR4 = new List<string> {
		"11110001",	// ; $52 (82)
		"11110110",
        "11110110",
        "11110001",
        "11110011",
        "11110101",
        "11110110",

};

        private static List<string> CHARS4 = new List<string> {
		"11111001",	// ; $53 (83)
		"11110110",
        "11110111",
        "11111001",
        "11111110",
        "11110110",
        "11111001",

};



        private static List<string> CHARU4 = new List<string> {
		"11110110",	// ; $55 (85)
		"11110110",
        "11110110",
        "11110110",
        "11110110",
        "11110110",
        "11111001",

};



        private static List<string> CHARZ4 = new List<string> {
		"11110000",	// ; $5A (90)
		"11111110",
        "11111101",
        "11111011",
        "11110111",
        "11110111",
        "11110000",

};
        private static readonly List<List<string>> paletteList5Column = new List<List<string>>
        {
            CHAR05,
            CHAR1,
            CHAR25,
            CHAR35,
            CHAR45,
            CHAR55,
            CHAR65,
            CHAR75,
            CHAR85,
            CHAR95,
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            CHARA5,
            CHARB5,
            CHARC5,
            CHARD5,
            CHARE5,
            CHARF5,
            CHARG5,
            CHARH5,
            CHARI,
            CHARJ,
            CHARK5,
            CHARL5,
            CHARM5,
            CHARN5,
            CHARO5,
            CHARP5,
            CHARQ5,
            CHARR5,
            CHARS5,
            CHART5,
            CHARU5,
            CHARV5,
            CHARW5,
            CHARX5,
            CHARY5,
            CHARZ5
        };

        private static readonly List<List<string>> paletteList4Column = new List<List<string>>
        {
            CHAR04,
            CHAR1,
            CHAR24,
            CHAR34,
            CHAR44,
            CHAR54,
            CHAR64,
            CHAR74,
            CHAR84,
            CHAR94,
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            CHARA4,
            CHARB4,
            CHARC4,
            CHARD4,
            CHARE4,
            CHARF4,
            CHARG4,
            CHARH4,
            CHARI,
            CHARJ,
            null,
            CHARL4,
            null,
            null,
            CHARO4,
            CHARP4,
            CHARQ4,
            CHARR4,
            CHARS4,
            null,
            CHARU4,
            null,
            null,
            null,
            null,
            CHARZ5
        };

        public static List<List<string>> PaletteList5Column => paletteList5Column;
        public static List<List<string>> PaletteList4Column => paletteList4Column;
    }
}
