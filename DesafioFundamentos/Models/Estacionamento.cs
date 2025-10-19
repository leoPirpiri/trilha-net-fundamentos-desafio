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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(placa) && placa.Length == 8)
            {
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Veículo já está estacionado.");
                }
                else
                {
                    veiculos.Add(placa);
                    Console.WriteLine($"Veículo com placa {placa} adicionado ao estacionamento.");
                }
            }
            else
            {
                Console.WriteLine("Placa inválida. Tente novamente! (ex: ABC-1234)");
            }
        }

        public void RemoverVeiculo()
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("O estacionamento está vazio, não há carros para serem removidos.");
                return;
            }
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(placa) && placa.Length == 8)
            {
                // Verifica se o veículo existe
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                    // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
                    if (int.TryParse(Console.ReadLine(), out int horas))
                    {
                        decimal valorTotal = precoInicial + (precoPorHora * horas);

                        // Remover a placa digitada da lista de veículos
                        veiculos.RemoveAll(x => x.ToUpper() == placa.ToUpper());

                        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:0.00}");
                    }
                    else
                    {
                        Console.WriteLine("Número de horas inválido. Tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui.");
                }
            }
            else
            {
                Console.WriteLine("Placa inválida. Tente novamente! (ex: ABC-1234)");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
