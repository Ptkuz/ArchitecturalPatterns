using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderLibrary
{
    public class PC
    {


        public CPU Processor { get; set; }
        public GPU Videocard { get; set; }
        public Motherboard Motherboard { get; set; }
        public List<RAM> RAMS { get; set; }

       

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($"Компьютер содержит следующие комплектующие: \n " +
                $"Процессор - {Processor.Performance} {Processor.Model} Частота {Processor.Frequency} Мгц Количество ядер {Processor.NumberCores} \n" +
                $"Видеокарта - {Videocard.Performance} {Videocard.Model} Объем памяти: {Videocard.Memory} \n" +
                $"Материнская плата - {Motherboard.Performance} {Motherboard.Model} форм-фактор: {Motherboard.Size} Чипсет: {Motherboard.Chipset} \n");

            foreach (RAM ram in RAMS) 
            {
                stringBuilder.Append($"Оперативная память - {ram.Performance} {ram.Model} Объем плашки: {ram.Size} частотой {ram.Frequency} Мгц \n");
            
            }

            return stringBuilder.ToString();
        
        
        }
    }
}
