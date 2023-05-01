using System;
class ExportDicc{

    public string  exportDictionaryInString(string letter, string number) 
    {
        string exportBothDictionaries = "";
        string letterToExportableString = letter.Replace("{", " ").Replace("}"," ").Replace("\r\n", "\n").Replace('\r', '\n').Replace('\n',' ').Replace(" ", "");

        string numberToExportableString = number.Replace("{", " ").Replace("}"," ").Replace("\r\n", "\n").Replace('\r', '\n').Replace('\n',' ').Replace(" ", "");
        string[] exportableStringLetter = letterToExportableString.Split("");
        string[] exportableStringNumber = numberToExportableString.Split(" ");
        for (int i = 0; i < exportableStringLetter.Length; i++){
            exportBothDictionaries += exportableStringLetter[i];
            exportBothDictionaries += exportBothDictionaries.Last() + ",";
        }
        
        for (int i = 0; i < exportableStringNumber.Length; i++){
            exportBothDictionaries += exportableStringNumber[i];
        }
        Console.WriteLine(exportBothDictionaries);
        return letterToExportableString;
        
    }
}
