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
            Console.Clear();
            Console.Write("Digite a placa do veículo para estacionar: ");

            var placaVeiculoEstacionar = Console.ReadLine();

            veiculos.Add(placaVeiculoEstacionar.ToUpper());
        }

        public void RemoverVeiculo()
        {
            Console.Clear();

            string placa = "";

            Console.Write("Digite a placa do veículo para remover: ");
            var placaVeiculoRemoverEstacionamento = Console.ReadLine();

            placa = placaVeiculoRemoverEstacionamento;

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.Clear();

                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");

                int horas = Convert.ToInt32(Console.ReadLine()); ;
                decimal valorTotal = 0;

                valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.Clear();
                Console.WriteLine("Os veículos estacionados são:\n");

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo.ToUpper());
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
