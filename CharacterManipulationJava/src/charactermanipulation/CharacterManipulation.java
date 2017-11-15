/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package charactermanipulation;

import java.awt.Color;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author dreaadmin
 */
public class CharacterManipulation {

    public static final String fiveColumnMapKey = "charfive";
    public static final String fourColumnMapKey = "charfour";

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        CharacterList charList = new CharacterList();
        while (true) {
            System.out.println("Please enter the characters to be displayed (Not more than 3 characters)");
            Scanner keyboard = new Scanner(System.in);
            String input = keyboard.nextLine();
            long startTime = System.currentTimeMillis();
            String[] inputArray = input.split("(?!^)");
            if (inputArray.length > 3) {
                break;
            }
            String searchFiveKey = fiveColumnMapKey;
            String searchFourKey = fourColumnMapKey;
            for (int a = 0; a < 7; a++) {
                int ln = 0;
                String palette = "";
                for (int i = 0; i < inputArray.length; i++) {
                    String concatFive = searchFiveKey.concat(inputArray[i].toUpperCase());
                    String concatFour = searchFourKey.concat(inputArray[i].toUpperCase());
                    List<String> charToUse = charList.getPaletteList4Column().get(concatFour);
                    if (null != charToUse) {
                        String layer = "";
                        switch (inputArray.length) {                            
                            case 3:
                                layer = charToUse.get(a).substring(4, 8);
                                break;
                            case 2:
                                layer = "1".concat(charToUse.get(a).substring(3, 8)).concat("1");
                                break;
                            default:
                                layer = "11".concat(charToUse.get(a)).concat("11111");
                                break;
                        }
                        palette = palette.concat(layer);
                    } else {
                        charToUse = charList.getPaletteList5Column().get(concatFive);
                        String layer = "";
                        switch (inputArray.length) {
                            case 3:
                                if (i == 0) {
                                    layer = charToUse.get(a).substring(3, 8);
                                } else if (i == 1) {
                                    layer = charToUse.get(a).substring(3, 8);
                                } else {
                                    layer = charToUse.get(a).substring(2, 8);
                                }
                                break;
                            case 2:
                                layer = "1".concat(charToUse.get(a).substring(2, 8)).concat("1");
                                break;
                            default:
                                layer = "111".concat(charToUse.get(a)).concat("1111");
                                break;
                        }
                        palette = palette.concat(layer);
                    }
                }
                ln = 16 - palette.length();
                for (int i = 0; i < ln; i++) {
                    if (ln % 2 == 0) {
                        palette = "1".concat(palette).concat("1");
                        i++;
                    } else {
                        palette = palette.concat("1");
                    }
                }
                System.out.println(palette.replace('0', 'X').replace('1', '_') + "   " + palette.length());
            }
            long endTime = System.currentTimeMillis();
            long duration = (endTime - startTime);
            System.out.println(duration +" Milliseconds");
        }
    }
}
