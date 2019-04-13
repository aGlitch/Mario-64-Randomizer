using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mario64Randomizer.Helpers
{
    public class n64Text
    {
        static public List<string> GetStrings(byte[] bytes)
        {
            List<string> strings = new List<string>();
            string text = "";
            checked
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    byte b = bytes[i];
                    if (b <= 158)
                    {
                        switch (b)
                        {
                            case 0:
                                text += "0";
                                break;
                            case 1:
                                text += "1";
                                break;
                            case 2:
                                text += "2";
                                break;
                            case 3:
                                text += "3";
                                break;
                            case 4:
                                text += "4";
                                break;
                            case 5:
                                text += "5";
                                break;
                            case 6:
                                text += "6";
                                break;
                            case 7:
                                text += "7";
                                break;
                            case 8:
                                text += "8";
                                break;
                            case 9:
                                text += "9";
                                break;
                            case 10:
                                text += "A";
                                break;
                            case 11:
                                text += "B";
                                break;
                            case 12:
                                text += "C";
                                break;
                            case 13:
                                text += "D";
                                break;
                            case 14:
                                text += "E";
                                break;
                            case 15:
                                text += "F";
                                break;
                            case 16:
                                text += "G";
                                break;
                            case 17:
                                text += "H";
                                break;
                            case 18:
                                text += "I";
                                break;
                            case 19:
                                text += "J";
                                break;
                            case 20:
                                text += "K";
                                break;
                            case 21:
                                text += "L";
                                break;
                            case 22:
                                text += "M";
                                break;
                            case 23:
                                text += "N";
                                break;
                            case 24:
                                text += "O";
                                break;
                            case 25:
                                text += "P";
                                break;
                            case 26:
                                text += "Q";
                                break;
                            case 27:
                                text += "R";
                                break;
                            case 28:
                                text += "S";
                                break;
                            case 29:
                                text += "T";
                                break;
                            case 30:
                                text += "U";
                                break;
                            case 31:
                                text += "V";
                                break;
                            case 32:
                                text += "W";
                                break;
                            case 33:
                                text += "X";
                                break;
                            case 34:
                                text += "Y";
                                break;
                            case 35:
                                text += "Z";
                                break;
                            case 36:
                                text += "a";
                                break;
                            case 37:
                                text += "b";
                                break;
                            case 38:
                                text += "c";
                                break;
                            case 39:
                                text += "d";
                                break;
                            case 40:
                                text += "e";
                                break;
                            case 41:
                                text += "f";
                                break;
                            case 42:
                                text += "g";
                                break;
                            case 43:
                                text += "h";
                                break;
                            case 44:
                                text += "i";
                                break;
                            case 45:
                                text += "j";
                                break;
                            case 46:
                                text += "k";
                                break;
                            case 47:
                                text += "l";
                                break;
                            case 48:
                                text += "m";
                                break;
                            case 49:
                                text += "n";
                                break;
                            case 50:
                                text += "o";
                                break;
                            case 51:
                                text += "p";
                                break;
                            case 52:
                                text += "q";
                                break;
                            case 53:
                                text += "r";
                                break;
                            case 54:
                                text += "s";
                                break;
                            case 55:
                                text += "t";
                                break;
                            case 56:
                                text += "u";
                                break;
                            case 57:
                                text += "v";
                                break;
                            case 58:
                                text += "w";
                                break;
                            case 59:
                                text += "x";
                                break;
                            case 60:
                                text += "y";
                                break;
                            case 61:
                                text += "z";
                                break;
                            case 62:
                                text += "'";
                                break;
                            case 63:
                                text += ".";
                                break;
                            case 64:
                            case 65:
                            case 66:
                            case 67:
                            case 68:
                            case 69:
                            case 70:
                            case 71:
                            case 72:
                            case 73:
                            case 74:
                            case 75:
                            case 76:
                            case 77:
                            case 78:
                            case 79:
                            case 89:
                            case 90:
                            case 91:
                            case 92:
                            case 93:
                            case 94:
                            case 95:
                            case 96:
                            case 97:
                            case 98:
                            case 99:
                            case 100:
                            case 101:
                            case 102:
                            case 103:
                            case 104:
                            case 105:
                            case 106:
                            case 107:
                            case 108:
                            case 109:
                            case 110:
                                break;
                            case 80:
                                text += "↑";
                                break;
                            case 81:
                                text += "↓";
                                break;
                            case 82:
                                text += "←";
                                break;
                            case 83:
                                text += "→";
                                break;
                            case 84:
                                text += "[A]";
                                break;
                            case 85:
                                text += "[B]";
                                break;
                            case 86:
                                text += "[C]";
                                break;
                            case 87:
                                text += "[Z]";
                                break;
                            case 88:
                                text += "[R]";
                                break;
                            case 111:
                                text += ",";
                                break;
                            default:
                                if (b == 158)
                                {
                                    text += " ";
                                }
                                break;
                        }
                    }
                    else if (b != 159)
                    {
                        switch (b)
                        {
                            case 208:
                                text += "/";
                                break;
                            case 209:
                                text += "the";
                                break;
                            case 210:
                                text += "you";
                                break;
                            default:
                                switch (b)
                                {
                                    case 224:
                                        text += "{starsleft}";
                                        break;
                                    case 225:
                                        text += "(";
                                        break;
                                    case 226:
                                        text += ")(";
                                        break;
                                    case 227:
                                        text += ")";
                                        break;
                                    case 228:
                                        text += "+";
                                        break;
                                    case 229:
                                        text += "&";
                                        break;
                                    case 230:
                                        text += ":";
                                        break;
                                    case 242:
                                        text += "!";
                                        break;
                                    case 244:
                                        text += "?";
                                        break;
                                    case 245:
                                        text += "\"";
                                        break;
                                    case 246:
                                        text += "\"";
                                        break;
                                    case 247:
                                        text += "~";
                                        break;
                                    case 249:
                                        text += "$";
                                        break;
                                    case 250:
                                        text += "★";
                                        break;
                                    case 251:
                                        text += "[x]";
                                        break;
                                    case 252:
                                        text += "•";
                                        break;
                                    case 253:
                                        text += "☆";
                                        break;
                                    case 254:
                                        text += "\r\n";
                                        break;
                                    case 255:
                                        strings.Add(text);
                                        text = "";
                                        break;
                                }
                                break;
                        }
                    }
                    else
                    {
                        text += "-";
                    }
                }
                return strings;
            }
        }
    }
}
