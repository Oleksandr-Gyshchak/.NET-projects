using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_5
{
    class Dictionary
    {
        private string[] key = null;
        private string[] value = null;

        public Dictionary()
        {
            key = new string[4];
            value = new string[4];

            key[0] = "Привет";
            value[0] = "Hi";

            key[1] = "Досведание";
            value[1] = "Goodbye";

            key[2] = "Зима";
            value[2] = "Winter";

            key[3] = "Лето";
            value[3] = "Summer";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i].ToLower() == index.ToLower())
                    {
                        return key[i] + " - " + value[i];
                    }
                }
                return $"{index} - no translation yet";
            }

            set
            {
                int wordIndex = -1;

                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i].ToLower() == index.ToLower())
                    {
                        wordIndex = i;
                        break;
                    }
                }

                if (wordIndex != -1)
                {
                    key[wordIndex] = value;
                }
                else
                {
                    int arrLength = key.Length;
                    Array.Resize(ref key, arrLength + 1);
                    Array.Resize(ref this.value, arrLength + 1);

                    key[arrLength] = index;
                    this.value[arrLength] = value;
                }
            }


        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                {
                    return key[index] + " - " + value[index];
                }
                else
                {
                    return "Invalid index";
                }
            }

            set
            {
                if (index >= 0 && index < key.Length)
                {
                    this.value[index] = value;
                }
                else
                {
                    string[] dictionaryWords = value.Split(new char[] { ',' });

                    Array.Resize(ref key, index + 1);
                    Array.Resize(ref this.value, index + 1);

                    if (dictionaryWords.Length == 2)
                    {
                        key[index] = dictionaryWords[0];
                        this.value[index] = dictionaryWords[1];
                    }
                    else
                    {
                        key[key.Length - 1] = value;
                        this.value[this.value.Length - 1] = "No translation yet";
                    }
                }
            }
        }

    }
}
