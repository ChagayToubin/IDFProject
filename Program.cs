using Idf.attack_units;
using Idf.idf;
namespace Idf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            IdfMain a = new IdfMain("1948", "zamir");
            AttackUnits b = new AttackUnits("f16", 56);
            a.AddAttackUnit(b);
            foreach (var i in a.AtackUnits)
            {
                Console.WriteLine(i.TypeUnit);
                Console.WriteLine(i.FuelSupply);
                Console.WriteLine(i.MaximumArmaments);
                Console.WriteLine(i.CurrentAmmunitionQuantity);
                Console.WriteLine(i.AttacksAtSameTime);
                Console.WriteLine(i.PoweredBy);
            }    
        }
    }
}
