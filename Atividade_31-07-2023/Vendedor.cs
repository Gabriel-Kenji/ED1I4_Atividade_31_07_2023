namespace Atividade_31_07_2023;

public class Vendedor
{
    private int _id;
    private string _nome;
    private double _percComissao;
    private Venda[] _asVendas;


    public Vendedor(int id, string nome, double percComissao)
    {
        _id = id;
        _nome = nome;
        _percComissao = percComissao;
        _asVendas = new Venda[31];
    }
    
    public Vendedor()
    {
        
    }

    internal int Id
    {
        get => _id;
    }

    internal string Nome
    {
        get => _nome;
        set => _nome = value;
    }

    internal double PercComissao
    {
        get => _percComissao;
        set => _percComissao = value;
    }

    internal Venda[] AsVendas
    {
        get => _asVendas;
    }

    public void RegistrarVenda(int dia, Venda venda)
    {
        this.AsVendas[dia] = venda;
    }

    public double ValorVendas()
    {
        double valor = 0;
        foreach(Venda venda in this.AsVendas)
        {
            if ( venda != null)
            {
                valor += venda.Valor;
            }
        } 

        return valor;
    }
    
    public double valorComissao()
    {
        double valor = 0;
        foreach(Venda venda in this.AsVendas)
        {
            if ( venda != null)
            {
                valor += venda.Valor;
            }
        } 

        return (valor/100) * this._percComissao; 
    }
        

    public override string ToString()
    {
        string vendas = "";
        foreach(var venda  in this.AsVendas.Select((value, key) => (value,key)) )
        {
            if (venda.value != null)
            {
                vendas += "\n    Dia:" + venda.key +"     Valor Medio: " + venda.value.ValorMedio();
            }
            
        }
        return "\n Id: " + this._id  + "\n Nome: " +  this._nome + "\n Valor vendas: " + this.ValorVendas() + "\n Valor comissão: " + this.valorComissao() + "\n VALOR MEDIO DIARIO: " + vendas;
    }
    
    public override bool Equals(object obj)
    {
        return this.Id.Equals((((Vendedor)obj)).Id);
    }
}