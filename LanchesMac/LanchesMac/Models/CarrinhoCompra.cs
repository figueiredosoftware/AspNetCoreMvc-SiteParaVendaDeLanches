using LanchesMac.Context;

namespace LanchesMac.Models
{
    public class CarrinhoCompra
    {
        private readonly AppDbContext _context;

        public CarrinhoCompra(AppDbContext context)
        {
            _context = context;
        }

        public string CarrinhoCompraId { get; set; }
        public List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public static CarrinhoCompra GetCarrinho(IServiceProvider services) 
        {
            //define uma sessão. Se a instância de IHttpContextAccessor não for null ele vai evocar a session com HttpContext.Session 
            //e retornar alocndo na variável session, para isso usamos o operador ? (?=elvis)
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //obtem um serviço do tipo do nosso contexto
            var context = services.GetService<AppDbContext>();

            //obtem ou gera o Id do carrinho usando o operados de coalescencia nula  ??, ou seja, vou tentar pegar um carrinho da sessin com
            //session.GetString("CarrinhoId") e se for nulo eu atribuo um novo Guid com Guid.NewGuid().ToString();
            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            //atribui o id do carrinho na Sessão, se ja existe sobrepõe se não existe põe
            session.SetString("CarrinhoId", carrinhoId);

            //retorna o carrinho com o contexto e o Id atribuido ou obtido
            return new CarrinhoCompra(context)
            {
                CarrinhoCompraId = carrinhoId
            };
        }

        public void AdicionarAoCarrinho(Lanche lanche)
        {
            //tentar obter o lanche que entro via parâmetro na tabela CarrinhoCompraItens, se existe popula carrinhoCompraItem 
            //senão move null para carrinhoCompraItem
            var carrinhoCompraItem = _context.CarrinhoCompraItens.FirstOrDefault(
                s => s.Lanche.LancheId == lanche.LancheId &&
                s.CarrinhoCompraId == CarrinhoCompraId);

            //Verifica se esse lanche para este CarrinhoCompraId ja existe. Se não existe inclui na tabela CarrinhoCompraItens 
            //senão altera
            if (carrinhoCompraItem == null)
            {
                //CarrinhoCompraId = CarrinhoCompraId o primeiro CarrinhoCompraId é da instancia e o segundo é propriedade desta classe
                carrinhoCompraItem = new CarrinhoCompraItem
                {
                    CarrinhoCompraId = CarrinhoCompraId,
                    Lanche = lanche,
                    Quantidade = 1
                };
                _context.CarrinhoCompraItens.Add(carrinhoCompraItem);
            }
            else
            {
                carrinhoCompraItem.Quantidade++;
                _context.SaveChanges();
            }
        }
    }
}
