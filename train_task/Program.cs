//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?'
text = "— Я думаю, — сказал князь, улыбаясь, — что,";

string Replace(string text, char oldValue, char newValue);
        {
            string result = string.Empty;
            int length = text.Length;
            for (int i = 0; i < length; i++)
            {
                if (text[i] == oldValue) result = result + $"{newValue}";
                else result = result + $"{text[i]}";
            }
            return result;
        }  
string newText = Replace(text, ' ', '|');
