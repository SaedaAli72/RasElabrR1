using Demo.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Demo
{
    public class Test
    {
        //public Decimal CalculateBonus(Employee Emp)
        //{
        //    if(Emp.Position == "Manager")
        //    {
        //        return Emp.Salary * .20m;
        //    }else if(Emp.Position == "Hr")
        //        return  return Emp.Salary * .15m;

        //    return  Emp.Salary * .10m;

        //}


        //List<Emp> emps = new List<Emp>()
        //{
        //    new FullTimeEmp()
        //    new tempemp()
        //};

        //{
        //calculateBonus()
        //}


       

       
        
    }
    public interface IEmp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

       
    }
// public interface IBonus
//{
//    Decemal CaculateBonus();
//}

//    public class TemporaryEmployee : Emp
//    {
//        public override decimal CalculateBonus()
//        {
//        throw new NotImplementedException("");
//        }
//    }


    public interface IBonusStrategy
    {
        decimal Calcultae(decimal Salary);
    }

    public class RegularEmployeeBonus : IBonusStrategy
    {
        public decimal Calcultae(decimal Salary)
        {
            throw new NotImplementedException();
        }
    }
    public class MangerEmployeeBonus : IBonusStrategy
    {
        public decimal Calcultae(decimal Salary)
        {
            throw new NotImplementedException();
        }
    }

}
