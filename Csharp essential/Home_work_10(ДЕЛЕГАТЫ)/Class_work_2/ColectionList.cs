using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_work_2
{
    class ColectionList<T>
    {
        private T[] data;
        public ColectionList()
        {
            data = new T[0];
        }

        public void Add(T item)
        {
            int arrLength = data.Length;

            Array.Resize(ref data, arrLength + 1);

            data[arrLength] = item;
        }
        //удаляем первое вхождение элемента при его наличии
        public void Remove(T item)
        {
            int index = -1;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }


            if (index > -1)
            {
                T[] newData = new T[data.Length - 1];

                int j = 0;

                for (int i = 0; i < data.Length; i++)
                {
                    if (i == index)
                    {
                        continue;
                    }
                    newData[j] = data[i];
                    j++;
                }
                data = newData;
            }
        }

        public T GetItemByIndex(int index)
        {
            if (index >= 0 && index < data.Length)
            {
                return data[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public int ListLength()
        {
            return data.Length;
        }

    }
}
