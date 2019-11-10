using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_11
{
    class Dictionary2<TKey, TValue1, TValue2>
    {
        private TKey[] key;
        private TValue1[] value1;
        private TValue2[] value2;

        public Dictionary2()
        {
            key = new TKey[0];
            value1 = new TValue1[0];
            value2 = new TValue2[0];
        }

        public int Lenght
        {
            get
            {
                return key.Length;
            }
        }

        //Метод добавления записи в словарь
        public void Add(TKey key, TValue1 value1, TValue2 value2)
        {
            int arrLength = this.key.Length;

            Array.Resize(ref this.key, arrLength + 1);
            Array.Resize(ref this.value1, arrLength + 1);
            Array.Resize(ref this.value2, arrLength + 1);

            this.key[arrLength] = key;
            this.value1[arrLength] = value1;
            this.value2[arrLength] = value2;
        }

        public dynamic GetTranslation(TKey key, int translationIndex = 1)
        {
            for (int i = 0; i < this.key.Length; i++)
            {
                if (this.key[i].Equals(key))
                {
                    if (translationIndex == 2)
                    {
                        return this.value2[translationIndex];
                    }
                    else
                    {
                        return this.value1[translationIndex];
                    }
                }
            }
            return "No translation";
        }

        public void RemoveTranslation(TKey key)
        {
            int index = -1;

            for (int i = 0; i < this.key.Length; i++)
            {
                if (this.key[i].Equals(key))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                TKey[] keyNew = new TKey[0];
                TValue1[] value1New = new TValue1[0];
                TValue2[] value2New = new TValue2[0];

                for (int i = 0; i < this.key.Length; i++)
                {
                    if (i != index)
                    {
                        int arrLength = keyNew.Length;

                        Array.Resize(ref keyNew, arrLength + 1);
                        Array.Resize(ref value1New, arrLength + 1);
                        Array.Resize(ref value2New, arrLength + 1);

                        keyNew[arrLength] = this.key[i];
                        value1New[arrLength] = this.value1[i];
                        value2New[arrLength] = this.value2[i];
                    }
                }

                this.key = keyNew;
                value1 = value1New;
                value2 = value2New;
            }

        }

        public void Clear()
        {
            key = new TKey[0];
            value1 = new TValue1[0];
            value2 = new TValue2[0];
        }
    }


}

