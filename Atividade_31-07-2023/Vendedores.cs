namespace Atividade_31_07_2023;

public class Vendedores
{
    private Vendedor[] osVendedores;
    private int max;
    private int qtde;

    public int Max { 
        get => max; 
    }
    public int Qtde {
        get => qtde; 
    }

    internal Vendedor[] OsVendedores
    {
        get => osVendedores;
    }

    public Vendedores(int max)
    {
        this.max = max;
        this.qtde = 0;
        this.osVendedores = new Vendedor[this.max];
        for(int i= 0; i < this.max; i++)
        {
            this.osVendedores[i] = new Vendedor(-1, "...", 0);
        }
    }


    public bool addVendedor(Vendedor v)
    {
        bool podeAdicionar = (this.qtde < this.max);
        if (podeAdicionar)
        {
            this.osVendedores[this.qtde++] = v;
        }
        return podeAdicionar;
    }
    
    public bool delVendedor(Vendedor v)
    {
        bool podeRemover;
        bool naoPodeRemover = false;
        int i = 0;
        while (i < this.max && !this.osVendedores[i].Equals(v))
        {
            i++;
        }
        podeRemover = (i < this.max);
        
        if (podeRemover)
        {
            foreach(Venda venda in this.osVendedores[i].AsVendas)
            {
                if ( venda != null)
                {
                    naoPodeRemover = true;
                }
            }

            if (!naoPodeRemover)
            {
                while (i < this.max-1)
                {
                    this.osVendedores[i] = this.osVendedores[i+1];
                    i++;
                }
                this.osVendedores[i] = new Vendedor(-1, "...", 0);
                this.qtde--;
            }
            
            
        }
        return (!naoPodeRemover);
    }

    public override string ToString()
    {
        string s = "";
        foreach(Vendedor v in this.osVendedores)
        {
            if (v.Id != -1)
            {
                s += "\n Id: " + v.Id  + "\n Nome: " +  v.Nome + "\n    Valor vendas: " + v.ValorVendas() + "\n    Valor comissão: " + v.valorComissao() ;
            }
        }
        return s;
    }
}