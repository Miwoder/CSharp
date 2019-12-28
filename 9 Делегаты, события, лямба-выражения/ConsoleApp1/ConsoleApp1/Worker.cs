using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Director
    {
        public delegate void DirectorSolution(string message);
        public event DirectorSolution RankUp;
        public event DirectorSolution Fine;
        public event DirectorSolution Solution;
        public event DirectorSolution Vvod;
        string strrr = "Vvod";
        public Director(int money)
        {
            Money = money;
        }
        public int Money { get; private set; }
        public void rankUp()
        { 
            Money += 200;
            RankUp?.Invoke($"Сотрудник повышен. Новая ЗП: {Money}");
        }
        public void fine()
        {
            Money -= 100;
            Fine?.Invoke($"Сотрудник оштрафован. ЗП уменьшена и составляет: {Money}");        }


        public void vvvod(string strrr)
        {
            if(strrr == null)
                {
                Vvod?.Invoke("Ввод пустой");
                Console.WriteLine();
            }
            else {
                Console.WriteLine(strrr);
                Vvod?.Invoke($"Вы ввели: {strrr}");
            }

        }
    }

}
