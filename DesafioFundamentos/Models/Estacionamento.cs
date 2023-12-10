namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine($"A placa '{placa}' já existe no sistema. Por favor, insira uma placa diferente.");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine($"Veículo com a placa '{placa}' adicionado com sucesso!");
            }
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                decimal valorTotal = 0; 
                
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                string inputHoras = Console.ReadLine();
                horas = int.Parse(inputHoras);
                
                valorTotal = precoInicial + precoPorHora * horas; 

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
               
                for (int i = 0; i < veiculos.Count; i++)
                {
                    string texto = $"Nº {i + 1} - Placa: {veiculos[i]}";
                    Console.WriteLine(texto);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void EncontrarVeiculo()
        {
             Console.WriteLine("Digite a placa do seu veiculo: ");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine($"Encontramos seu veículo: {placa}");
            }
            else
            {
                Console.WriteLine($"Este veículo com a placa {placa} não foi encontrado.");
            }
        }
    }
}
