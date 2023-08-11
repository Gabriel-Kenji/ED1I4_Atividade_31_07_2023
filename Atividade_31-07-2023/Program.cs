using Atividade_31_07_2023;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace projMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*vendedor.RegistrarVenda(1, venda);
            vendedor.RegistrarVenda(30, venda);*/
            Vendedor vendedor2 = new Vendedor(1,"ab", 10);
            /*Console.WriteLine(vendedor.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(vendedor.ValorVendas());
            Console.WriteLine("\n");
            Console.WriteLine(vendedor.valorComissao());*/

            Vendedores vendedores = new Vendedores(10);
            

            /*Console.WriteLine(vendedores.addVendedor(vendedor));
            Console.WriteLine(vendedores.addVendedor(vendedor2));

            
            Console.WriteLine((vendedores.ToString()));
            
            Console.WriteLine(vendedores.delVendedor(vendedor));
            Console.WriteLine(vendedores.delVendedor(vendedor2));*/
            
            Console.WriteLine(vendedores.addVendedor(vendedor2));
            
            int num = 100;
            
            while (num > 0)
            {
                int id;
                string name;
                float comis;
                Vendedor vend = new Vendedor();
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("                 0 - Sair");
                Console.WriteLine("                 1 - Cadastrar vendedor");
                Console.WriteLine("                 2 - Consultar vendedor");
                Console.WriteLine("                 3 - Excluir vendedor");
                Console.WriteLine("                 4 - Registrar venda");
                Console.WriteLine("                 5 - Listar vendedores");
                Console.WriteLine("-------------------------------------------------------------");
                Console.Write("Digite uma opção desejada: ");
                num = Int32.Parse( Console.ReadLine());
                switch (num)
                {
                    case 0:
                        Console.WriteLine("SAINDO...");
                        break;
                    case 1:
                        Console.Write("Digite o nome do vendedor: ");
                        name = Console.ReadLine();
                        Console.Write("Digite o porcentagem da comissão do vendedor: ");
                        comis = float.Parse(Console.ReadLine());
                        Console.Write("Digite o codigo do vendedor: ");
                        id = Int32.Parse(Console.ReadLine());
                        Vendedor vendedor = new Vendedor( id, name, comis);
                        vendedores.addVendedor(vendedor);
                        Console.WriteLine((vendedores.ToString()));
                        break;
                    case 2:
                        Console.Write("Digite o id do vendedor: ");
                        id = Int32.Parse(Console.ReadLine());
                        foreach (Vendedor ven in vendedores.OsVendedores)
                        {
                            if(ven.Id == id)
                                Console.WriteLine(ven.ToString());
                        }
                        break;
                    case 3:
                        Console.Write("Digite o id do vendedor: ");
                        id = Int32.Parse(Console.ReadLine());
                        foreach (Vendedor ven in vendedores.OsVendedores)
                        {
                            if (ven.Id == id)
                            {
                                if (vendedores.delVendedor(ven))
                                    Console.WriteLine("Removido com sucesso");
                                else
                                    Console.WriteLine("Não foi possivel remover");
                                
                                
                                    
                                break;
                            }
                        }

                        
                        break;
                    case 4:
                        int dia, qtd;
                        float valor;
                        Console.Write("Digite o id do vendedor: ");
                        id = Int32.Parse(Console.ReadLine());
                        
                        foreach (Vendedor ven in vendedores.OsVendedores)
                        {
                            if (ven.Id == id)
                            {
                                vend = ven;
                                break;
                            }
                        }
                        Console.Write("Digite o dia da venda:");
                        dia = Int32.Parse(Console.ReadLine());
                        Console.Write("Digite o quantidade da venda:");
                        qtd = Int32.Parse(Console.ReadLine());
                        Console.Write("Digite o valor da venda:");
                        valor = float.Parse(Console.ReadLine());
                        Venda venda = new Venda(qtd, valor);
                        vend.RegistrarVenda(dia,venda);
                        Console.WriteLine("Venda registrada com sucesso!!");
                        break;
                    case 5:
                        Console.WriteLine(vendedores.ToString());
                        break;
                }
            }
        }
    }
}