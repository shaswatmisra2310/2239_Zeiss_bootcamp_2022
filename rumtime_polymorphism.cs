namespace Myproject
{

    class FinancialCalc
    {
        int principle;
        int interest_rate;
        int years;
        
        public void FinancialCalc(int p,int r, inr y)
        {
        this.principle=p;
        this.interest_rate=r;
        this.years=y;
        }
        
        public virtual calcinterest()
        {
        }
    }
    
    class SimpleInterest:FinancialCalc
    {
    public override calcinterest()
    {
     Console.WriteLine(principle*interest_rate*years);
    }
    }
    class CompoundInterest:FinancialCalc
    {
    public override calcinterest()
    {
     Console.WriteLine(principle*((1+interest_rate)^years-1));
    }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        FinancialCalc newUserFinance = new FinanceCalc[2];
        newUserFinance[0]=new SimpleInterest(20,0.01,2);
        newUserFinance[1]=new ComoundInterest(20,0.01,4);
        foreach(FinanceCalc f in newUserFinance)
            f.calcinterest();
        }
    }

}
