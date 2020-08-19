using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class GetStripInformations
    {
        /// <summary> Получение рандомных позиций сегментов </summary>
        /// <param name="count"> Целочисленное количество рандомных сегментов</param>
        public IList<SegmentDto> GetRandomList(int count)
        {
            IList<SegmentDto> list = null;

            if (count <= 0)
                throw new Exception("Количество меньше одного");
            else
            {
                Random rand = new Random();
                int temp = rand.Next(0, 200);

                for (int i =  0; i < count; i++)
                {
                    int randEnd = rand.Next(temp+50, 250);
                    list.Add(new SegmentDto(temp, randEnd));
                    temp += rand.Next(randEnd, randEnd + 200);
                }
            }

            return list;
        }
    }
}
