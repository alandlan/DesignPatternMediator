using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternMediator.Structural
{
    public class StructuralService : Execute, IProgram<StructuralService>
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Run()
        {
            var mediator = new ConcreteMediator();
            //var c1 = new Colleague1();
            //var c2 = new Colleague2();
            ////mediator.Colleague1 = c1;
            ////mediator.Colleague2 = c2;
            //mediator.Register(c1);
            //mediator.Register(c2);

            var c1 = mediator.CreateColleague<Colleague1>();
            var c2 = mediator.CreateColleague<Colleague2>();

            c1.Send("Hello, (from c1)");
            c2.Send("Hei, (from c2)");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
