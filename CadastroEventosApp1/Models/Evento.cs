using System;


namespace CadastroEventosApp1.Models
{

    public class Evento
    {
       
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime DataTermino { get; set; } = DateTime.Now.AddDays(1); 
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public double CustoPorParticipante { get; set; }


        public int DuracaoEmDias
        {
            get
            {
                // Calcula a diferença entre as datas
                TimeSpan duracao = DataTermino.Date - DataInicio.Date;

                // Retorna o total de dias. Se for o mesmo dia, retorna 0.
                return duracao.Days;
            }
        }

        // 2. Lógica que calcula o custo total do evento
        public double CustoTotal
        {
            get
            {
                // Cálculo simples baseado nos dados de entrada.
                return NumeroParticipantes * CustoPorParticipante;
            }
        }
    }
}